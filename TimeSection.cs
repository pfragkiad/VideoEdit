using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEdit;

public class TimeSection
{
    public const string TimeFormat = "hh\\:mm\\:ss\\.f";

    public static string[] TimeFormats = new string[]
    {
        "hh\\:mm\\:ss\\.f",
        "hh\\:mm\\:ss\\.",
        "hh\\:mm\\:ss",

        "h\\:mm\\:ss\\.f",
        "h\\:mm\\:ss\\.",
        "h\\:mm\\:ss",

        "mm\\:ss\\.f",
        "mm\\:ss",
        "ss\\.f",
        "ss",
    };

    public TimeSpan? From { get; set; }
    public TimeSpan? To { get; set; }

    //public static TimeSection Empty => new();

    public override string ToString()
    {
        string sFrom = From?.ToString(TimeFormat) ?? "";
        string sTo = To?.ToString(TimeFormat) ?? "";

        if (From is null && To is null) return "<Empty>";
        if (From is null) return $"<Start> - {sTo}";
        if (To is null) return $"{sFrom} - <End>";
        return $"{sFrom} - {sTo}";
    }

    public string ToFfmpegCommand(string inputFileName, int outputIndex)
    {
        string filenameWithoutExtension = Path.GetFileNameWithoutExtension(inputFileName);
        string outputFileName = $"{filenameWithoutExtension}_part{outputIndex}.mp4";

        StringBuilder stringBuilder = new("ffmpeg -i ");
        stringBuilder.Append(inputFileName);
        if (From is not null)
            stringBuilder.Append($" -ss {From.Value.ToString(TimeFormat)}");
        if (To is not null)
            stringBuilder.Append($" -to {To.Value.ToString(TimeFormat)}");

        stringBuilder.Append($" -c:v copy -c:a copy {outputFileName}");
        return stringBuilder.ToString();
    }


}
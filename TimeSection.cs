using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEdit;

public class TimeSection
{
    public const string TimeFormat = "hh\\:mm\\:ss\\.f";

    public static string[] TimeFormats =
    [
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
    ];

    public TimeSpan? From { get; set; }
    public TimeSpan? To { get; set; }

    public Rectangle? BlurSection { get; set; }

    //public static TimeSection Empty => new();

    public override string ToString()
    {
        string sFrom = From?.ToString(TimeFormat) ?? "";
        string sTo = To?.ToString(TimeFormat) ?? "";

        if (From is null && To is null) return "<Whole>";
        if (From is null) return $"<Start> - {sTo}";
        if (To is null) return $"{sFrom} - <End>";
        return $"{sFrom} - {sTo}";
    }

    public string ToFfmpegCommand(string inputFileName, int? outputIndex,
        string? postfix, Rectangle? cropSection = null)
    {

        string filenameWithoutExtension = Path.GetFileNameWithoutExtension(inputFileName);
        string extension = Path.GetExtension(inputFileName);

        bool isPart = outputIndex is not null;  
        string fullPostfix = isPart ? $"_part{outputIndex}{postfix}" : 
                (postfix is null ? "_merged" : postfix );
        string outputFileName = $"{filenameWithoutExtension}{fullPostfix}{extension}";

        StringBuilder stringBuilder = new($"ffmpeg -i \"{inputFileName}\" ");
        
        if (From is not null)
            stringBuilder.Append($" -ss {From.Value.ToString(TimeFormat)}");
        if (To is not null)
            stringBuilder.Append($" -to {To.Value.ToString(TimeFormat)}");

        //1030:712:113:27
        //"crop=out_w:out_h:x:y"
        string sVideo = "-c:v copy";
        if (cropSection.HasValue)
        {
            Rectangle r = cropSection.Value;
            sVideo = $" -vf \"crop={r.Width}:{r.Height}:{r.X}:{r.Y}\"";
        }
        else if (BlurSection.HasValue )
        {
            Rectangle r = BlurSection.Value;
            sVideo = $" -filter_complex \"[0:v]crop={r.Width}:{r.Height}:{r.X}:{r.Y},boxblur=10[mask];[0:v][mask]overlay={r.X}:{r.Y}[v]\" -map \"[v]\" -map 0:a";
        }

        stringBuilder.Append($" {sVideo} -c:a copy \"{outputFileName}\"");
        return stringBuilder.ToString();
    }


}
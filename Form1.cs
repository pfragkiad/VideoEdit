using System.Globalization;

namespace VideoEdit;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        ResetTimeSection();

    }

    TimeSection? _currentTimeSection;

    private void SelectCurrentTimeSection()
    {
        _currentTimeSection = lstTimeSections.SelectedItem as TimeSection;
        if (_currentTimeSection is null) return;

        txtFrom.Text = _currentTimeSection.From?.ToString(TimeSection.TimeFormat) ?? "";
        txtTo.Text = _currentTimeSection.To?.ToString(TimeSection.TimeFormat) ?? "";
        chkTimeTo.Checked = _currentTimeSection.To is not null;
        chkTimeFrom.Checked = _currentTimeSection.From is not null;

        btnUpdateTimeSection.Enabled = true;
        btnAddTimeSection.Enabled = false;
        btnDeleteTimeSection.Enabled = true;

        chkBlurSection.Checked = _currentTimeSection.BlurSection is not null;   
        if(_currentTimeSection.BlurSection is not null)
        {
            var r  = _currentTimeSection.BlurSection.Value;
            txtBlurTopX.Text = r.X.ToString();
            txtBlurTopY.Text = r.Y.ToString();
            chkBlurUseBottomRightPoint.Checked = true;
            txtBlurBottomXOrWidth.Text = (r.Right-1).ToString();
            txtBlurBottomYOrHeight.Text = (r.Bottom-1).ToString();
        }
        else
        {
            txtBlurTopX.Clear(); txtBlurTopY.Clear();
            txtBlurBottomXOrWidth.Clear(); txtBlurBottomYOrHeight.Clear();
            chkBlurUseBottomRightPoint.Checked = true;
        }

        btnMoveTimeSectionDown.Enabled = lstTimeSections.SelectedIndex < lstTimeSections.Items.Count - 1;
        btnMoveTimeSectionUp.Enabled = lstTimeSections.SelectedIndex > 0;
    }


    private void AddTimeSection()
    {
        string sFrom = txtFrom.Text.Trim();
        string sTo = txtTo.Text.Trim();

        //00:12:10
        bool fromParsed = TimeSpan.TryParseExact(sFrom, TimeSection.TimeFormats, CultureInfo.InvariantCulture, out var from);
        bool toParsed = TimeSpan.TryParseExact(sTo, TimeSection.TimeFormats, CultureInfo.InvariantCulture, out var to);

        TimeSection? newTimeSection = GetCurrentTimeSection();
        if (newTimeSection is null) return;


        //remove handler temporarily
        lstTimeSections.SelectedValueChanged -= lstTimeSections_SelectedValueChanged;
        //_sections.Add(newTimeSection);
        lstTimeSections.Items.Add(newTimeSection);
        lstTimeSections.SelectedItems.Clear();
        lstTimeSections.SelectedValueChanged += lstTimeSections_SelectedValueChanged;

        //reset based on previous value
        txtFrom.Clear(); chkTimeFrom.Checked = true;
        txtTo.Clear(); chkTimeTo.Checked = true;

        txtFrom.Focus();
    }

    private TimeSection? GetCurrentTimeSection()
    {
        string sFrom = txtFrom.Text.Trim();
        string sTo = txtTo.Text.Trim();

        //00:12:10
        bool fromParsed = TimeSpan.TryParseExact(sFrom, TimeSection.TimeFormats, CultureInfo.InvariantCulture, out var from);
        bool toParsed = TimeSpan.TryParseExact(sTo, TimeSection.TimeFormats, CultureInfo.InvariantCulture, out var to);

        if (!fromParsed && chkTimeFrom.Checked)
        {
            ShowError(sFrom + " is not a valid time");
            return null;
        }

        if (!toParsed && chkTimeTo.Checked)
        {
            ShowError(sTo + " is not a valid time");
            return null;
        }

        Rectangle? blurSection = GetBlurSection();

        return new TimeSection
        {
            From = fromParsed && chkTimeFrom.Checked ? from : null,
            To = toParsed && chkTimeTo.Checked ? to : null,
            BlurSection = blurSection
        };
    }


    private void UpdateCurrentTimeSection()
    {
        if (_currentTimeSection is null) return;

        _currentTimeSection = GetCurrentTimeSection();
        if (_currentTimeSection is null) return;

        lstTimeSections.Items[lstTimeSections.SelectedIndex] = _currentTimeSection;
    }

    private void ResetTimeSection()
    {
        txtFrom.Clear();
        txtTo.Clear();

        chkTimeFrom.Checked = true;
        chkTimeTo.Checked = true;

        btnAddTimeSection.Enabled = true;
        btnUpdateTimeSection.Enabled = false;
        btnDeleteTimeSection.Enabled = false;

        btnMoveTimeSectionDown.Enabled = false;
        btnMoveTimeSectionUp.Enabled = false;

        chkBlurSection.Checked = false;
        chkBlurUseBottomRightPoint.Checked = true;
        txtBlurTopX.Clear(); txtBlurTopY.Clear();
        txtBlurBottomXOrWidth.Clear(); txtBlurBottomYOrHeight.Clear();

        _currentTimeSection = null;
    }

    private void DeleteCurrentTimeSection()
    {
        if (_currentTimeSection is null) return;

        var reply = MessageBox.Show("Are you sure you want to delete this time section?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (reply != DialogResult.Yes) return;

        //_sections.Remove(_currentTimeSection);
        lstTimeSections.Items.Remove(_currentTimeSection);
        ResetTimeSection();
    }

    private void MoveCurrentTimeSectionUp()
    {
        if (_currentTimeSection is null) return;

        int currentLocation = lstTimeSections.SelectedIndex;
        if (currentLocation <= 0) return;

        //_sections.RemoveAt(currentLocation);
        //_sections.Insert(currentLocation - 1, _currentTimeSection);

        lstTimeSections.Items.RemoveAt(currentLocation);
        lstTimeSections.Items.Insert(currentLocation - 1, _currentTimeSection);
    }

    private void MoveCurrentTimeSectionDown()
    {
        if (_currentTimeSection is null) return;

        int currentLocation = lstTimeSections.SelectedIndex;
        if (currentLocation >= lstTimeSections.Items.Count - 1) return;

        //_sections.RemoveAt(currentLocation);
        //_sections.Insert(currentLocation + 1, _currentTimeSection);
        lstTimeSections.Items.RemoveAt(currentLocation);
        lstTimeSections.Items.Insert(currentLocation + 1, _currentTimeSection);
    }
    private Rectangle? GetCropSection()
    {
        if (!chkCropSection.Checked) return null;


        bool parsed;
        parsed = int.TryParse(txtTopX.Text, CultureInfo.InvariantCulture, out int topX);
        if (!parsed)
        {
            ShowError("Invalid Top X value");
            return null;
        }

        parsed = int.TryParse(txtTopY.Text, CultureInfo.InvariantCulture, out int topY);
        if (!parsed)
        {
            ShowError("Invalid Top Y value");
            return null;
        }

        parsed = int.TryParse(txtBottomXOrWidth.Text, CultureInfo.InvariantCulture, out int wOrX);
        if (!parsed)
        {
            ShowError("Invalid Bottom X or Width value");
            return null;
        }

        parsed = int.TryParse(txtBottomYOrHeight.Text, CultureInfo.InvariantCulture, out int hOrY);
        if (!parsed)
        {
            ShowError("Invalid Bottom Y or Height value");
            return null;
        }

        return new Rectangle
        {
            X = topX,
            Y = topY,
            Width = chkUseBottomRightPoint.Checked ? wOrX - topX + 1 : wOrX,
            Height = chkUseBottomRightPoint.Checked ? hOrY - topY + 1 : hOrY
        };
    }

    private Rectangle? GetBlurSection()
    {

        if (!chkBlurSection.Checked) return null;


        bool parsed;
        parsed = int.TryParse(txtBlurTopX.Text, CultureInfo.InvariantCulture, out int topX);
        if (!parsed)
        {
            ShowError("Invalid Top X value");
            return null;
        }

        parsed = int.TryParse(txtBlurTopY.Text, CultureInfo.InvariantCulture, out int topY);
        if (!parsed)
        {
            ShowError("Invalid Top Y value");
            return null;
        }

        parsed = int.TryParse(txtBlurBottomXOrWidth.Text, CultureInfo.InvariantCulture, out int wOrX);
        if (!parsed)
        {
            ShowError("Invalid Bottom X or Width value");
            return null;
        }

        parsed = int.TryParse(txtBlurBottomYOrHeight.Text, CultureInfo.InvariantCulture, out int hOrY);
        if (!parsed)
        {
            ShowError("Invalid Bottom Y or Height value");
            return null;
        }

        return new Rectangle
        {
            X = topX,
            Y = topY,
            Width = chkBlurUseBottomRightPoint.Checked ? wOrX - topX + 1 : wOrX,
            Height = chkBlurUseBottomRightPoint.Checked ? hOrY - topY + 1 : hOrY
        };



    }


    public void UpdateCommands()
    {
        txtCommands.Clear();

        var timeSections = lstTimeSections.Items.Cast<TimeSection>().ToList();
        if (timeSections.Count == 0) return;




        string inputFile = txtSourceFile.Text.Trim();
        bool isFileEmpty = string.IsNullOrWhiteSpace(inputFile);
        if (isFileEmpty)
        {
            inputFile = "<input>.mp4";
        }


        //ffmpeg -i v1.mp4 -ss 00:06:27 -to 00:46:35 -c:v copy -c:a copy v1_part1.mp4
        //ffmpeg -i v1.mp4 -ss 01:01:33 -c:v copy -c:a copy v1_part2.mp4
        //(echo file 'v1_part1.mp4' & echo file 'v1_part2.mp4') >list.txt
        //ffmpeg -safe 0 -f concat -i list.txt -c copy v1_m.mp4
        //del v1_part1.mp4 & del v1_part2.mp4

        if (timeSections.Count == 1)
        {
            //cropped section only works with one section
            Rectangle? cropSection = GetCropSection();
            txtCommands.AppendText($"{timeSections[0].ToFfmpegCommand(inputFile, null, cropSection)}\r\n");
            return;
        }


        for (int i = 0; i < timeSections.Count; i++)
        {
            var section = timeSections[i];
            txtCommands.AppendText($"{section.ToFfmpegCommand(inputFile, i + 1)}\r\n");
        }

        //write the echo command
        string echoCommand = string.Join(" & ", timeSections.Select((x, i) => $"echo file '{Path.GetFileNameWithoutExtension(inputFile)}__part{i + 1}.mp4'"));
        echoCommand = $"({echoCommand}) >list.txt";

        txtCommands.AppendText(echoCommand + "\r\n");

        //merge command
        string mergeCommand = $"ffmpeg -safe 0 -f concat -i list.txt -c copy \"{Path.GetFileNameWithoutExtension(inputFile)}__merged.mp4\"";
        txtCommands.AppendText(mergeCommand + "\r\n");

        //delete command 
        string deleteCommand = string.Join(" & ", timeSections.Select((x, i) => $"del \"{Path.GetFileNameWithoutExtension(inputFile)}__part{i + 1}.mp4\"")) + " & del list.txt";
        txtCommands.AppendText(deleteCommand + "\r\n");
    }


    #region Handlers

    private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
            txtTo.Focus();

    }

    private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)

            btnAddTimeSection_Click(sender, e);
    }

    private void btnAddTimeSection_Click(object sender, EventArgs e)
    {
        AddTimeSection();
    }


    private void btnResetTimeSection_Click(object sender, EventArgs e)
    {
        ResetTimeSection();
    }

    private void lstTimeSections_SelectedValueChanged(object? sender, EventArgs e)
    {
        SelectCurrentTimeSection();
    }

    private void lstTimeSections_Click(object sender, EventArgs e)
    {
        SelectCurrentTimeSection();

    }
    private void btnUpdateTimeSection_Click(object sender, EventArgs e)
    {
        UpdateCurrentTimeSection();
    }

    private void btnDeleteTimeSection_Click(object sender, EventArgs e)
    {
        DeleteCurrentTimeSection();
    }

    private void btnMoveTimeSectionUp_Click(object sender, EventArgs e)
    {
        MoveCurrentTimeSectionUp();

    }

    private void btnMoveTimeSectionDown_Click(object sender, EventArgs e)
    {
        MoveCurrentTimeSectionDown();
    }

    private void btnUpdateCommands_Click(object sender, EventArgs e)
    {
        UpdateCommands();
    }
    private void chkUseBottomRightPoint_CheckedChanged(object sender, EventArgs e)
    {
        lblBottomRightPointOrSize.Text = chkUseBottomRightPoint.Checked ? "Bottom Right Point: " : "Size (Width, Height):";
    }
    private void chkBlurUseBottomRightPoint_CheckedChanged(object sender, EventArgs e)
    {
        lblBlurBottomRightPointOrSize.Text = chkBlurUseBottomRightPoint.Checked ? "Bottom Right Point: " : "Size (Width, Height):";
    }

    #endregion

    #region Common
    public void ShowError(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void ShowInfo(string message)
    {
        MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public void ShowWarning(string message)
    {
        MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    #endregion


    private void btnClearTimeSections_Click(object sender, EventArgs e)
    {
        lstTimeSections.Items.Clear();
        ResetTimeSection();
    }
}
namespace VideoEdit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstTimeSections = new ListBox();
            btnClearTimeSections = new Button();
            txtFrom = new MaskedTextBox();
            txtTo = new MaskedTextBox();
            chkBlurUseBottomRightPoint = new CheckBox();
            chkTimeFrom = new CheckBox();
            lblBlurBottomRightPointOrSize = new Label();
            chkTimeTo = new CheckBox();
            label4 = new Label();
            txtBlurBottomYOrHeight = new TextBox();
            txtBlurBottomXOrWidth = new TextBox();
            txtBlurTopY = new TextBox();
            txtBlurTopX = new TextBox();
            btnDeleteTimeSection = new Button();
            btnUpdateTimeSection = new Button();
            btnMoveTimeSectionDown = new Button();
            btnMoveTimeSectionUp = new Button();
            btnNewTimeSection = new Button();
            btnAddTimeSection = new Button();
            txtSourceFile = new TextBox();
            label1 = new Label();
            txtCommands = new TextBox();
            label2 = new Label();
            btnUpdateCommands = new Button();
            groupBox2 = new GroupBox();
            chkCropSection = new CheckBox();
            chkUseBottomRightPoint = new CheckBox();
            lblBottomRightPointOrSize = new Label();
            label3 = new Label();
            txtBottomYOrHeight = new TextBox();
            txtBottomXOrWidth = new TextBox();
            txtTopY = new TextBox();
            txtTopX = new TextBox();
            tabControl1 = new TabControl();
            tabPreprocess = new TabPage();
            tabSections = new TabPage();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            txtPostfix = new TextBox();
            tabMerge = new TabPage();
            label7 = new Label();
            txtMergedOutputFile = new TextBox();
            label5 = new Label();
            txtListOfFilesToMerge = new TextBox();
            chkKeepExistingCommands = new CheckBox();
            cboRectangle = new ComboBox();
            label8 = new Label();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPreprocess.SuspendLayout();
            tabSections.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabMerge.SuspendLayout();
            SuspendLayout();
            // 
            // lstTimeSections
            // 
            lstTimeSections.FormattingEnabled = true;
            lstTimeSections.ItemHeight = 15;
            lstTimeSections.Location = new Point(49, 35);
            lstTimeSections.Name = "lstTimeSections";
            lstTimeSections.Size = new Size(137, 169);
            lstTimeSections.TabIndex = 0;
            lstTimeSections.Click += lstTimeSections_Click;
            lstTimeSections.SelectedIndexChanged += lstTimeSections_SelectedValueChanged;
            // 
            // btnClearTimeSections
            // 
            btnClearTimeSections.Location = new Point(49, 216);
            btnClearTimeSections.Name = "btnClearTimeSections";
            btnClearTimeSections.Size = new Size(75, 29);
            btnClearTimeSections.TabIndex = 2;
            btnClearTimeSections.Text = "Clear";
            btnClearTimeSections.UseVisualStyleBackColor = true;
            btnClearTimeSections.Click += btnClearTimeSections_Click;
            // 
            // txtFrom
            // 
            txtFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtFrom.InsertKeyMode = InsertKeyMode.Overwrite;
            txtFrom.Location = new Point(83, 47);
            txtFrom.Mask = "00:00:00.0";
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(95, 29);
            txtFrom.TabIndex = 3;
            txtFrom.TextAlign = HorizontalAlignment.Center;
            txtFrom.KeyPress += txtFrom_KeyPress;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtTo.InsertKeyMode = InsertKeyMode.Overwrite;
            txtTo.Location = new Point(83, 94);
            txtTo.Mask = "00:00:00.0";
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(95, 29);
            txtTo.TabIndex = 3;
            txtTo.Text = "0100000";
            txtTo.TextAlign = HorizontalAlignment.Center;
            txtTo.KeyPress += txtTo_KeyPress;
            // 
            // chkBlurUseBottomRightPoint
            // 
            chkBlurUseBottomRightPoint.AutoSize = true;
            chkBlurUseBottomRightPoint.Checked = true;
            chkBlurUseBottomRightPoint.CheckState = CheckState.Checked;
            chkBlurUseBottomRightPoint.Location = new Point(281, 36);
            chkBlurUseBottomRightPoint.Name = "chkBlurUseBottomRightPoint";
            chkBlurUseBottomRightPoint.Size = new Size(147, 19);
            chkBlurUseBottomRightPoint.TabIndex = 2;
            chkBlurUseBottomRightPoint.Text = "Use bottom right point";
            chkBlurUseBottomRightPoint.UseVisualStyleBackColor = true;
            chkBlurUseBottomRightPoint.CheckedChanged += chkBlurUseBottomRightPoint_CheckedChanged;
            // 
            // chkTimeFrom
            // 
            chkTimeFrom.AutoSize = true;
            chkTimeFrom.Location = new Point(17, 54);
            chkTimeFrom.Name = "chkTimeFrom";
            chkTimeFrom.Size = new Size(60, 19);
            chkTimeFrom.TabIndex = 4;
            chkTimeFrom.Text = "From: ";
            chkTimeFrom.UseVisualStyleBackColor = true;
            // 
            // lblBlurBottomRightPointOrSize
            // 
            lblBlurBottomRightPointOrSize.AutoSize = true;
            lblBlurBottomRightPointOrSize.Location = new Point(281, 75);
            lblBlurBottomRightPointOrSize.Name = "lblBlurBottomRightPointOrSize";
            lblBlurBottomRightPointOrSize.Size = new Size(109, 15);
            lblBlurBottomRightPointOrSize.TabIndex = 1;
            lblBlurBottomRightPointOrSize.Text = "Bottom right point:";
            // 
            // chkTimeTo
            // 
            chkTimeTo.AutoSize = true;
            chkTimeTo.Checked = true;
            chkTimeTo.CheckState = CheckState.Checked;
            chkTimeTo.Location = new Point(18, 101);
            chkTimeTo.Name = "chkTimeTo";
            chkTimeTo.Size = new Size(41, 19);
            chkTimeTo.TabIndex = 4;
            chkTimeTo.Text = "To:";
            chkTimeTo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 76);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 1;
            label4.Text = "Top left point:";
            // 
            // txtBlurBottomYOrHeight
            // 
            txtBlurBottomYOrHeight.Location = new Point(467, 72);
            txtBlurBottomYOrHeight.Name = "txtBlurBottomYOrHeight";
            txtBlurBottomYOrHeight.Size = new Size(56, 23);
            txtBlurBottomYOrHeight.TabIndex = 0;
            txtBlurBottomYOrHeight.Text = "768";
            txtBlurBottomYOrHeight.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBlurBottomXOrWidth
            // 
            txtBlurBottomXOrWidth.Location = new Point(405, 72);
            txtBlurBottomXOrWidth.Name = "txtBlurBottomXOrWidth";
            txtBlurBottomXOrWidth.Size = new Size(56, 23);
            txtBlurBottomXOrWidth.TabIndex = 0;
            txtBlurBottomXOrWidth.Text = "1024";
            txtBlurBottomXOrWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBlurTopY
            // 
            txtBlurTopY.Location = new Point(203, 72);
            txtBlurTopY.Name = "txtBlurTopY";
            txtBlurTopY.Size = new Size(56, 23);
            txtBlurTopY.TabIndex = 0;
            txtBlurTopY.Text = "32";
            txtBlurTopY.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBlurTopX
            // 
            txtBlurTopX.Location = new Point(141, 72);
            txtBlurTopX.Name = "txtBlurTopX";
            txtBlurTopX.Size = new Size(56, 23);
            txtBlurTopX.TabIndex = 0;
            txtBlurTopX.Text = "0";
            txtBlurTopX.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDeleteTimeSection
            // 
            btnDeleteTimeSection.Location = new Point(447, 216);
            btnDeleteTimeSection.Name = "btnDeleteTimeSection";
            btnDeleteTimeSection.Size = new Size(74, 29);
            btnDeleteTimeSection.TabIndex = 2;
            btnDeleteTimeSection.Text = "Delete";
            btnDeleteTimeSection.UseVisualStyleBackColor = true;
            btnDeleteTimeSection.Click += btnDeleteTimeSection_Click;
            // 
            // btnUpdateTimeSection
            // 
            btnUpdateTimeSection.Location = new Point(368, 216);
            btnUpdateTimeSection.Name = "btnUpdateTimeSection";
            btnUpdateTimeSection.Size = new Size(74, 29);
            btnUpdateTimeSection.TabIndex = 2;
            btnUpdateTimeSection.Text = "Update";
            btnUpdateTimeSection.UseVisualStyleBackColor = true;
            btnUpdateTimeSection.Click += btnUpdateTimeSection_Click;
            // 
            // btnMoveTimeSectionDown
            // 
            btnMoveTimeSectionDown.Location = new Point(17, 64);
            btnMoveTimeSectionDown.Name = "btnMoveTimeSectionDown";
            btnMoveTimeSectionDown.Size = new Size(26, 23);
            btnMoveTimeSectionDown.TabIndex = 2;
            btnMoveTimeSectionDown.Text = "v";
            btnMoveTimeSectionDown.UseVisualStyleBackColor = true;
            btnMoveTimeSectionDown.Click += btnMoveTimeSectionDown_Click;
            // 
            // btnMoveTimeSectionUp
            // 
            btnMoveTimeSectionUp.Location = new Point(17, 35);
            btnMoveTimeSectionUp.Name = "btnMoveTimeSectionUp";
            btnMoveTimeSectionUp.Size = new Size(26, 23);
            btnMoveTimeSectionUp.TabIndex = 2;
            btnMoveTimeSectionUp.Text = "^";
            btnMoveTimeSectionUp.UseVisualStyleBackColor = true;
            btnMoveTimeSectionUp.Click += btnMoveTimeSectionUp_Click;
            // 
            // btnNewTimeSection
            // 
            btnNewTimeSection.Location = new Point(210, 216);
            btnNewTimeSection.Name = "btnNewTimeSection";
            btnNewTimeSection.Size = new Size(74, 29);
            btnNewTimeSection.TabIndex = 2;
            btnNewTimeSection.Text = "New";
            btnNewTimeSection.UseVisualStyleBackColor = true;
            btnNewTimeSection.Click += btnNewTimeSection_Click;
            // 
            // btnAddTimeSection
            // 
            btnAddTimeSection.Location = new Point(289, 216);
            btnAddTimeSection.Name = "btnAddTimeSection";
            btnAddTimeSection.Size = new Size(74, 29);
            btnAddTimeSection.TabIndex = 2;
            btnAddTimeSection.Text = "Add";
            btnAddTimeSection.UseVisualStyleBackColor = true;
            btnAddTimeSection.Click += btnAddTimeSection_Click;
            // 
            // txtSourceFile
            // 
            txtSourceFile.Location = new Point(129, 29);
            txtSourceFile.Name = "txtSourceFile";
            txtSourceFile.Size = new Size(380, 23);
            txtSourceFile.TabIndex = 5;
            txtSourceFile.Text = "sample.mp4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 6;
            label1.Text = "Input video file:";
            // 
            // txtCommands
            // 
            txtCommands.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCommands.Location = new Point(29, 423);
            txtCommands.Multiline = true;
            txtCommands.Name = "txtCommands";
            txtCommands.ScrollBars = ScrollBars.Both;
            txtCommands.Size = new Size(1067, 243);
            txtCommands.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 386);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Commands:";
            // 
            // btnUpdateCommands
            // 
            btnUpdateCommands.Location = new Point(737, 377);
            btnUpdateCommands.Name = "btnUpdateCommands";
            btnUpdateCommands.Size = new Size(173, 34);
            btnUpdateCommands.TabIndex = 8;
            btnUpdateCommands.Text = "Update ffmpeg commands";
            btnUpdateCommands.UseVisualStyleBackColor = true;
            btnUpdateCommands.Click += btnUpdateCommands_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkCropSection);
            groupBox2.Controls.Add(chkUseBottomRightPoint);
            groupBox2.Controls.Add(lblBottomRightPointOrSize);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtBottomYOrHeight);
            groupBox2.Controls.Add(txtBottomXOrWidth);
            groupBox2.Controls.Add(txtTopY);
            groupBox2.Controls.Add(txtTopX);
            groupBox2.Location = new Point(26, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 246);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crop";
            // 
            // chkCropSection
            // 
            chkCropSection.ForeColor = Color.Blue;
            chkCropSection.Location = new Point(22, 41);
            chkCropSection.Name = "chkCropSection";
            chkCropSection.Size = new Size(242, 29);
            chkCropSection.TabIndex = 2;
            chkCropSection.Text = "Crop video size";
            chkCropSection.UseVisualStyleBackColor = false;
            // 
            // chkUseBottomRightPoint
            // 
            chkUseBottomRightPoint.AutoSize = true;
            chkUseBottomRightPoint.Checked = true;
            chkUseBottomRightPoint.CheckState = CheckState.Checked;
            chkUseBottomRightPoint.Location = new Point(22, 140);
            chkUseBottomRightPoint.Name = "chkUseBottomRightPoint";
            chkUseBottomRightPoint.Size = new Size(147, 19);
            chkUseBottomRightPoint.TabIndex = 2;
            chkUseBottomRightPoint.Text = "Use bottom right point";
            chkUseBottomRightPoint.UseVisualStyleBackColor = true;
            chkUseBottomRightPoint.CheckedChanged += chkUseBottomRightPoint_CheckedChanged;
            // 
            // lblBottomRightPointOrSize
            // 
            lblBottomRightPointOrSize.AutoSize = true;
            lblBottomRightPointOrSize.Location = new Point(22, 183);
            lblBottomRightPointOrSize.Name = "lblBottomRightPointOrSize";
            lblBottomRightPointOrSize.Size = new Size(109, 15);
            lblBottomRightPointOrSize.TabIndex = 1;
            lblBottomRightPointOrSize.Text = "Bottom right point:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 1;
            label3.Text = "Top left point:";
            // 
            // txtBottomYOrHeight
            // 
            txtBottomYOrHeight.Location = new Point(208, 180);
            txtBottomYOrHeight.Name = "txtBottomYOrHeight";
            txtBottomYOrHeight.Size = new Size(56, 23);
            txtBottomYOrHeight.TabIndex = 0;
            txtBottomYOrHeight.Text = "768";
            txtBottomYOrHeight.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBottomXOrWidth
            // 
            txtBottomXOrWidth.Location = new Point(146, 180);
            txtBottomXOrWidth.Name = "txtBottomXOrWidth";
            txtBottomXOrWidth.Size = new Size(56, 23);
            txtBottomXOrWidth.TabIndex = 0;
            txtBottomXOrWidth.Text = "1024";
            txtBottomXOrWidth.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTopY
            // 
            txtTopY.Location = new Point(208, 95);
            txtTopY.Name = "txtTopY";
            txtTopY.Size = new Size(56, 23);
            txtTopY.TabIndex = 0;
            txtTopY.Text = "32";
            txtTopY.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTopX
            // 
            txtTopX.Location = new Point(146, 95);
            txtTopX.Name = "txtTopX";
            txtTopX.Size = new Size(56, 23);
            txtTopX.TabIndex = 0;
            txtTopX.Text = "0";
            txtTopX.TextAlign = HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPreprocess);
            tabControl1.Controls.Add(tabSections);
            tabControl1.Controls.Add(tabMerge);
            tabControl1.Location = new Point(25, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 304);
            tabControl1.TabIndex = 11;
            // 
            // tabPreprocess
            // 
            tabPreprocess.Controls.Add(groupBox2);
            tabPreprocess.Location = new Point(4, 24);
            tabPreprocess.Name = "tabPreprocess";
            tabPreprocess.Padding = new Padding(3);
            tabPreprocess.Size = new Size(1063, 276);
            tabPreprocess.TabIndex = 0;
            tabPreprocess.Text = "Preprocess";
            tabPreprocess.UseVisualStyleBackColor = true;
            // 
            // tabSections
            // 
            tabSections.Controls.Add(groupBox1);
            tabSections.Controls.Add(btnMoveTimeSectionUp);
            tabSections.Controls.Add(btnClearTimeSections);
            tabSections.Controls.Add(btnAddTimeSection);
            tabSections.Controls.Add(btnNewTimeSection);
            tabSections.Controls.Add(label6);
            tabSections.Controls.Add(btnMoveTimeSectionDown);
            tabSections.Controls.Add(btnUpdateTimeSection);
            tabSections.Controls.Add(txtPostfix);
            tabSections.Controls.Add(btnDeleteTimeSection);
            tabSections.Controls.Add(lstTimeSections);
            tabSections.Location = new Point(4, 24);
            tabSections.Name = "tabSections";
            tabSections.Padding = new Padding(3);
            tabSections.Size = new Size(1063, 276);
            tabSections.TabIndex = 1;
            tabSections.Text = "Time sections";
            tabSections.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(chkTimeFrom);
            groupBox1.Controls.Add(txtTo);
            groupBox1.Controls.Add(txtFrom);
            groupBox1.Controls.Add(chkTimeTo);
            groupBox1.Location = new Point(210, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Time Section";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboRectangle);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lblBlurBottomRightPointOrSize);
            groupBox3.Controls.Add(txtBlurTopY);
            groupBox3.Controls.Add(txtBlurBottomYOrHeight);
            groupBox3.Controls.Add(txtBlurTopX);
            groupBox3.Controls.Add(chkBlurUseBottomRightPoint);
            groupBox3.Controls.Add(txtBlurBottomXOrWidth);
            groupBox3.Location = new Point(217, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(576, 128);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Blur/Cover";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(826, 223);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 6;
            label6.Text = "Output postfix:";
            // 
            // txtPostfix
            // 
            txtPostfix.Location = new Point(918, 220);
            txtPostfix.Name = "txtPostfix";
            txtPostfix.Size = new Size(105, 23);
            txtPostfix.TabIndex = 5;
            txtPostfix.Text = "__final";
            // 
            // tabMerge
            // 
            tabMerge.Controls.Add(label7);
            tabMerge.Controls.Add(txtMergedOutputFile);
            tabMerge.Controls.Add(label5);
            tabMerge.Controls.Add(txtListOfFilesToMerge);
            tabMerge.Location = new Point(4, 24);
            tabMerge.Name = "tabMerge";
            tabMerge.Size = new Size(1063, 276);
            tabMerge.TabIndex = 2;
            tabMerge.Text = "Merge";
            tabMerge.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(365, 24);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 10;
            label7.Text = "Output file:";
            // 
            // txtMergedOutputFile
            // 
            txtMergedOutputFile.Location = new Point(365, 53);
            txtMergedOutputFile.Name = "txtMergedOutputFile";
            txtMergedOutputFile.Size = new Size(171, 23);
            txtMergedOutputFile.TabIndex = 9;
            txtMergedOutputFile.Text = "output_merged.mp4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 24);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "List of files:";
            // 
            // txtListOfFilesToMerge
            // 
            txtListOfFilesToMerge.Location = new Point(21, 53);
            txtListOfFilesToMerge.Multiline = true;
            txtListOfFilesToMerge.Name = "txtListOfFilesToMerge";
            txtListOfFilesToMerge.ScrollBars = ScrollBars.Both;
            txtListOfFilesToMerge.Size = new Size(283, 202);
            txtListOfFilesToMerge.TabIndex = 7;
            // 
            // chkKeepExistingCommands
            // 
            chkKeepExistingCommands.AutoSize = true;
            chkKeepExistingCommands.Location = new Point(925, 386);
            chkKeepExistingCommands.Name = "chkKeepExistingCommands";
            chkKeepExistingCommands.Size = new Size(159, 19);
            chkKeepExistingCommands.TabIndex = 9;
            chkKeepExistingCommands.Text = "Keep existing commands";
            chkKeepExistingCommands.UseVisualStyleBackColor = true;
            // 
            // cboRectangle
            // 
            cboRectangle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRectangle.FormattingEnabled = true;
            cboRectangle.Items.AddRange(new object[] { "<None>", "Color fill", "Blur" });
            cboRectangle.Location = new Point(141, 32);
            cboRectangle.Name = "cboRectangle";
            cboRectangle.Size = new Size(118, 23);
            cboRectangle.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 33);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 1;
            label8.Text = "Rectangle type:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 678);
            Controls.Add(chkKeepExistingCommands);
            Controls.Add(btnUpdateCommands);
            Controls.Add(tabControl1);
            Controls.Add(txtCommands);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSourceFile);
            Name = "Form1";
            Text = "ffmpeg command builder";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPreprocess.ResumeLayout(false);
            tabSections.ResumeLayout(false);
            tabSections.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabMerge.ResumeLayout(false);
            tabMerge.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTimeSections;
        private Button btnClearTimeSections;
        private MaskedTextBox txtFrom;
        private MaskedTextBox txtTo;
        private Button btnDeleteTimeSection;
        private Button btnAddTimeSection;
        private CheckBox chkTimeFrom;
        private CheckBox chkTimeTo;
        private Button btnUpdateTimeSection;
        private Button btnNewTimeSection;
        private Button btnMoveTimeSectionDown;
        private Button btnMoveTimeSectionUp;
        private TextBox txtSourceFile;
        private Label label1;
        private TextBox txtCommands;
        private Label label2;
        private Button btnUpdateCommands;
        private GroupBox groupBox2;
        private TextBox txtTopY;
        private TextBox txtTopX;
        private Label label3;
        private CheckBox chkUseBottomRightPoint;
        private Label lblBottomRightPointOrSize;
        private TextBox txtBottomYOrHeight;
        private TextBox txtBottomXOrWidth;
        private CheckBox chkCropSection;
        private CheckBox chkBlurUseBottomRightPoint;
        private Label lblBlurBottomRightPointOrSize;
        private Label label4;
        private TextBox txtBlurBottomYOrHeight;
        private TextBox txtBlurBottomXOrWidth;
        private TextBox txtBlurTopY;
        private TextBox txtBlurTopX;
        private TabControl tabControl1;
        private TabPage tabPreprocess;
        private TabPage tabSections;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TabPage tabMerge;
        private TextBox txtListOfFilesToMerge;
        private Label label5;
        private Label label6;
        private TextBox txtPostfix;
        private CheckBox chkKeepExistingCommands;
        private Label label7;
        private TextBox txtMergedOutputFile;
        private ComboBox cboRectangle;
        private Label label8;
    }
}

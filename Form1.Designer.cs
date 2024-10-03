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
            groupBox1 = new GroupBox();
            chkTimeFrom = new CheckBox();
            chkTimeTo = new CheckBox();
            btnDeleteTimeSection = new Button();
            btnUpdateTimeSection = new Button();
            btnMoveTimeSectionDown = new Button();
            btnMoveTimeSectionUp = new Button();
            btnResetTimeSection = new Button();
            btnAddTimeSection = new Button();
            txtSourceFile = new TextBox();
            label1 = new Label();
            txtCommands = new TextBox();
            label2 = new Label();
            btnUpdateCommands = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstTimeSections
            // 
            lstTimeSections.FormattingEnabled = true;
            lstTimeSections.ItemHeight = 15;
            lstTimeSections.Location = new Point(59, 41);
            lstTimeSections.Name = "lstTimeSections";
            lstTimeSections.Size = new Size(137, 139);
            lstTimeSections.TabIndex = 0;
            lstTimeSections.Click += lstTimeSections_Click;
            lstTimeSections.SelectedIndexChanged += lstTimeSections_SelectedValueChanged;
            // 
            // btnClearTimeSections
            // 
            btnClearTimeSections.Location = new Point(59, 186);
            btnClearTimeSections.Name = "btnClearTimeSections";
            btnClearTimeSections.Size = new Size(75, 23);
            btnClearTimeSections.TabIndex = 2;
            btnClearTimeSections.Text = "Clear";
            btnClearTimeSections.UseVisualStyleBackColor = true;
            // 
            // txtFrom
            // 
            txtFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtFrom.InsertKeyMode = InsertKeyMode.Overwrite;
            txtFrom.Location = new Point(275, 41);
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
            txtTo.Location = new Point(275, 88);
            txtTo.Mask = "00:00:00.0";
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(95, 29);
            txtTo.TabIndex = 3;
            txtTo.Text = "0100000";
            txtTo.TextAlign = HorizontalAlignment.Center;
            txtTo.KeyPress += txtTo_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkTimeFrom);
            groupBox1.Controls.Add(chkTimeTo);
            groupBox1.Controls.Add(lstTimeSections);
            groupBox1.Controls.Add(txtTo);
            groupBox1.Controls.Add(txtFrom);
            groupBox1.Controls.Add(btnDeleteTimeSection);
            groupBox1.Controls.Add(btnUpdateTimeSection);
            groupBox1.Controls.Add(btnMoveTimeSectionDown);
            groupBox1.Controls.Add(btnMoveTimeSectionUp);
            groupBox1.Controls.Add(btnResetTimeSection);
            groupBox1.Controls.Add(btnAddTimeSection);
            groupBox1.Controls.Add(btnClearTimeSections);
            groupBox1.Location = new Point(25, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 227);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time sections";
            // 
            // chkTimeFrom
            // 
            chkTimeFrom.AutoSize = true;
            chkTimeFrom.Location = new Point(209, 48);
            chkTimeFrom.Name = "chkTimeFrom";
            chkTimeFrom.Size = new Size(60, 19);
            chkTimeFrom.TabIndex = 4;
            chkTimeFrom.Text = "From: ";
            chkTimeFrom.UseVisualStyleBackColor = true;
            // 
            // chkTimeTo
            // 
            chkTimeTo.AutoSize = true;
            chkTimeTo.Checked = true;
            chkTimeTo.CheckState = CheckState.Checked;
            chkTimeTo.Location = new Point(210, 95);
            chkTimeTo.Name = "chkTimeTo";
            chkTimeTo.Size = new Size(41, 19);
            chkTimeTo.TabIndex = 4;
            chkTimeTo.Text = "To:";
            chkTimeTo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTimeSection
            // 
            btnDeleteTimeSection.Location = new Point(296, 157);
            btnDeleteTimeSection.Name = "btnDeleteTimeSection";
            btnDeleteTimeSection.Size = new Size(74, 23);
            btnDeleteTimeSection.TabIndex = 2;
            btnDeleteTimeSection.Text = "Delete";
            btnDeleteTimeSection.UseVisualStyleBackColor = true;
            btnDeleteTimeSection.Click += btnDeleteTimeSection_Click;
            // 
            // btnUpdateTimeSection
            // 
            btnUpdateTimeSection.Location = new Point(210, 157);
            btnUpdateTimeSection.Name = "btnUpdateTimeSection";
            btnUpdateTimeSection.Size = new Size(74, 23);
            btnUpdateTimeSection.TabIndex = 2;
            btnUpdateTimeSection.Text = "Update";
            btnUpdateTimeSection.UseVisualStyleBackColor = true;
            btnUpdateTimeSection.Click += btnUpdateTimeSection_Click;
            // 
            // btnMoveTimeSectionDown
            // 
            btnMoveTimeSectionDown.Location = new Point(27, 70);
            btnMoveTimeSectionDown.Name = "btnMoveTimeSectionDown";
            btnMoveTimeSectionDown.Size = new Size(26, 23);
            btnMoveTimeSectionDown.TabIndex = 2;
            btnMoveTimeSectionDown.Text = "v";
            btnMoveTimeSectionDown.UseVisualStyleBackColor = true;
            btnMoveTimeSectionDown.Click += btnMoveTimeSectionDown_Click;
            // 
            // btnMoveTimeSectionUp
            // 
            btnMoveTimeSectionUp.Location = new Point(27, 41);
            btnMoveTimeSectionUp.Name = "btnMoveTimeSectionUp";
            btnMoveTimeSectionUp.Size = new Size(26, 23);
            btnMoveTimeSectionUp.TabIndex = 2;
            btnMoveTimeSectionUp.Text = "^";
            btnMoveTimeSectionUp.UseVisualStyleBackColor = true;
            btnMoveTimeSectionUp.Click += btnMoveTimeSectionUp_Click;
            // 
            // btnResetTimeSection
            // 
            btnResetTimeSection.Location = new Point(210, 128);
            btnResetTimeSection.Name = "btnResetTimeSection";
            btnResetTimeSection.Size = new Size(74, 23);
            btnResetTimeSection.TabIndex = 2;
            btnResetTimeSection.Text = "Reset";
            btnResetTimeSection.UseVisualStyleBackColor = true;
            btnResetTimeSection.Click += btnResetTimeSection_Click;
            // 
            // btnAddTimeSection
            // 
            btnAddTimeSection.Location = new Point(296, 128);
            btnAddTimeSection.Name = "btnAddTimeSection";
            btnAddTimeSection.Size = new Size(74, 23);
            btnAddTimeSection.TabIndex = 2;
            btnAddTimeSection.Text = "Add";
            btnAddTimeSection.UseVisualStyleBackColor = true;
            btnAddTimeSection.Click += btnAddTimeSection_Click;
            // 
            // txtSourceFile
            // 
            txtSourceFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSourceFile.Location = new Point(129, 29);
            txtSourceFile.Name = "txtSourceFile";
            txtSourceFile.Size = new Size(649, 23);
            txtSourceFile.TabIndex = 5;
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
            txtCommands.Location = new Point(25, 363);
            txtCommands.Multiline = true;
            txtCommands.Name = "txtCommands";
            txtCommands.ScrollBars = ScrollBars.Both;
            txtCommands.Size = new Size(753, 127);
            txtCommands.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 332);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 6;
            label2.Text = "Commands:";
            // 
            // btnUpdateCommands
            // 
            btnUpdateCommands.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateCommands.Location = new Point(25, 505);
            btnUpdateCommands.Name = "btnUpdateCommands";
            btnUpdateCommands.Size = new Size(153, 34);
            btnUpdateCommands.TabIndex = 8;
            btnUpdateCommands.Text = "Update commands";
            btnUpdateCommands.UseVisualStyleBackColor = true;
            btnUpdateCommands.Click += btnUpdateCommands_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 551);
            Controls.Add(btnUpdateCommands);
            Controls.Add(txtCommands);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSourceFile);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTimeSections;
        private Button btnClearTimeSections;
        private MaskedTextBox txtFrom;
        private MaskedTextBox txtTo;
        private GroupBox groupBox1;
        private Button btnDeleteTimeSection;
        private Button btnAddTimeSection;
        private CheckBox chkTimeFrom;
        private CheckBox chkTimeTo;
        private Button btnUpdateTimeSection;
        private Button btnResetTimeSection;
        private Button btnMoveTimeSectionDown;
        private Button btnMoveTimeSectionUp;
        private TextBox txtSourceFile;
        private Label label1;
        private TextBox txtCommands;
        private Label label2;
        private Button btnUpdateCommands;
    }
}

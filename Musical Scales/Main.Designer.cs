namespace Musical_Scales
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lblNoteC1 = new Label();
            lblNoteC2 = new Label();
            lblNoteC3 = new Label();
            lblNoteC4 = new Label();
            lblNoteC5 = new Label();
            lblNoteC6 = new Label();
            lblNoteC7 = new Label();
            cbbCurrentScale = new ComboBox();
            lblCurrentScale = new Label();
            lblWantedScale = new Label();
            cbbWantedScale = new ComboBox();
            tlpInputs = new TableLayoutPanel();
            cbShowNames = new CheckBox();
            tlpCurrentScale = new TableLayoutPanel();
            tlpWanted = new TableLayoutPanel();
            lblNoteW1 = new Label();
            lblNoteW2 = new Label();
            lblNoteW3 = new Label();
            lblNoteW7 = new Label();
            lblNoteW4 = new Label();
            lblNoteW6 = new Label();
            lblNoteW5 = new Label();
            tlpInputs.SuspendLayout();
            tlpCurrentScale.SuspendLayout();
            tlpWanted.SuspendLayout();
            SuspendLayout();
            // 
            // lblNoteC1
            // 
            resources.ApplyResources(lblNoteC1, "lblNoteC1");
            lblNoteC1.Name = "lblNoteC1";
            // 
            // lblNoteC2
            // 
            resources.ApplyResources(lblNoteC2, "lblNoteC2");
            lblNoteC2.Name = "lblNoteC2";
            // 
            // lblNoteC3
            // 
            resources.ApplyResources(lblNoteC3, "lblNoteC3");
            lblNoteC3.Name = "lblNoteC3";
            // 
            // lblNoteC4
            // 
            resources.ApplyResources(lblNoteC4, "lblNoteC4");
            lblNoteC4.Name = "lblNoteC4";
            // 
            // lblNoteC5
            // 
            resources.ApplyResources(lblNoteC5, "lblNoteC5");
            lblNoteC5.Name = "lblNoteC5";
            // 
            // lblNoteC6
            // 
            resources.ApplyResources(lblNoteC6, "lblNoteC6");
            lblNoteC6.Name = "lblNoteC6";
            // 
            // lblNoteC7
            // 
            resources.ApplyResources(lblNoteC7, "lblNoteC7");
            lblNoteC7.Name = "lblNoteC7";
            // 
            // cbbCurrentScale
            // 
            resources.ApplyResources(cbbCurrentScale, "cbbCurrentScale");
            cbbCurrentScale.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCurrentScale.FormattingEnabled = true;
            cbbCurrentScale.Name = "cbbCurrentScale";
            cbbCurrentScale.SelectedIndexChanged += cbbCurrentScale_SelectedIndexChanged;
            // 
            // lblCurrentScale
            // 
            resources.ApplyResources(lblCurrentScale, "lblCurrentScale");
            lblCurrentScale.Name = "lblCurrentScale";
            // 
            // lblWantedScale
            // 
            resources.ApplyResources(lblWantedScale, "lblWantedScale");
            lblWantedScale.Name = "lblWantedScale";
            // 
            // cbbWantedScale
            // 
            resources.ApplyResources(cbbWantedScale, "cbbWantedScale");
            cbbWantedScale.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbWantedScale.FormattingEnabled = true;
            cbbWantedScale.Name = "cbbWantedScale";
            cbbWantedScale.SelectedIndexChanged += cbbWantedScale_SelectedIndexChanged;
            // 
            // tlpInputs
            // 
            resources.ApplyResources(tlpInputs, "tlpInputs");
            tlpInputs.Controls.Add(lblCurrentScale, 0, 0);
            tlpInputs.Controls.Add(lblWantedScale, 1, 0);
            tlpInputs.Controls.Add(cbbCurrentScale, 0, 1);
            tlpInputs.Controls.Add(cbbWantedScale, 1, 1);
            tlpInputs.Name = "tlpInputs";
            // 
            // cbShowNames
            // 
            resources.ApplyResources(cbShowNames, "cbShowNames");
            cbShowNames.Name = "cbShowNames";
            cbShowNames.UseVisualStyleBackColor = true;
            cbShowNames.CheckedChanged += cbShowNames_CheckedChanged;
            // 
            // tlpCurrentScale
            // 
            resources.ApplyResources(tlpCurrentScale, "tlpCurrentScale");
            tlpCurrentScale.Controls.Add(lblNoteC1, 0, 0);
            tlpCurrentScale.Controls.Add(lblNoteC2, 1, 0);
            tlpCurrentScale.Controls.Add(lblNoteC3, 2, 0);
            tlpCurrentScale.Controls.Add(lblNoteC7, 6, 0);
            tlpCurrentScale.Controls.Add(lblNoteC4, 3, 0);
            tlpCurrentScale.Controls.Add(lblNoteC6, 5, 0);
            tlpCurrentScale.Controls.Add(lblNoteC5, 4, 0);
            tlpCurrentScale.Name = "tlpCurrentScale";
            // 
            // tlpWanted
            // 
            resources.ApplyResources(tlpWanted, "tlpWanted");
            tlpWanted.Controls.Add(lblNoteW1, 0, 0);
            tlpWanted.Controls.Add(lblNoteW2, 1, 0);
            tlpWanted.Controls.Add(lblNoteW3, 2, 0);
            tlpWanted.Controls.Add(lblNoteW7, 6, 0);
            tlpWanted.Controls.Add(lblNoteW4, 3, 0);
            tlpWanted.Controls.Add(lblNoteW6, 5, 0);
            tlpWanted.Controls.Add(lblNoteW5, 4, 0);
            tlpWanted.Name = "tlpWanted";
            // 
            // lblNoteW1
            // 
            resources.ApplyResources(lblNoteW1, "lblNoteW1");
            lblNoteW1.Name = "lblNoteW1";
            // 
            // lblNoteW2
            // 
            resources.ApplyResources(lblNoteW2, "lblNoteW2");
            lblNoteW2.Name = "lblNoteW2";
            // 
            // lblNoteW3
            // 
            resources.ApplyResources(lblNoteW3, "lblNoteW3");
            lblNoteW3.Name = "lblNoteW3";
            // 
            // lblNoteW7
            // 
            resources.ApplyResources(lblNoteW7, "lblNoteW7");
            lblNoteW7.Name = "lblNoteW7";
            // 
            // lblNoteW4
            // 
            resources.ApplyResources(lblNoteW4, "lblNoteW4");
            lblNoteW4.Name = "lblNoteW4";
            // 
            // lblNoteW6
            // 
            resources.ApplyResources(lblNoteW6, "lblNoteW6");
            lblNoteW6.Name = "lblNoteW6";
            // 
            // lblNoteW5
            // 
            resources.ApplyResources(lblNoteW5, "lblNoteW5");
            lblNoteW5.Name = "lblNoteW5";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpWanted);
            Controls.Add(tlpCurrentScale);
            Controls.Add(cbShowNames);
            Controls.Add(tlpInputs);
            MaximizeBox = false;
            Name = "Main";
            tlpInputs.ResumeLayout(false);
            tlpInputs.PerformLayout();
            tlpCurrentScale.ResumeLayout(false);
            tlpCurrentScale.PerformLayout();
            tlpWanted.ResumeLayout(false);
            tlpWanted.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNoteC1;
        private Label lblNoteC2;
        private Label lblNoteC3;
        private Label lblNoteC4;
        private Label lblNoteC5;
        private Label lblNoteC6;
        private Label lblNoteC7;
        private ComboBox cbbCurrentScale;
        private Label lblCurrentScale;
        private Label lblWantedScale;
        private ComboBox cbbWantedScale;
        private TableLayoutPanel tlpInputs;
        private CheckBox cbShowNames;
        private TableLayoutPanel tlpCurrentScale;
        private TableLayoutPanel tlpWanted;
        private Label lblNoteW1;
        private Label lblNoteW2;
        private Label lblNoteW3;
        private Label lblNoteW7;
        private Label lblNoteW4;
        private Label lblNoteW6;
        private Label lblNoteW5;
    }
}
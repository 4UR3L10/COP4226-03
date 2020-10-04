namespace NeatOffice
{
    partial class NeatOffice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeatOffice));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuAppearance = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFileItemClearCalculatorHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFileItemSaveCalculatorHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFilePrintCalculatorHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFileSaveMinimumSpanningTreeAs = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFileSaveShortestPathAs = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuOpenCalculatorHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuOpenGraphMatrixTxT = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuOpenGraphMatrixCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuOpenMultipleGraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuAppearanceModifyCalculatorDisplayFont = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuAppearanceModifyBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelpProjectDocumentation = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelpHowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelpTutorials = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFile,
            this.StripMenuOpen,
            this.StripMenuAppearance,
            this.StripMenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "File";
            // 
            // StripMenuFile
            // 
            this.StripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFileItemClearCalculatorHistory,
            this.StripMenuFileItemSaveCalculatorHistory,
            this.StripMenuFilePrintCalculatorHistory,
            this.StripMenuFileSaveMinimumSpanningTreeAs,
            this.StripMenuFileSaveShortestPathAs,
            this.StripMenuFileExit});
            this.StripMenuFile.Name = "StripMenuFile";
            this.StripMenuFile.Size = new System.Drawing.Size(54, 29);
            this.StripMenuFile.Text = "File";
            // 
            // StripMenuOpen
            // 
            this.StripMenuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuOpenCalculatorHistory,
            this.StripMenuOpenGraphMatrixTxT,
            this.StripMenuOpenGraphMatrixCSV,
            this.StripMenuOpenMultipleGraphs});
            this.StripMenuOpen.Name = "StripMenuOpen";
            this.StripMenuOpen.Size = new System.Drawing.Size(72, 29);
            this.StripMenuOpen.Text = "Open";
            // 
            // StripMenuAppearance
            // 
            this.StripMenuAppearance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuAppearanceModifyCalculatorDisplayFont,
            this.StripMenuAppearanceModifyBackgroundColor});
            this.StripMenuAppearance.Name = "StripMenuAppearance";
            this.StripMenuAppearance.Size = new System.Drawing.Size(122, 29);
            this.StripMenuAppearance.Text = "Appearance";
            // 
            // StripMenuHelp
            // 
            this.StripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuHelpAbout,
            this.StripMenuHelpProjectDocumentation,
            this.StripMenuHelpHowTo,
            this.StripMenuHelpTutorials,
            this.aboutToolStripMenuItem2});
            this.StripMenuHelp.Name = "StripMenuHelp";
            this.StripMenuHelp.Size = new System.Drawing.Size(65, 29);
            this.StripMenuHelp.Text = "Help";
            // 
            // StripMenuFileExit
            // 
            this.StripMenuFileExit.Image = global::NeatOffice.Properties.Resources.ShutDown;
            this.StripMenuFileExit.Name = "StripMenuFileExit";
            this.StripMenuFileExit.Size = new System.Drawing.Size(379, 34);
            this.StripMenuFileExit.Text = "Exit";
            this.StripMenuFileExit.Click += new System.EventHandler(this.StripMenuFileExit_Click);
            // 
            // StripMenuFileItemClearCalculatorHistory
            // 
            this.StripMenuFileItemClearCalculatorHistory.Image = global::NeatOffice.Properties.Resources.Eraser;
            this.StripMenuFileItemClearCalculatorHistory.Name = "StripMenuFileItemClearCalculatorHistory";
            this.StripMenuFileItemClearCalculatorHistory.Size = new System.Drawing.Size(379, 34);
            this.StripMenuFileItemClearCalculatorHistory.Text = "Clear calculator history";
            // 
            // StripMenuFileItemSaveCalculatorHistory
            // 
            this.StripMenuFileItemSaveCalculatorHistory.Image = global::NeatOffice.Properties.Resources.Save;
            this.StripMenuFileItemSaveCalculatorHistory.Name = "StripMenuFileItemSaveCalculatorHistory";
            this.StripMenuFileItemSaveCalculatorHistory.Size = new System.Drawing.Size(379, 34);
            this.StripMenuFileItemSaveCalculatorHistory.Text = "Save calculator history as ...";
            // 
            // StripMenuFilePrintCalculatorHistory
            // 
            this.StripMenuFilePrintCalculatorHistory.Image = global::NeatOffice.Properties.Resources.Printer;
            this.StripMenuFilePrintCalculatorHistory.Name = "StripMenuFilePrintCalculatorHistory";
            this.StripMenuFilePrintCalculatorHistory.Size = new System.Drawing.Size(379, 34);
            this.StripMenuFilePrintCalculatorHistory.Text = "Print calculator history";
            // 
            // StripMenuFileSaveMinimumSpanningTreeAs
            // 
            this.StripMenuFileSaveMinimumSpanningTreeAs.Image = global::NeatOffice.Properties.Resources.BTree;
            this.StripMenuFileSaveMinimumSpanningTreeAs.Name = "StripMenuFileSaveMinimumSpanningTreeAs";
            this.StripMenuFileSaveMinimumSpanningTreeAs.Size = new System.Drawing.Size(379, 34);
            this.StripMenuFileSaveMinimumSpanningTreeAs.Text = "Save minimum spanning tree as...";
            // 
            // StripMenuFileSaveShortestPathAs
            // 
            this.StripMenuFileSaveShortestPathAs.Image = global::NeatOffice.Properties.Resources.ShorPath;
            this.StripMenuFileSaveShortestPathAs.Name = "StripMenuFileSaveShortestPathAs";
            this.StripMenuFileSaveShortestPathAs.Size = new System.Drawing.Size(379, 34);
            this.StripMenuFileSaveShortestPathAs.Text = "Save shortest path as...";
            // 
            // StripMenuOpenCalculatorHistory
            // 
            this.StripMenuOpenCalculatorHistory.Image = global::NeatOffice.Properties.Resources.CalcHistory;
            this.StripMenuOpenCalculatorHistory.Name = "StripMenuOpenCalculatorHistory";
            this.StripMenuOpenCalculatorHistory.Size = new System.Drawing.Size(260, 34);
            this.StripMenuOpenCalculatorHistory.Text = "Calculator History";
            // 
            // StripMenuOpenGraphMatrixTxT
            // 
            this.StripMenuOpenGraphMatrixTxT.Image = global::NeatOffice.Properties.Resources.TXT;
            this.StripMenuOpenGraphMatrixTxT.Name = "StripMenuOpenGraphMatrixTxT";
            this.StripMenuOpenGraphMatrixTxT.Size = new System.Drawing.Size(260, 34);
            this.StripMenuOpenGraphMatrixTxT.Text = "Graph Matrix (.txt)";
            // 
            // StripMenuOpenGraphMatrixCSV
            // 
            this.StripMenuOpenGraphMatrixCSV.Image = global::NeatOffice.Properties.Resources.CSV;
            this.StripMenuOpenGraphMatrixCSV.Name = "StripMenuOpenGraphMatrixCSV";
            this.StripMenuOpenGraphMatrixCSV.Size = new System.Drawing.Size(260, 34);
            this.StripMenuOpenGraphMatrixCSV.Text = "Graph Matrix (.csv)";
            // 
            // StripMenuOpenMultipleGraphs
            // 
            this.StripMenuOpenMultipleGraphs.Image = global::NeatOffice.Properties.Resources.MultipleGraph;
            this.StripMenuOpenMultipleGraphs.Name = "StripMenuOpenMultipleGraphs";
            this.StripMenuOpenMultipleGraphs.Size = new System.Drawing.Size(260, 34);
            this.StripMenuOpenMultipleGraphs.Text = "Multiple Graphs";
            // 
            // StripMenuAppearanceModifyCalculatorDisplayFont
            // 
            this.StripMenuAppearanceModifyCalculatorDisplayFont.Image = global::NeatOffice.Properties.Resources.Font;
            this.StripMenuAppearanceModifyCalculatorDisplayFont.Name = "StripMenuAppearanceModifyCalculatorDisplayFont";
            this.StripMenuAppearanceModifyCalculatorDisplayFont.Size = new System.Drawing.Size(350, 34);
            this.StripMenuAppearanceModifyCalculatorDisplayFont.Text = "Modify calculator display font";
            // 
            // StripMenuAppearanceModifyBackgroundColor
            // 
            this.StripMenuAppearanceModifyBackgroundColor.Image = global::NeatOffice.Properties.Resources.BackgroundColor;
            this.StripMenuAppearanceModifyBackgroundColor.Name = "StripMenuAppearanceModifyBackgroundColor";
            this.StripMenuAppearanceModifyBackgroundColor.Size = new System.Drawing.Size(350, 34);
            this.StripMenuAppearanceModifyBackgroundColor.Text = "Modify background color";
            // 
            // StripMenuHelpAbout
            // 
            this.StripMenuHelpAbout.Image = global::NeatOffice.Properties.Resources.Manual;
            this.StripMenuHelpAbout.Name = "StripMenuHelpAbout";
            this.StripMenuHelpAbout.Size = new System.Drawing.Size(296, 34);
            this.StripMenuHelpAbout.Text = "User Manual";
            // 
            // StripMenuHelpProjectDocumentation
            // 
            this.StripMenuHelpProjectDocumentation.Image = global::NeatOffice.Properties.Resources.Documentation;
            this.StripMenuHelpProjectDocumentation.Name = "StripMenuHelpProjectDocumentation";
            this.StripMenuHelpProjectDocumentation.Size = new System.Drawing.Size(296, 34);
            this.StripMenuHelpProjectDocumentation.Text = "Project Documentation";
            // 
            // StripMenuHelpHowTo
            // 
            this.StripMenuHelpHowTo.Image = global::NeatOffice.Properties.Resources.HowTo;
            this.StripMenuHelpHowTo.Name = "StripMenuHelpHowTo";
            this.StripMenuHelpHowTo.Size = new System.Drawing.Size(296, 34);
            this.StripMenuHelpHowTo.Text = "How - To Guides";
            // 
            // StripMenuHelpTutorials
            // 
            this.StripMenuHelpTutorials.Image = global::NeatOffice.Properties.Resources.Recursos;
            this.StripMenuHelpTutorials.Name = "StripMenuHelpTutorials";
            this.StripMenuHelpTutorials.Size = new System.Drawing.Size(296, 34);
            this.StripMenuHelpTutorials.Text = "Resources";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Image = global::NeatOffice.Properties.Resources.AboutUs;
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(296, 34);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // NeatOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 537);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NeatOffice";
            this.Text = "Neat Office";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFileItemClearCalculatorHistory;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFileItemSaveCalculatorHistory;
        private System.Windows.Forms.ToolStripMenuItem StripMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem StripMenuAppearance;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFilePrintCalculatorHistory;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFileSaveMinimumSpanningTreeAs;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFileSaveShortestPathAs;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem StripMenuOpenCalculatorHistory;
        private System.Windows.Forms.ToolStripMenuItem StripMenuOpenGraphMatrixTxT;
        private System.Windows.Forms.ToolStripMenuItem StripMenuOpenGraphMatrixCSV;
        private System.Windows.Forms.ToolStripMenuItem StripMenuOpenMultipleGraphs;
        private System.Windows.Forms.ToolStripMenuItem StripMenuAppearanceModifyCalculatorDisplayFont;
        private System.Windows.Forms.ToolStripMenuItem StripMenuAppearanceModifyBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelpProjectDocumentation;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelpHowTo;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelpTutorials;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
    }
}


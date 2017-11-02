﻿namespace Nebulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importMidiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMidiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnCompile = new System.Windows.Forms.Button();
            this.timeMaster = new Nebulator.Controls.TimeControl();
            this.sldVolume = new Nebulator.Controls.Slider();
            this.chkPlay = new System.Windows.Forms.CheckBox();
            this.potSpeed = new Nebulator.Controls.Pot();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.btnRewind = new System.Windows.Forms.Button();
            this.splitContainerControl = new System.Windows.Forms.SplitContainer();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageLevers = new System.Windows.Forms.TabPage();
            this.levers = new Nebulator.UI.Levers();
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.tabAux = new System.Windows.Forms.TabControl();
            this.tabPageInfoX = new System.Windows.Forms.TabPage();
            this.infoDisplay = new Nebulator.UI.InfoDisplay();
            this.tabPageMonitorX = new System.Windows.Forms.TabPage();
            this.midiMonitor = new Nebulator.UI.MidiMonitor();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageLevers.SuspendLayout();
            this.tabAux.SuspendLayout();
            this.tabPageInfoX.SuspendLayout();
            this.tabPageMonitorX.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.pianoToolStripMenuItem,
            this.logToolStripMenuItem,
            this.importMidiToolStripMenuItem,
            this.exportMidiToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Nebulator.Properties.Resources.glyphicons_137_cogwheel;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_Click);
            // 
            // pianoToolStripMenuItem
            // 
            this.pianoToolStripMenuItem.CheckOnClick = true;
            this.pianoToolStripMenuItem.Image = global::Nebulator.Properties.Resources.glyphicons_327_piano;
            this.pianoToolStripMenuItem.Name = "pianoToolStripMenuItem";
            this.pianoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pianoToolStripMenuItem.Text = "Piano";
            this.pianoToolStripMenuItem.Click += new System.EventHandler(this.Piano_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Image = global::Nebulator.Properties.Resources.glyphicons_331_blog;
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.Log_Click);
            // 
            // importMidiToolStripMenuItem
            // 
            this.importMidiToolStripMenuItem.Image = global::Nebulator.Properties.Resources.glyphicons_359_file_import;
            this.importMidiToolStripMenuItem.Name = "importMidiToolStripMenuItem";
            this.importMidiToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.importMidiToolStripMenuItem.Text = "Import Style";
            this.importMidiToolStripMenuItem.Click += new System.EventHandler(this.ImportStyle_Click);
            // 
            // exportMidiToolStripMenuItem
            // 
            this.exportMidiToolStripMenuItem.Image = global::Nebulator.Properties.Resources.glyphicons_360_file_export;
            this.exportMidiToolStripMenuItem.Name = "exportMidiToolStripMenuItem";
            this.exportMidiToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exportMidiToolStripMenuItem.Text = "Export Midi";
            this.exportMidiToolStripMenuItem.Click += new System.EventHandler(this.ExportMidi_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Nebulator.Properties.Resources.glyphicons_195_question_sign;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.AutoScroll = true;
            this.splitContainerMain.Panel1.Controls.Add(this.btnCompile);
            this.splitContainerMain.Panel1.Controls.Add(this.timeMaster);
            this.splitContainerMain.Panel1.Controls.Add(this.sldVolume);
            this.splitContainerMain.Panel1.Controls.Add(this.chkPlay);
            this.splitContainerMain.Panel1.Controls.Add(this.potSpeed);
            this.splitContainerMain.Panel1.Controls.Add(this.chkLoop);
            this.splitContainerMain.Panel1.Controls.Add(this.btnRewind);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerControl);
            this.splitContainerMain.Size = new System.Drawing.Size(826, 556);
            this.splitContainerMain.TabIndex = 14;
            // 
            // btnCompile
            // 
            this.btnCompile.FlatAppearance.BorderSize = 0;
            this.btnCompile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompile.Image = global::Nebulator.Properties.Resources.glyphicons_366_restart;
            this.btnCompile.Location = new System.Drawing.Point(77, 7);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(34, 32);
            this.btnCompile.TabIndex = 38;
            this.toolTip.SetToolTip(this.btnCompile, "Compile neb file - lit indicates file changed externally");
            this.btnCompile.UseVisualStyleBackColor = false;
            this.btnCompile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // timeMaster
            // 
            this.timeMaster.ControlColor = System.Drawing.Color.Orange;
            this.timeMaster.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeMaster.Location = new System.Drawing.Point(268, 8);
            this.timeMaster.Major = 0;
            this.timeMaster.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.timeMaster.MaxMajor = 100;
            this.timeMaster.Minor = 0;
            this.timeMaster.Name = "timeMaster";
            this.timeMaster.Size = new System.Drawing.Size(221, 34);
            this.timeMaster.TabIndex = 37;
            this.timeMaster.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            // 
            // sldVolume
            // 
            this.sldVolume.ControlColor = System.Drawing.Color.Orange;
            this.sldVolume.Label = "VOL";
            this.sldVolume.Location = new System.Drawing.Point(195, 8);
            this.sldVolume.Maximum = 150;
            this.sldVolume.Minimum = 0;
            this.sldVolume.Name = "sldVolume";
            this.sldVolume.ResetValue = 0;
            this.sldVolume.Size = new System.Drawing.Size(66, 34);
            this.sldVolume.TabIndex = 36;
            this.toolTip.SetToolTip(this.sldVolume, "Master volume");
            this.sldVolume.Value = 90;
            this.sldVolume.ValueChanged += new System.EventHandler(this.Volume_ValueChanged);
            // 
            // chkPlay
            // 
            this.chkPlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPlay.BackColor = System.Drawing.SystemColors.Control;
            this.chkPlay.FlatAppearance.BorderSize = 0;
            this.chkPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPlay.Image = global::Nebulator.Properties.Resources.glyphicons_174_play;
            this.chkPlay.Location = new System.Drawing.Point(49, 8);
            this.chkPlay.MaximumSize = new System.Drawing.Size(32, 32);
            this.chkPlay.MinimumSize = new System.Drawing.Size(32, 32);
            this.chkPlay.Name = "chkPlay";
            this.chkPlay.Size = new System.Drawing.Size(32, 32);
            this.chkPlay.TabIndex = 35;
            this.toolTip.SetToolTip(this.chkPlay, "Play project");
            this.chkPlay.UseVisualStyleBackColor = false;
            this.chkPlay.Click += new System.EventHandler(this.Play_Click);
            // 
            // potSpeed
            // 
            this.potSpeed.ControlColor = System.Drawing.Color.Black;
            this.potSpeed.DecPlaces = 0;
            this.potSpeed.Location = new System.Drawing.Point(156, 7);
            this.potSpeed.Maximum = 200D;
            this.potSpeed.Minimum = 50D;
            this.potSpeed.Name = "potSpeed";
            this.potSpeed.Size = new System.Drawing.Size(32, 32);
            this.potSpeed.TabIndex = 33;
            this.toolTip.SetToolTip(this.potSpeed, "Speed in Ticks per minute (sorta BPM)");
            this.potSpeed.Value = 100D;
            this.potSpeed.ValueChanged += new System.EventHandler(this.Speed_ValueChanged);
            // 
            // chkLoop
            // 
            this.chkLoop.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLoop.BackColor = System.Drawing.SystemColors.Control;
            this.chkLoop.FlatAppearance.BorderSize = 0;
            this.chkLoop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLoop.Image = global::Nebulator.Properties.Resources.glyphicons_82_refresh;
            this.chkLoop.Location = new System.Drawing.Point(115, 8);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(31, 31);
            this.chkLoop.TabIndex = 32;
            this.toolTip.SetToolTip(this.chkLoop, "Loop forever");
            this.chkLoop.UseVisualStyleBackColor = false;
            // 
            // btnRewind
            // 
            this.btnRewind.FlatAppearance.BorderSize = 0;
            this.btnRewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewind.Image = global::Nebulator.Properties.Resources.glyphicons_172_fast_backward;
            this.btnRewind.Location = new System.Drawing.Point(10, 8);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(34, 32);
            this.btnRewind.TabIndex = 31;
            this.toolTip.SetToolTip(this.btnRewind, "Reset to start");
            this.btnRewind.UseVisualStyleBackColor = false;
            this.btnRewind.Click += new System.EventHandler(this.Rewind_Click);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.tabMain);
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.tabAux);
            this.splitContainerControl.Size = new System.Drawing.Size(826, 502);
            this.splitContainerControl.SplitterDistance = 447;
            this.splitContainerControl.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageLevers);
            this.tabMain.Controls.Add(this.tabPageOther);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(447, 502);
            this.tabMain.TabIndex = 2;
            // 
            // tabPageLevers
            // 
            this.tabPageLevers.Controls.Add(this.levers);
            this.tabPageLevers.Location = new System.Drawing.Point(4, 22);
            this.tabPageLevers.Name = "tabPageLevers";
            this.tabPageLevers.Size = new System.Drawing.Size(439, 476);
            this.tabPageLevers.TabIndex = 6;
            this.tabPageLevers.Text = "Levers";
            this.tabPageLevers.UseVisualStyleBackColor = true;
            // 
            // levers
            // 
            this.levers.BackColor = System.Drawing.Color.AliceBlue;
            this.levers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levers.Location = new System.Drawing.Point(0, 0);
            this.levers.Name = "levers";
            this.levers.Size = new System.Drawing.Size(439, 476);
            this.levers.TabIndex = 0;
            // 
            // tabPageOther
            // 
            this.tabPageOther.Location = new System.Drawing.Point(4, 22);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOther.Size = new System.Drawing.Size(439, 476);
            this.tabPageOther.TabIndex = 1;
            this.tabPageOther.Text = "Other";
            this.tabPageOther.UseVisualStyleBackColor = true;
            // 
            // tabAux
            // 
            this.tabAux.Controls.Add(this.tabPageInfoX);
            this.tabAux.Controls.Add(this.tabPageMonitorX);
            this.tabAux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAux.Location = new System.Drawing.Point(0, 0);
            this.tabAux.Name = "tabAux";
            this.tabAux.SelectedIndex = 0;
            this.tabAux.Size = new System.Drawing.Size(375, 502);
            this.tabAux.TabIndex = 0;
            // 
            // tabPageInfoX
            // 
            this.tabPageInfoX.Controls.Add(this.infoDisplay);
            this.tabPageInfoX.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfoX.Name = "tabPageInfoX";
            this.tabPageInfoX.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfoX.Size = new System.Drawing.Size(367, 476);
            this.tabPageInfoX.TabIndex = 0;
            this.tabPageInfoX.Text = "Info";
            this.tabPageInfoX.UseVisualStyleBackColor = true;
            // 
            // infoDisplay
            // 
            this.infoDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoDisplay.Location = new System.Drawing.Point(3, 3);
            this.infoDisplay.Name = "infoDisplay";
            this.infoDisplay.Size = new System.Drawing.Size(361, 470);
            this.infoDisplay.TabIndex = 0;
            // 
            // tabPageMonitorX
            // 
            this.tabPageMonitorX.Controls.Add(this.midiMonitor);
            this.tabPageMonitorX.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonitorX.Name = "tabPageMonitorX";
            this.tabPageMonitorX.Size = new System.Drawing.Size(367, 476);
            this.tabPageMonitorX.TabIndex = 1;
            this.tabPageMonitorX.Text = "Midi";
            this.tabPageMonitorX.UseVisualStyleBackColor = true;
            // 
            // midiMonitor
            // 
            this.midiMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midiMonitor.Location = new System.Drawing.Point(0, 0);
            this.midiMonitor.Name = "midiMonitor";
            this.midiMonitor.Size = new System.Drawing.Size(367, 476);
            this.midiMonitor.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(826, 580);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Nebulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerControl.Panel1.ResumeLayout(false);
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPageLevers.ResumeLayout(false);
            this.tabAux.ResumeLayout(false);
            this.tabPageInfoX.ResumeLayout(false);
            this.tabPageMonitorX.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pianoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private Controls.Slider sldVolume;
        private System.Windows.Forms.CheckBox chkPlay;
        private Controls.Pot potSpeed;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.SplitContainer splitContainerControl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageLevers;
        private UI.Levers levers;
        private System.Windows.Forms.TabPage tabPageOther;
        private System.Windows.Forms.TabControl tabAux;
        private System.Windows.Forms.TabPage tabPageInfoX;
        private System.Windows.Forms.TabPage tabPageMonitorX;
        private UI.MidiMonitor midiMonitor;
        private UI.InfoDisplay infoDisplay;
        private Controls.TimeControl timeMaster;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.ToolStripMenuItem exportMidiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importMidiToolStripMenuItem;
    }
}


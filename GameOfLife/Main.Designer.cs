namespace GameOfLife
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToggleAnimationToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.inputWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.inputHeight = new System.Windows.Forms.ToolStripTextBox();
            this.statusLabel = new System.Windows.Forms.ToolStripLabel();
            this.menu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(498, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNewMenuItem,
            this.FileLoadMenuItem,
            this.FileSaveMenuItem,
            this.toolStripSeparator1,
            this.FileExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // FileNewMenuItem
            // 
            this.FileNewMenuItem.Name = "FileNewMenuItem";
            this.FileNewMenuItem.Size = new System.Drawing.Size(100, 22);
            this.FileNewMenuItem.Text = "&New";
            this.FileNewMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // FileLoadMenuItem
            // 
            this.FileLoadMenuItem.Name = "FileLoadMenuItem";
            this.FileLoadMenuItem.Size = new System.Drawing.Size(100, 22);
            this.FileLoadMenuItem.Text = "&Load";
            this.FileLoadMenuItem.Click += new System.EventHandler(this.FileLoadMenuItem_Click);
            // 
            // FileSaveMenuItem
            // 
            this.FileSaveMenuItem.Name = "FileSaveMenuItem";
            this.FileSaveMenuItem.Size = new System.Drawing.Size(100, 22);
            this.FileSaveMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // FileExitMenuItem
            // 
            this.FileExitMenuItem.Name = "FileExitMenuItem";
            this.FileExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.FileExitMenuItem.Text = "E&xit";
            this.FileExitMenuItem.Click += new System.EventHandler(this.FileExitMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "&Control";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.play;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.startToolStripMenuItem.Text = "&Toggle Animation";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.ToggleAnimationToolStripButton_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stepToolStripMenuItem.Text = "&Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastestToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.slowToolStripMenuItem,
            this.slowestToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.speedToolStripMenuItem.Text = "S&peed";
            // 
            // fastestToolStripMenuItem
            // 
            this.fastestToolStripMenuItem.Name = "fastestToolStripMenuItem";
            this.fastestToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.fastestToolStripMenuItem.Text = "Fastest";
            this.fastestToolStripMenuItem.Click += new System.EventHandler(this.ToggleMenuChecked);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.fastToolStripMenuItem.Text = "Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.ToggleMenuChecked);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Checked = true;
            this.normalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.ToggleMenuChecked);
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.slowToolStripMenuItem.Text = "Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.ToggleMenuChecked);
            // 
            // slowestToolStripMenuItem
            // 
            this.slowestToolStripMenuItem.Name = "slowestToolStripMenuItem";
            this.slowestToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.slowestToolStripMenuItem.Text = "Slowest";
            this.slowestToolStripMenuItem.Click += new System.EventHandler(this.ToggleMenuChecked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "RLE files|*.rle|Plaintext files|*.cells|Life 1.05/1.06 files|*.lif|All Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "RLE files|*.rle|Plaintext files|*.cells|Life 1.05/1.06 files|*.lif|All Files|*.*";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.toolStripSeparator,
            this.ToggleAnimationToolStripButton,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.inputWidth,
            this.toolStripLabel2,
            this.inputHeight,
            this.statusLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(498, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "&New";
            this.NewToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "&Open";
            this.OpenToolStripButton.Click += new System.EventHandler(this.FileLoadMenuItem_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ToggleAnimationToolStripButton
            // 
            this.ToggleAnimationToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToggleAnimationToolStripButton.Image = global::GameOfLife.Properties.Resources.play;
            this.ToggleAnimationToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToggleAnimationToolStripButton.Name = "ToggleAnimationToolStripButton";
            this.ToggleAnimationToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToggleAnimationToolStripButton.Text = "Toggle Animation";
            this.ToggleAnimationToolStripButton.Click += new System.EventHandler(this.ToggleAnimationToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Width:";
            // 
            // inputWidth
            // 
            this.inputWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(25, 25);
            this.inputWidth.Text = "20";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "Height:";
            // 
            // inputHeight
            // 
            this.inputHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(25, 25);
            this.inputHeight.Text = "30";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(498, 468);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.Text = "Game Of Life";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileLoadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowestToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton ToggleAnimationToolStripButton;
        private System.Windows.Forms.ToolStripTextBox inputWidth;
        private System.Windows.Forms.ToolStripTextBox inputHeight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel statusLabel;
    }
}


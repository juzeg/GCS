namespace GCS
{
    partial class GCS
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.missionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missionStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missionToolStripMenuItem,
            this.dataDisplayToolStripMenuItem,
            this.systemsCheckToolStripMenuItem,
            this.missionStatusToolStripMenuItem,
            this.checkListToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // missionToolStripMenuItem
            // 
            this.missionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.newToolStripMenuItem,
            this.joinToolStripMenuItem});
            this.missionToolStripMenuItem.Name = "missionToolStripMenuItem";
            this.missionToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.missionToolStripMenuItem.Text = "Mission";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // joinToolStripMenuItem
            // 
            this.joinToolStripMenuItem.Name = "joinToolStripMenuItem";
            this.joinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.joinToolStripMenuItem.Text = "Join";
            // 
            // dataDisplayToolStripMenuItem
            // 
            this.dataDisplayToolStripMenuItem.Name = "dataDisplayToolStripMenuItem";
            this.dataDisplayToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.dataDisplayToolStripMenuItem.Text = "Data Display";
            this.dataDisplayToolStripMenuItem.Click += new System.EventHandler(this.dataDisplayToolStripMenuItem_Click);
            // 
            // systemsCheckToolStripMenuItem
            // 
            this.systemsCheckToolStripMenuItem.Name = "systemsCheckToolStripMenuItem";
            this.systemsCheckToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.systemsCheckToolStripMenuItem.Text = "Systems Check";
            // 
            // missionStatusToolStripMenuItem
            // 
            this.missionStatusToolStripMenuItem.Name = "missionStatusToolStripMenuItem";
            this.missionStatusToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.missionStatusToolStripMenuItem.Text = "Mission Status";
            // 
            // checkListToolStripMenuItem
            // 
            this.checkListToolStripMenuItem.Name = "checkListToolStripMenuItem";
            this.checkListToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.checkListToolStripMenuItem.Text = "Check List";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // GCS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GCS";
            this.Text = "Ground Control Station";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem missionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemsCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}


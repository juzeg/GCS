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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SendCommand = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // joinToolStripMenuItem
            // 
            this.joinToolStripMenuItem.Name = "joinToolStripMenuItem";
            this.joinToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1338, 530);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 573);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1130, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1078, 772);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SendCommand
            // 
            this.SendCommand.Location = new System.Drawing.Point(1148, 573);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.Size = new System.Drawing.Size(161, 31);
            this.SendCommand.TabIndex = 5;
            this.SendCommand.Text = "Send";
            this.SendCommand.UseVisualStyleBackColor = true;
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.comboBox1.Location = new System.Drawing.Point(12, 610);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GCS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 724);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GCS";
            this.Text = "Ground Control Station";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendCommand;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


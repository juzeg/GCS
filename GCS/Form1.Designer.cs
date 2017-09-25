namespace GCS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.butDD = new System.Windows.Forms.Button();
            this.butCLI = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupCLI = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupCLI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.butDD);
            this.panel1.Controls.Add(this.butCLI);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 690);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Stencil", 25F);
            this.button7.Location = new System.Drawing.Point(0, 585);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(228, 105);
            this.button7.TabIndex = 6;
            this.button7.Text = "Backup";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Stencil", 25F);
            this.button6.Location = new System.Drawing.Point(0, 494);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(227, 94);
            this.button6.TabIndex = 5;
            this.button6.Text = "About";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Stencil", 25F);
            this.button5.Location = new System.Drawing.Point(0, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 116);
            this.button5.TabIndex = 4;
            this.button5.Text = "Check List";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Stencil", 25F);
            this.button4.Location = new System.Drawing.Point(0, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 124);
            this.button4.TabIndex = 3;
            this.button4.Text = "Mission Status";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // butDD
            // 
            this.butDD.BackColor = System.Drawing.Color.PaleTurquoise;
            this.butDD.FlatAppearance.BorderSize = 0;
            this.butDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDD.Font = new System.Drawing.Font("Stencil", 25F);
            this.butDD.Location = new System.Drawing.Point(0, 164);
            this.butDD.Name = "butDD";
            this.butDD.Size = new System.Drawing.Size(228, 105);
            this.butDD.TabIndex = 2;
            this.butDD.Text = "Data Display";
            this.butDD.UseVisualStyleBackColor = false;
            // 
            // butCLI
            // 
            this.butCLI.BackColor = System.Drawing.Color.PaleTurquoise;
            this.butCLI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCLI.FlatAppearance.BorderSize = 0;
            this.butCLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCLI.Font = new System.Drawing.Font("Stencil", 25F);
            this.butCLI.Location = new System.Drawing.Point(0, 0);
            this.butCLI.Name = "butCLI";
            this.butCLI.Size = new System.Drawing.Size(228, 169);
            this.butCLI.TabIndex = 1;
            this.butCLI.Text = "Command Line Interface";
            this.butCLI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.butCLI.UseVisualStyleBackColor = false;
            this.butCLI.Click += new System.EventHandler(this.butCLI_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(227, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 127);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 95);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "GCS";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Playbill", 36F);
            this.button3.Location = new System.Drawing.Point(1302, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupCLI
            // 
            this.groupCLI.Controls.Add(this.button8);
            this.groupCLI.Controls.Add(this.textBox2);
            this.groupCLI.Controls.Add(this.textBox1);
            this.groupCLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCLI.Location = new System.Drawing.Point(267, 58);
            this.groupCLI.Margin = new System.Windows.Forms.Padding(0);
            this.groupCLI.Name = "groupCLI";
            this.groupCLI.Padding = new System.Windows.Forms.Padding(0);
            this.groupCLI.Size = new System.Drawing.Size(1068, 677);
            this.groupCLI.TabIndex = 3;
            this.groupCLI.TabStop = false;
            this.groupCLI.Text = "Command Line Interface";
            this.groupCLI.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(897, 643);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 24);
            this.button8.TabIndex = 2;
            this.button8.Text = "Send";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 641);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(871, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("TechnicBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox1.Location = new System.Drawing.Point(19, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1026, 609);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "NewMission#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 25F);
            this.label2.Location = new System.Drawing.Point(269, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "MISSION TIME: N/A";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupCLI);
            this.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Ground Control Station";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupCLI.ResumeLayout(false);
            this.groupCLI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDD;
        private System.Windows.Forms.Button butCLI;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupCLI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}


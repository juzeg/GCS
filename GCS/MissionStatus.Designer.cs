namespace GCS
{
    partial class MissionStatus
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
            this.MissionProgres = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MissionProgres
            // 
            this.MissionProgres.Location = new System.Drawing.Point(868, 128);
            this.MissionProgres.Name = "MissionProgres";
            this.MissionProgres.Size = new System.Drawing.Size(185, 23);
            this.MissionProgres.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(405, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 311);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clock.Location = new System.Drawing.Point(882, 62);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(161, 41);
            this.clock.TabIndex = 3;
            this.clock.Text = "13:05:10";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 175);
            this.label1.TabIndex = 4;
            this.label1.Text = "error 404";
            // 
            // MissionStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MissionProgres);
            this.Name = "MissionStatus";
            this.Text = "MissionStatus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar MissionProgres;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
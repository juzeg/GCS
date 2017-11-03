namespace GCS
{
    partial class systemcheck2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.satellite = new System.Windows.Forms.CheckBox();
            this.ground = new System.Windows.Forms.CheckBox();
            this.reserve = new System.Windows.Forms.CheckBox();
            this.comunication4 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.temperature = new System.Windows.Forms.CheckBox();
            this.pressure = new System.Windows.Forms.CheckBox();
            this.camera = new System.Windows.Forms.CheckBox();
            this.gps = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.database = new System.Windows.Forms.CheckBox();
            this.Scientist = new System.Windows.Forms.CheckBox();
            this.Engeneer = new System.Windows.Forms.CheckBox();
            this.Programmer = new System.Windows.Forms.CheckBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.power1 = new System.Windows.Forms.CheckBox();
            this.power2 = new System.Windows.Forms.CheckBox();
            this.power3 = new System.Windows.Forms.CheckBox();
            this.power4 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Comunication";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sensors";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.satellite);
            this.flowLayoutPanel4.Controls.Add(this.ground);
            this.flowLayoutPanel4.Controls.Add(this.reserve);
            this.flowLayoutPanel4.Controls.Add(this.comunication4);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(40, 194);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(188, 93);
            this.flowLayoutPanel4.TabIndex = 22;
            // 
            // satellite
            // 
            this.satellite.AutoSize = true;
            this.satellite.Location = new System.Drawing.Point(10, 3);
            this.satellite.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.satellite.MinimumSize = new System.Drawing.Size(80, 40);
            this.satellite.Name = "satellite";
            this.satellite.Size = new System.Drawing.Size(80, 40);
            this.satellite.TabIndex = 0;
            this.satellite.Text = "Satellite";
            this.satellite.UseVisualStyleBackColor = true;
            this.satellite.CheckedChanged += new System.EventHandler(this.satellite_CheckedChanged);
            // 
            // ground
            // 
            this.ground.AutoSize = true;
            this.ground.Location = new System.Drawing.Point(96, 3);
            this.ground.MinimumSize = new System.Drawing.Size(80, 40);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(80, 40);
            this.ground.TabIndex = 1;
            this.ground.Text = "Gruound";
            this.ground.UseVisualStyleBackColor = true;
            this.ground.CheckedChanged += new System.EventHandler(this.ground_CheckedChanged);
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(10, 49);
            this.reserve.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.reserve.MinimumSize = new System.Drawing.Size(80, 40);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(80, 40);
            this.reserve.TabIndex = 2;
            this.reserve.Text = "Reserve";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.CheckedChanged += new System.EventHandler(this.reserve_CheckedChanged);
            // 
            // comunication4
            // 
            this.comunication4.AutoSize = true;
            this.comunication4.Location = new System.Drawing.Point(96, 49);
            this.comunication4.MinimumSize = new System.Drawing.Size(80, 40);
            this.comunication4.Name = "comunication4";
            this.comunication4.Size = new System.Drawing.Size(80, 40);
            this.comunication4.TabIndex = 3;
            this.comunication4.Text = "GPS";
            this.comunication4.UseVisualStyleBackColor = true;
            this.comunication4.CheckedChanged += new System.EventHandler(this.comunication4_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.temperature);
            this.flowLayoutPanel2.Controls.Add(this.pressure);
            this.flowLayoutPanel2.Controls.Add(this.camera);
            this.flowLayoutPanel2.Controls.Add(this.gps);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(40, 52);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(188, 93);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(10, 3);
            this.temperature.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.temperature.MinimumSize = new System.Drawing.Size(80, 40);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(86, 40);
            this.temperature.TabIndex = 0;
            this.temperature.Text = "Temperature";
            this.temperature.UseVisualStyleBackColor = true;
            this.temperature.CheckedChanged += new System.EventHandler(this.temperature_CheckedChanged);
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Location = new System.Drawing.Point(102, 3);
            this.pressure.MinimumSize = new System.Drawing.Size(80, 40);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(80, 40);
            this.pressure.TabIndex = 1;
            this.pressure.Text = "Pressure";
            this.pressure.UseVisualStyleBackColor = true;
            this.pressure.CheckedChanged += new System.EventHandler(this.pressure_CheckedChanged);
            // 
            // camera
            // 
            this.camera.Location = new System.Drawing.Point(10, 49);
            this.camera.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.camera.MinimumSize = new System.Drawing.Size(80, 40);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(88, 40);
            this.camera.TabIndex = 2;
            this.camera.Text = "Camera";
            this.camera.UseVisualStyleBackColor = true;
            this.camera.CheckedChanged += new System.EventHandler(this.camera_CheckedChanged);
            // 
            // gps
            // 
            this.gps.AutoSize = true;
            this.gps.Location = new System.Drawing.Point(104, 49);
            this.gps.MinimumSize = new System.Drawing.Size(80, 40);
            this.gps.Name = "gps";
            this.gps.Size = new System.Drawing.Size(80, 40);
            this.gps.TabIndex = 3;
            this.gps.Text = "GPS";
            this.gps.UseVisualStyleBackColor = true;
            this.gps.CheckedChanged += new System.EventHandler(this.gps_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "GCS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Power";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.database);
            this.flowLayoutPanel3.Controls.Add(this.Scientist);
            this.flowLayoutPanel3.Controls.Add(this.Engeneer);
            this.flowLayoutPanel3.Controls.Add(this.Programmer);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(329, 194);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(188, 93);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // database
            // 
            this.database.AutoSize = true;
            this.database.Location = new System.Drawing.Point(10, 3);
            this.database.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.database.MinimumSize = new System.Drawing.Size(80, 40);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(80, 40);
            this.database.TabIndex = 0;
            this.database.Text = "Database";
            this.database.UseVisualStyleBackColor = true;
            this.database.CheckedChanged += new System.EventHandler(this.database_CheckedChanged);
            // 
            // Scientist
            // 
            this.Scientist.AutoSize = true;
            this.Scientist.Location = new System.Drawing.Point(96, 3);
            this.Scientist.MinimumSize = new System.Drawing.Size(80, 40);
            this.Scientist.Name = "Scientist";
            this.Scientist.Size = new System.Drawing.Size(80, 40);
            this.Scientist.TabIndex = 1;
            this.Scientist.Text = "Scientist";
            this.Scientist.UseVisualStyleBackColor = true;
            this.Scientist.CheckedChanged += new System.EventHandler(this.Scientist_CheckedChanged);
            // 
            // Engeneer
            // 
            this.Engeneer.AutoSize = true;
            this.Engeneer.Location = new System.Drawing.Point(10, 49);
            this.Engeneer.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Engeneer.MinimumSize = new System.Drawing.Size(80, 40);
            this.Engeneer.Name = "Engeneer";
            this.Engeneer.Size = new System.Drawing.Size(80, 40);
            this.Engeneer.TabIndex = 2;
            this.Engeneer.Text = "Engeener";
            this.Engeneer.UseVisualStyleBackColor = true;
            this.Engeneer.CheckedChanged += new System.EventHandler(this.Engeneer_CheckedChanged);
            // 
            // Programmer
            // 
            this.Programmer.AutoSize = true;
            this.Programmer.Location = new System.Drawing.Point(96, 49);
            this.Programmer.MinimumSize = new System.Drawing.Size(80, 40);
            this.Programmer.Name = "Programmer";
            this.Programmer.Size = new System.Drawing.Size(82, 40);
            this.Programmer.TabIndex = 3;
            this.Programmer.Text = "Programmer";
            this.Programmer.UseVisualStyleBackColor = true;
            this.Programmer.CheckedChanged += new System.EventHandler(this.Programmer_CheckedChanged);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(78, 351);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(399, 39);
            this.progress.Step = 1;
            this.progress.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.power1);
            this.flowLayoutPanel1.Controls.Add(this.power2);
            this.flowLayoutPanel1.Controls.Add(this.power3);
            this.flowLayoutPanel1.Controls.Add(this.power4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(329, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 93);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // power1
            // 
            this.power1.AutoSize = true;
            this.power1.Location = new System.Drawing.Point(10, 3);
            this.power1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.power1.MinimumSize = new System.Drawing.Size(80, 40);
            this.power1.Name = "power1";
            this.power1.Size = new System.Drawing.Size(80, 40);
            this.power1.TabIndex = 0;
            this.power1.Text = "checkBox1";
            this.power1.UseVisualStyleBackColor = true;
            this.power1.CheckedChanged += new System.EventHandler(this.power1_CheckedChanged);
            // 
            // power2
            // 
            this.power2.AutoSize = true;
            this.power2.Location = new System.Drawing.Point(96, 3);
            this.power2.MinimumSize = new System.Drawing.Size(80, 40);
            this.power2.Name = "power2";
            this.power2.Size = new System.Drawing.Size(80, 40);
            this.power2.TabIndex = 1;
            this.power2.Text = "checkBox2";
            this.power2.UseVisualStyleBackColor = true;
            this.power2.CheckedChanged += new System.EventHandler(this.power2_CheckedChanged);
            // 
            // power3
            // 
            this.power3.AutoSize = true;
            this.power3.Location = new System.Drawing.Point(10, 49);
            this.power3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.power3.MinimumSize = new System.Drawing.Size(80, 40);
            this.power3.Name = "power3";
            this.power3.Size = new System.Drawing.Size(80, 40);
            this.power3.TabIndex = 2;
            this.power3.Text = "checkBox3";
            this.power3.UseVisualStyleBackColor = true;
            this.power3.CheckedChanged += new System.EventHandler(this.power3_CheckedChanged);
            // 
            // power4
            // 
            this.power4.AutoSize = true;
            this.power4.Location = new System.Drawing.Point(96, 49);
            this.power4.MinimumSize = new System.Drawing.Size(80, 40);
            this.power4.Name = "power4";
            this.power4.Size = new System.Drawing.Size(80, 40);
            this.power4.TabIndex = 3;
            this.power4.Text = "checkBox4";
            this.power4.UseVisualStyleBackColor = true;
            this.power4.CheckedChanged += new System.EventHandler(this.power4_CheckedChanged);
            // 
            // systemcheck2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "systemcheck2";
            this.Text = "systemcheck2";
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox satellite;
        private System.Windows.Forms.CheckBox ground;
        private System.Windows.Forms.CheckBox reserve;
        private System.Windows.Forms.CheckBox comunication4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox temperature;
        private System.Windows.Forms.CheckBox pressure;
        private System.Windows.Forms.CheckBox camera;
        private System.Windows.Forms.CheckBox gps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox database;
        private System.Windows.Forms.CheckBox Scientist;
        private System.Windows.Forms.CheckBox Engeneer;
        private System.Windows.Forms.CheckBox Programmer;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox power1;
        private System.Windows.Forms.CheckBox power2;
        private System.Windows.Forms.CheckBox power3;
        private System.Windows.Forms.CheckBox power4;
    }
}
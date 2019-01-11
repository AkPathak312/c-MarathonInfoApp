namespace MarathonProject
{
    partial class BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI));
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trBmi = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBmi)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(182, 25);
            // 
            // rem
            // 
            this.rem.Size = new System.Drawing.Size(771, 36);
            this.rem.Text = "22 Days 18 Hours 34 Minutes 17 Seconds remaining.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(671, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 44);
            this.label2.TabIndex = 52;
            this.label2.Text = "BMI Calculator";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(822, 145);
            this.label14.TabIndex = 69;
            this.label14.Text = resources.GetString("label14.Text");
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 176);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(833, 146);
            this.flowLayoutPanel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::MarathonProject.Properties.Resources.male_icon;
            this.pictureBox1.Location = new System.Drawing.Point(231, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = global::MarathonProject.Properties.Resources.female_icon;
            this.pictureBox2.Location = new System.Drawing.Point(500, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 74;
            this.label3.Text = "Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 75;
            this.label4.Text = "Weight :";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(390, 590);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(135, 38);
            this.txtHeight.TabIndex = 76;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(390, 637);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(135, 38);
            this.txtWeight.TabIndex = 77;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 78;
            this.label5.Text = "cms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 32);
            this.label6.TabIndex = 79;
            this.label6.Text = "kg";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(231, 707);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 53);
            this.btnCalculate.TabIndex = 80;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(445, 707);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 53);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Image = global::MarathonProject.Properties.Resources.female_icon;
            this.pictureBox3.Location = new System.Drawing.Point(1134, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 433);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // trBmi
            // 
            this.trBmi.Location = new System.Drawing.Point(1055, 680);
            this.trBmi.Maximum = 35;
            this.trBmi.Minimum = 15;
            this.trBmi.Name = "trBmi";
            this.trBmi.Size = new System.Drawing.Size(364, 56);
            this.trBmi.TabIndex = 83;
            this.trBmi.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trBmi.Value = 15;
            this.trBmi.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(1073, 722);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 14);
            this.panel3.TabIndex = 84;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(119, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 14);
            this.panel4.TabIndex = 85;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lime;
            this.panel5.Location = new System.Drawing.Point(1159, 722);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(92, 14);
            this.panel5.TabIndex = 85;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(1247, 722);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(85, 14);
            this.panel6.TabIndex = 86;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(1328, 722);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(85, 14);
            this.panel7.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(1063, 739);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Underweight";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(1171, 739);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Healthy";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(1243, 739);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 90;
            this.label9.Text = "Overweight";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(1342, 739);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Obese";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(1187, 643);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 92;
            this.label11.Text = "BMI :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBmi.Location = new System.Drawing.Point(1242, 643);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(50, 25);
            this.lblBmi.TabIndex = 93;
            this.lblBmi.Text = "24.2";
            this.lblBmi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 835);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.trBmi);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BMI";
            this.Text = "Marathon Skills 2015- BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtHeight, 0);
            this.Controls.SetChildIndex(this.txtWeight, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnCalculate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.trBmi, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.lblBmi, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBmi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar trBmi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBmi;
    }
}

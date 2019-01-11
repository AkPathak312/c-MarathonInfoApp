namespace MarathonProject
{
    partial class BMR
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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbmr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblsedentry = new System.Windows.Forms.Label();
            this.lbllight = new System.Windows.Forms.Label();
            this.lblmoderate = new System.Windows.Forms.Label();
            this.lblactive = new System.Windows.Forms.Label();
            this.lblextremely = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rem
            // 
            this.rem.Size = new System.Drawing.Size(771, 36);
            this.rem.Text = "22 Days 18 Hours 34 Minutes 39 Seconds remaining.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(644, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 44);
            this.label2.TabIndex = 53;
            this.label2.Text = "BMR Calculator";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 189);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(833, 121);
            this.flowLayoutPanel2.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(814, 87);
            this.label14.TabIndex = 69;
            this.label14.Text = "BMR stands for Basal Metabolic Rate. The BMR is used as a measure of an adult\'s m" +
    "etabolism, which changes with height, weight, age and a variety of medical facto" +
    "rs.";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = global::MarathonProject.Properties.Resources.female_icon;
            this.pictureBox2.Location = new System.Drawing.Point(535, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::MarathonProject.Properties.Resources.male_icon;
            this.pictureBox1.Location = new System.Drawing.Point(266, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(486, 717);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 53);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(272, 717);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 53);
            this.btnCalculate.TabIndex = 88;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 32);
            this.label6.TabIndex = 87;
            this.label6.Text = "kg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 86;
            this.label5.Text = "cms";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(435, 584);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(135, 38);
            this.txtWeight.TabIndex = 85;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(435, 537);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(135, 38);
            this.txtHeight.TabIndex = 84;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 83;
            this.label4.Text = "Weight :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 82;
            this.label3.Text = "Height :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 32);
            this.label7.TabIndex = 90;
            this.label7.Text = "Age :";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(435, 639);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(135, 38);
            this.txtAge.TabIndex = 91;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(581, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 32);
            this.label8.TabIndex = 92;
            this.label8.Text = "years";
            // 
            // lblbmr
            // 
            this.lblbmr.AutoSize = true;
            this.lblbmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbmr.Location = new System.Drawing.Point(1118, 360);
            this.lblbmr.Name = "lblbmr";
            this.lblbmr.Size = new System.Drawing.Size(0, 38);
            this.lblbmr.TabIndex = 93;
            this.lblbmr.Click += new System.EventHandler(this.lblbmr_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(1064, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 44);
            this.label9.TabIndex = 94;
            this.label9.Text = "Your BMR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(966, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(396, 44);
            this.label10.TabIndex = 95;
            this.label10.Text = "Daily calories burned";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(999, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 32);
            this.label11.TabIndex = 96;
            this.label11.Text = "Sedentry :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(905, 693);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 32);
            this.label12.TabIndex = 97;
            this.label12.Text = "Extremely active :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(973, 652);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 32);
            this.label13.TabIndex = 98;
            this.label13.Text = "Very active :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(890, 610);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(253, 32);
            this.label15.TabIndex = 99;
            this.label15.Text = "Moderately active :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(968, 562);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 32);
            this.label16.TabIndex = 100;
            this.label16.Text = "Light active :";
            // 
            // lblsedentry
            // 
            this.lblsedentry.AutoSize = true;
            this.lblsedentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsedentry.ForeColor = System.Drawing.Color.Blue;
            this.lblsedentry.Location = new System.Drawing.Point(1149, 518);
            this.lblsedentry.Name = "lblsedentry";
            this.lblsedentry.Size = new System.Drawing.Size(0, 32);
            this.lblsedentry.TabIndex = 101;
            // 
            // lbllight
            // 
            this.lbllight.AutoSize = true;
            this.lbllight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllight.ForeColor = System.Drawing.Color.Lime;
            this.lbllight.Location = new System.Drawing.Point(1149, 562);
            this.lbllight.Name = "lbllight";
            this.lbllight.Size = new System.Drawing.Size(0, 32);
            this.lbllight.TabIndex = 102;
            // 
            // lblmoderate
            // 
            this.lblmoderate.AutoSize = true;
            this.lblmoderate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoderate.ForeColor = System.Drawing.Color.Yellow;
            this.lblmoderate.Location = new System.Drawing.Point(1149, 610);
            this.lblmoderate.Name = "lblmoderate";
            this.lblmoderate.Size = new System.Drawing.Size(0, 32);
            this.lblmoderate.TabIndex = 103;
            // 
            // lblactive
            // 
            this.lblactive.AutoSize = true;
            this.lblactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactive.ForeColor = System.Drawing.Color.Red;
            this.lblactive.Location = new System.Drawing.Point(1154, 652);
            this.lblactive.Name = "lblactive";
            this.lblactive.Size = new System.Drawing.Size(0, 32);
            this.lblactive.TabIndex = 104;
            // 
            // lblextremely
            // 
            this.lblextremely.AutoSize = true;
            this.lblextremely.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblextremely.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblextremely.Location = new System.Drawing.Point(1154, 693);
            this.lblextremely.Name = "lblextremely";
            this.lblextremely.Size = new System.Drawing.Size(0, 32);
            this.lblextremely.TabIndex = 105;
            // 
            // BMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 835);
            this.Controls.Add(this.lblextremely);
            this.Controls.Add(this.lblactive);
            this.Controls.Add(this.lblmoderate);
            this.Controls.Add(this.lbllight);
            this.Controls.Add(this.lblsedentry);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblbmr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label7);
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
            this.Name = "BMR";
            this.Text = "Marathon Skills 2015- BMR Calculator";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
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
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtAge, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblbmr, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.lblsedentry, 0);
            this.Controls.SetChildIndex(this.lbllight, 0);
            this.Controls.SetChildIndex(this.lblmoderate, 0);
            this.Controls.SetChildIndex(this.lblactive, 0);
            this.Controls.SetChildIndex(this.lblextremely, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblbmr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblsedentry;
        private System.Windows.Forms.Label lbllight;
        private System.Windows.Forms.Label lblmoderate;
        private System.Windows.Forms.Label lblactive;
        private System.Windows.Forms.Label lblextremely;
    }
}

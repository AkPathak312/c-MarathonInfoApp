namespace MarathonProject
{
    partial class allresult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmarathon = new System.Windows.Forms.ComboBox();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbAge = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(44, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(195, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marathon Skills 2015";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1906, 106);
            this.panel1.TabIndex = 36;
            // 
            // rem
            // 
            this.rem.AutoSize = true;
            this.rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rem.ForeColor = System.Drawing.SystemColors.Control;
            this.rem.Location = new System.Drawing.Point(384, 9);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(255, 36);
            this.rem.TabIndex = 1;
            this.rem.Text = "Time will be here";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.rem);
            this.panel2.Location = new System.Drawing.Point(-4, 784);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1916, 54);
            this.panel2.TabIndex = 37;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(506, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 46);
            this.label2.TabIndex = 38;
            this.label2.Text = "Previous Race Results ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "Marathon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "Race Event :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "Age Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(779, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "Gender :";
            // 
            // cmbmarathon
            // 
            this.cmbmarathon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarathon.FormattingEnabled = true;
            this.cmbmarathon.Items.AddRange(new object[] {
            "Marathon Skills 2011",
            "Marathon Skills 2012",
            "Marathon Skills 2013",
            "Marathon Skills 2014"});
            this.cmbmarathon.Location = new System.Drawing.Point(312, 248);
            this.cmbmarathon.Name = "cmbmarathon";
            this.cmbmarathon.Size = new System.Drawing.Size(233, 24);
            this.cmbmarathon.TabIndex = 43;
            this.cmbmarathon.SelectedIndexChanged += new System.EventHandler(this.cmbmarathon_SelectedIndexChanged);
            // 
            // cmbEvent
            // 
            this.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Items.AddRange(new object[] {
            "Full Marathon",
            "Half Marathon",
            "5km Fun Run"});
            this.cmbEvent.Location = new System.Drawing.Point(312, 322);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(233, 24);
            this.cmbEvent.TabIndex = 44;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(909, 248);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(187, 24);
            this.cmbGender.TabIndex = 45;
            // 
            // cmbAge
            // 
            this.cmbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAge.FormattingEnabled = true;
            this.cmbAge.Items.AddRange(new object[] {
            "< 18",
            "Between 18 and 29",
            "Between 30 and 55",
            "Between 55 and 69",
            "> 70"});
            this.cmbAge.Location = new System.Drawing.Point(909, 322);
            this.cmbAge.Name = "cmbAge";
            this.cmbAge.Size = new System.Drawing.Size(187, 24);
            this.cmbAge.TabIndex = 46;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1165, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 43);
            this.button2.TabIndex = 57;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = "Total Runners :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "Total Runners finished :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1010, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "Average race time :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(256, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 329);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(781, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "label10";
            // 
            // allresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 835);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbAge);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.cmbmarathon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "allresult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2015- Previous Race results";
            this.Load += new System.EventHandler(this.allresult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmarathon;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbAge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
    }
}
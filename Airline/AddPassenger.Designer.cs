﻿namespace Airline
{
    partial class AddPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassenger));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassId = new System.Windows.Forms.TextBox();
            this.passengerTblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet3 = new Airline.AirlineDBDataSet3();
            this.passengerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDbDataSet = new Airline.AirlineDbDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.PassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PassportTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PassAd = new System.Windows.Forms.TextBox();
            this.NationalityCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.passengerTblTableAdapter = new Airline.AirlineDbDataSetTableAdapters.PassengerTblTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.passengerTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTblTableAdapter1 = new Airline.AirlineDBDataSet3TableAdapters.PassengerTblTableAdapter();
            this.passengerTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(220, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Record Passengers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(231, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turkish Airlines";
            // 
            // PassId
            // 
            this.PassId.BackColor = System.Drawing.SystemColors.Control;
            this.PassId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassId", true));
            this.PassId.Location = new System.Drawing.Point(219, 158);
            this.PassId.Name = "PassId";
            this.PassId.Size = new System.Drawing.Size(149, 22);
            this.PassId.TabIndex = 17;
            // 
            // passengerTblBindingSource3
            // 
            this.passengerTblBindingSource3.DataMember = "PassengerTbl";
            this.passengerTblBindingSource3.DataSource = this.airlineDBDataSet3;
            // 
            // airlineDBDataSet3
            // 
            this.airlineDBDataSet3.DataSetName = "AirlineDBDataSet3";
            this.airlineDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerTblBindingSource
            // 
            this.passengerTblBindingSource.DataMember = "PassengerTbl";
            this.passengerTblBindingSource.DataSource = this.airlineDbDataSet;
            // 
            // airlineDbDataSet
            // 
            this.airlineDbDataSet.DataSetName = "AirlineDbDataSet";
            this.airlineDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(29, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Passenger Id";
            // 
            // PassName
            // 
            this.PassName.BackColor = System.Drawing.SystemColors.Control;
            this.PassName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassName", true));
            this.PassName.Location = new System.Drawing.Point(219, 221);
            this.PassName.Name = "PassName";
            this.PassName.Size = new System.Drawing.Size(149, 22);
            this.PassName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(29, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Passenger Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(29, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Passport Number";
            // 
            // PassportTb
            // 
            this.PassportTb.BackColor = System.Drawing.SystemColors.Control;
            this.PassportTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "Passport", true));
            this.PassportTb.Location = new System.Drawing.Point(219, 277);
            this.PassportTb.Name = "PassportTb";
            this.PassportTb.Size = new System.Drawing.Size(149, 22);
            this.PassportTb.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(29, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Passenger Adress";
            // 
            // PassAd
            // 
            this.PassAd.BackColor = System.Drawing.SystemColors.Control;
            this.PassAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassAd", true));
            this.PassAd.Location = new System.Drawing.Point(219, 340);
            this.PassAd.Name = "PassAd";
            this.PassAd.Size = new System.Drawing.Size(149, 22);
            this.PassAd.TabIndex = 22;
            // 
            // NationalityCb
            // 
            this.NationalityCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassNat", true));
            this.NationalityCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalityCb.FormattingEnabled = true;
            this.NationalityCb.Items.AddRange(new object[] {
            "INDIAN",
            "CHINESE",
            "AMERICAN",
            "CONGOLESE",
            "INGERIAN",
            "SPANISH",
            "TURKISH",
            "ETHOPIAN"});
            this.NationalityCb.Location = new System.Drawing.Point(219, 398);
            this.NationalityCb.Name = "NationalityCb";
            this.NationalityCb.Size = new System.Drawing.Size(149, 31);
            this.NationalityCb.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(29, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nationality";
            // 
            // GenderCb
            // 
            this.GenderCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassGend", true));
            this.GenderCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GenderCb.Location = new System.Drawing.Point(219, 457);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(149, 31);
            this.GenderCb.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(29, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Gender";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(247, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 50);
            this.button2.TabIndex = 31;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(683, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 32;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(29, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone";
            // 
            // PhoneTb
            // 
            this.PhoneTb.BackColor = System.Drawing.SystemColors.Control;
            this.PhoneTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassPhone", true));
            this.PhoneTb.Location = new System.Drawing.Point(219, 526);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(149, 22);
            this.PhoneTb.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(207, 671);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 50);
            this.button3.TabIndex = 34;
            this.button3.Text = "View Passengers";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // passengerTblTableAdapter
            // 
            this.passengerTblTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(469, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 50);
            this.button4.TabIndex = 35;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // passengerTblBindingSource1
            // 
            this.passengerTblBindingSource1.DataMember = "PassengerTbl";
            this.passengerTblBindingSource1.DataSource = this.airlineDBDataSet3;
            // 
            // passengerTblTableAdapter1
            // 
            this.passengerTblTableAdapter1.ClearBeforeFill = true;
            // 
            // passengerTblBindingSource2
            // 
            this.passengerTblBindingSource2.DataMember = "PassengerTbl";
            this.passengerTblBindingSource2.DataSource = this.airlineDBDataSet3;
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 768);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NationalityCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PassAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassportTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassName);
            this.Controls.Add(this.PassId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.AddPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PassportTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PassAd;
        private System.Windows.Forms.ComboBox NationalityCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private AirlineDbDataSet airlineDbDataSet;
        private System.Windows.Forms.BindingSource passengerTblBindingSource;
        private AirlineDbDataSetTableAdapters.PassengerTblTableAdapter passengerTblTableAdapter;
        private System.Windows.Forms.Button button4;
        private AirlineDBDataSet3 airlineDBDataSet3;
        private System.Windows.Forms.BindingSource passengerTblBindingSource1;
        private AirlineDBDataSet3TableAdapters.PassengerTblTableAdapter passengerTblTableAdapter1;
        private System.Windows.Forms.BindingSource passengerTblBindingSource3;
        private System.Windows.Forms.BindingSource passengerTblBindingSource2;
    }
}
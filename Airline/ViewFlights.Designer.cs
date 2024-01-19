namespace Airline
{
    partial class ViewFlights
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.flightTblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet3 = new Airline.AirlineDBDataSet3();
            this.label7 = new System.Windows.Forms.Label();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.DstCb = new System.Windows.Forms.ComboBox();
            this.SrcCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Seatnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FlightDGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flightTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTblTableAdapter = new Airline.AirlineDBDataSet3TableAdapters.FlightTblTableAdapter();
            this.flightTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(156, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Scheduled Flights";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(193, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turkish Airlines";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FDate
            // 
            this.FDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.FDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightTblBindingSource3, "FDate", true));
            this.FDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FDate.Location = new System.Drawing.Point(154, 245);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(149, 32);
            this.FDate.TabIndex = 30;
            // 
            // flightTblBindingSource3
            // 
            this.flightTblBindingSource3.DataMember = "FlightTbl";
            this.flightTblBindingSource3.DataSource = this.airlineDBDataSet3;
            // 
            // airlineDBDataSet3
            // 
            this.airlineDBDataSet3.DataSetName = "AirlineDBDataSet3";
            this.airlineDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "TakeofDate";
            // 
            // FcodeTb
            // 
            this.FcodeTb.BackColor = System.Drawing.SystemColors.Control;
            this.FcodeTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightTblBindingSource3, "Fcode", true));
            this.FcodeTb.Location = new System.Drawing.Point(155, 189);
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(149, 22);
            this.FcodeTb.TabIndex = 28;
            // 
            // DstCb
            // 
            this.DstCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightTblBindingSource3, "FDate", true));
            this.DstCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DstCb.FormattingEnabled = true;
            this.DstCb.Items.AddRange(new object[] {
            "Bangalore",
            "Mumbai",
            "Chennai",
            "Delhy",
            "Dubai",
            "Biyar",
            "Madrid",
            "Barcelona",
            "Lagos"});
            this.DstCb.Location = new System.Drawing.Point(449, 246);
            this.DstCb.Name = "DstCb";
            this.DstCb.Size = new System.Drawing.Size(149, 31);
            this.DstCb.TabIndex = 27;
            // 
            // SrcCb
            // 
            this.SrcCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightTblBindingSource3, "Fsrc", true));
            this.SrcCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcCb.FormattingEnabled = true;
            this.SrcCb.Items.AddRange(new object[] {
            "Bangalore",
            "Mumbai",
            "Chennai",
            "Delhy",
            "Dubai",
            "Biyar",
            "Madrid",
            "Barcelona",
            "Lagos"});
            this.SrcCb.Location = new System.Drawing.Point(449, 186);
            this.SrcCb.Name = "SrcCb";
            this.SrcCb.Size = new System.Drawing.Size(149, 31);
            this.SrcCb.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(325, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(349, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(166, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Num of Seats";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Seatnum
            // 
            this.Seatnum.BackColor = System.Drawing.SystemColors.Control;
            this.Seatnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightTblBindingSource3, "FCap", true));
            this.Seatnum.Location = new System.Drawing.Point(310, 326);
            this.Seatnum.Name = "Seatnum";
            this.Seatnum.Size = new System.Drawing.Size(149, 22);
            this.Seatnum.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Flight Code";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 31;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(315, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 50);
            this.button2.TabIndex = 32;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(465, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 34;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(169, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 50);
            this.button4.TabIndex = 33;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FlightDGV
            // 
            this.FlightDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.FlightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDGV.Location = new System.Drawing.Point(17, 511);
            this.FlightDGV.Name = "FlightDGV";
            this.FlightDGV.RowHeadersWidth = 51;
            this.FlightDGV.RowTemplate.Height = 24;
            this.FlightDGV.Size = new System.Drawing.Size(582, 221);
            this.FlightDGV.TabIndex = 35;
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 25);
            this.panel3.TabIndex = 47;
            // 
            // flightTblBindingSource
            // 
            this.flightTblBindingSource.DataMember = "FlightTbl";
            this.flightTblBindingSource.DataSource = this.airlineDBDataSet3;
            // 
            // flightTblTableAdapter
            // 
            this.flightTblTableAdapter.ClearBeforeFill = true;
            // 
            // flightTblBindingSource1
            // 
            this.flightTblBindingSource1.DataMember = "FlightTbl";
            this.flightTblBindingSource1.DataSource = this.airlineDBDataSet3;
            // 
            // flightTblBindingSource2
            // 
            this.flightTblBindingSource2.DataMember = "FlightTbl";
            this.flightTblBindingSource2.DataSource = this.airlineDBDataSet3;
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.DstCb);
            this.Controls.Add(this.SrcCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Seatnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightTblBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.ComboBox DstCb;
        private System.Windows.Forms.ComboBox SrcCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Seatnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView FlightDGV;
        private System.Windows.Forms.Panel panel3;
        private AirlineDBDataSet3 airlineDBDataSet3;
        private System.Windows.Forms.BindingSource flightTblBindingSource;
        private AirlineDBDataSet3TableAdapters.FlightTblTableAdapter flightTblTableAdapter;
        private System.Windows.Forms.BindingSource flightTblBindingSource3;
        private System.Windows.Forms.BindingSource flightTblBindingSource1;
        private System.Windows.Forms.BindingSource flightTblBindingSource2;
    }
}
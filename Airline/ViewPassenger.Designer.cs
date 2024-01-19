namespace Airline
{
    partial class ViewPassenger
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
            this.label6 = new System.Windows.Forms.Label();
            this.PaddTb = new System.Windows.Forms.TextBox();
            this.passengerTblBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet3 = new Airline.AirlineDBDataSet3();
            this.passengerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDbDataSet = new Airline.AirlineDbDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.PpassTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PnameTb = new System.Windows.Forms.TextBox();
            this.PidTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassengerDGV = new System.Windows.Forms.DataGridView();
            this.passengerTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet1 = new Airline.AirlineDBDataSet();
            this.GendCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.natcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.passengerTblTableAdapter = new Airline.AirlineDbDataSetTableAdapters.PassengerTblTableAdapter();
            this.passengerTblTableAdapter1 = new Airline.AirlineDBDataSetTableAdapters.PassengerTblTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PphoneTb = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.passengerTblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTblTableAdapter2 = new Airline.AirlineDBDataSet3TableAdapters.PassengerTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(199, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "View Passengers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(197, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Turkish Airlines";
             //
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(370, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Adress";
            // 
            // PaddTb
            // 
            this.PaddTb.BackColor = System.Drawing.SystemColors.Control;
            this.PaddTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassAd", true));
            this.PaddTb.Location = new System.Drawing.Point(451, 258);
            this.PaddTb.Name = "PaddTb";
            this.PaddTb.Size = new System.Drawing.Size(149, 22);
            this.PaddTb.TabIndex = 30;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(24, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Passport";
            // 
            // PpassTb
            // 
            this.PpassTb.BackColor = System.Drawing.SystemColors.Control;
            this.PpassTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "Passport", true));
            this.PpassTb.Location = new System.Drawing.Point(164, 258);
            this.PpassTb.Name = "PpassTb";
            this.PpassTb.Size = new System.Drawing.Size(149, 22);
            this.PpassTb.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(375, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name";
            // 
            // PnameTb
            // 
            this.PnameTb.BackColor = System.Drawing.SystemColors.Control;
            this.PnameTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassName", true));
            this.PnameTb.Location = new System.Drawing.Point(447, 203);
            this.PnameTb.Name = "PnameTb";
            this.PnameTb.Size = new System.Drawing.Size(149, 22);
            this.PnameTb.TabIndex = 26;
            // 
            // PidTb
            // 
            this.PidTb.BackColor = System.Drawing.SystemColors.Control;
            this.PidTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassId", true));
            this.PidTb.Location = new System.Drawing.Point(164, 200);
            this.PidTb.Name = "PidTb";
            this.PidTb.Size = new System.Drawing.Size(149, 22);
            this.PidTb.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(24, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Passenger Id";
            // 
            // PassengerDGV
            // 
            this.PassengerDGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.PassengerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.PassengerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengerDGV.Location = new System.Drawing.Point(11, 503);
            this.PassengerDGV.Name = "PassengerDGV";
            this.PassengerDGV.RowHeadersWidth = 51;
            this.PassengerDGV.RowTemplate.Height = 24;
            this.PassengerDGV.Size = new System.Drawing.Size(600, 233);
            this.PassengerDGV.TabIndex = 36;
            this.PassengerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PassengerDGV_CellContentClick_1);
            // 
            // passengerTblBindingSource1
            // 
            this.passengerTblBindingSource1.DataMember = "PassengerTbl";
            this.passengerTblBindingSource1.DataSource = this.airlineDBDataSet1;
            // 
            // airlineDBDataSet1
            // 
            this.airlineDBDataSet1.DataSetName = "AirlineDBDataSet";
            this.airlineDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GendCb
            // 
            this.GendCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassGend", true));
            this.GendCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GendCb.FormattingEnabled = true;
            this.GendCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GendCb.Location = new System.Drawing.Point(451, 315);
            this.GendCb.Name = "GendCb";
            this.GendCb.Size = new System.Drawing.Size(149, 31);
            this.GendCb.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(361, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Gender";
            // 
            // natcb
            // 
            this.natcb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassNat", true));
            this.natcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natcb.FormattingEnabled = true;
            this.natcb.Items.AddRange(new object[] {
            "INDIAN",
            "CHINESE",
            "AMERICAN",
            "CONGOLESE",
            "INGERIAN",
            "SPANISH",
            "TURKISH",
            "ETHOPIAN"});
            this.natcb.Location = new System.Drawing.Point(163, 315);
            this.natcb.Name = "natcb";
            this.natcb.Size = new System.Drawing.Size(149, 31);
            this.natcb.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(24, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nationality";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(460, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 44;
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
            this.button4.Location = new System.Drawing.Point(164, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 50);
            this.button4.TabIndex = 43;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(310, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 50);
            this.button2.TabIndex = 42;
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
            this.button1.Location = new System.Drawing.Point(11, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 41;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passengerTblTableAdapter
            // 
            this.passengerTblTableAdapter.ClearBeforeFill = true;
            // 
            // passengerTblTableAdapter1
            // 
            this.passengerTblTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 742);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 26);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 25);
            this.panel3.TabIndex = 46;
            // 
            // PphoneTb
            // 
            this.PphoneTb.BackColor = System.Drawing.SystemColors.Control;
            this.PphoneTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passengerTblBindingSource3, "PassPhone", true));
            this.PphoneTb.Location = new System.Drawing.Point(285, 381);
            this.PphoneTb.Name = "PphoneTb";
            this.PphoneTb.Size = new System.Drawing.Size(149, 22);
            this.PphoneTb.TabIndex = 48;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b.Location = new System.Drawing.Point(183, 381);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(83, 27);
            this.b.TabIndex = 47;
            this.b.Text = "Phone";
            // 
            // passengerTblBindingSource2
            // 
            this.passengerTblBindingSource2.DataMember = "PassengerTbl";
            this.passengerTblBindingSource2.DataSource = this.airlineDBDataSet3;
            // 
            // passengerTblTableAdapter2
            // 
            this.passengerTblTableAdapter2.ClearBeforeFill = true;
            // 
            // ViewPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 768);
            this.Controls.Add(this.PphoneTb);
            this.Controls.Add(this.b);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GendCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.natcb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PassengerDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PaddTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PpassTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnameTb);
            this.Controls.Add(this.PidTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassenger";
            this.Load += new System.EventHandler(this.ViewPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passengerTblBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PaddTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PpassTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PnameTb;
        private System.Windows.Forms.TextBox PidTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PassengerDGV;
        private System.Windows.Forms.ComboBox GendCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox natcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AirlineDbDataSet airlineDbDataSet;
        private System.Windows.Forms.BindingSource passengerTblBindingSource;
        private AirlineDbDataSetTableAdapters.PassengerTblTableAdapter passengerTblTableAdapter;
        private AirlineDBDataSet airlineDBDataSet1;
        private System.Windows.Forms.BindingSource passengerTblBindingSource1;
        private AirlineDBDataSetTableAdapters.PassengerTblTableAdapter passengerTblTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PphoneTb;
        private System.Windows.Forms.Label b;
        private AirlineDBDataSet3 airlineDBDataSet3;
        private System.Windows.Forms.BindingSource passengerTblBindingSource2;
        private AirlineDBDataSet3TableAdapters.PassengerTblTableAdapter passengerTblTableAdapter2;
        private System.Windows.Forms.BindingSource passengerTblBindingSource3;
    }
}
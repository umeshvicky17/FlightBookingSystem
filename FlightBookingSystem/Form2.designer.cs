namespace FlightBookingSystem
{
    partial class Form2
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
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.DataGrid2 = new System.Windows.Forms.DataGrid();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label12
            // 
            this.Label12.ForeColor = System.Drawing.Color.DarkCyan;
            this.Label12.Location = new System.Drawing.Point(46, 429);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(152, 27);
            this.Label12.TabIndex = 51;
            this.Label12.Text = "BookingDetails";
            // 
            // Label11
            // 
            this.Label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.Label11.Location = new System.Drawing.Point(46, 255);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(152, 24);
            this.Label11.TabIndex = 50;
            this.Label11.Text = "FlightDetails";
            // 
            // DataGrid2
            // 
            this.DataGrid2.DataMember = "";
            this.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid2.Location = new System.Drawing.Point(50, 459);
            this.DataGrid2.Name = "DataGrid2";
            this.DataGrid2.Size = new System.Drawing.Size(624, 154);
            this.DataGrid2.TabIndex = 49;
            // 
            // DataGrid1
            // 
            this.DataGrid1.DataMember = "";
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(50, 282);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(624, 144);
            this.DataGrid1.TabIndex = 48;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(560, 232);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(136, 32);
            this.Button2.TabIndex = 47;
            this.Button2.Text = "Showall";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(560, 192);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(136, 32);
            this.Button1.TabIndex = 46;
            this.Button1.Text = "Save";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox8
            // 
            this.TextBox8.Location = new System.Drawing.Point(361, 210);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(111, 33);
            this.TextBox8.TabIndex = 45;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(254, 213);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(112, 24);
            this.Label10.TabIndex = 44;
            this.Label10.Text = "Booking Date";
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(160, 210);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(88, 33);
            this.TextBox7.TabIndex = 43;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(46, 210);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(112, 24);
            this.Label9.TabIndex = 42;
            this.Label9.Text = "Fare";
            // 
            // ComboBox2
            // 
            this.ComboBox2.Items.AddRange(new object[] {
            "Economy",
            "Executive"});
            this.ComboBox2.Location = new System.Drawing.Point(160, 170);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(160, 34);
            this.ComboBox2.TabIndex = 41;
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(46, 173);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(112, 24);
            this.Label8.TabIndex = 40;
            this.Label8.Text = "Class";
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(160, 135);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(312, 33);
            this.TextBox6.TabIndex = 39;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(46, 138);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(112, 24);
            this.Label7.TabIndex = 38;
            this.Label7.Text = "CustName";
            // 
            // TextBox5
            // 
            this.TextBox5.Enabled = false;
            this.TextBox5.Location = new System.Drawing.Point(588, 15);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(122, 33);
            this.TextBox5.TabIndex = 37;
            // 
            // Label6
            // 
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label6.Location = new System.Drawing.Point(488, 17);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(112, 65);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Available Seats";
            // 
            // TextBox4
            // 
            this.TextBox4.Enabled = false;
            this.TextBox4.Location = new System.Drawing.Point(384, 98);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(88, 33);
            this.TextBox4.TabIndex = 35;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(272, 98);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(112, 24);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Destination";
            // 
            // TextBox3
            // 
            this.TextBox3.Enabled = false;
            this.TextBox3.Location = new System.Drawing.Point(160, 98);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(88, 33);
            this.TextBox3.TabIndex = 33;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(46, 98);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(112, 24);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "Source";
            // 
            // TextBox2
            // 
            this.TextBox2.Enabled = false;
            this.TextBox2.Location = new System.Drawing.Point(160, 58);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(312, 33);
            this.TextBox2.TabIndex = 31;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(46, 58);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 24);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Fname";
            // 
            // ComboBox1
            // 
            this.ComboBox1.Location = new System.Drawing.Point(344, 17);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(128, 34);
            this.ComboBox1.TabIndex = 29;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(254, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 24);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "FlightNo";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(160, 18);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(88, 33);
            this.TextBox1.TabIndex = 27;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(46, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 24);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Seatno";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 641);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.DataGrid2);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox8);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.DataGrid DataGrid2;
        internal System.Windows.Forms.DataGrid DataGrid1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox8;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
    }
}
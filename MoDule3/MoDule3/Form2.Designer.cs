namespace MoDule3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_from1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_to1 = new System.Windows.Forms.Label();
            this.lbl_flight1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_date1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_flight2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_date2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_to2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_from2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPassportnumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_addPassenger = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.data_Passengers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_cabin1 = new System.Windows.Forms.Label();
            this.lbl_cabin2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_Birthdate = new System.Windows.Forms.GroupBox();
            this.DateTime_Birthday = new System.Windows.Forms.DateTimePicker();
            this.cbb_passportCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Passengers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cbb_Birthdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // lbl_from1
            // 
            this.lbl_from1.AutoSize = true;
            this.lbl_from1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from1.Location = new System.Drawing.Point(116, 28);
            this.lbl_from1.Name = "lbl_from1";
            this.lbl_from1.Size = new System.Drawing.Size(39, 20);
            this.lbl_from1.TabIndex = 1;
            this.lbl_from1.Text = "CAI";
            this.lbl_from1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
            // 
            // lbl_to1
            // 
            this.lbl_to1.AutoSize = true;
            this.lbl_to1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to1.Location = new System.Drawing.Point(247, 28);
            this.lbl_to1.Name = "lbl_to1";
            this.lbl_to1.Size = new System.Drawing.Size(48, 20);
            this.lbl_to1.TabIndex = 3;
            this.lbl_to1.Text = "AUH";
            this.lbl_to1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_flight1
            // 
            this.lbl_flight1.AutoSize = true;
            this.lbl_flight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flight1.Location = new System.Drawing.Point(953, 28);
            this.lbl_flight1.Name = "lbl_flight1";
            this.lbl_flight1.Size = new System.Drawing.Size(49, 20);
            this.lbl_flight1.TabIndex = 7;
            this.lbl_flight1.Text = "1908";
            this.lbl_flight1.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Flight number:";
            // 
            // lbl_date1
            // 
            this.lbl_date1.AutoSize = true;
            this.lbl_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date1.Location = new System.Drawing.Point(721, 28);
            this.lbl_date1.Name = "lbl_date1";
            this.lbl_date1.Size = new System.Drawing.Size(101, 20);
            this.lbl_date1.TabIndex = 5;
            this.lbl_date1.Text = "11/10/2017";
            this.lbl_date1.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(673, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date:";
            // 
            // lbl_flight2
            // 
            this.lbl_flight2.AutoSize = true;
            this.lbl_flight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flight2.Location = new System.Drawing.Point(953, 30);
            this.lbl_flight2.Name = "lbl_flight2";
            this.lbl_flight2.Size = new System.Drawing.Size(49, 20);
            this.lbl_flight2.TabIndex = 15;
            this.lbl_flight2.Text = "1907";
            this.lbl_flight2.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(849, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Flight number:";
            // 
            // lbl_date2
            // 
            this.lbl_date2.AutoSize = true;
            this.lbl_date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date2.Location = new System.Drawing.Point(721, 30);
            this.lbl_date2.Name = "lbl_date2";
            this.lbl_date2.Size = new System.Drawing.Size(101, 20);
            this.lbl_date2.TabIndex = 13;
            this.lbl_date2.Text = "11/15/2017";
            this.lbl_date2.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(673, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Date:";
            // 
            // lbl_to2
            // 
            this.lbl_to2.AutoSize = true;
            this.lbl_to2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to2.Location = new System.Drawing.Point(247, 30);
            this.lbl_to2.Name = "lbl_to2";
            this.lbl_to2.Size = new System.Drawing.Size(39, 20);
            this.lbl_to2.TabIndex = 11;
            this.lbl_to2.Text = "CAI";
            this.lbl_to2.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(200, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "To:";
            // 
            // lbl_from2
            // 
            this.lbl_from2.AutoSize = true;
            this.lbl_from2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from2.Location = new System.Drawing.Point(116, 30);
            this.lbl_from2.Name = "lbl_from2";
            this.lbl_from2.Size = new System.Drawing.Size(48, 20);
            this.lbl_from2.TabIndex = 9;
            this.lbl_from2.Text = "AUH";
            this.lbl_from2.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "From:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Firstname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(131, 39);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(249, 22);
            this.txtFirstname.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Passport number";
            // 
            // txtPassportnumber
            // 
            this.txtPassportnumber.Location = new System.Drawing.Point(177, 100);
            this.txtPassportnumber.Name = "txtPassportnumber";
            this.txtPassportnumber.Size = new System.Drawing.Size(203, 22);
            this.txtPassportnumber.TabIndex = 19;
            this.txtPassportnumber.TextChanged += new System.EventHandler(this.txtPassportnumber_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(464, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Passport country";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(555, 39);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(221, 22);
            this.txtLastname.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(464, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 17);
            this.label20.TabIndex = 20;
            this.label20.Text = "Lastname";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(916, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 22);
            this.txtPhone.TabIndex = 27;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(861, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "Phone";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(861, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 24;
            this.label22.Text = "Birthdate";
            // 
            // btn_addPassenger
            // 
            this.btn_addPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_addPassenger.Location = new System.Drawing.Point(934, 152);
            this.btn_addPassenger.Name = "btn_addPassenger";
            this.btn_addPassenger.Size = new System.Drawing.Size(188, 33);
            this.btn_addPassenger.TabIndex = 28;
            this.btn_addPassenger.Text = "Add passenger";
            this.btn_addPassenger.UseVisualStyleBackColor = false;
            this.btn_addPassenger.Click += new System.EventHandler(this.btn_addPassenger_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(70, 436);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 17);
            this.label23.TabIndex = 29;
            this.label23.Text = "Passengers list";
            // 
            // data_Passengers
            // 
            this.data_Passengers.AllowUserToAddRows = false;
            this.data_Passengers.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.data_Passengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Passengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.data_Passengers.Location = new System.Drawing.Point(66, 465);
            this.data_Passengers.Name = "data_Passengers";
            this.data_Passengers.RowHeadersWidth = 51;
            this.data_Passengers.RowTemplate.Height = 24;
            this.data_Passengers.Size = new System.Drawing.Size(1171, 198);
            this.data_Passengers.TabIndex = 30;
            this.data_Passengers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Passengers_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Firstname";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lastname";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Birthdate";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Passport number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 170;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Passport Country";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(367, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 41);
            this.button2.TabIndex = 31;
            this.button2.Text = "Back to search for flights";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(693, 696);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(169, 41);
            this.button3.TabIndex = 32;
            this.button3.Text = "Confirm booking";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Location = new System.Drawing.Point(1056, 669);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 30);
            this.button4.TabIndex = 33;
            this.button4.Text = "Remove passenger";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(356, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 17);
            this.label24.TabIndex = 34;
            this.label24.Text = "Cabin Type:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(359, 33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 17);
            this.label25.TabIndex = 35;
            this.label25.Text = "Cabin Type:";
            // 
            // lbl_cabin1
            // 
            this.lbl_cabin1.AutoSize = true;
            this.lbl_cabin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabin1.Location = new System.Drawing.Point(438, 28);
            this.lbl_cabin1.Name = "lbl_cabin1";
            this.lbl_cabin1.Size = new System.Drawing.Size(85, 20);
            this.lbl_cabin1.TabIndex = 36;
            this.lbl_cabin1.Text = "Economy";
            // 
            // lbl_cabin2
            // 
            this.lbl_cabin2.AutoSize = true;
            this.lbl_cabin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabin2.Location = new System.Drawing.Point(439, 30);
            this.lbl_cabin2.Name = "lbl_cabin2";
            this.lbl_cabin2.Size = new System.Drawing.Size(85, 20);
            this.lbl_cabin2.TabIndex = 37;
            this.lbl_cabin2.Text = "Economy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_cabin1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_from1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lbl_to1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_date1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_flight1);
            this.groupBox1.Location = new System.Drawing.Point(66, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1171, 83);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outbound flights details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_date2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lbl_cabin2);
            this.groupBox2.Controls.Add(this.lbl_from2);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbl_to2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbl_flight2);
            this.groupBox2.Location = new System.Drawing.Point(66, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1171, 84);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return flights details";
            // 
            // cbb_Birthdate
            // 
            this.cbb_Birthdate.Controls.Add(this.DateTime_Birthday);
            this.cbb_Birthdate.Controls.Add(this.cbb_passportCountry);
            this.cbb_Birthdate.Controls.Add(this.txtLastname);
            this.cbb_Birthdate.Controls.Add(this.label17);
            this.cbb_Birthdate.Controls.Add(this.txtFirstname);
            this.cbb_Birthdate.Controls.Add(this.label18);
            this.cbb_Birthdate.Controls.Add(this.txtPassportnumber);
            this.cbb_Birthdate.Controls.Add(this.label20);
            this.cbb_Birthdate.Controls.Add(this.label19);
            this.cbb_Birthdate.Controls.Add(this.btn_addPassenger);
            this.cbb_Birthdate.Controls.Add(this.label22);
            this.cbb_Birthdate.Controls.Add(this.txtPhone);
            this.cbb_Birthdate.Controls.Add(this.label21);
            this.cbb_Birthdate.Location = new System.Drawing.Point(66, 220);
            this.cbb_Birthdate.Name = "cbb_Birthdate";
            this.cbb_Birthdate.Size = new System.Drawing.Size(1171, 199);
            this.cbb_Birthdate.TabIndex = 40;
            this.cbb_Birthdate.TabStop = false;
            this.cbb_Birthdate.Text = "Passenger details";
            // 
            // DateTime_Birthday
            // 
            this.DateTime_Birthday.CustomFormat = "MM/dd/yyyy";
            this.DateTime_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime_Birthday.Location = new System.Drawing.Point(933, 40);
            this.DateTime_Birthday.Name = "DateTime_Birthday";
            this.DateTime_Birthday.Size = new System.Drawing.Size(200, 22);
            this.DateTime_Birthday.TabIndex = 30;
            this.DateTime_Birthday.Value = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            // 
            // cbb_passportCountry
            // 
            this.cbb_passportCountry.FormattingEnabled = true;
            this.cbb_passportCountry.Location = new System.Drawing.Point(585, 98);
            this.cbb_passportCountry.Name = "cbb_passportCountry";
            this.cbb_passportCountry.Size = new System.Drawing.Size(191, 24);
            this.cbb_passportCountry.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1271, 799);
            this.Controls.Add(this.cbb_Birthdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data_Passengers);
            this.Controls.Add(this.label23);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking confirmation";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Passengers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cbb_Birthdate.ResumeLayout(false);
            this.cbb_Birthdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_from1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_to1;
        private System.Windows.Forms.Label lbl_flight1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_date1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_flight2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_date2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_to2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_from2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPassportnumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_addPassenger;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView data_Passengers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_cabin1;
        private System.Windows.Forms.Label lbl_cabin2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox cbb_Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cbb_passportCountry;
        private System.Windows.Forms.DateTimePicker DateTime_Birthday;
    }
}
namespace MoDule3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbb_from = new System.Windows.Forms.ComboBox();
            this.cbb_to = new System.Windows.Forms.ComboBox();
            this.cbb_cabin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.data_Rfd = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.data_Ofd = new System.Windows.Forms.DataGridView();
            this.txt_Passengers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime_Return = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Outbound = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_books = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Rfd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ofd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cabin Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Return";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(195, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "One way";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbb_from
            // 
            this.cbb_from.FormattingEnabled = true;
            this.cbb_from.Location = new System.Drawing.Point(172, 30);
            this.cbb_from.Name = "cbb_from";
            this.cbb_from.Size = new System.Drawing.Size(121, 24);
            this.cbb_from.TabIndex = 7;
            this.cbb_from.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbb_to
            // 
            this.cbb_to.FormattingEnabled = true;
            this.cbb_to.Location = new System.Drawing.Point(484, 30);
            this.cbb_to.Name = "cbb_to";
            this.cbb_to.Size = new System.Drawing.Size(170, 24);
            this.cbb_to.TabIndex = 8;
            this.cbb_to.SelectedIndexChanged += new System.EventHandler(this.cbb_to_SelectedIndexChanged);
            // 
            // cbb_cabin
            // 
            this.cbb_cabin.FormattingEnabled = true;
            this.cbb_cabin.Location = new System.Drawing.Point(824, 30);
            this.cbb_cabin.Name = "cbb_cabin";
            this.cbb_cabin.Size = new System.Drawing.Size(121, 24);
            this.cbb_cabin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Outbound flight details:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(886, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(253, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Display three days before and after";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // data_Rfd
            // 
            this.data_Rfd.AllowUserToAddRows = false;
            this.data_Rfd.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.data_Rfd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Rfd.Location = new System.Drawing.Point(43, 467);
            this.data_Rfd.Name = "data_Rfd";
            this.data_Rfd.RowHeadersWidth = 51;
            this.data_Rfd.RowTemplate.Height = 24;
            this.data_Rfd.Size = new System.Drawing.Size(1099, 183);
            this.data_Rfd.TabIndex = 15;
            this.data_Rfd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Rfd_CellClick);
            this.data_Rfd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Return flight details:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(886, 441);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(253, 21);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Display three days before and after";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // data_Ofd
            // 
            this.data_Ofd.AllowUserToAddRows = false;
            this.data_Ofd.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.data_Ofd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Ofd.Location = new System.Drawing.Point(43, 205);
            this.data_Ofd.Name = "data_Ofd";
            this.data_Ofd.RowHeadersWidth = 51;
            this.data_Ofd.RowTemplate.Height = 24;
            this.data_Ofd.Size = new System.Drawing.Size(1099, 164);
            this.data_Ofd.TabIndex = 18;
            this.data_Ofd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Ofd_CellClick_1);
            // 
            // txt_Passengers
            // 
            this.txt_Passengers.Location = new System.Drawing.Point(30, 38);
            this.txt_Passengers.Name = "txt_Passengers";
            this.txt_Passengers.Size = new System.Drawing.Size(100, 22);
            this.txt_Passengers.TabIndex = 19;
            this.txt_Passengers.TextChanged += new System.EventHandler(this.txt_Passengers_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Passengers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime_Return);
            this.groupBox1.Controls.Add(this.dateTime_Outbound);
            this.groupBox1.Controls.Add(this.cbb_from);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbb_to);
            this.groupBox1.Controls.Add(this.cbb_cabin);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Location = new System.Drawing.Point(48, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 146);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Passengers";
            // 
            // dateTime_Return
            // 
            this.dateTime_Return.CustomFormat = "MM/dd/yyyy";
            this.dateTime_Return.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_Return.Location = new System.Drawing.Point(781, 97);
            this.dateTime_Return.Name = "dateTime_Return";
            this.dateTime_Return.Size = new System.Drawing.Size(164, 22);
            this.dateTime_Return.TabIndex = 14;
            this.dateTime_Return.Value = new System.DateTime(2018, 10, 10, 0, 0, 0, 0);
            this.dateTime_Return.ValueChanged += new System.EventHandler(this.dateTime_Return_ValueChanged);
            // 
            // dateTime_Outbound
            // 
            this.dateTime_Outbound.CustomFormat = "MM/dd/yyyy";
            this.dateTime_Outbound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_Outbound.Location = new System.Drawing.Point(502, 96);
            this.dateTime_Outbound.Name = "dateTime_Outbound";
            this.dateTime_Outbound.Size = new System.Drawing.Size(152, 22);
            this.dateTime_Outbound.TabIndex = 13;
            this.dateTime_Outbound.UseWaitCursor = true;
            this.dateTime_Outbound.Value = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            this.dateTime_Outbound.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_books);
            this.groupBox2.Controls.Add(this.txt_Passengers);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(281, 656);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 82);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirm booking for";
            // 
            // btn_books
            // 
            this.btn_books.BackColor = System.Drawing.Color.Lime;
            this.btn_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_books.Image = global::MoDule3.Properties.Resources.tick_yes;
            this.btn_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_books.Location = new System.Drawing.Point(303, 21);
            this.btn_books.Name = "btn_books";
            this.btn_books.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_books.Size = new System.Drawing.Size(197, 44);
            this.btn_books.TabIndex = 21;
            this.btn_books.Text = "Books Flight";
            this.btn_books.UseVisualStyleBackColor = false;
            this.btn_books.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Image = global::MoDule3.Properties.Resources._001_back_arrow;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(394, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Outbound";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Image = global::MoDule3.Properties.Resources._002_back_arrow_1;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(701, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Return";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.Image = ((System.Drawing.Image)(resources.GetObject("btn_apply.Image")));
            this.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apply.Location = new System.Drawing.Point(977, 82);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(94, 38);
            this.btn_apply.TabIndex = 12;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Image = global::MoDule3.Properties.Resources.cancel;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1039, 656);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 39);
            this.button3.TabIndex = 22;
            this.button3.Text = "exit";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1195, 750);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.data_Ofd);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_Rfd);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for flights";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Rfd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ofd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_from;
        private System.Windows.Forms.ComboBox cbb_to;
        private System.Windows.Forms.ComboBox cbb_cabin;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView data_Rfd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridView data_Ofd;
        private System.Windows.Forms.TextBox txt_Passengers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTime_Outbound;
        private System.Windows.Forms.DateTimePicker dateTime_Return;
    }
}


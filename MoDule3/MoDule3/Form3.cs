using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoDule3
{
    public partial class Form3 : Form
    {
        public double totalAmount;

        Form2 Booking;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            this.Close();
        }

        public void setMoney(double money)
        {
            totalAmount = money;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_totalAmount.Text = "[$ " + totalAmount.ToString() + " ]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking.datve();
            MessageBox.Show("Successful ticket booking!", "Message!!!");
            Booking.Close();
            Close();
        }

        public void setBookingForm(Form2 booking)
        {
            Booking = booking;
        }
    }
}

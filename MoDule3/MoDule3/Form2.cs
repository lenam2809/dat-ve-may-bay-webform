using BULs;
using DALs;
using DTOs;
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
    public partial class Form2 : Form
    {
        public int idScheduleOutbound;
        public int idScheduleReturn;
        public string fromOutbound;
        public string fromReturn;
        public string toOutbound;
        public string toReturn;
        public bool checkFlight1;
        public bool checkFlight2;
        public string dateOutbound;
        public string dateReturn;
        public string CabinTypeOutbound;
        public string CabinTypeReturn;
        public string filghtNumberOutbound;
        public string flightNumberReturn;
        public int indexPassengerRemove;

        public double Money;
        public int NumberPassenger;
        public int idCabintype;

        public string format2 = "MM/dd/yyyy";

        FlightDetailBUL flightDetailBUL = new FlightDetailBUL();
        AirportsBUL bulAirports = new AirportsBUL();
        CabinTypesBUL bulCabinTypes = new CabinTypesBUL();
        CountriesBUL bulCountries = new CountriesBUL();
        FlightDetailsDTO flightReturn;
        FlightDetailsDTO flightOutbound;

        TicketsBUL ticketsBUL = new TicketsBUL();
        List<PassengerDTO> listPassenger;



        public Form2()
        {
            InitializeComponent();
            listPassenger = new List<PassengerDTO>();
        }

        public Form2(FlightDetailsDTO flyOutbound, FlightDetailsDTO flyReturn, int numberPassenger, int IDcabin)
        {
            InitializeComponent();
            listPassenger = new List<PassengerDTO>();

            this.flightOutbound = flyOutbound;
            this.flightReturn = flyReturn;
            this.NumberPassenger = numberPassenger;
            this.idCabintype = IDcabin;

            // get name cabin 
            string nameCabin = bulCabinTypes.getNameCabinTypeFromID(idCabintype);
        }

        public void setNumberPassenger(int numberPassenger)
        {
            NumberPassenger = numberPassenger;
        }

        public void setIDcaBin(int idCabin)
        {
            idCabintype = idCabin;
        }

        public void setMoney(double money)
        {
            Money = money;
        }
        // set infor label
        public void setInfor(int id1, int id2, string from1, string to1, string cabin, string date1, int flghtnumber1, bool check1, string from2, string to2, string date2, int flghtnumber2, bool check2)
        {
            idScheduleOutbound = id1;
            fromOutbound = from1;
            toOutbound = to1;
            CabinTypeOutbound = cabin;
            dateOutbound = date1;
            filghtNumberOutbound = flghtnumber1.ToString();
            idScheduleReturn = id2;
            fromReturn = from2;
            toReturn = to2;
            CabinTypeReturn = cabin;
            dateReturn = date2;
            flightNumberReturn =(flghtnumber1 + " - " + flghtnumber2).ToString();
            checkFlight1 = check1;
            checkFlight2 = check2;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (checkFlight2 == false)
            {
                // ẩn infor khứ hồi
                groupBox2.Hide();
                lbl_from1.Text = fromOutbound;
                lbl_to1.Text = toOutbound;
                lbl_cabin1.Text = CabinTypeOutbound;
                lbl_date1.Text = dateOutbound;
                lbl_flight1.Text = filghtNumberOutbound.ToString();

            }
            else
            {
                // Hiển thị infor khứ hồi  
                groupBox1.Show();
                lbl_from1.Text = fromOutbound;
                lbl_to1.Text = toOutbound;
                lbl_cabin1.Text = CabinTypeOutbound;
                lbl_date1.Text = dateOutbound;
                lbl_flight1.Text = filghtNumberOutbound.ToString();

                groupBox2.Show();
                lbl_from2.Text = fromReturn;
                lbl_to2.Text = toReturn;
                lbl_cabin2.Text = CabinTypeReturn;
                lbl_date2.Text = dateReturn;
                lbl_flight2.Text = flightNumberReturn.ToString();
            }

            cbb_passportCountry.DataSource = bulCountries.getCountries();
            cbb_passportCountry.DisplayMember = "Name";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NumberPassenger == listPassenger.Count)
            {
                Form3 form3 = new Form3();
                form3.setBookingForm(this);
                form3.setMoney(Money*NumberPassenger);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Add enough " + NumberPassenger + " passengers, Please!!!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (indexPassengerRemove >= 0 && listPassenger.Count >= 1)
            {
                listPassenger.RemoveAt(indexPassengerRemove);
                hienthiPassenger();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addPassenger_Click(object sender, EventArgs e)
        {

            if (listPassenger.Count > (NumberPassenger-1))
            {
                MessageBox.Show(NumberPassenger.ToString());
                MessageBox.Show("Max passenger!");
            }
            else
            {
                if (txtFirstname.Text.Equals("") || txtLastname.Text.Equals("") || txtPassportnumber.Text.Equals("") || txtPhone.Text.Equals(""))
                {
                    MessageBox.Show("Do not leave any fields blank !");
                }
                else
                {
                    int idpasscountry = bulCountries.getIDCountryFromName(cbb_passportCountry.Text);
                    string name = bulCountries.getNameCountryFromID(idpasscountry);
                    PassengerDTO passengerDTO = new PassengerDTO(txtFirstname.Text, txtLastname.Text, DateTime_Birthday.Value.Date.ToString(format2), txtPassportnumber.Text, cbb_passportCountry.Text, txtPhone.Text, idpasscountry);
                    listPassenger.Add(passengerDTO);
                    MessageBox.Show("Added passenger");
                    clearField();
                    hienthiPassenger();
                }
            }
        }

        // Clear field
        private void clearField()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPassportnumber.Text = "";
            txtPhone.Text = "";
        }

        public void hienthiPassenger()
        {
            data_Passengers.Rows.Clear();
            data_Passengers.ColumnCount = 6;

            int i = 0;
            foreach (PassengerDTO item in listPassenger)
            {
                data_Passengers.Rows.Add();
                data_Passengers.Rows[i].Cells[0].Value = item.FirstName;
                data_Passengers.Rows[i].Cells[1].Value = item.LastName;
                data_Passengers.Rows[i].Cells[2].Value = item.Birthday;
                data_Passengers.Rows[i].Cells[3].Value = item.PassportNumber;
                data_Passengers.Rows[i].Cells[4].Value = item.PassporCountry;
                data_Passengers.Rows[i].Cells[5].Value = item.Phone;
                i++;
            }
        }

        private void data_Passengers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            indexPassengerRemove = row;
        }

        public void datve()
        {
            // duyệt từng pasenger xong đặt vé cho đi hoặc cả đi và về cho từng  passenger
            foreach (PassengerDTO item in listPassenger)
            {
                //   đặt vé cho từng passenger
                if (flightReturn != null)
                {
                    // đặt vé 2 chiều 

                    // đặt vé chiều đi
                    TicketsDTO ticketOutbound = new TicketsDTO(idScheduleOutbound, idCabintype, item.FirstName, item.LastName, item.Phone, item.PassportNumber,Convert.ToInt32(item.IDCountry), getBookingRefrecence());
                    ticketsBUL.addTicket(ticketOutbound);

                    // đặt vé chiều về
                    TicketsDTO ticketReturn = new TicketsDTO(idScheduleReturn, idCabintype, item.FirstName, item.LastName, item.Phone, item.PassportNumber, item.IDCountry, getBookingRefrecence());
                    ticketsBUL.addTicket(ticketReturn);
                }
                else
                {
                    // đặt vé chiều đi
                    TicketsDTO ticket = new TicketsDTO(idScheduleOutbound, idCabintype, item.FirstName, item.LastName, item.Phone, item.PassportNumber, item.IDCountry, getBookingRefrecence());
                    ticketsBUL.addTicket(ticket);
                }
            }
        }

        public string getBookingRefrecence()
        {
            Random rnd = new Random();
            string basestring = "zxcvbnmasdfghjkqwertyuiopl";

            string booking = null;
            do
            {
                for (int i = 0; i < 6; i++)
                {
                    int indexRandom = rnd.Next(0, basestring.Length);
                    booking = booking + basestring[indexRandom];
                }
            } while (ticketsBUL.checkBookingExist(booking));

            return booking;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NumberPassenger.ToString());
        }


        //check number txtPassport
        private void txtPassportnumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassportnumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPassportnumber.Text = txtPassportnumber.Text.Remove(txtPassportnumber.Text.Length - 1);
            }
        }


        //check number txtPhone
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
            }
        }
    }
}

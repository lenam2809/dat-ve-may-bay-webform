using BULs;
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
    public partial class Form1 : Form
    {
        public int numberTotalOutbound;
        public int numberEconomyOutbound;
        public int numberBusinessOutbound;
        public int numberTotalReturn;
        public int numberEconomyReturn;
        public int numberBusinessReturn;
        public int numberPassengers;
        public int numberPeoplesOutbound;
        public int numberPeoplesReturn;

        public int numberTotalOutboundDefault;
        public int numberEconomyOutboundDefault;
        public int numberBusinessOutboundDefault;
        public int numberTotalReturnDefault;
        public int numberEconomyReturnDefault;
        public int numberBusinessReturnDefault;


        public bool checkIdOutbound;
        public bool checkIdReturn;
        public bool checkFlightOutbound;
        public bool checkFlightReturn;
        public bool checkPassengers;

        public string fromReturn;
        public string fromOutbound;
        public string toOutbound;
        public string toReturn;
        public string dateOutbound;
        public string dateReturn;
        public string CabinTypeOutbound;
        public string CabinTypeReturn;
        public int filghtNumberOutbound;
        public int flightNumberReturn;
        public int IDCabin;

        public double moneyPrice;
        public double moneyOutbound;
        public double moneyReturn;
        public int idScheduleOutBound;
        public int idScheduleReturn;
        public string format2 = "MM/dd/yyyy";
        FlightDetailBUL flightDetailBUL = new FlightDetailBUL();
        AirportsBUL bulAirports = new AirportsBUL();
        CabinTypesBUL bulCabinTypes = new CabinTypesBUL();
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // button Exit
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Do you sure you want to exit?", " Exit ", MessageBoxButtons.YesNo);
            if (diaResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Check numberpassengers
        private Boolean checkOfCheckPassengers()
        {
            if (txt_Passengers.Text == "")
            {
                checkPassengers = false;
                MessageBox.Show("Add number passengers");
            }
            else
            {
                numberPassengers = Convert.ToInt32(txt_Passengers.Text);
                CheckPassengersNumber();
            }
            return checkPassengers;
        }

        //Check infor in Flights
        private void CheckIn()
        {
            Form2 booking = new Form2();
            if (checkIdOutbound==true)
            {
                if(checkFlightOutbound==true)
                {
                    if(checkOfCheckPassengers()==true)
                    {
                        booking.setInfor(idScheduleOutBound, idScheduleReturn, fromOutbound, toOutbound, cbb_cabin.Text, dateOutbound, filghtNumberOutbound, checkIdOutbound, fromReturn, toReturn, dateReturn, flightNumberReturn, checkIdReturn);
                        switch (cbb_cabin.Text)
                        {
                            case "Economy":
                                moneyPrice = moneyOutbound;
                                break;
                            case "Business":
                                moneyPrice = moneyOutbound * 0.3 + moneyOutbound;
                                break;
                            case "First Class":
                                moneyPrice = (moneyOutbound * 0.3 + moneyOutbound) * 0.35 + (moneyOutbound * 0.3 + moneyOutbound);
                                break;
                        };
                        numberPassengers = Convert.ToInt32(txt_Passengers.Text);
                        booking.setMoney(moneyPrice);
                        booking.setNumberPassenger(numberPassengers);
                        booking.setIDcaBin(IDCabin);
                        booking.Show();
                    } else
                    {
                        //MessageBox.Show("Add number passengers");
                    }
                } else
                {
                    MessageBox.Show("Choose your flight Outbound!");
                }
            } else if(checkIdReturn == true)
            {                
                    if(checkFlightOutbound==true)
                    {
                        if(checkFlightReturn==true)
                        {
                            if(checkOfCheckPassengers()==true)
                            {
                                booking.setInfor(idScheduleOutBound, idScheduleReturn, fromOutbound, toOutbound, cbb_cabin.Text, dateOutbound, filghtNumberOutbound, checkIdOutbound, fromReturn, toReturn, dateReturn, flightNumberReturn, checkIdReturn);
                                switch (cbb_cabin.Text)
                                {
                                    case "Economy":
                                        moneyPrice = moneyReturn+ moneyOutbound;
                                        //MessageBox.Show(moneyPrice.ToString() + " + " + idScheduleOutBound.ToString());
                                        break;
                                    case "Business":
                                        moneyPrice = (moneyReturn * 0.3 + moneyReturn)+ (moneyOutbound * 0.3 + moneyOutbound);
                                        break;
                                    case "First Class":
                                        moneyPrice = ((moneyReturn * 0.3 + moneyReturn) * 0.35 + (moneyReturn * 0.3 + moneyReturn))+ ((moneyOutbound * 0.3 + moneyOutbound) * 0.35 + (moneyOutbound * 0.3 + moneyOutbound));
                                        break;
                                };
                                //MessageBox.Show("Return");
                                booking.setMoney(moneyPrice);
                                booking.setNumberPassenger(numberPassengers);
                                booking.setIDcaBin(IDCabin);
                                booking.Show();
                            } else
                            {
                                //MessageBox.Show("Add number passengers");
                            }
                        } else
                        {
                            MessageBox.Show("Choose your flight Return!");
                        }
                    } else
                    {
                        MessageBox.Show("Choose your flight Outbound!");
                    } 
            } else
            {
                MessageBox.Show("Choose Flights, please!");
            }
            booking.setMoney(moneyPrice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkIdReturn = true;
                checkIdOutbound = false;
            }
            else if (radioButton2.Checked == true)
            {
                checkIdOutbound = true;
                checkIdReturn = false;
            }

            //MessageBox.Show(((numberEconomyOutboundDefault - numberEconomyOutbound)).ToString());
           //MessageBox.Show(((numberTotalReturnDefault - numberEconomyReturnDefault - numberBusinessReturnDefault) - (numberTotalReturn - numberEconomyReturn - numberBusinessReturn)).ToString());
            CheckIn();
           

        }

        //check so nguoi
        private void CheckPassengersNumber()
        {
            if (checkIdOutbound == true)
            {
                if (cbb_cabin.Text == "Economy")
                {
                    if (numberPassengers < (numberEconomyOutboundDefault - numberEconomyOutbound))
                    {
                        checkPassengers = true;
                    }
                    else
                    {
                        MessageBox.Show("The number of passengers Economy is full!");
                        checkPassengers = false;
                    }
            }
            else if (cbb_cabin.Text == "Business")
            {
                if (numberPassengers < (numberBusinessOutboundDefault - numberBusinessOutbound))
                {
                    checkPassengers = true;
                }
                else
                {
                    MessageBox.Show("The number of passengers Business is full!");
                        checkPassengers = false;
                }
            }
            else if (cbb_cabin.Text == "First Class")
            {
                if (numberPassengers < (numberTotalOutboundDefault - numberEconomyOutboundDefault - numberBusinessOutboundDefault) - (numberTotalOutbound - numberEconomyOutbound- numberBusinessOutbound))
                {
                    checkPassengers = true;
                }
                else
                {
                    MessageBox.Show("The number of passengers First Class is full!");
                        checkPassengers = false;
                }
            }
        }
            else
            {
                if (cbb_cabin.Text == "Economy")
                {
                    if (numberPassengers < (numberEconomyReturnDefault - numberEconomyReturn))
                    {
                        checkPassengers = true;
                    }
                    else
                    {
                        MessageBox.Show("The number of passengers Economy is full!");
                        checkPassengers = false;
                    }
                }
                else if (cbb_cabin.Text == "Business")
                {
                    if (numberPassengers < (numberBusinessReturnDefault - numberBusinessReturn))
                    {
                        checkPassengers = true;
                    }
                    else
                    {
                        MessageBox.Show("The number of passengers Business is full!");
                        checkPassengers = false;
                    }
                }
                else if (cbb_cabin.Text == "First Class")
                {
                    if (numberPassengers < (numberTotalReturnDefault - numberEconomyReturnDefault - numberBusinessReturnDefault) - (numberTotalReturn - numberEconomyReturn - numberBusinessReturn))
                    {
                        checkPassengers = true;
                    }
                    else
                    {
                        MessageBox.Show("The number of passengers First Class is full!");
                        checkPassengers = false;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_from.DataSource = bulAirports.getAirports();
            cbb_from.DisplayMember = "IATACode";
          

            cbb_to.DataSource = bulAirports.getAirports();
            cbb_to.DisplayMember = "IATACode";

            cbb_cabin.DataSource = bulCabinTypes.getCabinTypes();
            cbb_cabin.DisplayMember = "Name";
            cbb_cabin.ValueMember = "ID";

            IDCabin = Convert.ToInt32(cbb_cabin.SelectedValue);
            //textBox1.Text = IDCabin.ToString();

            data_Rfd.DataSource = flightDetailBUL.getFlight(cbb_from.Text, cbb_to.Text, dateTime_Outbound.Value.Date.ToString(format2));

            data_Ofd.DataSource = flightDetailBUL.getFlightReturn(cbb_from.Text, cbb_to.Text, dateTime_Outbound.Value.Date.ToString(format2), dateTime_Outbound.Value.Date.ToString(format2));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        // Button Books Flight
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // ẩn list khứ hồi
                data_Rfd.Hide();
                label7.Hide();
                checkBox2.Hide();
            }
            else
            {
                // Hiển thị list khứ hồi            
                data_Rfd.Show();
                label7.Show();
                checkBox2.Show();
            }
        }

        // Button Apply
        private void btn_apply_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                data_Ofd.DataSource = flightDetailBUL.getFlight(cbb_from.Text, cbb_to.Text, dateTime_Outbound.Value.Date.ToString(format2));
                if (data_Ofd.RowCount > 0)
                {
                    data_Rfd.DataSource = flightDetailBUL.getFlightReturn(cbb_from.Text, cbb_to.Text, dateTime_Outbound.Value.Date.ToString(format2), dateTime_Return.Value.Date.ToString(format2));
                }
            }
            else if (radioButton2.Checked)
            {
                data_Ofd.DataSource = flightDetailBUL.getFlight(cbb_from.Text, cbb_to.Text, dateTime_Outbound.Value.Date.ToString(format2));
            }
        }

        //Click checkbox Return
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                data_Ofd.DataSource = flightDetailBUL.getFlightThreeDayOutbound(cbb_from.Text, cbb_to.Text, dateTime_Outbound.Value.Date.ToString(format2));
            }
            
        }

        //Click checkbox Outbound
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                data_Rfd.DataSource = flightDetailBUL.getFlightThreeDayReturn(cbb_from.Text, cbb_to.Text, dateTime_Outbound.Value.Date.ToString(format2), dateTime_Return.Value.Date.ToString(format2));
            }          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Choose combobox from default
        private void cbb_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbb_to.SelectedIndex = 1;
            
        }

        // Cell Click Outbound
        private void data_Ofd_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id = int.Parse(data_Ofd.Rows[row].Cells[0].Value.ToString());
            numberPeoplesOutbound = flightDetailBUL.getPassengers(id);
            numberEconomyOutbound = flightDetailBUL.getEconomy(id);
            numberBusinessOutbound = flightDetailBUL.getBusiness(id);
            numberTotalOutbound = flightDetailBUL.getTotal(id);

            numberEconomyOutboundDefault = flightDetailBUL.getEconomyDefault(id);
            numberBusinessOutboundDefault = flightDetailBUL.getBusinessDefault(id);
            numberTotalOutboundDefault = flightDetailBUL.getTotalDefault(id);

            moneyOutbound = double.Parse(data_Ofd.Rows[row].Cells[6].Value.ToString());
            idScheduleOutBound = int.Parse(data_Ofd.Rows[row].Cells[0].Value.ToString());
            fromOutbound = data_Ofd.Rows[row].Cells[1].Value.ToString();
            toOutbound = data_Ofd.Rows[row].Cells[2].Value.ToString();
            dateOutbound = data_Ofd.Rows[row].Cells[3].Value.ToString();
            filghtNumberOutbound = int.Parse(data_Ofd.Rows[row].Cells[5].Value.ToString());
            checkFlightOutbound = true;
        }

        // Cell Click Return
        private void data_Rfd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id = int.Parse(data_Rfd.Rows[row].Cells[0].Value.ToString());
            numberPeoplesReturn  = flightDetailBUL.getPassengers(id);
            numberEconomyReturn = flightDetailBUL.getEconomy(id);
            numberBusinessReturn = flightDetailBUL.getBusiness(id);
            numberTotalReturn = flightDetailBUL.getTotal(id);

            numberEconomyReturnDefault = flightDetailBUL.getEconomyDefault(id);
            numberBusinessReturnDefault = flightDetailBUL.getBusinessDefault(id);
            numberTotalReturnDefault = flightDetailBUL.getTotalDefault(id);

            moneyReturn = double.Parse(data_Rfd.Rows[row].Cells[6].Value.ToString());
            idScheduleReturn = int.Parse(data_Rfd.Rows[row].Cells[0].Value.ToString());
            fromReturn = data_Rfd.Rows[row].Cells[1].Value.ToString();
            toReturn = data_Rfd.Rows[row].Cells[2].Value.ToString();
            dateReturn = data_Rfd.Rows[row].Cells[3].Value.ToString();
            flightNumberReturn = int.Parse(data_Rfd.Rows[row].Cells[5].Value.ToString());
            checkFlightReturn = true;
        }

        private void txt_Passengers_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Passengers.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Passengers.Text = txt_Passengers.Text.Remove(txt_Passengers.Text.Length - 1);
            }
        }

        private void dateTime_Return_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

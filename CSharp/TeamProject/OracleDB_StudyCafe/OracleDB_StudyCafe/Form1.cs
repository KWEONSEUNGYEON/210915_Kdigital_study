using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleDB_StudyCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataManager.selectQuery();
            refreshScreen();
           
        }

        void refreshScreen()
        {
            dataGridView_studycafe.DataSource = null;
            try
            {
                if(DataManager.seats.Count > 0)
                {
                    dataGridView_studycafe.DataSource = DataManager.seats;
                    textBox_seatspot.Text = DataManager.seats[0].SeatSpot.ToString();
                    textBox_seatspot_manager.Text = textBox_seatspot.Text;
                    textBox_regisname.Text = DataManager.seats[0].RegisName;
                    textBox_phonenumber.Text = DataManager.seats[0].PhoneNumber;
                    textBox_regismonth.Text = DataManager.seats[0].RegisMonth.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("에러 " + ex.Message + "에러 위치 " + Environment.NewLine + ex.StackTrace);
            }
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox_seatspot.Text == "")
                {
                    MessageBox.Show("좌석번호를 입력하세요.");
                    return;
                }
                if(textBox_regisname.Text == "")
                {
                    MessageBox.Show("성명을 입력하세요.");
                    return;
                }
                StudyCafe seat = DataManager.selectQuery(int.Parse(textBox_seatspot.Text));

                if(seat.RegisName !="")
                {
                    MessageBox.Show("이미 자리가 배정되었습니다.");
                }
                else
                {
                    DataManager.executeQuery("update", textBox_seatspot.Text, textBox_regisname.Text,
                    textBox_phonenumber.Text);
                    DataManager.selectQuery();
                    refreshScreen();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("에러 " + ex.Message + "에러 위치 " + Environment.NewLine + ex.StackTrace);
            }
        }


        private void button_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button_seatmap_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("insert", textBox_seatspot_manager.Text);
            refreshScreen();    
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("delete", textBox_seatspot_manager.Text);
            refreshScreen();
        }

        private void dataGridView_studycafe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudyCafe seat = dataGridView_studycafe.CurrentRow.DataBoundItem as StudyCafe; 
            textBox_seatspot.Text = seat.SeatSpot.ToString();
            textBox_seatspot_manager.Text = textBox_seatspot.Text;

            textBox_regisname.Text = seat.RegisName;
            textBox_phonenumber.Text = seat.PhoneNumber;
            textBox_regismonth.Text = seat.RegisMonth.ToString();

        }

        private void button_out_Click(object sender, EventArgs e)
        {

        }
    }
}

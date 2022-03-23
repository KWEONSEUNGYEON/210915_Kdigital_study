using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        //경계 곡선
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            Color c = Color.FromArgb(224, 229, 236); //배경색
            Color d = Color.FromArgb(91, 91, 91); //글자색
            Color e = Color.FromArgb(109, 109, 109); //listview1 헤드글자색
            Color f = Color.FromArgb(240, 240, 240); //listview1 헤드배경색
            this.BackColor = c;
            this.ForeColor = d;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = d;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //경계 곡선
            textBox1.BackColor = c; textBox2.BackColor = c; textBox3.BackColor = c; textBox4.BackColor = c;
            textBox1.ForeColor = d; textBox2.ForeColor = d; textBox3.ForeColor = d; textBox4.ForeColor = d;
            Data.selectQuery();
            refreshScreen();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.ForeColor = d;
            colorListViewHeader(ref listView1, f, e);
            Log_Info("프로그램 시작");
            listView1.Columns[1].Width = listView1.Width - SystemInformation.VerticalScrollBarWidth; //listview1 횡스크롤바 제거

        }
        //드래그
        private Point mousePoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                     this.Top - (mousePoint.Y - e.Y));
            }
        }
        void refreshScreen()
        {
            dataGridView1.DataSource = null;
            try
            {
                if (Data.cars.Count > 0)
                {
                    dataGridView1.DataSource = Data.cars;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("프로그램을 종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Log_Info("프로그램 종료");
                Dispose(); //종료 버튼
            }
            else
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("테이블을 초기화하시겠습니까?", "테이블 초기화", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Log_Info("테이블 초기화");
                Data.executeQuery("delete", textBox1.Text, "", "", "");
                refreshScreen();
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("주차 공간 번호 입력해 주세요.");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("주차 차량번호 입력해 주세요.");
                    return;
                }
                ParkingCar car = Data.selectQuery(int.Parse(textBox1.Text));
                if (car.CarNumber != "")
                {
                    MessageBox.Show("다른 차량 주차 중");
                }
                else
                {
                    Data.executeQuery("update", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    Log_Info($"공간번호:{textBox1.Text}, 이름:{textBox3.Text}, 차량번호:{textBox2.Text} 주차");
                    refreshScreen();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("주차 공간 번호 입력해 주세요.");
                    return;
                }
                ParkingCar car = Data.selectQuery(int.Parse(textBox1.Text));
                if (car.CarNumber == "")
                {
                    MessageBox.Show("주차된 차량 없음");
                    return;
                }
                else
                {
                    Log_Info($"공간번호:{textBox1.Text}, 이름:{textBox3.Text}, 차량번호:{textBox2.Text} 출차");
                    Data.executeQuery("update", textBox1.Text, "", "", "");
                    refreshScreen();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ParkingCar car = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
            textBox1.Text = car.ParkNum.ToString();
            textBox2.Text = car.CarNumber;
            textBox3.Text = car.DriverName;
            textBox4.Text = car.PhoneNumber;
        }
        public bool Log_Info(string strMsg)
        {
            try
            {
                string strCheckFolder = "";
                string strFileName = "";
                string strLocal = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
                strCheckFolder = strLocal + "\\Log";
                if (!System.IO.Directory.Exists(strCheckFolder))
                {
                    System.IO.Directory.CreateDirectory(strCheckFolder);
                }
                strFileName = strCheckFolder + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                System.IO.StreamWriter FileWriter = new System.IO.StreamWriter(strFileName, true);
                string msg = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " (" + strMsg + ")" + "\r\n";
                FileWriter.Write(msg);
                FileWriter.Flush();
                FileWriter.Close();
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(msg);
                listView1.Items.Insert(0, lvi);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string strLocal = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT 파일(*.txt) | *.txt";
            ofd.InitialDirectory = strLocal + "\\Log";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();

                string strFileName = "";
                strFileName = ofd.FileName;

                if (!System.IO.File.Exists(strFileName))
                {
                    MessageBox.Show("해당 파일이 없거나 선택된 파일이 없습니다.", "확 인", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    string[] strValue = System.IO.File.ReadAllLines(strFileName);

                    for (int i = strValue.Length - 1; i >= 0; i--)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.SubItems.Add(strValue[i]);
                        listView1.Items.Add(lvi);
                    }
                }
            }
        }
        public static void colorListViewHeader(ref ListView list, Color backColor, Color foreColor)  //listview1 색
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => headerDraw(sender, e, backColor, foreColor)
                );
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }

        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)  //listview1 색
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }

        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)  //listview1 색
        {
            e.DrawDefault = true;
        }

    }
}

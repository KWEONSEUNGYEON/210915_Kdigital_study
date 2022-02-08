using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleDB_StudyRoom
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
            dataGridView_studyroom.DataSource = null;
            try
            {
                if(DataManager.rooms.Count > 0)
                {

                }    
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

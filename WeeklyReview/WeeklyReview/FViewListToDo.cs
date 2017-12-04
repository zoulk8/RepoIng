using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyReview
{
    public partial class FViewListToDo : Form
    {
        public FViewListToDo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void FViewListToDo_Load(object sender, EventArgs e)
        {
            //AUMENTAR VALOR DE BARRA DE PROGRESO
            /*
            int status = 3;
            
            progressBarV.Minimum = 0;
            progressBarV.Maximum = 100;

            if (status == 1)
            {
                progressBarV.Value = 10;
            }
            else if (status == 2)
            {
                progressBarV.Value = 50;
            }
            else if (status == 3)
            {
                progressBarV.Value = 100;
            }*/
        }


    }
}

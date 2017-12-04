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
    public partial class FNewRequest : Form
    {
        public FNewRequest()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Establece fecha de TimePicker fija a hoy
            DateTime today = DateTime.Today;
            dateTPInitReq.MinDate = today;
            dateTPFinalReq.MinDate = today;
                        

            // TODO: This line of code loads data into the 'bD_BIPlatformDataSet3.WRCatAsoc' table. You can move, or remove it, as needed.
            this.wRCatAsocTableAdapter1.Fill(this.bD_BIPlatformDataSet3.WRCatAsoc);
            // TODO: This line of code loads data into the 'bD_BIPlatformDataSet1.WRCatPriorityReq' table. You can move, or remove it, as needed.
            this.wRCatPriorityReqTableAdapter.Fill(this.bD_BIPlatformDataSet1.WRCatPriorityReq);
            // TODO: This line of code loads data into the 'bD_BIPlatformDataSet.WRCatAsoc' table. You can move, or remove it, as needed.
            this.wRCatAsocTableAdapter.Fill(this.bD_BIPlatformDataSet.WRCatAsoc);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            string nameReq = "";
            string descReq = "";
            int nameSolicReq =0;
            int priorityReq = 0;
            int assignedUserReq = 0;
            errorNameSol.SetError(cmBSolReq, "");
            errorDReq1.SetError(dateTPInitReq, "");
            errorDReq2.SetError(dateTPFinalReq, "");
            errorPriority.SetError(cmBPriorityReq, "");
            errorUserAssigned.SetError(cmBUsuAsignedReq, "");

            if (!string.IsNullOrEmpty(txtBNameReq.Text))
            {
               nameReq = txtBNameReq.Text; //Nombre de la solicitud
               errorNameReq.SetError(txtBNameReq,"");
            }
            else if(string.IsNullOrEmpty(txtBNameReq.Text))
            {
                 errorNameReq.SetError(txtBNameReq,"*");
            }

            if(!string.IsNullOrEmpty(txtBDescReq.Text))
            {
                descReq = txtBDescReq.Text;
                errorDescReq.SetError(txtBDescReq, "");
            }
            else if (string.IsNullOrEmpty(txtBDescReq.Text))
            {
                errorDescReq.SetError(txtBDescReq, "*");
            }

            

            try
            {
                nameSolicReq = Convert.ToInt32(cmBSolReq.SelectedValue.ToString());
                DateTime dateInit = dateTPInitReq.Value;
                DateTime dateFinal = dateTPFinalReq.Value;
                priorityReq = Convert.ToInt32(cmBPriorityReq.SelectedValue.ToString());
                assignedUserReq = Convert.ToInt32(cmBUsuAsignedReq.SelectedValue.ToString());
            }
            catch
            {
                errorNameSol.SetError(cmBSolReq,"*");
                errorDReq1.SetError(dateTPInitReq,"*");
                errorDReq2.SetError(dateTPFinalReq,"*");
                errorPriority.SetError(cmBPriorityReq,"*");
                errorUserAssigned.SetError(cmBUsuAsignedReq,"*");
            }

            //Variables con valores: nameReq, descReq, nameSolicReq, priorityReq, assignedUserReq,  nameSolicReq
            //Variables:  dateFinal, dateInit
        }

        private int verifyingData( int asocReq)
        { 
           return 0;
        }

        private void dateTPInitReq_ValueChanged(object sender, EventArgs e)
        {
            DateTime max = dateTPInitReq.Value;
            dateTPFinalReq.MinDate = max;
        }





        
    }
}

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
            int nameSolicReq =0 ;
            string dateInitial = "";
            string dateFinal = "";
            string priorityReq = "";
            string asignedUserReq = "";

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

            nameSolicReq = Convert.ToInt32(cmBSolReq.SelectedValue.ToString());

        /*    try
            {

                    DateTime
                    errorNameReq.SetError(txtBNameReq,"");
                
            }
            catch
            { 
               
            }*/
            
            //else if (string.IsNullOrEmpty(txtBNameReq.Text))
            
                
            

           
            
        }

        private int verifyingData( int asocReq)
        { 
           return 0;
        }



        
    }
}

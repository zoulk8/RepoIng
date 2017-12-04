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
    public partial class FEditNewRequest : Form
    {
        public FEditNewRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nameReq = 0;
            string descReq = "";
            int solReq = 0;
            int priority = 0;
            int status = 0;
            errorNameReq.SetError(cmBNameReq, "");
            errorDate1.SetError(TPdateInitial,"");
            errorDate2.SetError(TPFinalDate, "");
            errorSolReq.SetError(cmBSolReq, "");
            errorPriorityReq.SetError(cmBPriorityReq, "");
            errorStatusReq.SetError(cmBStatusReq, "");

            if(!string.IsNullOrEmpty(txtBDescReq.Text))
            {
                descReq = txtBDescReq.Text;
                errorDescReq.SetError(txtBDescReq,"");
            }
            else if(string.IsNullOrEmpty(txtBDescReq.Text))
            {
                errorDescReq.SetError(txtBDescReq, "*");
            }

            try
            {
                nameReq = Convert.ToInt32(cmBNameReq.SelectedValue.ToString());
                solReq = Convert.ToInt32(cmBSolReq.SelectedValue.ToString());
                priority = Convert.ToInt32(cmBPriorityReq.SelectedValue.ToString());
                DateTime dateInit = TPdateInitial.Value;
                DateTime dateFinal = TPFinalDate.Value;
                status = Convert.ToInt32(cmBStatusReq.SelectedValue.ToString());
            }
            catch
            {
                errorNameReq.SetError(cmBNameReq, "*");
                errorSolReq.SetError(cmBSolReq, "*");
                errorPriorityReq.SetError(cmBPriorityReq,"*");
                errorDate1.SetError(TPdateInitial, "*");
                errorDate2.SetError(TPFinalDate, "*");
                errorStatusReq.SetError(cmBStatusReq,"*");
            }

        }

        private void FEditNewRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_DataSetEditStatusReq.WRCatStatus' table. You can move, or remove it, as needed.
            this.wRCatStatusTableAdapter.Fill(this.bD_DataSetEditStatusReq.WRCatStatus);
            // TODO: This line of code loads data into the 'bD_DataSetEditPriorityReq.WRCatPriorityReq' table. You can move, or remove it, as needed.
            this.wRCatPriorityReqTableAdapter.Fill(this.bD_DataSetEditPriorityReq.WRCatPriorityReq);
            // TODO: This line of code loads data into the 'bD_DataSetNameAsoc.WRCatAsoc' table. You can move, or remove it, as needed.
            this.wRCatAsocTableAdapter.Fill(this.bD_DataSetNameAsoc.WRCatAsoc);
            DateTime today = DateTime.Today;
            TPdateInitial.MinDate = today;
            TPFinalDate.MinDate = today;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime minVal = TPdateInitial.Value;
            TPFinalDate.MinDate = minVal;
        }
    }
}

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
    public partial class FEmergenciesAttended : Form
    {
        public FEmergenciesAttended()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FEmergenciesAttended_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_DataSetTypeUrgency.WRTType' table. You can move, or remove it, as needed.
            this.wRTTypeTableAdapter.Fill(this.bD_DataSetTypeUrgency.WRTType);
            DTPDateInital.MinDate = DateTime.Today;
            DTPDateFinalUrg.MinDate = DateTime.Today;
            cmBTypeUrg.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameUrg = "";
            string descUrg = "";
            int typeUrg = 0;
            errorTypeUrg.SetError(cmBTypeUrg, "");
            errorDate1Urg.SetError(DTPDateInital, "");
            errorDate2Urg.SetError(DTPDateFinalUrg, "");

            if(!string.IsNullOrEmpty(txtBNameUrg.Text))
            {
                nameUrg = txtBNameUrg.Text;
                errorNameUrg.SetError(txtBNameUrg, "");
            }
            else if (string.IsNullOrEmpty(txtBNameUrg.Text))
            {
                errorNameUrg.SetError(txtBNameUrg, "*");
            }

            if(!string.IsNullOrEmpty(txtBDescUrg.Text))
            {
                descUrg = txtBDescUrg.Text;
                errorDescUrg.SetError(txtBDescUrg, "");
            }
            else if(string.IsNullOrEmpty(txtBDescUrg.Text))
            {
                errorDescUrg.SetError(txtBDescUrg, "*");
            }

            try
            {
                typeUrg = Convert.ToInt32(cmBTypeUrg.SelectedValue);
                DateTime dateInitialUrg = DTPDateInital.Value;
                DateTime dateFinalUrg = DTPDateFinalUrg.Value;

            }
            catch
            {
                errorTypeUrg.SetError(cmBTypeUrg, "*");
                errorDate1Urg.SetError(DTPDateInital, "*");
                errorDate2Urg.SetError(DTPDateFinalUrg, "*");
            }

            if(!string.IsNullOrEmpty(nameUrg) &&
                !string.IsNullOrEmpty(descUrg))
            {
                MessageBox.Show("La urgencia se ha almacenado correctamente.", "Add Urgency", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(sender,e);
            }
            else
            {
                MessageBox.Show("No fue posible almacenar la urgencia, verifique información.", "Add Urgency", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DTPDateInital_ValueChanged(object sender, EventArgs e)
        {
            DateTime minDate = DTPDateInital.Value;
            DTPDateFinalUrg.MinDate = minDate;
        }

        private void ClearFields(object sender, EventArgs e)
        {
            txtBNameUrg.Text = string.Empty;
            txtBDescUrg.Text = string.Empty;
            this.wRTTypeTableAdapter.Fill(this.bD_DataSetTypeUrgency.WRTType);
            DTPDateInital.MinDate = DateTime.Today;
            DTPDateFinalUrg.MinDate = DateTime.Today;
            cmBTypeUrg.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

    }
}

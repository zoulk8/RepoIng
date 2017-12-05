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
    public partial class FRequirements : Form
    {
        public FRequirements()
        {
            InitializeComponent();
        }

        private void FRequirements_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameComment = "";
            string descComment = "";

            if(!string.IsNullOrEmpty(txtBNameComment.Text))
            {
                errorNameComment.SetError(txtBNameComment, "");
                nameComment = txtBNameComment.Text;
            }
            else if(string.IsNullOrEmpty(txtBNameComment.Text))
            {
                errorNameComment.SetError(txtBNameComment, "* Requerido");
            }

            if(!string.IsNullOrEmpty(txtBDescComment.Text))
            {
                errorNameComment.SetError(txtBDescComment, "");
                descComment = txtBDescComment.Text;
            }
            else if(string.IsNullOrEmpty(txtBDescComment.Text))
            {
                errorDescComment.SetError(txtBDescComment, "* Requerido");
            }

            if (!string.IsNullOrEmpty(nameComment) && !string.IsNullOrEmpty(descComment))
            {
                MessageBox.Show("El rquerimiento ha sido de alta exitosamente","Add Comments/Requirements",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(sender, e);
            }
            else 
            {
                MessageBox.Show("El requerimiento no fue guardado, verifique información","Add Comments/Requirements",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            txtBNameComment.Text = string.Empty;
            txtBDescComment.Text = string.Empty;
            errorDescComment.SetError(txtBDescComment,"");
            errorNameComment.SetError(txtBNameComment,"");
        }
    }
}

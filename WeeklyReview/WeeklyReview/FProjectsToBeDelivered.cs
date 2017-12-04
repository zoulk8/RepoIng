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
    public partial class FProjectsToBeDelivered : Form
    {
        public FProjectsToBeDelivered()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameProject = "";
            string descProject = "";
            string commentsProj = "";
            errorNameProj.SetError(txtBNameProj,"");
            errorDescProj.SetError(txtBDescProj,"");
            errorDate1Proj.SetError(DTPDateInitProj,"");
            errorDate2Proj.SetError(DTPDateFinalProj,"");
            errorCommentsProj.SetError(txtBCommentsProj,"");

            if(!string.IsNullOrEmpty(txtBNameProj.Text))
            {
                nameProject = txtBNameProj.Text;
            }
            else if(string.IsNullOrEmpty(txtBNameProj.Text))
            {
                errorNameProj.SetError(txtBNameProj,"*");
            }

            if(!string.IsNullOrEmpty(txtBDescProj.Text))
            {
                descProject = txtBDescProj.Text;
            }
            else if (string.IsNullOrEmpty(txtBDescProj.Text))
            {
                errorDescProj.SetError(txtBDescProj, "*");
            }

            if(!string.IsNullOrEmpty(txtBCommentsProj.Text))
            {
                commentsProj = txtBCommentsProj.Text;
            }
            else if(string.IsNullOrEmpty(txtBCommentsProj.Text))
            {
                errorCommentsProj.SetError(txtBCommentsProj, "*");
            }

            try
            {
                DateTime initialDate = DTPDateInitProj.Value;
                DateTime finalDate = DTPDateFinalProj.Value;
            }
            catch
            { 
                errorDate1Proj.SetError(DTPDateInitProj,"*");
                errorDate2Proj.SetError(DTPDateFinalProj, "*");
            }

            if(!string.IsNullOrEmpty(nameProject) &&
               !string.IsNullOrEmpty(descProject) &&
               !string.IsNullOrEmpty(commentsProj))
            {
                MessageBox.Show("Su proyecto ha sido dado de alta exitosamente.","Add Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields(sender, e);
            }
            
            
        }

        private void FProjectsToBeDelivered_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DTPDateInitProj.MinDate = today;
            DTPDateFinalProj.MinDate = today;
        }

        private void DTPDateInitProj_ValueChanged(object sender, EventArgs e)
        {
            DateTime minValue = DTPDateInitProj.Value;
            DTPDateFinalProj.MinDate = minValue;
        }

        private void clearFields(object sender, EventArgs e)
        {
            txtBNameProj.Text = string.Empty;
            txtBDescProj.Text = string.Empty;
            txtBCommentsProj.Text = string.Empty;
            DTPDateFinalProj.MinDate = DateTime.Today;
            DTPDateInitProj.MinDate = DateTime.Today;

        }
    }
}

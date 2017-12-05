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
    public partial class FWMTasks : Form
    {
        public FWMTasks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameTask = "";
            string descTask = "";
            int typeTask = 0;

            if(!string.IsNullOrEmpty(txtBNameTask.Text))
            {
                errorNameTask.SetError(txtBNameTask,"");
                nameTask = txtBNameTask.Text;
            }
            else if(string.IsNullOrEmpty(txtBDescTask.Text))
            {
                errorNameTask.SetError(txtBNameTask, "*Requerido");
            }

            if(!string.IsNullOrEmpty(txtBDescTask.Text))
            {
                errorDescTask.SetError(txtBDescTask,"");
                descTask = txtBDescTask.Text;
            }
            else if(string.IsNullOrEmpty(txtBDescTask.Text))
            {
                errorDescTask.SetError(txtBDescTask, "*Requerido");
            }

            try
            {
                errorTypeTask.SetError(cmBTypeTask,"");
                typeTask = Convert.ToInt32(cmBTypeTask.SelectedValue);
            }
            catch
            {
                errorTypeTask.SetError(cmBTypeTask,"Error de base de datos.");
            }

            if(!string.IsNullOrEmpty(nameTask)&&!string.IsNullOrEmpty(descTask)&&typeTask!=0)
            {
                ClearFields(sender,e);
                MessageBox.Show("La tarea ha sido guardada correctamente.", "Add Monthly/Weekly Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La tarea no pudo ser almacenada, favor de verificar.","Add Monthly/Weekly Tasks",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            txtBDescTask.Text = string.Empty;
            txtBNameTask.Text = string.Empty;
            this.wRTTypeTableAdapter.Fill(this.bD_DataSetTypeTasks.WRTType);
        }

        private void FWMTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_DataSetTypeTasks.WRTType' table. You can move, or remove it, as needed.
            this.wRTTypeTableAdapter.Fill(this.bD_DataSetTypeTasks.WRTType);

        }

    }
}

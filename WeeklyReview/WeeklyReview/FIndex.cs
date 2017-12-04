using System;
using System.Management; //Utilizar para obtener usuario local
using System.Security.Principal;
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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FNewRequest f2 = new FNewRequest();
            f2.Show();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            WindowsIdentity nameCurrent = WindowsIdentity.GetCurrent();
            string nameUsu = nameCurrent.Name.ToString();            
            label2.Text = nameUsu;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FEmergenciesAttended emAtt = new FEmergenciesAttended();
            emAtt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FProjectsToBeDelivered pToBeDel = new FProjectsToBeDelivered();
            pToBeDel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FRequirements fReq = new FRequirements();
            fReq.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FWMTasks wMTask = new FWMTasks();
            wMTask.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //FEditNewRequest editNewReq = new FEditNewRequest();
            //editNewReq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FEditProjectsToBeDelivered projToBeDel = new FEditProjectsToBeDelivered();
            projToBeDel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FEditEmergenciesAttended emergAttend = new FEditEmergenciesAttended();
            emergAttend.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FEditRequirements req = new FEditRequirements();
            req.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FEditWMTasks wMTasks = new FEditWMTasks();
            wMTasks.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //IndexForm indF = IndexForm();
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FViewListToDo viewListToDo = new FViewListToDo();
            viewListToDo.Show();
        }


    }
}

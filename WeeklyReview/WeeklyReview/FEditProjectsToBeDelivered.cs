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
    public partial class FEditProjectsToBeDelivered : Form
    {
        public FEditProjectsToBeDelivered()
        {
            InitializeComponent();
        }

        private void FEditProjectsToBeDelivered_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_BIPlatformDataSet5.WRCatStatus' table. You can move, or remove it, as needed.
            this.wRCatStatusTableAdapter.Fill(this.bD_BIPlatformDataSet5.WRCatStatus);
            // TODO: This line of code loads data into the 'bD_BIPlatformDataSet4.WRDetailTasks' table. You can move, or remove it, as needed.
            this.wRDetailTasksTableAdapter.Fill(this.bD_BIPlatformDataSet4.WRDetailTasks);

        }



   
    }
}

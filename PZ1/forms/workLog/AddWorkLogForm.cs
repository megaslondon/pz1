using PZ1.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ1.forms.workLog
{
    public partial class AddWorkLogForm : Form
    {
        private DataSet1 dataSet;
        private string dataPath;
        public AddWorkLogForm(DataSet1 ds, string path)
        {
            this.dataSet = ds;
            this.dataPath = path;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddWorkLogButton_Click(object sender, EventArgs e)
        {

        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using PZ1.db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PZ1.forms.workLog
{
    public partial class AddWorkLogForm : Form
    {
        private DataSet1.WorkerRow selectedWorker;
        private string dataPath;
        private DataSet1 dataSet;
        public AddWorkLogForm(DataSet1 ds, DataSet1.WorkerRow sw, string path)
        {
            this.selectedWorker = sw;
            this.dataPath = path;
            this.dataSet = ds;

            InitializeComponent();
            
            StartTimePicker.MaxDate = DateTime.Now;
            EndTimePicker.MaxDate = DateTime.Now;
        }

        private void AddWorkLogButton_Click(object sender, EventArgs e)
        {
            DataSet1.WorkLogRow newRow = dataSet.WorkLog.NewWorkLogRow();
            newRow.work_description = WorkDescriptionTextBox.Text;
            newRow.started_at = StartTimePicker.Value;
            newRow.ended_at = EndTimePicker.Value;
            newRow.worker_id = (long)WorkerComboBox.SelectedValue;

            if (WorkerComboBox.SelectedValue == null)
            {
                MessageBox.Show("Не выбран работник, который выполнил работу. Попробуйте еще раз!");
                return;
            }

            if (newRow.started_at == null)
            {
                MessageBox.Show("Не выбрана дата начала выполненной работы!");
                return;
            }

            if(newRow.ended_at == null)
            {
                MessageBox.Show("Не выбрана дата конца выполненной работы!");
                return;
            }

            if (newRow.work_description.Length==0)
            {
                MessageBox.Show("Укажите описание выполенной работы!");
                return;
            }

            dataSet.WorkLog.AddWorkLogRow(newRow);
            dataSet.WriteXml(dataPath);
            MessageBox.Show("Данные о выполненной работе были успешно добавлены!");
            this.Close();

        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWorkLogForm_Load(object sender, EventArgs e)
        {
            WorkerComboBox.DataSource = new[] { selectedWorker };
            WorkerComboBox.DisplayMember = "fio";
            WorkerComboBox.ValueMember = "id";
            WorkerComboBox.Enabled = false;

        }
        private void WorkDescriptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool hasRealText = WorkDescriptionTextBox.Text.Any(c => !char.IsControl(c) && !char.IsWhiteSpace(c));

            var key = e.KeyChar;

            if (key == (char)Keys.Enter)
            {
                if (hasRealText) this.ProcessTabKey(true);
                else e.Handled = true;
            }
        }
    }
}

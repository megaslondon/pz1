using PZ1.db;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PZ1.forms.workLog
{
    public partial class EditWorkLogForm : Form
    {
        private DataSet1.WorkLogRow workLogRow;
        private DataSet1.WorkerRow workerRow;
        private DataTable _workersTable;
        private string dataPath;

        public EditWorkLogForm(DataTable workersTable, DataSet1.WorkerRow sw, DataSet1.WorkLogRow row, string path)
        {
            InitializeComponent();
            this.workerRow = sw;
            this._workersTable = workersTable;
            this.workLogRow = row;
            this.dataPath = path;
            this.StartTimePicker.Value = row.started_at;
            this.EndTimePicker.Value = row.ended_at;
            this.WorkDescriptionTextBox.Text = row.work_description;

        }

        private void EditWorkLogForm_Load(object sender, EventArgs e)
        {
            WorkerComboBox.DataSource = _workersTable;
            WorkerComboBox.DisplayMember = "fio";
            WorkerComboBox.ValueMember = "id";
            this.WorkerComboBox.SelectedValue = this.workLogRow.worker_id;
            this.WorkerComboBox.Enabled = false;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWorkLogButton_Click(object sender, EventArgs e)
        {
            workLogRow.work_description = WorkDescriptionTextBox.Text;
            workLogRow.started_at = StartTimePicker.Value;
            workLogRow.ended_at = EndTimePicker.Value;
            workLogRow.worker_id = (long)WorkerComboBox.SelectedValue;

            if (WorkerComboBox.SelectedValue == null)
            {
                MessageBox.Show("Не выбран работник, который выполнил работу. Попробуйте еще раз!");
                return;
            }

            if (workLogRow.started_at == null)
            {
                MessageBox.Show("Не выбрана дата начала выполненной работы!");
                return;
            }

            if (workLogRow.ended_at == null)
            {
                MessageBox.Show("Не выбрана дата конца выполненной работы!");
                return;
            }

            if (workLogRow.work_description.Length == 0)
            {
                MessageBox.Show("Укажите описание выполенной работы!");
                return;
            }

            workLogRow.Table.WriteXml(dataPath);
            MessageBox.Show("Данные о выполненной работе были успешно обновлены!");
            this.Close();
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

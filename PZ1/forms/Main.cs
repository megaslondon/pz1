using PZ1.db;
using PZ1.forms.workers;
using PZ1.forms.workLog;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PZ1.forms
{
    public partial class Main : Form
    {
        private DataSet1 dataSet = new DataSet1();
        private string dataPath = "db.xml";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(dataPath))
            {
                dataSet.ReadXml(dataPath);
            }
            dataGridView1.DataSource = dataSet.Worker;
        }

        private DataSet1.WorkerRow getSelectedWorker()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null) return null;
            var view = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            var row = (DataSet1.WorkerRow)view.Row;
            return row;
        }

        private DataSet1.WorkLogRow getSelectedWorkLog()
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.DataBoundItem == null) return null;
            var view = (DataRowView)dataGridView2.CurrentRow.DataBoundItem;
            var row = (DataSet1.WorkLogRow)view.Row;
            return row;
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm(dataSet, dataPath);
            addWorkerForm.ShowDialog(this);
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void EditWorkerButton_Click(object sender, EventArgs e)
        {
            var selectedWorker = getSelectedWorker();
            if (selectedWorker == null)
            {
                MessageBox.Show("Выберите работника для редактирования!");
                return;
            }
            EditWorkerForm editWorkerForm = new EditWorkerForm(selectedWorker, dataPath);
            editWorkerForm.ShowDialog(this);
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {
            var selectedWorker = getSelectedWorker();
            if (selectedWorker == null)
            {
                MessageBox.Show("Выберите работника для удаления!");
                return;
            }

            var res = MessageBox.Show($"Вы действительно хотите удалить {selectedWorker.fio}?", "Подтверждение", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                selectedWorker.Delete();
                dataSet.WriteXml(dataPath);
                MessageBox.Show("Информация о работнике успешно удалена!");

                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }
        }

        private void AddWorkLogButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("На данный момент нет ни одного работника, которому можно присвоить выполненную работу - список работников пуст!");
                return;
            }
            var selectedWorker = getSelectedWorker();
            if (selectedWorker == null)
            {
                MessageBox.Show("Выберите работника, которому надо добавить работу!");
                return;
            }
            AddWorkLogForm addWorkLogForm = new AddWorkLogForm(dataSet, selectedWorker, dataPath);
            addWorkLogForm.ShowDialog(this);
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void EditWorkLogButton_Click(object sender, EventArgs e)
        {
            var selectedWorker = getSelectedWorker();
            if (selectedWorker == null)
            {
                MessageBox.Show("Выберите работника, которому надо отредактировать работу!");
                return;
            }

            var selectedWorkLog = getSelectedWorkLog();
            if (selectedWorkLog == null)
            {
                MessageBox.Show("На данный момент нет ни одной выбранной работы, которую можно отредактировать!");
                return;
            }

            EditWorkLogForm editWorkLogForm = new EditWorkLogForm(dataSet.Tables["worker"], selectedWorker, selectedWorkLog, dataPath);
            editWorkLogForm.ShowDialog(this);
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void DeleteWorkLogButton_Click(object sender, EventArgs e)
        {
            var selectedWorkLog = getSelectedWorkLog();
            if (selectedWorkLog == null)
            {
                MessageBox.Show("Выберите запись выполненной работы для удаления!");
                return;
            }
            var res = MessageBox.Show($"Вы действительно хотите удалить запись о выполненной работе с id {selectedWorkLog.id}?", "Подтверждение", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                selectedWorkLog.Delete();
                dataSet.WriteXml(dataPath);
                MessageBox.Show("Информация о выполенной работе успешно удалена!");
                dataGridView2.Refresh();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EditWorkerButton.Enabled = dataGridView1.Rows.Count > 0;
            DeleteWorkerButton.Enabled = dataGridView1.Rows.Count > 0;
            AddWorkLogButton.Enabled = dataGridView1.Rows.Count > 0;
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EditWorkLogButton.Enabled = dataGridView2.Rows.Count > 0;
            DeleteWorkLogButton.Enabled = dataGridView2.Rows.Count > 0;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var selectedWorker = getSelectedWorker();
            var view = dataSet.WorkLog.DefaultView;

            if (selectedWorker != null)
            {
                view.RowFilter = $"worker_id = {selectedWorker.id}";
            }
            else
            {
                view.RowFilter = "1=0";
            }
            dataGridView2.DataSource = view;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

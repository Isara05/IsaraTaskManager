using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;

namespace IsaraTaskManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Please enter a task name.");
                return;
            }

            if (cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a priority.");
                return;
            }

            string taskName = txtTaskName.Text.Trim();
            string dueDate = dtpDueDate.Value.ToShortDateString();
            string priority = cmbPriority.SelectedItem?.ToString() ?? "";

            string task =
                $"{taskName} | Due: {dueDate} | Priority: {priority}";

            lstTasks.Items.Add(task);

            SaveTasksToJson();

            txtTaskName.Clear();
            cmbPriority.SelectedIndex = -1;
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);

            SaveTasksToJson();
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to mark as complete.");
                return;
            }

            int index = lstTasks.SelectedIndex;
            string task = lstTasks.SelectedItem?.ToString() ?? "";

            if (!task.StartsWith("[COMPLETED] "))
            {
                lstTasks.Items[index] = "[COMPLETED] " + task;
            }

            SaveTasksToJson();
        }

        private void SaveTasksToJson()
        {
            var tasks = lstTasks.Items
                .Cast<object>()
                .Select(item => item.ToString())
                .ToList();

            string json =
                JsonConvert.SerializeObject(tasks, Formatting.Indented);

            string documentsPath =
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);

            string filePath =
                Path.Combine(documentsPath, "tasks.json");

            File.WriteAllText(filePath, json);
        }



        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FileName = "tasks.csv";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var tasks = lstTasks.Items
                .Cast<object>()
                .Select(item => new
                {
                    Task = item.ToString()
                })
                .ToList();

            using var writer = new StreamWriter(saveFileDialog.FileName);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            csv.WriteRecords(tasks);

            MessageBox.Show("Tasks exported successfully.");
        }
    }
}
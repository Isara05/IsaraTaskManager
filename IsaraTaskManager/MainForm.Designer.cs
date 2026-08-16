namespace IsaraTaskManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTaskName = new TextBox();
            label3 = new Label();
            dtpDueDate = new DateTimePicker();
            label4 = new Label();
            cmbPriority = new ComboBox();
            btnAddTask = new Button();
            lstTasks = new ListBox();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            btnExportCsv = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "TASK MANAGER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 60);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Task Name:";
            label2.Click += label2_Click_1;
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(138, 53);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(197, 27);
            txtTaskName.TabIndex = 2;
            txtTaskName.TextChanged += txtTaskName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 106);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(138, 99);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 158);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 5;
            label4.Text = "Priority:";
            label4.Click += label4_Click;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(138, 150);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(151, 28);
            cmbPriority.TabIndex = 6;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(27, 205);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(27, 256);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(526, 144);
            lstTasks.TabIndex = 8;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(138, 205);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(94, 29);
            btnDeleteTask.TabIndex = 9;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(251, 205);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(189, 29);
            btnCompleteTask.TabIndex = 10;
            btnCompleteTask.Text = "Mark Complete";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(468, 205);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(94, 29);
            btnExportCsv.TabIndex = 11;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportCsv);
            Controls.Add(btnCompleteTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(lstTasks);
            Controls.Add(btnAddTask);
            Controls.Add(cmbPriority);
            Controls.Add(label4);
            Controls.Add(dtpDueDate);
            Controls.Add(label3);
            Controls.Add(txtTaskName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Isara Task Manager";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaskName;
        private Label label3;
        private DateTimePicker dtpDueDate;
        private Label label4;
        private ComboBox cmbPriority;
        private Button btnAddTask;
        private ListBox lstTasks;
        private Button btnDeleteTask;
        private Button btnCompleteTask;
        private Button btnExportCsv;
    }
}

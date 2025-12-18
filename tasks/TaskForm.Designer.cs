namespace tasks
{
    partial class TaskForm
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            cboPriority = new ComboBox();
            cboStatus = new ComboBox();
            btnSave = new Button();
            dtgDueDate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            dtg = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pyidaungsu", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(339, 46);
            label1.TabIndex = 1;
            label1.Text = "Task Management System";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cboPriority);
            panel2.Controls.Add(cboStatus);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(dtgDueDate);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 366);
            panel2.TabIndex = 1;
            // 
            // cboPriority
            // 
            cboPriority.FormattingEnabled = true;
            cboPriority.Location = new Point(79, 186);
            cboPriority.Name = "cboPriority";
            cboPriority.Size = new Size(121, 29);
            cboPriority.TabIndex = 14;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(79, 139);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 29);
            cboStatus.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(79, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 28);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtgDueDate
            // 
            dtgDueDate.Location = new Point(79, 234);
            dtgDueDate.Name = "dtgDueDate";
            dtgDueDate.Size = new Size(200, 28);
            dtgDueDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 240);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 11;
            label6.Text = "Due Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 189);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 8;
            label5.Text = "Priority";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 142);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(79, 85);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(178, 28);
            txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 88);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(79, 40);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(178, 28);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 43);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 0;
            label2.Text = "Task Title";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(dtg);
            panel3.Location = new Point(351, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(433, 366);
            panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(84, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 28);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 0, 192);
            btnEdit.Font = new Font("Pyidaungsu", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(3, 333);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 28);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // dtg
            // 
            dtg.BorderStyle = BorderStyle.None;
            dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg.Location = new Point(3, 3);
            dtg.Name = "dtg";
            dtg.Size = new Size(425, 318);
            dtg.TabIndex = 0;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(6F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(796, 495);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += TaskForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtTitle;
        private DateTimePicker dtgDueDate;
        private Label label6;
        private Label label5;
        private Button btnSave;
        private Panel panel3;
        private DataGridView dtg;
        private Button btnDelete;
        private Button btnEdit;
        private ComboBox cboPriority;
        private ComboBox cboStatus;
    }
}

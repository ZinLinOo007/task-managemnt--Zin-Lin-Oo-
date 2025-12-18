

using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace tasks
{
    public partial class TaskForm : Form
    {
        string connectionString = Program.conntionString;
        public TaskForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Tasks";
                SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                adp.Fill(ds);
                connection.Close();
                dtg.DataSource = ds.Tables[0];
            }
        }

        void clearData()
        {
            txtTitle.Clear();
            txtDescription.Clear();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string status = cboStatus.SelectedItem.ToString();
            string priority = cboPriority.SelectedItem.ToString();
            DateTime dueDate = Convert.ToDateTime(dtgDueDate.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (txtTitle.Text != "")
                {
                    string sql = "INSERT INTO tasks(title,description,status,priority,due_date,created_at,updated_at)" +
                        " values(@title,@description,@status,@priority,@due_date,@created_at,@updated_at)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@priority", priority);
                        cmd.Parameters.AddWithValue("@due_date", dueDate);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Your data saave successfullty!");
                    clearData();
                }
                else
                {
                    MessageBox.Show("Please Fill title!");
                    return;
                }
            }

            LoadData();



        }

        void bindPriorityData()
        {
            cboPriority.Items.Clear();
            cboPriority.Items.Add("Low");
            cboPriority.Items.Add("Medium");
            cboPriority.Items.Add("High");
            cboPriority.SelectedIndex = 0;
        }

        void bindStatusData()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Todo");
            cboStatus.Items.Add("In Progress");
            cboStatus.Items.Add("Done");
            cboStatus.SelectedIndex = 0;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            bindStatusData();
            bindPriorityData();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (dtg.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dtg.SelectedRows[0].Cells["Id"].Value);
                    DialogResult result = MessageBox.Show("Dou you want to delete this data", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        string sql = "Delete from Tasks where id = @id";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }

                        MessageBox.Show("Delete Successfully!");
                        LoadData();
                    }

                }
                else
                {
                    MessageBox.Show("Please Delete Item Select");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dtg.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtg.SelectedRows[0].Cells["Id"].Value);
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "Update Tasks SET title = @title,description = @description," +
                        " status =@status,priority =@priority, due_date = @due_date, created_at = @created_at,updated_at = @updated_at";
                    using(SqlCommand cmd = new SqlCommand(sql,connection))
                    {
                        string title = txtTitle.Text.Trim();
                        string description = txtDescription.Text.Trim();
                        string status = cboStatus.SelectedItem.ToString();
                        string priority = cboPriority.SelectedItem.ToString();
                        DateTime dueDate = Convert.ToDateTime(dtgDueDate.Text);

                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@priority", priority);
                        cmd.Parameters.AddWithValue("@due_date", dueDate);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Update Successfully!");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please Item Select!");
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustWell_Hospital_Doctor
{
    public partial class Form2: Form
    {
        string connString = "server=157.245.99.237;database=focusnet@ae;uid=groupAE;pwd=php@$aelinx_;";

        public Form2()
        {
            InitializeComponent();
            LoadUsers();
           // StyleDataGridView();


        }
        //private void StyleDataGridView()
        //{
        //    dataGridViewUsers.BorderStyle = BorderStyle.None;
        //    dataGridViewUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
        //    dataGridViewUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        //    dataGridViewUsers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
        //    dataGridViewUsers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        //    dataGridViewUsers.BackgroundColor = Color.White;

        //    dataGridViewUsers.EnableHeadersVisualStyles = false;
        //    dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //    dataGridViewUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
        //    dataGridViewUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    dataGridViewUsers.Font = new Font("Segoe UI", 12);
        //}

        private void LoadUsers()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.Columns.Clear();

            dataGridViewUsers.Columns.Add("user_id", "User ID");
            dataGridViewUsers.Columns.Add("name", "Name");
            dataGridViewUsers.Columns.Add("email", "Email");

            var roleColumn = new DataGridViewComboBoxColumn();
            roleColumn.Name = "role";
            roleColumn.HeaderText = "Role";
            roleColumn.Items.AddRange("user", "admin");
            dataGridViewUsers.Columns.Add(roleColumn);

           

            var updateButton = new DataGridViewButtonColumn();
            updateButton.Text = "Update";
            updateButton.UseColumnTextForButtonValue = true;
            updateButton.Name = "update";
            dataGridViewUsers.Columns.Add(updateButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Name = "delete";
            dataGridViewUsers.Columns.Add(deleteButton);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT user_id, name, email, role FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridViewUsers.Rows.Add(
                        reader["user_id"],
                        reader["name"],
                        reader["email"],
                        reader["role"]
                    );
                }


                conn.Close();
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["user_id"].Value);

                if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "update")
                {
                    string newRole = dataGridViewUsers.Rows[e.RowIndex].Cells["role"].Value.ToString();
                    UpdateRole(userId, newRole);
                }
                else if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "delete")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteUser(userId);

                    }
                }
            }
        }
                
          


             private void UpdateRole(int userId, string newRole)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE users SET role = @role WHERE user_id = @user_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@role", newRole);
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Role updated successfully.");
            LoadUsers();
        }

        private void DeleteUser(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM users WHERE user_id = @user_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", userId);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("User deleted successfully.");
            LoadUsers();
        }
    }
}

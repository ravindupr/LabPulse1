using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabPulse
{
    public partial class login : Form
    {
        private string connectionString = "Server=localhost;Database=labpulse_db;Uid=root;Pwd=;";
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailInput = textBox1.Text.Trim();
            string passwordInput = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT Role FROM User WHERE Email = @Email AND Password = @Password";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailInput);
                        cmd.Parameters.AddWithValue("@Password", passwordInput);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string userRole = result.ToString().ToLower().Trim();

                            // Redirect users depending on their assigned Database Role
                            if (userRole == "student")
                            {
                                studentDashboard studentDash = new studentDashboard();
                                studentDash.Show();
                            }
                            else if (userRole == "staff")
                            {
                                staffDashboard staffDash = new staffDashboard();
                                staffDash.Show();
                            }
                            else if (userRole == "admin")
                            {
                                adminDashboard adminDash = new adminDashboard();
                                adminDash.Show();
                            }
                            else
                            {
                                MessageBox.Show("User role not recognized.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            this.Hide(); // Hides the login screen safely
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 welcomePage = new Form1();
            welcomePage.Show();
            this.Hide();
        }
    }
}


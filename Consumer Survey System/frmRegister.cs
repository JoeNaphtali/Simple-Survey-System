﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Consumer_Survey_System
{
    public partial class frmRegister : Form
    {

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\Consumer Survey System\Consumer Survey System\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginform = new frmLogin();
            loginform.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            /* VALIDATE FOR EMPTY FIELDS */

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                // Display error message if user leaves the username text field empty
                MessageBox.Show("Please enter a username.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the username text field so that the user can type their input
                txtUsername.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                // Display error message if user leaves the password text field empty
                MessageBox.Show("Please enter a password.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the password text field so that the user can type their input
                txtPassword.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                // Display error message if user leaves the repeat password text field empty
                MessageBox.Show("Please repeat your password.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the repeat password text field so that the user can type their input
                txtRepeatPassword.Focus();
                // Terminate the event handler
                return;
            }

            /* VALIDATE FOR INVALID INPUTS */

            else if (!Regex.Match(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,32}$").Success)
            {
                // Display an error message if the user enters a password that is less than 8 characters long
                MessageBox.Show("The password you entered is too weak. Your password should contain between 8 and 32 characters, at least one digit, at least one uppercase letter, at least one lowercase letter and at least one special character.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the password text field so that the user can retype their input
                txtPassword.Focus();
                // Terminate the event handler
                return;
            }

            /* CHECK IF PASSWORDS MATCH */

            else if (txtPassword.Text != txtRepeatPassword.Text)
            {
                // Display an error message if the user enters a password that is less than 8 characters long
                MessageBox.Show("Your passwords do not match.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the repeat password text field so that the user can retype their input
                txtRepeatPassword.Focus();
                // Terminate the event handler
                return;
            }
            else
            {
                /* CHECK IF USERNAME ALREADY EXISTS IN USERS TABLE */

                // Open database connection
                con.Open();
                // Select all users with a username that matches the user's input
                cmd = new SqlCommand("SELECT * FROM users WHERE username='" + txtUsername.Text + "'", con);
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                // Close database connection
                con.Close();
                // Check if there is a matching record in the 'users' table
                if (i > 0)
                {
                    // If the record search is positive, display an error message
                    MessageBox.Show("This username address is already taken.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Set focus back the username text field so that the user can retype their input
                    txtUsername.Focus();
                    // Terminate the event handler
                    return;
                }
                else
                {
                    // Insert consumer information into 'users' table
                    cmd = new SqlCommand("INSERT INTO users (username, user_type, password) VALUES ('" + txtUsername.Text + "', 'consumer', '" + txtPassword.Text + "')", con);
                    // Open database connection
                    con.Open();
                    // Execute query
                    cmd.ExecuteNonQuery();
                    // Close database connection
                    con.Close();
                    // Display success message
                    MessageBox.Show("Registration Successful!", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Hide registration form
                    this.Hide();
                    // Display login form
                    var loginform = new frmLogin();
                    loginform.Show();
                }
            }
        }

        private void pbxHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            txtRepeatPassword.PasswordChar = '•';
            pbxHidePassword.Visible = false;
            pbxViewPassword.Visible = true;
        }

        private void pbxViewPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtRepeatPassword.PasswordChar = '\0';
            pbxViewPassword.Visible = false;
            pbxHidePassword.Visible = true;
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?",
                   "Consumer Survey System",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

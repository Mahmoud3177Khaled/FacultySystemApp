using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp
{
    public partial class VerifyAdmin : Form
    {
        public event EventHandler verified;

        public VerifyAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string password = Password.Text;

            
            if (email == "admin" && password == "admin")
            {
                verified?.Invoke(this, EventArgs.Empty);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

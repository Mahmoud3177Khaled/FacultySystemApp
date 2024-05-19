using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin
{
    public partial class UserIDInputForm : Form
    {
        public string UserID { get; private set; }
        private List<string> userIDs;

        public UserIDInputForm(string userType, List<string> userIDs)
        {
            InitializeComponent();
            CenterToScreen();
            label1.Text = $"Enter {userType} ID:";
            this.userIDs = userIDs;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserID = IDs.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UserIDInputForm_Load(object sender, EventArgs e)
        {
            IDs.DataSource = this.userIDs;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.student
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void StudentPageClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

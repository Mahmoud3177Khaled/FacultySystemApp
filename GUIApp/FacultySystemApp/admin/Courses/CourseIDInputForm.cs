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
    public partial class CourseIDInputForm : Form
    {
        private List<string> CourseIDs;

        public string CourseID { get; private set; }

        public CourseIDInputForm(List<string> CourseIDs)
        {
            InitializeComponent();
            CenterToScreen();
            label1.Text = $"Enter Course ID:";
            this.CourseIDs = CourseIDs;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CourseID = IDs.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CourseIDInputForm_Load(object sender, EventArgs e)
        {
            IDs.DataSource = this.CourseIDs;

        }
    }
}

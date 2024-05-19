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
    public partial class DepartmentIDInputForm : Form
    {
        private List<string> DepartmentIDs;

        public string DepartmentID { get; private set; }

        public DepartmentIDInputForm(List<string> DepartmentIDs)
        {
            InitializeComponent();
            CenterToScreen();
            label1.Text = $"Enter Department ID:";
            this.DepartmentIDs = DepartmentIDs;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DepartmentID = IDs.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DepartmentIDInputForm_Load(object sender, EventArgs e)
        {
            IDs.DataSource = this.DepartmentIDs;

        }
    }
}

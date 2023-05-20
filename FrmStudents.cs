using PI_vjezbe_sve.Models;
using PI_vjezbe_sve.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_vjezbe_sve
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }
        private void ShowStudents()
        {
            List<Student> students = StudentRepository.GetStudents();
            FrmStudents.DataSource = students;
            FrmStudents.Columns["Id"].DisplayIndex = 0;
            FrmStudents.Columns["FirstName"].DisplayIndex = 1;
            FrmStudents.Columns["LastName"].DisplayIndex = 2;
            FrmStudents.Columns["Grade"].DisplayIndex = 3;
        }
    }
}

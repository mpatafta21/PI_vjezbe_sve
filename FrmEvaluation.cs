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
    public partial class FrmEvaluation : Form
    {
        private Student student;
        public FrmEvaluation(Models.Student selectedStudent)
        {
            InitializeComponent();
            student = selectedStudent;

        }

        private void FrmEvaluation_Load(object sender, EventArgs e)
        {
            SetFormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;

        }
        private void SetFormText()
        {
            Text = student.FirstName + " " + student.LastName;
        }

    }
}

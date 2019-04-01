using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03
{
    /* Name: Ashton Becher
    * Date: March 13, 2019
    * Project: C03
    * Description: Windows form that implements data linking to modify a ist of student information
    */
    
    public partial class frmAddStudents : Form
    {
        public frmAddStudents()
        {
            InitializeComponent();
        }

        private Student joeStudent = null;

        // Add mode
        public Student GetNewStudent()
        {
            ShowDialog();
            return joeStudent;
        }

        // Update mode
        public Student UpdateStudent(Student student)
        {
            txtStudentID.Text = student.StudentID;
            txtStudentName.Text = student.StudentName;
            txtMidterm.Text = student.MidtermGrade.ToString();
            txtFinal.Text = student.FinalGrade.ToString();

            txtStudentID.ReadOnly = true;
            txtStudentName.ReadOnly = true;

            ShowDialog();

            return joeStudent;
        }

        public bool IsValid()
        {
            return Validator.IsPresent(txtStudentID) && Validator.IsPresent(txtStudentName) &&
                Validator.IsPresent(txtMidterm) && Validator.IsPresent(txtFinal) &&

                Validator.IsInt32(txtStudentID) && Validator.IsInt32(txtMidterm) && Validator.IsInt32(txtFinal) &&
                
                Validator.IsWithinRange(txtStudentID, 1, 999999) && Validator.IsWithinRange(txtMidterm, 0, 100) && Validator.IsWithinRange(txtFinal, 0, 100);
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
           if (IsValid())
             {
                joeStudent = new Student();
                joeStudent.StudentID = txtStudentID.Text;
                joeStudent.StudentName = txtStudentName.Text;
                joeStudent.MidtermGrade = Convert.ToInt32(txtMidterm.Text);
                joeStudent.FinalGrade = Convert.ToInt32(txtFinal.Text);
                Close();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
     * Description: Windows for that inplements data linking to modify a ist of student information
     */

    public partial class frmStudents : Form
    {
        // the internal list
        List<Student> students = new List<Student>();

        public frmStudents()
        {
            InitializeComponent();
        }

        private void FillStudentListBox()
        {
            lstStudents.Items.Clear();
            foreach (Student s in students)
            {
                lstStudents.Items.Add(s.DisplayStudentInfo(4));
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmAddStudents addForm = new frmAddStudents();
            Student s = addForm.GetNewStudent();

            if (s != null)
            {
                students.Add(s);
                StudentDB.SaveStudents(students);
                FillStudentListBox();
            }
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            students = StudentDB.GetStudents();
            FillStudentListBox();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int x = lstStudents.SelectedIndex;

            if (x != -1)
            {
                Student student = students[x];
                frmAddStudents updateForm = new frmAddStudents();
                student = updateForm.UpdateStudent(student);

                if (student != null)
                {
                    students[x].MidtermGrade = student.MidtermGrade;
                    students[x].FinalGrade = student.FinalGrade;
                    StudentDB.SaveStudents(students);
                    FillStudentListBox();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update", "Error");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = lstStudents.SelectedIndex;

            if (x != -1)
            {
                Student student = students[x];
                DialogResult result = MessageBox.Show("Are you sure you want to delete" + "\n" + student.StudentID + "\t" + student.StudentName, "Confirm Delete", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    students.Remove(student);
                    StudentDB.SaveStudents(students);
                    FillStudentListBox();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DisplayStudent : Form
    {
        public DisplayStudent()
        {
            InitializeComponent();
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterStudent f= new RegisterStudent();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData(string searchName="")
        {
            try
            {
                DBConnection db = new DBConnection();
                DataTable dt = db.GetData("select * from student");
                List <Student> students = new List<Student>();
                foreach (DataRow dr in dt.Rows)
                {
                    Student s = new Student();
                    s.Id = Convert.ToInt32( dr["Id"]);
                    s.Name = Convert.ToString(dr["Name"]);
                    s.Email = Convert.ToString(dr["Email"]);
                    s.Address = Convert.ToString(dr["Address"]);
                    students.Add(s);
                }
                if (!string.IsNullOrEmpty(searchName)) 
                {
                    //List<Student> searchStudents = students.Where(s=>s.Name.Contains(searchName)).ToList(); 
                    List<Student> searchStudents = (from s in students where s.Name.Contains (searchName) select s).ToList(); //LINQ
                    dataGridView1.DataSource = searchStudents;
                }
                else
                {
                    dataGridView1.DataSource = students;
                }

                //dataGridView1.DataSource = 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "Delete Confirm", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        string query = "DELETE FROM Student WHERE id=" + id;
                        DBConnection db = new DBConnection();
                        db.ExecuteQuery(query);
                        MessageBox.Show("Successfully deleted");
                        LoadData();
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    EditData(id);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditData(int id)
        {
            try
            {
                RegisterStudent editForm = new RegisterStudent();
                editForm.studentID= id;
                editForm.LoadDataForEditing(id);
                editForm.ShowDialog();
                
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            LoadData(name);
        }
    }
}

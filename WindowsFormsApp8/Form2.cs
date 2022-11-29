using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public List<Student> Students = new List<Student>
        {
            new Student
            {
                 Id=1,
                  Age=25,
                   Name="Huseyn"
            },
             new Student
            {
                 Id=2,
                  Age=19,
                   Name="Leyla"
            },
               new Student
            {
                 Id=3,
                  Age=35,
                   Name="Gulay"
            },
        };
        public Form2()
        {
            InitializeComponent();
            //listBox1.DataSource = Students;
            //listBox1.DisplayMember = nameof(Student.Name);
            listBox1.Items.AddRange(Students.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as Student;
            //  MessageBox.Show($"{item.Name}");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
            List<Student> students = new List<Student>();

            foreach (var item in listBox1.SelectedItems)
            {
                if (item is Student s)
                {
                    students.Add(s);
                }
            }

                listBox1.Items.Clear();

            listBox2.DataSource=(students.ToArray());


            }
            catch (Exception ex)
            {
            }
        }
    }
}

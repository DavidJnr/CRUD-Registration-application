using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelgiumCampusRegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataHandler handler = new DataHandler();
        Student student = new Student();

        private void button1_Click(object sender, EventArgs e)
        {
            student.StudentID = int.Parse(textBox1.Text);
            student.Name = textBox2.Text;
            student.Lastname = textBox3.Text;
            student.CourseID = textBox4.Text;

            handler.Register(student.StudentID, student.Name, student.Lastname, student.CourseID);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            student.StudentID = int.Parse(textBox1.Text);
            student.Name = textBox2.Text;
            student.Lastname = textBox3.Text;
            student.CourseID = textBox4.Text;

            handler.Update(student.StudentID, student.Name, student.Lastname, student.CourseID);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteForm d = new DeleteForm();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm s = new SearchForm();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

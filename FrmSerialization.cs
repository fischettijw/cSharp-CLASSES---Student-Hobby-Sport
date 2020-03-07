using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace cSharp___CLASSES___Student__Hobby__Sport
{
    public partial class FrmSerialization : Form
    {
        static List<Sport> sportList = new List<Sport>();
        static List<Hobby> hobbyList = new List<Hobby>();
        static List<Student> studentList = new List<Student>();
        public FrmSerialization()
        {
            InitializeComponent();
        }

        private void FrmSerialization_Load(object sender, EventArgs e)
        {
            TxtNumSports.Text = "0";
            TxtNumHobbies.Text = "0";
            TxtNumStudents.Text = "0";

        }

        private void BtnAddSport_Click(object sender, EventArgs e)
        {
            if (!Sport.Contains("Football"))
            {
                sportList.Add(new Sport("Football", true, 'M'));
            }
            else
            {
                MessageBox.Show($"Football already exist!");
            }

            if (!Sport.Contains("Soccer")) { sportList.Add(new Sport("Soccer", true, 'B')); }
            if (!Sport.Contains("Tennis")) { sportList.Add(new Sport("Tennis", true, 'B')); }
            if (!Sport.Contains("Baseball")) { sportList.Add(new Sport("Baseball", true, 'M')); }
            if (!Sport.Contains("Swimming")) { sportList.Add(new Sport("Swimming", false, 'B')); }
            if (!Sport.Contains("Softball")) { sportList.Add(new Sport("Softball", true, 'F')); }
            if (!Sport.Contains("Bowling")) { sportList.Add(new Sport("Bowling", false, 'B')); }


            TxtNumSports.Text = Convert.ToString(Sport.numOfSports);
            CbxSport.Items.Clear();
            foreach (Sport s in sportList)
            {
                CbxSport.Items.Add(s.Name);
            }
}

private void BtnAddHobby_Click(object sender, EventArgs e)
{
    if (!Hobby.Contains("Computers"))
    {
        hobbyList.Add(new Hobby("Computers"));
    }
    else
    {
        MessageBox.Show("Computers already exist!");
    }
    if (!Hobby.Contains("Stamps")) { hobbyList.Add(new Hobby("Stamps")); }
    if (!Hobby.Contains("Coins")) { hobbyList.Add(new Hobby("Coins")); }
    if (!Hobby.Contains("Baseball Cards")) { hobbyList.Add(new Hobby("Baseball Cards")); }

    TxtNumHobbies.Text = Convert.ToString(Hobby.numOfHobbies);
    CbxHobby.Items.Clear();
    foreach (Hobby h in hobbyList)
    {
        CbxHobby.Items.Add(h.Name);
    }
}

private void BtnAddStudent_Click(object sender, EventArgs e)
{
    if (!Student.Contains("John Smith"))
    {
        studentList.Add(new Student("John Smith", 10, 15));
    }
    else
    {
        MessageBox.Show("John Smith already exist!");
    }
    if (!Student.Contains("Joseph Duby")) { studentList.Add(new Student("Joseph Duby", 9, 14)); }
    if (!Student.Contains("Mary Harris")) { studentList.Add(new Student("Mary Harris", 10, 15)); }
    if (!Student.Contains("Ellen Bally")) { studentList.Add(new Student("Ellen Bally", 12, 17)); }

    TxtNumStudents.Text = Convert.ToString(Student.numOfStudents);
    CbxStudent.Items.Clear();
    foreach (Student s in studentList)
    {
        CbxStudent.Items.Add(s.Name);
    }
}

private void BtnExit_Click(object sender, EventArgs e)
{
    Application.Exit();
}
    }
}

using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {

        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_Voorraad.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_Voorraad.Hide();

                // show students
                pnl_Students.Show();



                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Items.Clear();

                listViewStudents.View = View.Details;

                foreach (SomerenModel.Student s in studentList)
                {

                    ListViewItem la = new ListViewItem(s.Number.ToString());
                    la.SubItems.Add(s.Name);
                    la.SubItems.Add(s.BirthDate.ToString("dd/MM/yyyy"));

                    listViewStudents.Items.Add(la);


                }
            }
            else if (panelName == "Teachers")
            {
                pnl_Students.Hide();
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Voorraad.Hide();

                pnl_Teachers.Show();

                SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teachService.GetTeachers();

                listViewTeachers.Items.Clear();

                listViewTeachers.View = View.Details;

                foreach (SomerenModel.Teacher t in teacherList)
                {

                    ListViewItem ti = new ListViewItem(t.Number.ToString());
                    ti.SubItems.Add(t.Name);
                    listViewTeachers.Items.Add(ti);
                }
            }
            else if (panelName == "Rooms")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Students.Hide();
                pnl_Voorraad.Hide();

                pnl_Rooms.Show();

                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRooms();

                listViewRooms.Items.Clear();

                listViewRooms.View = View.Details;
                
                
                foreach (SomerenModel.Room r in roomList)
                {

                    ListViewItem ri = new ListViewItem(r.Number.ToString());
                    ri.SubItems.Add(r.Capacity.ToString());
                    if (r.Type) ri.SubItems.Add("Teachers");
                    else ri.SubItems.Add("Students");

                    listViewRooms.Items.Add(ri);


                }
            }
            else if (panelName == "Voorraad")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Students.Hide();
                pnl_Rooms.Hide();

                pnl_Voorraad.Show();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void voorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Voorraad");
        }
    }
}

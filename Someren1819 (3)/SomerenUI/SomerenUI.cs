﻿using SomerenLogic;
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
                pnl_Drankvoorraad.Hide();
                pnl_veranderVoorraad.Hide();
                pnl_Kassa.Hide();

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
                pnl_Drankvoorraad.Hide();
                pnl_veranderVoorraad.Hide();
                pnl_Kassa.Hide();

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
                pnl_Drankvoorraad.Hide();
                pnl_veranderVoorraad.Hide();
                pnl_Kassa.Hide();

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
                pnl_Drankvoorraad.Hide();
                pnl_veranderVoorraad.Hide();
                pnl_Kassa.Hide();

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
            else if (panelName == "Drankvoorraad")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_Students.Hide();
                pnl_veranderVoorraad.Hide();
                pnl_Kassa.Hide();

                pnl_Drankvoorraad.Show();

                SomerenLogic.Drankje_Service drankjeService = new SomerenLogic.Drankje_Service();
                List<Drankje> drankjeList = drankjeService.GetDrankjes();

                listViewDrankvoorraad.Items.Clear();

                listViewDrankvoorraad.View = View.Details;

                foreach (SomerenModel.Drankje d in drankjeList)
                {

                    ListViewItem dr = new ListViewItem(d.Drankjes_ID.ToString());
                    dr.SubItems.Add(d.DrankjeNaam);
                    dr.SubItems.Add(d.DrankjePrijs.ToString());
                    dr.SubItems.Add(d.Voorraad.ToString());
                    listViewDrankvoorraad.Items.Add(dr);
                }

            }
            else if (panelName == "WijzigDrankvoorraad")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_Students.Hide();
                pnl_Drankvoorraad.Show();
                pnl_Kassa.Hide();

                pnl_veranderVoorraad.Show();


            }
            else if (panelName == "Kassa")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();
                pnl_Rooms.Hide();
                pnl_Drankvoorraad.Hide();
                pnl_veranderVoorraad.Hide();
                pnl_Students.Hide();
                listViewKassa2.Hide();

                // show students
                pnl_Kassa.Show();



                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService2 = new SomerenLogic.Student_Service();
                List<Student> studentList2 = studService2.GetStudents();

                SomerenLogic.Drankje_Service drankjeService2 = new SomerenLogic.Drankje_Service();
                List<Drankje> drankjeList2 = drankjeService2.GetAllDrankjes();

                // clear the listview before filling it again
                listViewKassa1.Items.Clear();
                listViewKassa2.Items.Clear();

                listViewKassa1.View = View.Details;
                listViewKassa2.View = View.Details;

                foreach (SomerenModel.Student sk in studentList2)
                {
                    ListViewItem lsk = new ListViewItem(sk.Name);

                    listViewKassa1.Items.Add(lsk);
                }

                foreach (SomerenModel.Drankje dk in drankjeList2)
                {
                    ListViewItem ldk = new ListViewItem(dk.DrankjeNaam);

                    listViewKassa2.Items.Add(ldk);
                }
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

        }

        private void drankvoorraadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drankvoorraad");
        }

        private void btn_wijzigDrankvoorraad_Click(object sender, EventArgs e)
        {
            showPanel("WijzigDrankvoorraad");
        }
        private void btnVerander_Click(object sender, EventArgs e)
        {
            int drankjeID = int.Parse(txtDrankID.Text);
            int drankjeVoorraad = int.Parse(txtDrankjeVoorraad.Text);

            SomerenLogic.Drankje_Service drankjeService = new SomerenLogic.Drankje_Service();
            drankjeService.ChangeVoorraad(drankjeID, drankjeVoorraad);

            showPanel("Drankvoorraad");
        }

        private void lbl_veranderen_Click(object sender, EventArgs e)
        {

        }

        private void kassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Kassa");
        }

        private void listViewKassa1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewKassa2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntNextKassa_Click(object sender, EventArgs e)
        {

            
        }

        private void btnKassa_Click(object sender, EventArgs e)
        {

            if (listViewKassa2.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please enter 1 beverage");
            }
            else if (listViewKassa2.CheckedItems.Count == 1)
            {
                string[] naamDrankje = listViewKassa2.CheckedItems[0].ToString().Split('{');
                string[] naamStudent = listViewKassa1.CheckedItems[0].ToString().Split('{');
                naamDrankje = naamDrankje[1].Split('}');
                naamStudent = naamStudent[1].Split('}');
                if (listViewKassa1.CheckedItems.Count == 1 && listViewKassa2.CheckedItems.Count == 1)
                {
                    SomerenLogic.Transactie_Service transactieService = new SomerenLogic.Transactie_Service();
                    Drankje_Service drankjeService = new Drankje_Service();
                    Drankje drankje = drankjeService.GetDrankjeByName(naamDrankje[0]);
                    Student_Service studentService = new Student_Service();
                    Student student = studentService.GetStudentByName(naamStudent[0]);
                    Transactie transactie = new Transactie()
                    {
                        GewenstDrankje = drankje,
                        Student = student
                    };
                    transactieService.InstertTransactie(transactie);
                }
                showPanel("Kassa");
            }
            else if (listViewKassa2.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please enter a beverage");
            }
        }

        private void btnKassaCancel_Click(object sender, EventArgs e)
        {
            showPanel("Kassa");
        }

        private void bntNextKassa_Click_1(object sender, EventArgs e)
        {

            if (listViewKassa1.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please enter 1 student");
            }
            else if (listViewKassa1.CheckedItems.Count == 1)
            {
                listViewKassa2.Show();
            }
            else if (listViewKassa1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please enter a student");
            }
        }
    }
}
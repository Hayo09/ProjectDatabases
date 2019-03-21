namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnl_Teachers = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.teacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.pnl_Rooms = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.KamerNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capaciteit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KamerType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.barDienstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drankvoorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omzetrapportageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Drankvoorraad = new System.Windows.Forms.Panel();
            this.listViewDrankvoorraad = new System.Windows.Forms.ListView();
            this.Drankje_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrankjeNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VerkoopPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_Drankvoorraad = new System.Windows.Forms.Label();
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_Drankvoorraad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(1672, 0);
            this.img_Dashboard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(829, 644);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.barDienstToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.teachersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2565, 55);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(180, 48);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(277, 46);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(277, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(146, 48);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(150, 48);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(147, 48);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(122, 48);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(144, 48);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(32, 57);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(2501, 1118);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(35, 31);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(490, 32);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(32, 57);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(2501, 1111);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.Location = new System.Drawing.Point(43, 100);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(2036, 727);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.SelectedIndexChanged += new System.EventHandler(this.listViewStudents_SelectedIndexChanged);
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            this.studentName.Width = 110;
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            this.studentDOB.Width = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2147, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 293);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(27, 24);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(255, 65);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Controls.Add(this.pictureBox2);
            this.pnl_Teachers.Controls.Add(this.lbl_Teachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(32, 213);
            this.pnl_Teachers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(2501, 955);
            this.pnl_Teachers.TabIndex = 6;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teacherID,
            this.teacherName});
            this.listViewTeachers.Location = new System.Drawing.Point(43, 100);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(2036, 727);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // teacherID
            // 
            this.teacherID.Text = "ID";
            // 
            // teacherName
            // 
            this.teacherName.Text = "Name";
            this.teacherName.Width = 110;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(2147, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 293);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(27, 24);
            this.lbl_Teachers.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(268, 65);
            this.lbl_Teachers.TabIndex = 3;
            this.lbl_Teachers.Text = "Teachers";
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.pictureBox3);
            this.pnl_Rooms.Controls.Add(this.lbl_Rooms);
            this.pnl_Rooms.Location = new System.Drawing.Point(32, 57);
            this.pnl_Rooms.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(2501, 1111);
            this.pnl_Rooms.TabIndex = 7;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KamerNummer,
            this.Capaciteit,
            this.KamerType});
            this.listViewRooms.Location = new System.Drawing.Point(43, 100);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(2036, 727);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // KamerNummer
            // 
            this.KamerNummer.Text = "ID";
            // 
            // Capaciteit
            // 
            this.Capaciteit.Text = "Capaciteit";
            // 
            // KamerType
            // 
            this.KamerType.Text = "Type";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(2147, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(347, 293);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rooms.Location = new System.Drawing.Point(27, 24);
            this.lbl_Rooms.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(209, 65);
            this.lbl_Rooms.TabIndex = 3;
            this.lbl_Rooms.Text = "Rooms";
            // 
            // barDienstToolStripMenuItem
            // 
            this.barDienstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drankvoorraadToolStripMenuItem,
            this.kassaToolStripMenuItem,
            this.omzetrapportageToolStripMenuItem});
            this.barDienstToolStripMenuItem.Name = "barDienstToolStripMenuItem";
            this.barDienstToolStripMenuItem.Size = new System.Drawing.Size(153, 48);
            this.barDienstToolStripMenuItem.Text = "Bardienst";
            this.barDienstToolStripMenuItem.Click += new System.EventHandler(this.voorraadToolStripMenuItem_Click);
            // 
            // drankvoorraadToolStripMenuItem
            // 
            this.drankvoorraadToolStripMenuItem.Name = "drankvoorraadToolStripMenuItem";
            this.drankvoorraadToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.drankvoorraadToolStripMenuItem.Text = "Drankvoorraad";
            this.drankvoorraadToolStripMenuItem.Click += new System.EventHandler(this.drankvoorraadToolStripMenuItem_Click);
            // 
            // kassaToolStripMenuItem
            // 
            this.kassaToolStripMenuItem.Name = "kassaToolStripMenuItem";
            this.kassaToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.kassaToolStripMenuItem.Text = "Kassa";
            // 
            // omzetrapportageToolStripMenuItem
            // 
            this.omzetrapportageToolStripMenuItem.Name = "omzetrapportageToolStripMenuItem";
            this.omzetrapportageToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.omzetrapportageToolStripMenuItem.Text = "Omzetrapportage";
            // 
            // pnl_Drankvoorraad
            // 
            this.pnl_Drankvoorraad.Controls.Add(this.listViewDrankvoorraad);
            this.pnl_Drankvoorraad.Controls.Add(this.pictureBox4);
            this.pnl_Drankvoorraad.Controls.Add(this.lbl_Drankvoorraad);
            this.pnl_Drankvoorraad.Location = new System.Drawing.Point(32, 57);
            this.pnl_Drankvoorraad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl_Drankvoorraad.Name = "pnl_Drankvoorraad";
            this.pnl_Drankvoorraad.Size = new System.Drawing.Size(2501, 1014);
            this.pnl_Drankvoorraad.TabIndex = 6;
            // 
            // listViewDrankvoorraad
            // 
            this.listViewDrankvoorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Drankje_ID,
            this.DrankjeNaam,
            this.VerkoopPrijs,
            this.Voorraad});
            this.listViewDrankvoorraad.Location = new System.Drawing.Point(43, 100);
            this.listViewDrankvoorraad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listViewDrankvoorraad.Name = "listViewDrankvoorraad";
            this.listViewDrankvoorraad.Size = new System.Drawing.Size(2036, 727);
            this.listViewDrankvoorraad.TabIndex = 5;
            this.listViewDrankvoorraad.UseCompatibleStateImageBehavior = false;
            // 
            // Drankje_ID
            // 
            this.Drankje_ID.Text = "ID";
            // 
            // DrankjeNaam
            // 
            this.DrankjeNaam.Text = "Naam";
            this.DrankjeNaam.Width = 110;
            // 
            // VerkoopPrijs
            // 
            this.VerkoopPrijs.Text = "Prijs";
            this.VerkoopPrijs.Width = 100;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(2147, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(347, 293);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_Drankvoorraad
            // 
            this.lbl_Drankvoorraad.AutoSize = true;
            this.lbl_Drankvoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drankvoorraad.Location = new System.Drawing.Point(27, 24);
            this.lbl_Drankvoorraad.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Drankvoorraad.Name = "lbl_Drankvoorraad";
            this.lbl_Drankvoorraad.Size = new System.Drawing.Size(408, 65);
            this.lbl_Drankvoorraad.TabIndex = 3;
            this.lbl_Drankvoorraad.Text = "Drankvoorraad";
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2565, 1061);
            this.Controls.Add(this.pnl_Drankvoorraad);
            this.Controls.Add(this.pnl_Rooms);
            this.Controls.Add(this.pnl_Teachers);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Teachers.ResumeLayout(false);
            this.pnl_Teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Rooms.ResumeLayout(false);
            this.pnl_Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_Drankvoorraad.ResumeLayout(false);
            this.pnl_Drankvoorraad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Teachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader teacherID;
        private System.Windows.Forms.ColumnHeader teacherName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Teachers;
        private System.Windows.Forms.Panel pnl_Rooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader KamerNummer;
        private System.Windows.Forms.ColumnHeader Capaciteit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.ColumnHeader KamerType;
        private System.Windows.Forms.ToolStripMenuItem barDienstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drankvoorraadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kassaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omzetrapportageToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Drankvoorraad;
        private System.Windows.Forms.ListView listViewDrankvoorraad;
        private System.Windows.Forms.ColumnHeader Drankje_ID;
        private System.Windows.Forms.ColumnHeader DrankjeNaam;
        private System.Windows.Forms.ColumnHeader VerkoopPrijs;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_Drankvoorraad;
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

using System.Drawing.Drawing2D;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool dragging = false;
        Point startPoint = new Point(0, 0);
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        FormExam Exam;
        GameForm Game;
        private void Form1_Load(object sender, EventArgs e)
        {
            Exam = new FormExam { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Exam.Show();
            Game = new GameForm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Game.Show();
        }
        private void lblTest_Click(object sender, EventArgs e)
        {
            panelForm2.Location = new Point(233, 525);
            timerForm.Start();
            timer1.Start();
            panelForm2.Controls.Clear();
            panelForm2.Controls.Add(Exam);

            lblBtnExam.Enabled = false;
            lblBtnGame.Enabled = true;
            lblBtnIMGExam.Enabled = true;
            lblBtnTeacher.Enabled = true;

            //btn color on click
            lblBtnExam.BackColor = this.BackColor;
            lblBtnGame.BackColor = SystemColors.MenuHighlight;
            lblBtnIMGExam.BackColor = SystemColors.MenuHighlight;
            lblBtnTeacher.BackColor = SystemColors.MenuHighlight;
        }

        private void lblGame_Click(object sender, EventArgs e)
        {
            panelForm2.Location = new Point(233, 525);
            timerForm.Start();
            timer1.Start();
            panelForm2.Controls.Clear();
            panelForm2.Controls.Add(Game);


            lblBtnExam.Enabled = true;
            lblBtnGame.Enabled = false;
            lblBtnIMGExam.Enabled = true;
            lblBtnTeacher.Enabled = true;


            //btn color on click
            lblBtnExam.BackColor = SystemColors.MenuHighlight;
            lblBtnGame.BackColor = this.BackColor;
            lblBtnIMGExam.BackColor = SystemColors.MenuHighlight;
            lblBtnTeacher.BackColor = SystemColors.MenuHighlight;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width < 844)
            {
                this.Width += 5;
                lblTitle.Width += 5;
                lblClose.Left += 5;
            }
            if (lblMenu.Width > 233)
            {
                lblMenu.Width -= 1;
                lblLine.Width -= 1;
            }
            if (lblBtnExam.Left != 0)
            {
                lblBtnExam.Left -= 1;
                lblBtnGame.Left -= 1;
                lblBtnIMGExam.Left -= 1;
                lblBtnTeacher.Left -= 1;
            }

            timer1.Interval = 1;
        }
        private void lblBtnIMGExam_Click(object sender, EventArgs e)
        {
            lblBtnExam.Enabled = true;
            lblBtnGame.Enabled = true;
            lblBtnIMGExam.Enabled = false;
            lblBtnTeacher.Enabled = true;

            timer1.Start();


            //btn color on click
            lblBtnExam.BackColor = SystemColors.MenuHighlight;
            lblBtnGame.BackColor = SystemColors.MenuHighlight;
            lblBtnIMGExam.BackColor = this.BackColor;
            lblBtnTeacher.BackColor = SystemColors.MenuHighlight;
        }

        private void lblBtnTeacher_Click(object sender, EventArgs e)
        {

            lblBtnExam.Enabled = true;
            lblBtnGame.Enabled = true;
            lblBtnIMGExam.Enabled = true;
            lblBtnTeacher.Enabled = false;

            timer1.Start();

            //btn color on click
            lblBtnExam.BackColor = SystemColors.MenuHighlight;
            lblBtnGame.BackColor = SystemColors.MenuHighlight;
            lblBtnIMGExam.BackColor = SystemColors.MenuHighlight;
            lblBtnTeacher.BackColor = this.BackColor;
        }

        private void timerForm_Tick(object sender, EventArgs e)
        {
            if (panelForm2.Top > 10)
                panelForm2.Top -= 3;
            else
                timerForm.Stop();
            timerForm.Interval = 1;
        }
    }
}

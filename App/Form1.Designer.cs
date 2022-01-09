namespace App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblBtnExam = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBtnGame = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBtnIMGExam = new System.Windows.Forms.Label();
            this.lblBtnTeacher = new System.Windows.Forms.Label();
            this.panelForm2 = new System.Windows.Forms.Panel();
            this.timerForm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBtnExam
            // 
            this.lblBtnExam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBtnExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnExam.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnExam.ForeColor = System.Drawing.Color.Black;
            this.lblBtnExam.Location = new System.Drawing.Point(30, 213);
            this.lblBtnExam.Name = "lblBtnExam";
            this.lblBtnExam.Size = new System.Drawing.Size(233, 39);
            this.lblBtnExam.TabIndex = 0;
            this.lblBtnExam.Text = "Exam";
            this.lblBtnExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnExam.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMenu.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMenu.Location = new System.Drawing.Point(0, 20);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.lblMenu.Size = new System.Drawing.Size(293, 589);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClose.Location = new System.Drawing.Point(268, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 23);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLine.Location = new System.Drawing.Point(7, 140);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(279, 1);
            this.lblLine.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "KARAM APP";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // lblBtnGame
            // 
            this.lblBtnGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBtnGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnGame.Font = new System.Drawing.Font("Tw Cen MT", 20.25F);
            this.lblBtnGame.ForeColor = System.Drawing.Color.Black;
            this.lblBtnGame.Location = new System.Drawing.Point(30, 272);
            this.lblBtnGame.Name = "lblBtnGame";
            this.lblBtnGame.Size = new System.Drawing.Size(233, 39);
            this.lblBtnGame.TabIndex = 5;
            this.lblBtnGame.Text = "Game";
            this.lblBtnGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnGame.Click += new System.EventHandler(this.lblGame_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBtnIMGExam
            // 
            this.lblBtnIMGExam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBtnIMGExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnIMGExam.Font = new System.Drawing.Font("Tw Cen MT", 20.25F);
            this.lblBtnIMGExam.ForeColor = System.Drawing.Color.Black;
            this.lblBtnIMGExam.Location = new System.Drawing.Point(30, 332);
            this.lblBtnIMGExam.Name = "lblBtnIMGExam";
            this.lblBtnIMGExam.Size = new System.Drawing.Size(233, 39);
            this.lblBtnIMGExam.TabIndex = 14;
            this.lblBtnIMGExam.Text = "IMG Exam";
            this.lblBtnIMGExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnIMGExam.Click += new System.EventHandler(this.lblBtnIMGExam_Click);
            // 
            // lblBtnTeacher
            // 
            this.lblBtnTeacher.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBtnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnTeacher.Font = new System.Drawing.Font("Tw Cen MT", 20.25F);
            this.lblBtnTeacher.ForeColor = System.Drawing.Color.Black;
            this.lblBtnTeacher.Location = new System.Drawing.Point(30, 389);
            this.lblBtnTeacher.Name = "lblBtnTeacher";
            this.lblBtnTeacher.Size = new System.Drawing.Size(233, 39);
            this.lblBtnTeacher.TabIndex = 15;
            this.lblBtnTeacher.Text = "Teacher";
            this.lblBtnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnTeacher.Click += new System.EventHandler(this.lblBtnTeacher_Click);
            // 
            // panelForm2
            // 
            this.panelForm2.BackColor = System.Drawing.Color.FloralWhite;
            this.panelForm2.Location = new System.Drawing.Point(233, 616);
            this.panelForm2.Name = "panelForm2";
            this.panelForm2.Size = new System.Drawing.Size(792, 588);
            this.panelForm2.TabIndex = 19;
            // 
            // timerForm
            // 
            this.timerForm.Tick += new System.EventHandler(this.timerForm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(290, 588);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBtnTeacher);
            this.Controls.Add(this.lblBtnIMGExam);
            this.Controls.Add(this.lblBtnGame);
            this.Controls.Add(this.lblBtnExam);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.panelForm2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBtnExam;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBtnGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBtnIMGExam;
        private System.Windows.Forms.Label lblBtnTeacher;
        private System.Windows.Forms.Timer timerForm;
        private System.Windows.Forms.Panel panelForm2;
    }
}


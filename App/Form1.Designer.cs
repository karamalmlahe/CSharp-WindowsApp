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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBtnExam = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBtnGame = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblQNumber = new System.Windows.Forms.Label();
            this.lblline2 = new System.Windows.Forms.Label();
            this.radioBtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioBtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.radioBtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.lblNext = new System.Windows.Forms.Label();
            this.radioBtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblBtnIMGExam = new System.Windows.Forms.Label();
            this.lblBtnTeacher = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Your_Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Correct_Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelResultExam = new System.Windows.Forms.Panel();
            this.lblTryAgainExam = new System.Windows.Forms.Label();
            this.lblResultExamColor = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblResultExam = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblDateDay = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelName.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelResultExam.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBtnExam
            // 
            this.lblBtnExam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBtnExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnExam.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnExam.ForeColor = System.Drawing.Color.Black;
            this.lblBtnExam.Location = new System.Drawing.Point(30, 184);
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
            this.lblMenu.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lblMenu.Size = new System.Drawing.Size(293, 499);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClose.Location = new System.Drawing.Point(268, -1);
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
            this.lblLine.Location = new System.Drawing.Point(7, 120);
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
            this.lblBtnGame.Location = new System.Drawing.Point(30, 243);
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
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxName.Location = new System.Drawing.Point(148, 13);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(178, 24);
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.Text = "Karam";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblName.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblName.Location = new System.Drawing.Point(46, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 24);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name : ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStart.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(328, 13);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(100, 24);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.Gainsboro;
            this.panelName.Controls.Add(this.lblStart);
            this.panelName.Controls.Add(this.txtBoxName);
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Location = new System.Drawing.Point(304, 526);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(470, 47);
            this.panelName.TabIndex = 13;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelQuestion
            // 
            this.panelQuestion.BackColor = System.Drawing.Color.Gainsboro;
            this.panelQuestion.Controls.Add(this.lblBack);
            this.panelQuestion.Controls.Add(this.lblQNumber);
            this.panelQuestion.Controls.Add(this.lblline2);
            this.panelQuestion.Controls.Add(this.radioBtnAnswer2);
            this.panelQuestion.Controls.Add(this.radioBtnAnswer1);
            this.panelQuestion.Controls.Add(this.radioBtnAnswer3);
            this.panelQuestion.Controls.Add(this.lblNext);
            this.panelQuestion.Controls.Add(this.radioBtnAnswer4);
            this.panelQuestion.Controls.Add(this.lblQuestion);
            this.panelQuestion.Enabled = false;
            this.panelQuestion.Location = new System.Drawing.Point(304, 579);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(470, 299);
            this.panelQuestion.TabIndex = 12;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(5, 250);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(125, 43);
            this.lblBack.TabIndex = 15;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblQNumber
            // 
            this.lblQNumber.AutoSize = true;
            this.lblQNumber.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQNumber.Location = new System.Drawing.Point(7, 5);
            this.lblQNumber.Name = "lblQNumber";
            this.lblQNumber.Size = new System.Drawing.Size(102, 24);
            this.lblQNumber.TabIndex = 14;
            this.lblQNumber.Text = "Question 0";
            // 
            // lblline2
            // 
            this.lblline2.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblline2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblline2.Location = new System.Drawing.Point(60, 81);
            this.lblline2.Name = "lblline2";
            this.lblline2.Size = new System.Drawing.Size(350, 1);
            this.lblline2.TabIndex = 13;
            // 
            // radioBtnAnswer2
            // 
            this.radioBtnAnswer2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAnswer2.Location = new System.Drawing.Point(60, 125);
            this.radioBtnAnswer2.Name = "radioBtnAnswer2";
            this.radioBtnAnswer2.Size = new System.Drawing.Size(350, 30);
            this.radioBtnAnswer2.TabIndex = 2;
            this.radioBtnAnswer2.TabStop = true;
            this.radioBtnAnswer2.Text = "radioButton2";
            this.radioBtnAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // radioBtnAnswer1
            // 
            this.radioBtnAnswer1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAnswer1.Location = new System.Drawing.Point(60, 95);
            this.radioBtnAnswer1.Name = "radioBtnAnswer1";
            this.radioBtnAnswer1.Size = new System.Drawing.Size(350, 30);
            this.radioBtnAnswer1.TabIndex = 1;
            this.radioBtnAnswer1.TabStop = true;
            this.radioBtnAnswer1.Text = "radioButton1";
            this.radioBtnAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // radioBtnAnswer3
            // 
            this.radioBtnAnswer3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAnswer3.Location = new System.Drawing.Point(60, 155);
            this.radioBtnAnswer3.Name = "radioBtnAnswer3";
            this.radioBtnAnswer3.Size = new System.Drawing.Size(350, 30);
            this.radioBtnAnswer3.TabIndex = 3;
            this.radioBtnAnswer3.TabStop = true;
            this.radioBtnAnswer3.Text = "radioButton3";
            this.radioBtnAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // lblNext
            // 
            this.lblNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNext.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(340, 250);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(125, 43);
            this.lblNext.TabIndex = 11;
            this.lblNext.Text = "Next";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // radioBtnAnswer4
            // 
            this.radioBtnAnswer4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAnswer4.Location = new System.Drawing.Point(60, 185);
            this.radioBtnAnswer4.Name = "radioBtnAnswer4";
            this.radioBtnAnswer4.Size = new System.Drawing.Size(350, 30);
            this.radioBtnAnswer4.TabIndex = 4;
            this.radioBtnAnswer4.TabStop = true;
            this.radioBtnAnswer4.Text = "radioButton4";
            this.radioBtnAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(60, 52);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(350, 27);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "QQQQQ";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBtnIMGExam
            // 
            this.lblBtnIMGExam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBtnIMGExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnIMGExam.Font = new System.Drawing.Font("Tw Cen MT", 20.25F);
            this.lblBtnIMGExam.ForeColor = System.Drawing.Color.Black;
            this.lblBtnIMGExam.Location = new System.Drawing.Point(30, 303);
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
            this.lblBtnTeacher.Location = new System.Drawing.Point(30, 360);
            this.lblBtnTeacher.Name = "lblBtnTeacher";
            this.lblBtnTeacher.Size = new System.Drawing.Size(233, 39);
            this.lblBtnTeacher.TabIndex = 15;
            this.lblBtnTeacher.Text = "Teacher";
            this.lblBtnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnTeacher.Click += new System.EventHandler(this.lblBtnTeacher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Column_Your_Answer,
            this.Column_Correct_Answer});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(17, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 295);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 200;
            // 
            // Column_Your_Answer
            // 
            this.Column_Your_Answer.HeaderText = "Your Answer";
            this.Column_Your_Answer.Name = "Column_Your_Answer";
            this.Column_Your_Answer.ReadOnly = true;
            this.Column_Your_Answer.Width = 150;
            // 
            // Column_Correct_Answer
            // 
            this.Column_Correct_Answer.HeaderText = "Correct Answer";
            this.Column_Correct_Answer.Name = "Column_Correct_Answer";
            this.Column_Correct_Answer.ReadOnly = true;
            this.Column_Correct_Answer.Width = 150;
            // 
            // panelResultExam
            // 
            this.panelResultExam.BackColor = System.Drawing.Color.White;
            this.panelResultExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultExam.Controls.Add(this.lblTryAgainExam);
            this.panelResultExam.Controls.Add(this.lblResultExamColor);
            this.panelResultExam.Controls.Add(this.lblWrongAnswers);
            this.panelResultExam.Controls.Add(this.lblResultExam);
            this.panelResultExam.Controls.Add(this.lblEndTime);
            this.panelResultExam.Controls.Add(this.lblTimeStart);
            this.panelResultExam.Controls.Add(this.lblDateDay);
            this.panelResultExam.Controls.Add(this.lblName2);
            this.panelResultExam.Controls.Add(this.dataGridView1);
            this.panelResultExam.Location = new System.Drawing.Point(948, 34);
            this.panelResultExam.Name = "panelResultExam";
            this.panelResultExam.Size = new System.Drawing.Size(569, 470);
            this.panelResultExam.TabIndex = 17;
            // 
            // lblTryAgainExam
            // 
            this.lblTryAgainExam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTryAgainExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTryAgainExam.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTryAgainExam.ForeColor = System.Drawing.Color.White;
            this.lblTryAgainExam.Location = new System.Drawing.Point(230, 431);
            this.lblTryAgainExam.Name = "lblTryAgainExam";
            this.lblTryAgainExam.Size = new System.Drawing.Size(107, 29);
            this.lblTryAgainExam.TabIndex = 11;
            this.lblTryAgainExam.Text = "Try Again";
            this.lblTryAgainExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTryAgainExam.Click += new System.EventHandler(this.lblTryAgainExam_Click);
            // 
            // lblResultExamColor
            // 
            this.lblResultExamColor.AutoSize = true;
            this.lblResultExamColor.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultExamColor.Location = new System.Drawing.Point(486, 123);
            this.lblResultExamColor.Name = "lblResultExamColor";
            this.lblResultExamColor.Size = new System.Drawing.Size(29, 19);
            this.lblResultExamColor.TabIndex = 23;
            this.lblResultExamColor.Text = ".....";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.Location = new System.Drawing.Point(13, 123);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(121, 19);
            this.lblWrongAnswers.TabIndex = 22;
            this.lblWrongAnswers.Text = "Wrong Answers : ";
            // 
            // lblResultExam
            // 
            this.lblResultExam.AutoSize = true;
            this.lblResultExam.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultExam.Location = new System.Drawing.Point(436, 123);
            this.lblResultExam.Name = "lblResultExam";
            this.lblResultExam.Size = new System.Drawing.Size(52, 19);
            this.lblResultExam.TabIndex = 21;
            this.lblResultExam.Text = "Result :";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(23, 88);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(73, 19);
            this.lblEndTime.TabIndex = 20;
            this.lblEndTime.Text = "Ending in :";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.Location = new System.Drawing.Point(23, 65);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(80, 19);
            this.lblTimeStart.TabIndex = 19;
            this.lblTimeStart.Text = "Starting in :";
            // 
            // lblDateDay
            // 
            this.lblDateDay.AutoSize = true;
            this.lblDateDay.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDay.Location = new System.Drawing.Point(377, 20);
            this.lblDateDay.Name = "lblDateDay";
            this.lblDateDay.Size = new System.Drawing.Size(63, 24);
            this.lblDateDay.TabIndex = 18;
            this.lblDateDay.Text = "Date :";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(13, 20);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(78, 24);
            this.lblName2.TabIndex = 17;
            this.lblName2.Text = "Name : ";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(289, 518);
            this.Controls.Add(this.panelResultExam);
            this.Controls.Add(this.lblBtnTeacher);
            this.Controls.Add(this.lblBtnIMGExam);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBtnGame);
            this.Controls.Add(this.lblBtnExam);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelResultExam.ResumeLayout(false);
            this.panelResultExam.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblQNumber;
        private System.Windows.Forms.Label lblline2;
        private System.Windows.Forms.RadioButton radioBtnAnswer2;
        private System.Windows.Forms.RadioButton radioBtnAnswer1;
        private System.Windows.Forms.RadioButton radioBtnAnswer3;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.RadioButton radioBtnAnswer4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblBtnIMGExam;
        private System.Windows.Forms.Label lblBtnTeacher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Your_Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Correct_Answer;
        private System.Windows.Forms.Panel panelResultExam;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblDateDay;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblResultExam;
        private System.Windows.Forms.Label lblResultExamColor;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblTryAgainExam;
    }
}


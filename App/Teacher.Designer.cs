namespace App
{
    partial class Teacher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblBtnLogin = new System.Windows.Forms.Label();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.panelAddQuestions = new System.Windows.Forms.Panel();
            this.panelInputsToAddQuestion = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCorrect = new System.Windows.Forms.ComboBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblAddQuestion = new System.Windows.Forms.Label();
            this.labelBtnAddIMG = new System.Windows.Forms.Label();
            this.labelIMG = new System.Windows.Forms.Label();
            this.textBoxAnswer4 = new System.Windows.Forms.TextBox();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblNameExam = new System.Windows.Forms.Label();
            this.lblTitleForAddQuestion = new System.Windows.Forms.Label();
            this.comboBoxAddQuestion = new System.Windows.Forms.ComboBox();
            this.panelShowTable = new System.Windows.Forms.Panel();
            this.lblLine = new System.Windows.Forms.Label();
            this.labelNameTable = new System.Windows.Forms.Label();
            this.lblTitleForTable = new System.Windows.Forms.Label();
            this.TableStudentsResult = new System.Windows.Forms.DataGridView();
            this.Column_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.lblStudentCountInExam = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.timerShowTables = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelLogin.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.panelAddQuestions.SuspendLayout();
            this.panelInputsToAddQuestion.SuspendLayout();
            this.panelShowTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableStudentsResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.lblusername);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.lblBtnLogin);
            this.panelLogin.Location = new System.Drawing.Point(216, 187);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(360, 119);
            this.panelLogin.TabIndex = 16;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxUsername.Location = new System.Drawing.Point(144, 13);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(178, 24);
            this.textBoxUsername.TabIndex = 11;
            // 
            // lblusername
            // 
            this.lblusername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblusername.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblusername.Location = new System.Drawing.Point(35, 13);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(107, 24);
            this.lblusername.TabIndex = 14;
            this.lblusername.Text = "Username :";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPassword.Location = new System.Drawing.Point(144, 43);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(178, 24);
            this.textBoxPassword.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPassword.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblPassword.Location = new System.Drawing.Point(35, 43);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 24);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBtnLogin
            // 
            this.lblBtnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnLogin.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtnLogin.ForeColor = System.Drawing.Color.White;
            this.lblBtnLogin.Location = new System.Drawing.Point(35, 80);
            this.lblBtnLogin.Name = "lblBtnLogin";
            this.lblBtnLogin.Size = new System.Drawing.Size(287, 24);
            this.lblBtnLogin.TabIndex = 10;
            this.lblBtnLogin.Text = "Login";
            this.lblBtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBtnLogin.Click += new System.EventHandler(this.lblBtnLogin_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.BackColor = System.Drawing.Color.FloralWhite;
            this.panelTeacher.Controls.Add(this.panelAddQuestions);
            this.panelTeacher.Controls.Add(this.panelShowTable);
            this.panelTeacher.Location = new System.Drawing.Point(795, 30);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(709, 530);
            this.panelTeacher.TabIndex = 19;
            // 
            // panelAddQuestions
            // 
            this.panelAddQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddQuestions.Controls.Add(this.panelInputsToAddQuestion);
            this.panelAddQuestions.Controls.Add(this.lblLine2);
            this.panelAddQuestions.Controls.Add(this.lblNameExam);
            this.panelAddQuestions.Controls.Add(this.lblTitleForAddQuestion);
            this.panelAddQuestions.Controls.Add(this.comboBoxAddQuestion);
            this.panelAddQuestions.Location = new System.Drawing.Point(356, 3);
            this.panelAddQuestions.Name = "panelAddQuestions";
            this.panelAddQuestions.Size = new System.Drawing.Size(352, 522);
            this.panelAddQuestions.TabIndex = 22;
            // 
            // panelInputsToAddQuestion
            // 
            this.panelInputsToAddQuestion.Controls.Add(this.label2);
            this.panelInputsToAddQuestion.Controls.Add(this.comboBoxCorrect);
            this.panelInputsToAddQuestion.Controls.Add(this.lblCorrect);
            this.panelInputsToAddQuestion.Controls.Add(this.lblAddQuestion);
            this.panelInputsToAddQuestion.Controls.Add(this.labelBtnAddIMG);
            this.panelInputsToAddQuestion.Controls.Add(this.labelIMG);
            this.panelInputsToAddQuestion.Controls.Add(this.textBoxAnswer4);
            this.panelInputsToAddQuestion.Controls.Add(this.lblAnswer4);
            this.panelInputsToAddQuestion.Controls.Add(this.textBoxAnswer3);
            this.panelInputsToAddQuestion.Controls.Add(this.lblAnswer3);
            this.panelInputsToAddQuestion.Controls.Add(this.textBoxAnswer2);
            this.panelInputsToAddQuestion.Controls.Add(this.lblAnswer2);
            this.panelInputsToAddQuestion.Controls.Add(this.textBoxAnswer1);
            this.panelInputsToAddQuestion.Controls.Add(this.lblAnswer1);
            this.panelInputsToAddQuestion.Controls.Add(this.textBoxQuestion);
            this.panelInputsToAddQuestion.Controls.Add(this.lblQuestion);
            this.panelInputsToAddQuestion.Location = new System.Drawing.Point(0, 142);
            this.panelInputsToAddQuestion.Name = "panelInputsToAddQuestion";
            this.panelInputsToAddQuestion.Size = new System.Drawing.Size(352, 372);
            this.panelInputsToAddQuestion.TabIndex = 22;
            this.panelInputsToAddQuestion.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(9, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 1);
            this.label2.TabIndex = 23;
            // 
            // comboBoxCorrect
            // 
            this.comboBoxCorrect.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCorrect.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCorrect.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCorrect.Location = new System.Drawing.Point(116, 250);
            this.comboBoxCorrect.Name = "comboBoxCorrect";
            this.comboBoxCorrect.Size = new System.Drawing.Size(231, 25);
            this.comboBoxCorrect.TabIndex = 24;
            this.comboBoxCorrect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxCorrect_KeyDown);
            // 
            // lblCorrect
            // 
            this.lblCorrect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCorrect.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(6, 250);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(107, 24);
            this.lblCorrect.TabIndex = 27;
            this.lblCorrect.Text = "Correct :";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddQuestion
            // 
            this.lblAddQuestion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddQuestion.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuestion.ForeColor = System.Drawing.Color.White;
            this.lblAddQuestion.Location = new System.Drawing.Point(31, 324);
            this.lblAddQuestion.Name = "lblAddQuestion";
            this.lblAddQuestion.Size = new System.Drawing.Size(287, 24);
            this.lblAddQuestion.TabIndex = 15;
            this.lblAddQuestion.Text = "Add";
            this.lblAddQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddQuestion.Click += new System.EventHandler(this.lblAddQuestion_Click);
            // 
            // labelBtnAddIMG
            // 
            this.labelBtnAddIMG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelBtnAddIMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBtnAddIMG.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBtnAddIMG.ForeColor = System.Drawing.Color.White;
            this.labelBtnAddIMG.Location = new System.Drawing.Point(116, 40);
            this.labelBtnAddIMG.Name = "labelBtnAddIMG";
            this.labelBtnAddIMG.Size = new System.Drawing.Size(116, 24);
            this.labelBtnAddIMG.TabIndex = 15;
            this.labelBtnAddIMG.Text = "Add IMG ...";
            this.labelBtnAddIMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBtnAddIMG.Click += new System.EventHandler(this.labelBtnAddIMG_Click);
            // 
            // labelIMG
            // 
            this.labelIMG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelIMG.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMG.Location = new System.Drawing.Point(6, 40);
            this.labelIMG.Name = "labelIMG";
            this.labelIMG.Size = new System.Drawing.Size(107, 24);
            this.labelIMG.TabIndex = 25;
            this.labelIMG.Text = "IMG";
            this.labelIMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAnswer4
            // 
            this.textBoxAnswer4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer4.Location = new System.Drawing.Point(116, 215);
            this.textBoxAnswer4.Multiline = true;
            this.textBoxAnswer4.Name = "textBoxAnswer4";
            this.textBoxAnswer4.Size = new System.Drawing.Size(231, 24);
            this.textBoxAnswer4.TabIndex = 23;
            this.textBoxAnswer4.TextChanged += new System.EventHandler(this.textBoxAnswer4_TextChanged);
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAnswer4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.Location = new System.Drawing.Point(6, 215);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(107, 24);
            this.lblAnswer4.TabIndex = 24;
            this.lblAnswer4.Text = "Answer 4 :";
            this.lblAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer3.Location = new System.Drawing.Point(116, 180);
            this.textBoxAnswer3.Multiline = true;
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(231, 24);
            this.textBoxAnswer3.TabIndex = 21;
            this.textBoxAnswer3.TextChanged += new System.EventHandler(this.textBoxAnswer3_TextChanged);
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAnswer3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.Location = new System.Drawing.Point(6, 180);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(107, 24);
            this.lblAnswer3.TabIndex = 22;
            this.lblAnswer3.Text = "Answer 3 :";
            this.lblAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer2.Location = new System.Drawing.Point(116, 145);
            this.textBoxAnswer2.Multiline = true;
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(231, 24);
            this.textBoxAnswer2.TabIndex = 19;
            this.textBoxAnswer2.TextChanged += new System.EventHandler(this.textBoxAnswer2_TextChanged);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAnswer2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.Location = new System.Drawing.Point(6, 145);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(107, 24);
            this.lblAnswer2.TabIndex = 20;
            this.lblAnswer2.Text = "Answer 2 :";
            this.lblAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer1.Location = new System.Drawing.Point(116, 110);
            this.textBoxAnswer1.Multiline = true;
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(231, 24);
            this.textBoxAnswer1.TabIndex = 17;
            this.textBoxAnswer1.TextChanged += new System.EventHandler(this.textBoxAnswer1_TextChanged);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblAnswer1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(6, 110);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(107, 24);
            this.lblAnswer1.TabIndex = 18;
            this.lblAnswer1.Text = "Answer 1 :";
            this.lblAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(116, 75);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(231, 24);
            this.textBoxQuestion.TabIndex = 15;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblQuestion.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(6, 75);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(107, 24);
            this.lblQuestion.TabIndex = 16;
            this.lblQuestion.Text = "Question :";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine2
            // 
            this.lblLine2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLine2.Location = new System.Drawing.Point(9, 133);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(336, 1);
            this.lblLine2.TabIndex = 21;
            // 
            // lblNameExam
            // 
            this.lblNameExam.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNameExam.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblNameExam.Location = new System.Drawing.Point(5, 94);
            this.lblNameExam.Name = "lblNameExam";
            this.lblNameExam.Size = new System.Drawing.Size(107, 25);
            this.lblNameExam.TabIndex = 15;
            this.lblNameExam.Text = "Name :";
            this.lblNameExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleForAddQuestion
            // 
            this.lblTitleForAddQuestion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitleForAddQuestion.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblTitleForAddQuestion.ForeColor = System.Drawing.Color.White;
            this.lblTitleForAddQuestion.Location = new System.Drawing.Point(0, 20);
            this.lblTitleForAddQuestion.Name = "lblTitleForAddQuestion";
            this.lblTitleForAddQuestion.Size = new System.Drawing.Size(354, 44);
            this.lblTitleForAddQuestion.TabIndex = 15;
            this.lblTitleForAddQuestion.Text = "Add Questions";
            this.lblTitleForAddQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAddQuestion
            // 
            this.comboBoxAddQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxAddQuestion.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAddQuestion.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAddQuestion.Items.AddRange(new object[] {
            "Normal Exam",
            "IMG Exam"});
            this.comboBoxAddQuestion.Location = new System.Drawing.Point(115, 94);
            this.comboBoxAddQuestion.Name = "comboBoxAddQuestion";
            this.comboBoxAddQuestion.Size = new System.Drawing.Size(232, 25);
            this.comboBoxAddQuestion.TabIndex = 20;
            this.comboBoxAddQuestion.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddQuestion_SelectedIndexChanged);
            this.comboBoxAddQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxAddQuestion_KeyDown);
            // 
            // panelShowTable
            // 
            this.panelShowTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowTable.Controls.Add(this.lblLine);
            this.panelShowTable.Controls.Add(this.labelNameTable);
            this.panelShowTable.Controls.Add(this.lblTitleForTable);
            this.panelShowTable.Controls.Add(this.TableStudentsResult);
            this.panelShowTable.Controls.Add(this.comboBoxTable);
            this.panelShowTable.Controls.Add(this.lblStudentCountInExam);
            this.panelShowTable.Controls.Add(this.lblAvg);
            this.panelShowTable.Location = new System.Drawing.Point(0, 3);
            this.panelShowTable.Name = "panelShowTable";
            this.panelShowTable.Size = new System.Drawing.Size(352, 522);
            this.panelShowTable.TabIndex = 21;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLine.Location = new System.Drawing.Point(9, 133);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(336, 1);
            this.lblLine.TabIndex = 21;
            // 
            // labelNameTable
            // 
            this.labelNameTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelNameTable.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.labelNameTable.Location = new System.Drawing.Point(5, 94);
            this.labelNameTable.Name = "labelNameTable";
            this.labelNameTable.Size = new System.Drawing.Size(107, 25);
            this.labelNameTable.TabIndex = 15;
            this.labelNameTable.Text = "Name :";
            this.labelNameTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleForTable
            // 
            this.lblTitleForTable.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitleForTable.Font = new System.Drawing.Font("Tw Cen MT", 15.75F);
            this.lblTitleForTable.ForeColor = System.Drawing.Color.White;
            this.lblTitleForTable.Location = new System.Drawing.Point(0, 20);
            this.lblTitleForTable.Name = "lblTitleForTable";
            this.lblTitleForTable.Size = new System.Drawing.Size(354, 44);
            this.lblTitleForTable.TabIndex = 15;
            this.lblTitleForTable.Text = "Students Results";
            this.lblTitleForTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableStudentsResult
            // 
            this.TableStudentsResult.AllowUserToAddRows = false;
            this.TableStudentsResult.AllowUserToDeleteRows = false;
            this.TableStudentsResult.AllowUserToResizeColumns = false;
            this.TableStudentsResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TableStudentsResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TableStudentsResult.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.TableStudentsResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableStudentsResult.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TableStudentsResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableStudentsResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableStudentsResult.ColumnHeadersHeight = 30;
            this.TableStudentsResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableStudentsResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_1,
            this.Column_2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableStudentsResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableStudentsResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TableStudentsResult.GridColor = System.Drawing.SystemColors.Desktop;
            this.TableStudentsResult.Location = new System.Drawing.Point(8, 201);
            this.TableStudentsResult.Name = "TableStudentsResult";
            this.TableStudentsResult.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableStudentsResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TableStudentsResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.TableStudentsResult.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TableStudentsResult.RowTemplate.ReadOnly = true;
            this.TableStudentsResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableStudentsResult.Size = new System.Drawing.Size(337, 313);
            this.TableStudentsResult.TabIndex = 16;
            // 
            // Column_1
            // 
            this.Column_1.HeaderText = "Student Name";
            this.Column_1.Name = "Column_1";
            this.Column_1.ReadOnly = true;
            this.Column_1.Width = 150;
            // 
            // Column_2
            // 
            this.Column_2.HeaderText = "Grade";
            this.Column_2.Name = "Column_2";
            this.Column_2.ReadOnly = true;
            this.Column_2.Width = 125;
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTable.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTable.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTable.Items.AddRange(new object[] {
            "Exam Grades",
            "Game Score",
            "IMG Exam Grades"});
            this.comboBoxTable.Location = new System.Drawing.Point(115, 94);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(232, 25);
            this.comboBoxTable.TabIndex = 20;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            this.comboBoxTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxTable_KeyDown);
            // 
            // lblStudentCountInExam
            // 
            this.lblStudentCountInExam.AutoSize = true;
            this.lblStudentCountInExam.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCountInExam.Location = new System.Drawing.Point(91, 142);
            this.lblStudentCountInExam.Name = "lblStudentCountInExam";
            this.lblStudentCountInExam.Size = new System.Drawing.Size(154, 22);
            this.lblStudentCountInExam.TabIndex = 18;
            this.lblStudentCountInExam.Text = "Count Of Students :";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(121, 172);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(89, 22);
            this.lblAvg.TabIndex = 19;
            this.lblAvg.Text = "Average : ";
            // 
            // timerShowTables
            // 
            this.timerShowTables.Tick += new System.EventHandler(this.timerShowTables_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1659, 580);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelAddQuestions.ResumeLayout(false);
            this.panelInputsToAddQuestion.ResumeLayout(false);
            this.panelInputsToAddQuestion.PerformLayout();
            this.panelShowTable.ResumeLayout(false);
            this.panelShowTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableStudentsResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblBtnLogin;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.DataGridView TableStudentsResult;
        private System.Windows.Forms.Label lblStudentCountInExam;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Timer timerShowTables;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Panel panelShowTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_2;
        private System.Windows.Forms.Label lblTitleForTable;
        private System.Windows.Forms.Label labelNameTable;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Panel panelAddQuestions;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblNameExam;
        private System.Windows.Forms.Label lblTitleForAddQuestion;
        private System.Windows.Forms.ComboBox comboBoxAddQuestion;
        private System.Windows.Forms.Panel panelInputsToAddQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label labelIMG;
        private System.Windows.Forms.TextBox textBoxAnswer4;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox textBoxAnswer3;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAddQuestion;
        private System.Windows.Forms.Label labelBtnAddIMG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.ComboBox comboBoxCorrect;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
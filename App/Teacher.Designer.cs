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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblBtnLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.panelGradeAndScore = new System.Windows.Forms.Panel();
            this.TableGradeStudents = new System.Windows.Forms.DataGridView();
            this.TableScore = new System.Windows.Forms.DataGridView();
            this.Column_Your_Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Correct_Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudentCountInExam = new System.Windows.Forms.Label();
            this.lblAvgInExam = new System.Windows.Forms.Label();
            this.lblAvgInGame = new System.Windows.Forms.Label();
            this.lblStudentCountInGame = new System.Windows.Forms.Label();
            this.timerShowTables = new System.Windows.Forms.Timer(this.components);
            this.panelLogin.SuspendLayout();
            this.panelGradeAndScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGradeStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableScore)).BeginInit();
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
            // panelGradeAndScore
            // 
            this.panelGradeAndScore.BackColor = System.Drawing.Color.White;
            this.panelGradeAndScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGradeAndScore.Controls.Add(this.lblAvgInGame);
            this.panelGradeAndScore.Controls.Add(this.lblStudentCountInGame);
            this.panelGradeAndScore.Controls.Add(this.lblAvgInExam);
            this.panelGradeAndScore.Controls.Add(this.lblStudentCountInExam);
            this.panelGradeAndScore.Controls.Add(this.TableScore);
            this.panelGradeAndScore.Controls.Add(this.TableGradeStudents);
            this.panelGradeAndScore.Location = new System.Drawing.Point(803, 29);
            this.panelGradeAndScore.Name = "panelGradeAndScore";
            this.panelGradeAndScore.Size = new System.Drawing.Size(647, 453);
            this.panelGradeAndScore.TabIndex = 19;
            // 
            // TableGradeStudents
            // 
            this.TableGradeStudents.AllowUserToAddRows = false;
            this.TableGradeStudents.AllowUserToDeleteRows = false;
            this.TableGradeStudents.AllowUserToResizeColumns = false;
            this.TableGradeStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TableGradeStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.TableGradeStudents.BackgroundColor = System.Drawing.Color.White;
            this.TableGradeStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableGradeStudents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TableGradeStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableGradeStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TableGradeStudents.ColumnHeadersHeight = 30;
            this.TableGradeStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableGradeStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Your_Answer,
            this.Column_Correct_Answer});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableGradeStudents.DefaultCellStyle = dataGridViewCellStyle13;
            this.TableGradeStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TableGradeStudents.GridColor = System.Drawing.SystemColors.Desktop;
            this.TableGradeStudents.Location = new System.Drawing.Point(21, 91);
            this.TableGradeStudents.Name = "TableGradeStudents";
            this.TableGradeStudents.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableGradeStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.TableGradeStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.TableGradeStudents.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.TableGradeStudents.RowTemplate.ReadOnly = true;
            this.TableGradeStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableGradeStudents.Size = new System.Drawing.Size(282, 360);
            this.TableGradeStudents.TabIndex = 16;
            // 
            // TableScore
            // 
            this.TableScore.AllowUserToAddRows = false;
            this.TableScore.AllowUserToDeleteRows = false;
            this.TableScore.AllowUserToResizeColumns = false;
            this.TableScore.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TableScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.TableScore.BackgroundColor = System.Drawing.Color.White;
            this.TableScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableScore.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TableScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.TableScore.ColumnHeadersHeight = 30;
            this.TableScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableScore.DefaultCellStyle = dataGridViewCellStyle18;
            this.TableScore.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TableScore.GridColor = System.Drawing.SystemColors.Desktop;
            this.TableScore.Location = new System.Drawing.Point(360, 91);
            this.TableScore.Name = "TableScore";
            this.TableScore.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.TableScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.TableScore.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.TableScore.RowTemplate.ReadOnly = true;
            this.TableScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableScore.Size = new System.Drawing.Size(282, 360);
            this.TableScore.TabIndex = 17;
            // 
            // Column_Your_Answer
            // 
            this.Column_Your_Answer.HeaderText = "Name";
            this.Column_Your_Answer.Name = "Column_Your_Answer";
            this.Column_Your_Answer.ReadOnly = true;
            this.Column_Your_Answer.Width = 120;
            // 
            // Column_Correct_Answer
            // 
            this.Column_Correct_Answer.HeaderText = "Grade";
            this.Column_Correct_Answer.Name = "Column_Correct_Answer";
            this.Column_Correct_Answer.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lblStudentCountInExam
            // 
            this.lblStudentCountInExam.AutoSize = true;
            this.lblStudentCountInExam.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCountInExam.Location = new System.Drawing.Point(16, 10);
            this.lblStudentCountInExam.Name = "lblStudentCountInExam";
            this.lblStudentCountInExam.Size = new System.Drawing.Size(154, 22);
            this.lblStudentCountInExam.TabIndex = 18;
            this.lblStudentCountInExam.Text = "Count Of Students :";
            // 
            // lblAvgInExam
            // 
            this.lblAvgInExam.AutoSize = true;
            this.lblAvgInExam.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgInExam.Location = new System.Drawing.Point(16, 48);
            this.lblAvgInExam.Name = "lblAvgInExam";
            this.lblAvgInExam.Size = new System.Drawing.Size(89, 22);
            this.lblAvgInExam.TabIndex = 19;
            this.lblAvgInExam.Text = "Average : ";
            // 
            // lblAvgInGame
            // 
            this.lblAvgInGame.AutoSize = true;
            this.lblAvgInGame.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgInGame.Location = new System.Drawing.Point(449, 48);
            this.lblAvgInGame.Name = "lblAvgInGame";
            this.lblAvgInGame.Size = new System.Drawing.Size(89, 22);
            this.lblAvgInGame.TabIndex = 21;
            this.lblAvgInGame.Text = "Average : ";
            // 
            // lblStudentCountInGame
            // 
            this.lblStudentCountInGame.AutoSize = true;
            this.lblStudentCountInGame.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCountInGame.Location = new System.Drawing.Point(384, 10);
            this.lblStudentCountInGame.Name = "lblStudentCountInGame";
            this.lblStudentCountInGame.Size = new System.Drawing.Size(154, 22);
            this.lblStudentCountInGame.TabIndex = 20;
            this.lblStudentCountInGame.Text = "Count Of Students :";
            // 
            // timerShowTables
            // 
            this.timerShowTables.Tick += new System.EventHandler(this.timerShowTables_Tick);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1659, 494);
            this.Controls.Add(this.panelGradeAndScore);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelGradeAndScore.ResumeLayout(false);
            this.panelGradeAndScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGradeStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblBtnLogin;
        private System.Windows.Forms.Panel panelGradeAndScore;
        private System.Windows.Forms.DataGridView TableGradeStudents;
        private System.Windows.Forms.DataGridView TableScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Your_Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Correct_Answer;
        private System.Windows.Forms.Label lblStudentCountInExam;
        private System.Windows.Forms.Label lblAvgInExam;
        private System.Windows.Forms.Label lblAvgInGame;
        private System.Windows.Forms.Label lblStudentCountInGame;
        private System.Windows.Forms.Timer timerShowTables;
    }
}
namespace App
{
    partial class FormExam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelName = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelResultExam = new System.Windows.Forms.Panel();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblTryAgainExam = new System.Windows.Forms.Label();
            this.lblResultExamColor = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblResultExam = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblDateDay = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.TableWrongAnswers = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Your_Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Correct_Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerPanelName = new System.Windows.Forms.Timer(this.components);
            this.timerPanelQuestion = new System.Windows.Forms.Timer(this.components);
            this.timerExamResult = new System.Windows.Forms.Timer(this.components);
            this.panelQuestion.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelResultExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWrongAnswers)).BeginInit();
            this.SuspendLayout();
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
            this.panelQuestion.Location = new System.Drawing.Point(71, 547);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(470, 299);
            this.panelQuestion.TabIndex = 14;
            this.panelQuestion.Visible = false;
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
            this.lblQuestion.Location = new System.Drawing.Point(11, 52);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(454, 27);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "QQQQQ";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.Gainsboro;
            this.panelName.Controls.Add(this.lblStart);
            this.panelName.Controls.Add(this.txtBoxName);
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Location = new System.Drawing.Point(71, 60);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(470, 47);
            this.panelName.TabIndex = 15;
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
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxName.Location = new System.Drawing.Point(148, 13);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(178, 24);
            this.txtBoxName.TabIndex = 5;
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
            // panelResultExam
            // 
            this.panelResultExam.BackColor = System.Drawing.Color.White;
            this.panelResultExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultExam.Controls.Add(this.lblGrade);
            this.panelResultExam.Controls.Add(this.lblTryAgainExam);
            this.panelResultExam.Controls.Add(this.lblResultExamColor);
            this.panelResultExam.Controls.Add(this.lblWrongAnswers);
            this.panelResultExam.Controls.Add(this.lblResultExam);
            this.panelResultExam.Controls.Add(this.lblEndTime);
            this.panelResultExam.Controls.Add(this.lblTimeStart);
            this.panelResultExam.Controls.Add(this.lblDateDay);
            this.panelResultExam.Controls.Add(this.lblName2);
            this.panelResultExam.Controls.Add(this.TableWrongAnswers);
            this.panelResultExam.Location = new System.Drawing.Point(613, 18);
            this.panelResultExam.Name = "panelResultExam";
            this.panelResultExam.Size = new System.Drawing.Size(569, 470);
            this.panelResultExam.TabIndex = 18;
            this.panelResultExam.Visible = false;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.lblGrade.Location = new System.Drawing.Point(235, 86);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(64, 19);
            this.lblGrade.TabIndex = 24;
            this.lblGrade.Text = "Grade : ";
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
            this.lblResultExamColor.Location = new System.Drawing.Point(460, 123);
            this.lblResultExamColor.Name = "lblResultExamColor";
            this.lblResultExamColor.Size = new System.Drawing.Size(29, 19);
            this.lblResultExamColor.TabIndex = 23;
            this.lblResultExamColor.Text = ".....";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.Location = new System.Drawing.Point(23, 123);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(121, 19);
            this.lblWrongAnswers.TabIndex = 22;
            this.lblWrongAnswers.Text = "Wrong Answers : ";
            // 
            // lblResultExam
            // 
            this.lblResultExam.AutoSize = true;
            this.lblResultExam.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultExam.Location = new System.Drawing.Point(410, 123);
            this.lblResultExam.Name = "lblResultExam";
            this.lblResultExam.Size = new System.Drawing.Size(52, 19);
            this.lblResultExam.TabIndex = 21;
            this.lblResultExam.Text = "Result :";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(393, 65);
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
            // TableWrongAnswers
            // 
            this.TableWrongAnswers.BackgroundColor = System.Drawing.Color.White;
            this.TableWrongAnswers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableWrongAnswers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TableWrongAnswers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableWrongAnswers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TableWrongAnswers.ColumnHeadersHeight = 30;
            this.TableWrongAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableWrongAnswers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Column_Your_Answer,
            this.Column_Correct_Answer});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableWrongAnswers.DefaultCellStyle = dataGridViewCellStyle6;
            this.TableWrongAnswers.Enabled = false;
            this.TableWrongAnswers.GridColor = System.Drawing.SystemColors.Desktop;
            this.TableWrongAnswers.Location = new System.Drawing.Point(17, 153);
            this.TableWrongAnswers.Name = "TableWrongAnswers";
            this.TableWrongAnswers.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableWrongAnswers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TableWrongAnswers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableWrongAnswers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.TableWrongAnswers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableWrongAnswers.Size = new System.Drawing.Size(546, 295);
            this.TableWrongAnswers.TabIndex = 16;
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
            // timerPanelQuestion
            // 
            this.timerPanelQuestion.Tick += new System.EventHandler(this.timerPanelQuestion_Tick);
            // 
            // timerExamResult
            // 
            this.timerExamResult.Tick += new System.EventHandler(this.timerExamResult_Tick);
            // 
            // FormExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1221, 848);
            this.Controls.Add(this.panelResultExam);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.panelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExam";
            this.Text = "FormExam";
            this.Load += new System.EventHandler(this.FormExam_Load);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelResultExam.ResumeLayout(false);
            this.panelResultExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableWrongAnswers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelResultExam;
        private System.Windows.Forms.Label lblTryAgainExam;
        private System.Windows.Forms.Label lblResultExamColor;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblResultExam;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblDateDay;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.DataGridView TableWrongAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Your_Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Correct_Answer;
        private System.Windows.Forms.Timer TimerPanelName;
        private System.Windows.Forms.Timer timerPanelQuestion;
        private System.Windows.Forms.Timer timerExamResult;
        private System.Windows.Forms.Label lblGrade;
    }
}
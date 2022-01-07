namespace App
{
    partial class GameForm
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblUP = new System.Windows.Forms.Label();
            this.panelGameZone = new System.Windows.Forms.Panel();
            this.lblWallDown4 = new System.Windows.Forms.Label();
            this.lblWallUp4 = new System.Windows.Forms.Label();
            this.lblWallDown3 = new System.Windows.Forms.Label();
            this.lblWallUp3 = new System.Windows.Forms.Label();
            this.lblWallDown2 = new System.Windows.Forms.Label();
            this.lblWallUp2 = new System.Windows.Forms.Label();
            this.lblWallDown1 = new System.Windows.Forms.Label();
            this.lblWallUp1 = new System.Windows.Forms.Label();
            this.lblBoxGame = new System.Windows.Forms.Label();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.TimerForBox = new System.Windows.Forms.Timer(this.components);
            this.timerStartGame = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.timerContainerLocation = new System.Windows.Forms.Timer(this.components);
            this.panelGameZone.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Tw Cen MT", 20.25F);
            this.lblScore.Location = new System.Drawing.Point(13, 3);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(187, 30);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score :";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDown
            // 
            this.lblDown.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDown.Enabled = false;
            this.lblDown.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.ForeColor = System.Drawing.Color.White;
            this.lblDown.Location = new System.Drawing.Point(271, 338);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(233, 39);
            this.lblDown.TabIndex = 22;
            this.lblDown.Text = "Down";
            this.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDown_MouseDown);
            this.lblDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblDown_MouseUp);
            // 
            // lblUP
            // 
            this.lblUP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUP.Enabled = false;
            this.lblUP.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUP.ForeColor = System.Drawing.Color.White;
            this.lblUP.Location = new System.Drawing.Point(16, 338);
            this.lblUP.Name = "lblUP";
            this.lblUP.Size = new System.Drawing.Size(233, 39);
            this.lblUP.TabIndex = 21;
            this.lblUP.Text = "UP";
            this.lblUP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblUP_MouseDown);
            this.lblUP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblUP_MouseUp);
            // 
            // panelGameZone
            // 
            this.panelGameZone.BackColor = System.Drawing.Color.White;
            this.panelGameZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGameZone.Controls.Add(this.lblWallDown4);
            this.panelGameZone.Controls.Add(this.lblWallUp4);
            this.panelGameZone.Controls.Add(this.lblWallDown3);
            this.panelGameZone.Controls.Add(this.lblWallUp3);
            this.panelGameZone.Controls.Add(this.lblWallDown2);
            this.panelGameZone.Controls.Add(this.lblWallUp2);
            this.panelGameZone.Controls.Add(this.lblWallDown1);
            this.panelGameZone.Controls.Add(this.lblWallUp1);
            this.panelGameZone.Controls.Add(this.lblBoxGame);
            this.panelGameZone.Location = new System.Drawing.Point(16, 36);
            this.panelGameZone.Name = "panelGameZone";
            this.panelGameZone.Size = new System.Drawing.Size(488, 294);
            this.panelGameZone.TabIndex = 20;
            // 
            // lblWallDown4
            // 
            this.lblWallDown4.BackColor = System.Drawing.Color.Maroon;
            this.lblWallDown4.Location = new System.Drawing.Point(854, 165);
            this.lblWallDown4.Name = "lblWallDown4";
            this.lblWallDown4.Size = new System.Drawing.Size(34, 128);
            this.lblWallDown4.TabIndex = 8;
            // 
            // lblWallUp4
            // 
            this.lblWallUp4.BackColor = System.Drawing.Color.Maroon;
            this.lblWallUp4.Location = new System.Drawing.Point(854, 0);
            this.lblWallUp4.Name = "lblWallUp4";
            this.lblWallUp4.Size = new System.Drawing.Size(34, 128);
            this.lblWallUp4.TabIndex = 7;
            // 
            // lblWallDown3
            // 
            this.lblWallDown3.BackColor = System.Drawing.Color.Maroon;
            this.lblWallDown3.Location = new System.Drawing.Point(732, 165);
            this.lblWallDown3.Name = "lblWallDown3";
            this.lblWallDown3.Size = new System.Drawing.Size(34, 128);
            this.lblWallDown3.TabIndex = 6;
            // 
            // lblWallUp3
            // 
            this.lblWallUp3.BackColor = System.Drawing.Color.Maroon;
            this.lblWallUp3.Location = new System.Drawing.Point(732, 0);
            this.lblWallUp3.Name = "lblWallUp3";
            this.lblWallUp3.Size = new System.Drawing.Size(34, 128);
            this.lblWallUp3.TabIndex = 5;
            // 
            // lblWallDown2
            // 
            this.lblWallDown2.BackColor = System.Drawing.Color.Maroon;
            this.lblWallDown2.Location = new System.Drawing.Point(610, 165);
            this.lblWallDown2.Name = "lblWallDown2";
            this.lblWallDown2.Size = new System.Drawing.Size(34, 128);
            this.lblWallDown2.TabIndex = 4;
            // 
            // lblWallUp2
            // 
            this.lblWallUp2.BackColor = System.Drawing.Color.Maroon;
            this.lblWallUp2.Location = new System.Drawing.Point(610, 0);
            this.lblWallUp2.Name = "lblWallUp2";
            this.lblWallUp2.Size = new System.Drawing.Size(34, 128);
            this.lblWallUp2.TabIndex = 3;
            // 
            // lblWallDown1
            // 
            this.lblWallDown1.BackColor = System.Drawing.Color.Maroon;
            this.lblWallDown1.Location = new System.Drawing.Point(488, 165);
            this.lblWallDown1.Name = "lblWallDown1";
            this.lblWallDown1.Size = new System.Drawing.Size(34, 128);
            this.lblWallDown1.TabIndex = 2;
            // 
            // lblWallUp1
            // 
            this.lblWallUp1.BackColor = System.Drawing.Color.Maroon;
            this.lblWallUp1.Location = new System.Drawing.Point(488, 0);
            this.lblWallUp1.Name = "lblWallUp1";
            this.lblWallUp1.Size = new System.Drawing.Size(34, 128);
            this.lblWallUp1.TabIndex = 1;
            // 
            // lblBoxGame
            // 
            this.lblBoxGame.BackColor = System.Drawing.Color.DarkOrange;
            this.lblBoxGame.Location = new System.Drawing.Point(82, 133);
            this.lblBoxGame.Name = "lblBoxGame";
            this.lblBoxGame.Size = new System.Drawing.Size(22, 22);
            this.lblBoxGame.TabIndex = 0;
            // 
            // lblStartGame
            // 
            this.lblStartGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStartGame.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.ForeColor = System.Drawing.Color.White;
            this.lblStartGame.Location = new System.Drawing.Point(328, 13);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(127, 24);
            this.lblStartGame.TabIndex = 19;
            this.lblStartGame.Text = "Start Game";
            this.lblStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartGame.Click += new System.EventHandler(this.lblStartGame_Click);
            // 
            // TimerForBox
            // 
            this.TimerForBox.Tick += new System.EventHandler(this.TimerForBox_Tick);
            // 
            // timerStartGame
            // 
            this.timerStartGame.Tick += new System.EventHandler(this.timerStartGame_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panelName);
            this.panelContainer.Location = new System.Drawing.Point(21, 26);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(615, 470);
            this.panelContainer.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panelGameZone);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblUP);
            this.panel1.Controls.Add(this.lblDown);
            this.panel1.Location = new System.Drawing.Point(37, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 386);
            this.panel1.TabIndex = 24;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.Gainsboro;
            this.panelName.Controls.Add(this.lblStartGame);
            this.panelName.Controls.Add(this.txtBoxName);
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Location = new System.Drawing.Point(37, 16);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(521, 47);
            this.panelName.TabIndex = 24;
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(663, 524);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panelGameZone.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblUP;
        private System.Windows.Forms.Panel panelGameZone;
        private System.Windows.Forms.Label lblWallDown4;
        private System.Windows.Forms.Label lblWallUp4;
        private System.Windows.Forms.Label lblWallDown3;
        private System.Windows.Forms.Label lblWallUp3;
        private System.Windows.Forms.Label lblWallDown2;
        private System.Windows.Forms.Label lblWallUp2;
        private System.Windows.Forms.Label lblWallDown1;
        private System.Windows.Forms.Label lblWallUp1;
        private System.Windows.Forms.Label lblBoxGame;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Timer TimerForBox;
        private System.Windows.Forms.Timer timerStartGame;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Timer timerContainerLocation;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
    }
}
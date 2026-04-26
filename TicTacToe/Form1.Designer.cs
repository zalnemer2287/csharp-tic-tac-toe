namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newgameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountForXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountForOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDrawCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.xWinCount = new System.Windows.Forms.Label();
            this.drawCount = new System.Windows.Forms.Label();
            this.oWinCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.P2 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newgameToolStripMenuItem,
            this.clearBoardToolStripMenuItem,
            this.resetCountsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newgameToolStripMenuItem
            // 
            this.newgameToolStripMenuItem.Name = "newgameToolStripMenuItem";
            this.newgameToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.newgameToolStripMenuItem.Text = "New Game";
            this.newgameToolStripMenuItem.Click += new System.EventHandler(this.newgameToolStripMenuItem_Click);
            // 
            // clearBoardToolStripMenuItem
            // 
            this.clearBoardToolStripMenuItem.Name = "clearBoardToolStripMenuItem";
            this.clearBoardToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.clearBoardToolStripMenuItem.Text = "Clear Board";
            this.clearBoardToolStripMenuItem.Click += new System.EventHandler(this.clearBoardToolStripMenuItem_Click);
            // 
            // resetCountsToolStripMenuItem
            // 
            this.resetCountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllCountsToolStripMenuItem,
            this.resetWinCountForXToolStripMenuItem,
            this.resetWinCountForOToolStripMenuItem,
            this.resetDrawCountToolStripMenuItem});
            this.resetCountsToolStripMenuItem.Name = "resetCountsToolStripMenuItem";
            this.resetCountsToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.resetCountsToolStripMenuItem.Text = "Reset Counts";
            // 
            // resetAllCountsToolStripMenuItem
            // 
            this.resetAllCountsToolStripMenuItem.Name = "resetAllCountsToolStripMenuItem";
            this.resetAllCountsToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.resetAllCountsToolStripMenuItem.Text = "Reset All Counts";
            this.resetAllCountsToolStripMenuItem.Click += new System.EventHandler(this.resetAllCountsToolStripMenuItem_Click);
            // 
            // resetWinCountForXToolStripMenuItem
            // 
            this.resetWinCountForXToolStripMenuItem.Name = "resetWinCountForXToolStripMenuItem";
            this.resetWinCountForXToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.resetWinCountForXToolStripMenuItem.Text = "Reset Win Count for X";
            this.resetWinCountForXToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountForXToolStripMenuItem_Click);
            // 
            // resetWinCountForOToolStripMenuItem
            // 
            this.resetWinCountForOToolStripMenuItem.Name = "resetWinCountForOToolStripMenuItem";
            this.resetWinCountForOToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.resetWinCountForOToolStripMenuItem.Text = "Reset Win Count for O";
            this.resetWinCountForOToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountForOToolStripMenuItem_Click);
            // 
            // resetDrawCountToolStripMenuItem
            // 
            this.resetDrawCountToolStripMenuItem.Name = "resetDrawCountToolStripMenuItem";
            this.resetDrawCountToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.resetDrawCountToolStripMenuItem.Text = "Reset Draw Count";
            this.resetDrawCountToolStripMenuItem.Click += new System.EventHandler(this.resetDrawCountToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(51, 24);
            this.exitToolStripMenuItem1.Text = "Quit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 31);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(118, 137);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 2;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(118, 243);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 4;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(224, 243);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 5;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(12, 243);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(224, 137);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 137);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 8;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(224, 31);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 9;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(118, 31);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 10;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 361);
            this.label3.MaximumSize = new System.Drawing.Size(100, 15);
            this.label3.MinimumSize = new System.Drawing.Size(100, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Draw Count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xWinCount
            // 
            this.xWinCount.AutoSize = true;
            this.xWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWinCount.Location = new System.Drawing.Point(50, 387);
            this.xWinCount.Name = "xWinCount";
            this.xWinCount.Size = new System.Drawing.Size(17, 17);
            this.xWinCount.TabIndex = 14;
            this.xWinCount.Text = "0";
            // 
            // drawCount
            // 
            this.drawCount.AutoSize = true;
            this.drawCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCount.Location = new System.Drawing.Point(157, 387);
            this.drawCount.Name = "drawCount";
            this.drawCount.Size = new System.Drawing.Size(17, 17);
            this.drawCount.TabIndex = 15;
            this.drawCount.Text = "0";
            // 
            // oWinCount
            // 
            this.oWinCount.AutoSize = true;
            this.oWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWinCount.Location = new System.Drawing.Point(264, 387);
            this.oWinCount.Name = "oWinCount";
            this.oWinCount.Size = new System.Drawing.Size(17, 17);
            this.oWinCount.TabIndex = 16;
            this.oWinCount.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // P2
            // 
            this.P2.ForeColor = System.Drawing.Color.Blue;
            this.P2.Location = new System.Drawing.Point(224, 358);
            this.P2.AutoSize = false;
            this.P2.BackColor = System.Drawing.Color.White;
            this.P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(100, 22);
            this.P2.TabIndex = 18;
            this.P2.Text = "Player 2 (O)";
            this.P2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P1
            // 
            this.P1.ForeColor = System.Drawing.Color.Red;
            this.P1.Location = new System.Drawing.Point(12, 358);
            this.P1.AutoSize = false;
            this.P1.BackColor = System.Drawing.Color.White;
            this.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(100, 22);
            this.P1.TabIndex = 17;
            this.P1.Text = "Player 1 (X)";
            this.P1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 413);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.oWinCount);
            this.Controls.Add(this.drawCount);
            this.Controls.Add(this.xWinCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newgameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xWinCount;
        private System.Windows.Forms.Label drawCount;
        private System.Windows.Forms.Label oWinCount;
        private System.Windows.Forms.ToolStripMenuItem resetCountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllCountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountForXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountForOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDrawCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearBoardToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P1;
    }
}


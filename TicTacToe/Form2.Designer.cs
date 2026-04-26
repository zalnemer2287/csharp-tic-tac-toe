namespace TicTacToe
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.singlePlayer = new System.Windows.Forms.Button();
            this.doublePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 (X) Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2 (O) Name:";
            // 
            // P1
            // 
            this.P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.Location = new System.Drawing.Point(191, 109);
            this.P1.MaxLength = 13;
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(269, 22);
            this.P1.TabIndex = 2;
            this.P1.Text = "Player 1";
            this.P1.DoubleClick += new System.EventHandler(this.P1_DoubleClick);
            this.P1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.play);
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(191, 151);
            this.P2.MaxLength = 13;
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(269, 22);
            this.P2.TabIndex = 3;
            this.P2.Text = "Player 2 ";
            this.P2.DoubleClick += new System.EventHandler(this.P1_DoubleClick);
            this.P2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.play);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // singlePlayer
            // 
            this.singlePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayer.Location = new System.Drawing.Point(12, 12);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(218, 80);
            this.singlePlayer.TabIndex = 5;
            this.singlePlayer.Text = "Single Player";
            this.singlePlayer.UseVisualStyleBackColor = true;
            this.singlePlayer.Click += new System.EventHandler(this.singlePlayer_Click);
            // 
            // doublePlayer
            // 
            this.doublePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doublePlayer.Location = new System.Drawing.Point(242, 12);
            this.doublePlayer.Name = "doublePlayer";
            this.doublePlayer.Size = new System.Drawing.Size(218, 80);
            this.doublePlayer.TabIndex = 6;
            this.doublePlayer.Text = "Double Player";
            this.doublePlayer.UseVisualStyleBackColor = true;
            this.doublePlayer.Click += new System.EventHandler(this.doublePlayer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 239);
            this.Controls.Add(this.doublePlayer);
            this.Controls.Add(this.singlePlayer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 286);
            this.MinimumSize = new System.Drawing.Size(490, 286);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox P1;
        private System.Windows.Forms.TextBox P2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button singlePlayer;
        private System.Windows.Forms.Button doublePlayer;
    }
}
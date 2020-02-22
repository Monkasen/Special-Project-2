namespace Special_Project_2
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
            this.btn_Player1Card1 = new System.Windows.Forms.Button();
            this.btn_Player1Card2 = new System.Windows.Forms.Button();
            this.btn_Player2Card2 = new System.Windows.Forms.Button();
            this.btn_Player2Card1 = new System.Windows.Forms.Button();
            this.lbl_Player1Card1 = new System.Windows.Forms.Label();
            this.lbl_Player1Card2 = new System.Windows.Forms.Label();
            this.lbl_Player2Card2 = new System.Windows.Forms.Label();
            this.lbl_Player2Card1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.pb_HidePlayer1Cards = new System.Windows.Forms.PictureBox();
            this.pb_HidePlayer2Cards = new System.Windows.Forms.PictureBox();
            this.lbl_Player1Turn = new System.Windows.Forms.Label();
            this.lbl_Player2Turn = new System.Windows.Forms.Label();
            this.timer_TurnStart = new System.Windows.Forms.Timer(this.components);
            this.btn_Draw = new System.Windows.Forms.Button();
            this.btn_Fold = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Swap = new System.Windows.Forms.Button();
            this.lbl_GameTxt = new System.Windows.Forms.Label();
            this.lbl_Comm1 = new System.Windows.Forms.Label();
            this.btn_Comm1 = new System.Windows.Forms.Button();
            this.lbl_Comm2 = new System.Windows.Forms.Label();
            this.btn_Comm2 = new System.Windows.Forms.Button();
            this.lbl_Comm3 = new System.Windows.Forms.Label();
            this.btn_Comm3 = new System.Windows.Forms.Button();
            this.lbl_Comm4 = new System.Windows.Forms.Label();
            this.btn_Comm4 = new System.Windows.Forms.Button();
            this.lbl_Comm5 = new System.Windows.Forms.Label();
            this.btn_Comm5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HidePlayer1Cards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HidePlayer2Cards)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Player1Card1
            // 
            this.btn_Player1Card1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Player1Card1.Enabled = false;
            this.btn_Player1Card1.Location = new System.Drawing.Point(7, 38);
            this.btn_Player1Card1.Name = "btn_Player1Card1";
            this.btn_Player1Card1.Size = new System.Drawing.Size(124, 149);
            this.btn_Player1Card1.TabIndex = 0;
            this.btn_Player1Card1.UseVisualStyleBackColor = false;
            // 
            // btn_Player1Card2
            // 
            this.btn_Player1Card2.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Player1Card2.Enabled = false;
            this.btn_Player1Card2.Location = new System.Drawing.Point(7, 207);
            this.btn_Player1Card2.Name = "btn_Player1Card2";
            this.btn_Player1Card2.Size = new System.Drawing.Size(124, 149);
            this.btn_Player1Card2.TabIndex = 1;
            this.btn_Player1Card2.UseVisualStyleBackColor = false;
            // 
            // btn_Player2Card2
            // 
            this.btn_Player2Card2.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Player2Card2.Enabled = false;
            this.btn_Player2Card2.Location = new System.Drawing.Point(786, 207);
            this.btn_Player2Card2.Name = "btn_Player2Card2";
            this.btn_Player2Card2.Size = new System.Drawing.Size(124, 149);
            this.btn_Player2Card2.TabIndex = 6;
            this.btn_Player2Card2.UseVisualStyleBackColor = false;
            // 
            // btn_Player2Card1
            // 
            this.btn_Player2Card1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Player2Card1.Enabled = false;
            this.btn_Player2Card1.Location = new System.Drawing.Point(785, 38);
            this.btn_Player2Card1.Name = "btn_Player2Card1";
            this.btn_Player2Card1.Size = new System.Drawing.Size(124, 149);
            this.btn_Player2Card1.TabIndex = 5;
            this.btn_Player2Card1.UseVisualStyleBackColor = false;
            // 
            // lbl_Player1Card1
            // 
            this.lbl_Player1Card1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Player1Card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Player1Card1.Location = new System.Drawing.Point(12, 45);
            this.lbl_Player1Card1.Name = "lbl_Player1Card1";
            this.lbl_Player1Card1.Size = new System.Drawing.Size(114, 136);
            this.lbl_Player1Card1.TabIndex = 10;
            this.lbl_Player1Card1.Text = "1";
            this.lbl_Player1Card1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Player1Card2
            // 
            this.lbl_Player1Card2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Player1Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Player1Card2.Location = new System.Drawing.Point(12, 214);
            this.lbl_Player1Card2.Name = "lbl_Player1Card2";
            this.lbl_Player1Card2.Size = new System.Drawing.Size(114, 136);
            this.lbl_Player1Card2.TabIndex = 11;
            this.lbl_Player1Card2.Text = "2";
            this.lbl_Player1Card2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Player2Card2
            // 
            this.lbl_Player2Card2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Player2Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Player2Card2.Location = new System.Drawing.Point(791, 214);
            this.lbl_Player2Card2.Name = "lbl_Player2Card2";
            this.lbl_Player2Card2.Size = new System.Drawing.Size(114, 136);
            this.lbl_Player2Card2.TabIndex = 16;
            this.lbl_Player2Card2.Text = "2";
            this.lbl_Player2Card2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Player2Card1
            // 
            this.lbl_Player2Card1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Player2Card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Player2Card1.Location = new System.Drawing.Point(790, 45);
            this.lbl_Player2Card1.Name = "lbl_Player2Card1";
            this.lbl_Player2Card1.Size = new System.Drawing.Size(114, 136);
            this.lbl_Player2Card1.TabIndex = 15;
            this.lbl_Player2Card1.Text = "1";
            this.lbl_Player2Card1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(518, 381);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 20;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(323, 381);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(75, 23);
            this.btn_NewGame.TabIndex = 21;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // pb_HidePlayer1Cards
            // 
            this.pb_HidePlayer1Cards.Location = new System.Drawing.Point(7, 12);
            this.pb_HidePlayer1Cards.Name = "pb_HidePlayer1Cards";
            this.pb_HidePlayer1Cards.Size = new System.Drawing.Size(136, 363);
            this.pb_HidePlayer1Cards.TabIndex = 32;
            this.pb_HidePlayer1Cards.TabStop = false;
            this.pb_HidePlayer1Cards.Visible = false;
            // 
            // pb_HidePlayer2Cards
            // 
            this.pb_HidePlayer2Cards.Location = new System.Drawing.Point(774, 12);
            this.pb_HidePlayer2Cards.Name = "pb_HidePlayer2Cards";
            this.pb_HidePlayer2Cards.Size = new System.Drawing.Size(136, 363);
            this.pb_HidePlayer2Cards.TabIndex = 33;
            this.pb_HidePlayer2Cards.TabStop = false;
            this.pb_HidePlayer2Cards.Visible = false;
            // 
            // lbl_Player1Turn
            // 
            this.lbl_Player1Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Player1Turn.Location = new System.Drawing.Point(12, 91);
            this.lbl_Player1Turn.Name = "lbl_Player1Turn";
            this.lbl_Player1Turn.Size = new System.Drawing.Size(123, 90);
            this.lbl_Player1Turn.TabIndex = 34;
            this.lbl_Player1Turn.Text = "Player 1";
            this.lbl_Player1Turn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Player1Turn.Visible = false;
            // 
            // lbl_Player2Turn
            // 
            this.lbl_Player2Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Player2Turn.Location = new System.Drawing.Point(780, 91);
            this.lbl_Player2Turn.Name = "lbl_Player2Turn";
            this.lbl_Player2Turn.Size = new System.Drawing.Size(123, 90);
            this.lbl_Player2Turn.TabIndex = 35;
            this.lbl_Player2Turn.Text = "Player 2";
            this.lbl_Player2Turn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Player2Turn.Visible = false;
            // 
            // timer_TurnStart
            // 
            this.timer_TurnStart.Interval = 1000;
            this.timer_TurnStart.Tick += new System.EventHandler(this.timer_TurnStart_Tick);
            // 
            // btn_Draw
            // 
            this.btn_Draw.Enabled = false;
            this.btn_Draw.Location = new System.Drawing.Point(420, 352);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(75, 23);
            this.btn_Draw.TabIndex = 36;
            this.btn_Draw.Text = "Draw";
            this.btn_Draw.UseVisualStyleBackColor = true;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // btn_Fold
            // 
            this.btn_Fold.Enabled = false;
            this.btn_Fold.Location = new System.Drawing.Point(518, 352);
            this.btn_Fold.Name = "btn_Fold";
            this.btn_Fold.Size = new System.Drawing.Size(75, 23);
            this.btn_Fold.TabIndex = 37;
            this.btn_Fold.Text = "Fold";
            this.btn_Fold.UseVisualStyleBackColor = true;
            this.btn_Fold.Click += new System.EventHandler(this.btn_Fold_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Enabled = false;
            this.btn_Check.Location = new System.Drawing.Point(323, 352);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 38;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Swap
            // 
            this.btn_Swap.Enabled = false;
            this.btn_Swap.Location = new System.Drawing.Point(420, 381);
            this.btn_Swap.Name = "btn_Swap";
            this.btn_Swap.Size = new System.Drawing.Size(75, 23);
            this.btn_Swap.TabIndex = 39;
            this.btn_Swap.Text = "Swap Player";
            this.btn_Swap.UseVisualStyleBackColor = true;
            this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
            // 
            // lbl_GameTxt
            // 
            this.lbl_GameTxt.AutoSize = true;
            this.lbl_GameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_GameTxt.Location = new System.Drawing.Point(390, 24);
            this.lbl_GameTxt.Name = "lbl_GameTxt";
            this.lbl_GameTxt.Size = new System.Drawing.Size(100, 24);
            this.lbl_GameTxt.TabIndex = 40;
            this.lbl_GameTxt.Text = "what is this";
            // 
            // lbl_Comm1
            // 
            this.lbl_Comm1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Comm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Comm1.Location = new System.Drawing.Point(149, 126);
            this.lbl_Comm1.Name = "lbl_Comm1";
            this.lbl_Comm1.Size = new System.Drawing.Size(114, 136);
            this.lbl_Comm1.TabIndex = 42;
            this.lbl_Comm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Comm1
            // 
            this.btn_Comm1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Comm1.Enabled = false;
            this.btn_Comm1.Location = new System.Drawing.Point(144, 119);
            this.btn_Comm1.Name = "btn_Comm1";
            this.btn_Comm1.Size = new System.Drawing.Size(124, 149);
            this.btn_Comm1.TabIndex = 41;
            this.btn_Comm1.UseVisualStyleBackColor = false;
            // 
            // lbl_Comm2
            // 
            this.lbl_Comm2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Comm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Comm2.Location = new System.Drawing.Point(274, 126);
            this.lbl_Comm2.Name = "lbl_Comm2";
            this.lbl_Comm2.Size = new System.Drawing.Size(114, 136);
            this.lbl_Comm2.TabIndex = 44;
            this.lbl_Comm2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Comm2
            // 
            this.btn_Comm2.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Comm2.Enabled = false;
            this.btn_Comm2.Location = new System.Drawing.Point(269, 119);
            this.btn_Comm2.Name = "btn_Comm2";
            this.btn_Comm2.Size = new System.Drawing.Size(124, 149);
            this.btn_Comm2.TabIndex = 43;
            this.btn_Comm2.UseVisualStyleBackColor = false;
            // 
            // lbl_Comm3
            // 
            this.lbl_Comm3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Comm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Comm3.Location = new System.Drawing.Point(399, 126);
            this.lbl_Comm3.Name = "lbl_Comm3";
            this.lbl_Comm3.Size = new System.Drawing.Size(114, 136);
            this.lbl_Comm3.TabIndex = 46;
            this.lbl_Comm3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Comm3
            // 
            this.btn_Comm3.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Comm3.Enabled = false;
            this.btn_Comm3.Location = new System.Drawing.Point(394, 119);
            this.btn_Comm3.Name = "btn_Comm3";
            this.btn_Comm3.Size = new System.Drawing.Size(124, 149);
            this.btn_Comm3.TabIndex = 45;
            this.btn_Comm3.UseVisualStyleBackColor = false;
            // 
            // lbl_Comm4
            // 
            this.lbl_Comm4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Comm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Comm4.Location = new System.Drawing.Point(524, 126);
            this.lbl_Comm4.Name = "lbl_Comm4";
            this.lbl_Comm4.Size = new System.Drawing.Size(114, 136);
            this.lbl_Comm4.TabIndex = 48;
            this.lbl_Comm4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Comm4
            // 
            this.btn_Comm4.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Comm4.Enabled = false;
            this.btn_Comm4.Location = new System.Drawing.Point(519, 119);
            this.btn_Comm4.Name = "btn_Comm4";
            this.btn_Comm4.Size = new System.Drawing.Size(124, 149);
            this.btn_Comm4.TabIndex = 47;
            this.btn_Comm4.UseVisualStyleBackColor = false;
            // 
            // lbl_Comm5
            // 
            this.lbl_Comm5.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Comm5.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.lbl_Comm5.Location = new System.Drawing.Point(649, 126);
            this.lbl_Comm5.Name = "lbl_Comm5";
            this.lbl_Comm5.Size = new System.Drawing.Size(114, 136);
            this.lbl_Comm5.TabIndex = 50;
            this.lbl_Comm5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Comm5
            // 
            this.btn_Comm5.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Comm5.Enabled = false;
            this.btn_Comm5.Location = new System.Drawing.Point(644, 119);
            this.btn_Comm5.Name = "btn_Comm5";
            this.btn_Comm5.Size = new System.Drawing.Size(124, 149);
            this.btn_Comm5.TabIndex = 49;
            this.btn_Comm5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.lbl_Comm5);
            this.Controls.Add(this.btn_Comm5);
            this.Controls.Add(this.lbl_Comm4);
            this.Controls.Add(this.btn_Comm4);
            this.Controls.Add(this.lbl_Comm3);
            this.Controls.Add(this.btn_Comm3);
            this.Controls.Add(this.lbl_Comm2);
            this.Controls.Add(this.btn_Comm2);
            this.Controls.Add(this.lbl_Comm1);
            this.Controls.Add(this.btn_Comm1);
            this.Controls.Add(this.lbl_GameTxt);
            this.Controls.Add(this.btn_Swap);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_Fold);
            this.Controls.Add(this.btn_Draw);
            this.Controls.Add(this.lbl_Player2Turn);
            this.Controls.Add(this.lbl_Player1Turn);
            this.Controls.Add(this.pb_HidePlayer2Cards);
            this.Controls.Add(this.pb_HidePlayer1Cards);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Player2Card2);
            this.Controls.Add(this.lbl_Player2Card1);
            this.Controls.Add(this.lbl_Player1Card2);
            this.Controls.Add(this.lbl_Player1Card1);
            this.Controls.Add(this.btn_Player2Card2);
            this.Controls.Add(this.btn_Player2Card1);
            this.Controls.Add(this.btn_Player1Card2);
            this.Controls.Add(this.btn_Player1Card1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_HidePlayer1Cards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HidePlayer2Cards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Player1Card1;
        private System.Windows.Forms.Button btn_Player1Card2;
        private System.Windows.Forms.Button btn_Player2Card2;
        private System.Windows.Forms.Button btn_Player2Card1;
        private System.Windows.Forms.Label lbl_Player1Card1;
        private System.Windows.Forms.Label lbl_Player1Card2;
        private System.Windows.Forms.Label lbl_Player2Card2;
        private System.Windows.Forms.Label lbl_Player2Card1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.PictureBox pb_HidePlayer1Cards;
        private System.Windows.Forms.PictureBox pb_HidePlayer2Cards;
        private System.Windows.Forms.Label lbl_Player1Turn;
        private System.Windows.Forms.Label lbl_Player2Turn;
        private System.Windows.Forms.Timer timer_TurnStart;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.Button btn_Fold;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Swap;
        private System.Windows.Forms.Label lbl_GameTxt;
        private System.Windows.Forms.Label lbl_Comm1;
        private System.Windows.Forms.Button btn_Comm1;
        private System.Windows.Forms.Label lbl_Comm2;
        private System.Windows.Forms.Button btn_Comm2;
        private System.Windows.Forms.Label lbl_Comm3;
        private System.Windows.Forms.Button btn_Comm3;
        private System.Windows.Forms.Label lbl_Comm4;
        private System.Windows.Forms.Button btn_Comm4;
        private System.Windows.Forms.Label lbl_Comm5;
        private System.Windows.Forms.Button btn_Comm5;
    }
}


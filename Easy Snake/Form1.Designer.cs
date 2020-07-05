namespace Easy_Snake
{
    partial class ESForm1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESForm1));
            this.bStart = new System.Windows.Forms.Button();
            this.bAbout = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tTick = new System.Windows.Forms.Timer(this.components);
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.lScore1 = new System.Windows.Forms.Label();
            this.lScore2 = new System.Windows.Forms.Label();
            this.lGameOver1 = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.lGamePaused = new System.Windows.Forms.Label();
            this.bControls = new System.Windows.Forms.Button();
            this.bOptions = new System.Windows.Forms.Button();
            this.puTimer = new System.Windows.Forms.Timer(this.components);
            this.ShowPUTimer = new System.Windows.Forms.Timer(this.components);
            this.lPressEsc = new System.Windows.Forms.Label();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.bStart.Location = new System.Drawing.Point(245, 52);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(260, 80);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start!";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bAbout
            // 
            this.bAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.bAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.bAbout.Location = new System.Drawing.Point(245, 310);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(260, 80);
            this.bAbout.TabIndex = 3;
            this.bAbout.Text = "About";
            this.bAbout.UseVisualStyleBackColor = false;
            this.bAbout.Click += new System.EventHandler(this.bAbout_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.bExit.Location = new System.Drawing.Point(245, 396);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(260, 80);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tTick
            // 
            this.tTick.Interval = 200;
            this.tTick.Tick += new System.EventHandler(this.tTick_Tick);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(584, 506);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 13);
            this.l1.TabIndex = 4;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(584, 519);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 13);
            this.l2.TabIndex = 5;
            // 
            // lScore1
            // 
            this.lScore1.AutoSize = true;
            this.lScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lScore1.Location = new System.Drawing.Point(15, 505);
            this.lScore1.Name = "lScore1";
            this.lScore1.Size = new System.Drawing.Size(99, 31);
            this.lScore1.TabIndex = 6;
            this.lScore1.Text = "Score:";
            this.lScore1.Visible = false;
            // 
            // lScore2
            // 
            this.lScore2.AutoSize = true;
            this.lScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lScore2.Location = new System.Drawing.Point(120, 505);
            this.lScore2.Name = "lScore2";
            this.lScore2.Size = new System.Drawing.Size(30, 31);
            this.lScore2.TabIndex = 7;
            this.lScore2.Text = "0";
            this.lScore2.Visible = false;
            // 
            // lGameOver1
            // 
            this.lGameOver1.AutoSize = true;
            this.lGameOver1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(156)))));
            this.lGameOver1.Font = new System.Drawing.Font("Segoe UI Black", 45.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGameOver1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lGameOver1.Location = new System.Drawing.Point(185, 200);
            this.lGameOver1.Name = "lGameOver1";
            this.lGameOver1.Size = new System.Drawing.Size(380, 82);
            this.lGameOver1.TabIndex = 10;
            this.lGameOver1.Text = "Game over!";
            this.lGameOver1.Visible = false;
            this.lGameOver1.Click += new System.EventHandler(this.lGameOver1_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.lGamePaused);
            this.StatusPanel.Location = new System.Drawing.Point(1, 502);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(749, 38);
            this.StatusPanel.TabIndex = 12;
            // 
            // lGamePaused
            // 
            this.lGamePaused.AutoSize = true;
            this.lGamePaused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lGamePaused.Font = new System.Drawing.Font("Segoe UI Black", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGamePaused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lGamePaused.Location = new System.Drawing.Point(236, -8);
            this.lGamePaused.Name = "lGamePaused";
            this.lGamePaused.Size = new System.Drawing.Size(278, 46);
            this.lGamePaused.TabIndex = 13;
            this.lGamePaused.Text = "Game is paused";
            this.lGamePaused.Visible = false;
            // 
            // bControls
            // 
            this.bControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.bControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.bControls.Location = new System.Drawing.Point(245, 224);
            this.bControls.Name = "bControls";
            this.bControls.Size = new System.Drawing.Size(260, 80);
            this.bControls.TabIndex = 2;
            this.bControls.Text = "Controls";
            this.bControls.UseVisualStyleBackColor = false;
            this.bControls.Click += new System.EventHandler(this.bInstruct_Click);
            // 
            // bOptions
            // 
            this.bOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.bOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.bOptions.Location = new System.Drawing.Point(245, 138);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(260, 80);
            this.bOptions.TabIndex = 1;
            this.bOptions.Text = "Options";
            this.bOptions.UseVisualStyleBackColor = false;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // puTimer
            // 
            this.puTimer.Interval = 1000;
            this.puTimer.Tick += new System.EventHandler(this.puTimer_Tick);
            // 
            // ShowPUTimer
            // 
            this.ShowPUTimer.Interval = 6000;
            this.ShowPUTimer.Tick += new System.EventHandler(this.ShowPUTimer_Tick);
            // 
            // lPressEsc
            // 
            this.lPressEsc.AutoSize = true;
            this.lPressEsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lPressEsc.Font = new System.Drawing.Font("Segoe UI Black", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPressEsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lPressEsc.Location = new System.Drawing.Point(176, 287);
            this.lPressEsc.Name = "lPressEsc";
            this.lPressEsc.Size = new System.Drawing.Size(399, 46);
            this.lPressEsc.TabIndex = 14;
            this.lPressEsc.Text = "Press \"Escape\" to exit!";
            this.lPressEsc.Visible = false;
            // 
            // ESForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(751, 541);
            this.Controls.Add(this.bOptions);
            this.Controls.Add(this.bControls);
            this.Controls.Add(this.lGameOver1);
            this.Controls.Add(this.lScore2);
            this.Controls.Add(this.lScore1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.lPressEsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ESForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESForm1_KeyDown);
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bAbout;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Timer tTick;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label lScore1;
        private System.Windows.Forms.Label lScore2;
        private System.Windows.Forms.Label lGameOver1;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Button bControls;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Timer puTimer;
        private System.Windows.Forms.Label lGamePaused;
        private System.Windows.Forms.Timer ShowPUTimer;
        private System.Windows.Forms.Label lPressEsc;

    }
}


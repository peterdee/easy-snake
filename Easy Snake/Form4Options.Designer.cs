namespace Easy_Snake
{
    partial class Form4Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4Options));
            this.cbPower = new System.Windows.Forms.CheckBox();
            this.lDifficulty = new System.Windows.Forms.Label();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbExtreme = new System.Windows.Forms.RadioButton();
            this.cbDeveloper = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbPower
            // 
            this.cbPower.AutoSize = true;
            this.cbPower.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.cbPower.Location = new System.Drawing.Point(12, 173);
            this.cbPower.Name = "cbPower";
            this.cbPower.Size = new System.Drawing.Size(327, 43);
            this.cbPower.TabIndex = 4;
            this.cbPower.Text = "Enable power-ups";
            this.cbPower.UseVisualStyleBackColor = true;
            this.cbPower.CheckedChanged += new System.EventHandler(this.cbPower_CheckedChanged);
            // 
            // lDifficulty
            // 
            this.lDifficulty.AutoSize = true;
            this.lDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lDifficulty.Location = new System.Drawing.Point(12, 9);
            this.lDifficulty.Name = "lDifficulty";
            this.lDifficulty.Size = new System.Drawing.Size(271, 39);
            this.lDifficulty.TabIndex = 2;
            this.lDifficulty.Text = "Select difficulty:";
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.rbEasy.Location = new System.Drawing.Point(19, 50);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(115, 43);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.rbNormal.Location = new System.Drawing.Point(19, 99);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(151, 43);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.rbHard.Location = new System.Drawing.Point(181, 50);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(113, 43);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbExtreme
            // 
            this.rbExtreme.AutoSize = true;
            this.rbExtreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbExtreme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.rbExtreme.Location = new System.Drawing.Point(181, 99);
            this.rbExtreme.Name = "rbExtreme";
            this.rbExtreme.Size = new System.Drawing.Size(168, 43);
            this.rbExtreme.TabIndex = 3;
            this.rbExtreme.Text = "Extreme";
            this.rbExtreme.UseVisualStyleBackColor = true;
            this.rbExtreme.CheckedChanged += new System.EventHandler(this.rbExtreme_CheckedChanged);
            // 
            // cbDeveloper
            // 
            this.cbDeveloper.AutoSize = true;
            this.cbDeveloper.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.cbDeveloper.Location = new System.Drawing.Point(12, 222);
            this.cbDeveloper.Name = "cbDeveloper";
            this.cbDeveloper.Size = new System.Drawing.Size(484, 43);
            this.cbDeveloper.TabIndex = 5;
            this.cbDeveloper.Text = "Show developer information";
            this.cbDeveloper.UseVisualStyleBackColor = true;
            this.cbDeveloper.CheckedChanged += new System.EventHandler(this.cbDeveloper_CheckedChanged);
            // 
            // Form4Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(524, 311);
            this.Controls.Add(this.cbDeveloper);
            this.Controls.Add(this.rbExtreme);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.lDifficulty);
            this.Controls.Add(this.cbPower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Snake  : :  Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPower;
        private System.Windows.Forms.Label lDifficulty;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbExtreme;
        private System.Windows.Forms.CheckBox cbDeveloper;
    }
}
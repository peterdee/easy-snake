namespace Easy_Snake
{
    partial class Form3Instr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3Instr));
            this.lControls = new System.Windows.Forms.Label();
            this.lOther = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lControlsWASD = new System.Windows.Forms.Label();
            this.lControlsArrows = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lControls
            // 
            this.lControls.AutoSize = true;
            this.lControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lControls.Location = new System.Drawing.Point(-3, 10);
            this.lControls.Name = "lControls";
            this.lControls.Size = new System.Drawing.Size(530, 31);
            this.lControls.TabIndex = 2;
            this.lControls.Text = "Use arrows or keys to control the snake";
            // 
            // lOther
            // 
            this.lOther.AutoSize = true;
            this.lOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lOther.Location = new System.Drawing.Point(8, 187);
            this.lOther.Name = "lOther";
            this.lOther.Size = new System.Drawing.Size(508, 31);
            this.lOther.TabIndex = 3;
            this.lOther.Text = "Press \'P\' to pause and \'Esc\' to escape";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Image = global::Easy_Snake.Properties.Resources.Escape;
            this.label2.Location = new System.Drawing.Point(307, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = global::Easy_Snake.Properties.Resources.Pause;
            this.label1.Location = new System.Drawing.Point(128, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "    ";
            // 
            // lControlsWASD
            // 
            this.lControlsWASD.AutoSize = true;
            this.lControlsWASD.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lControlsWASD.Image = global::Easy_Snake.Properties.Resources.ControlsWASD;
            this.lControlsWASD.Location = new System.Drawing.Point(269, 71);
            this.lControlsWASD.Name = "lControlsWASD";
            this.lControlsWASD.Size = new System.Drawing.Size(157, 97);
            this.lControlsWASD.TabIndex = 1;
            this.lControlsWASD.Text = "     ";
            // 
            // lControlsArrows
            // 
            this.lControlsArrows.AutoSize = true;
            this.lControlsArrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lControlsArrows.Image = global::Easy_Snake.Properties.Resources.ControlsArrows;
            this.lControlsArrows.Location = new System.Drawing.Point(90, 71);
            this.lControlsArrows.Name = "lControlsArrows";
            this.lControlsArrows.Size = new System.Drawing.Size(157, 97);
            this.lControlsArrows.TabIndex = 0;
            this.lControlsArrows.Text = "     ";
            // 
            // Form3Instr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(524, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lOther);
            this.Controls.Add(this.lControls);
            this.Controls.Add(this.lControlsWASD);
            this.Controls.Add(this.lControlsArrows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3Instr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Snake  : :  Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lControlsArrows;
        private System.Windows.Forms.Label lControlsWASD;
        private System.Windows.Forms.Label lControls;
        private System.Windows.Forms.Label lOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace Easy_Snake
{
    partial class Form2About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2About));
            this.lAuthor = new System.Windows.Forms.Label();
            this.lProject = new System.Windows.Forms.Label();
            this.lCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lAuthor.Location = new System.Drawing.Point(83, 132);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(361, 39);
            this.lAuthor.TabIndex = 0;
            this.lAuthor.Text = "Author: Peter Dyumin";
            // 
            // lProject
            // 
            this.lProject.AutoSize = true;
            this.lProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lProject.Location = new System.Drawing.Point(83, 80);
            this.lProject.Name = "lProject";
            this.lProject.Size = new System.Drawing.Size(342, 39);
            this.lProject.TabIndex = 2;
            this.lProject.Text = "Project: Easy Snake";
            // 
            // lCopy
            // 
            this.lCopy.AutoSize = true;
            this.lCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.lCopy.Location = new System.Drawing.Point(19, 263);
            this.lCopy.Name = "lCopy";
            this.lCopy.Size = new System.Drawing.Size(485, 39);
            this.lCopy.TabIndex = 3;
            this.lCopy.Text = "pete dee © 2013, CGI cource";
            // 
            // Form2About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(524, 311);
            this.Controls.Add(this.lCopy);
            this.Controls.Add(this.lProject);
            this.Controls.Add(this.lAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Easy Snake  : :  About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.Label lProject;
        private System.Windows.Forms.Label lCopy;
    }
}
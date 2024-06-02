namespace BusinessApplication
{
    partial class SignInSignUpDesktop
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
            this.exit = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(245, 296);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(341, 49);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.header.Location = new System.Drawing.Point(52, 85);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(714, 42);
            this.header.TabIndex = 6;
            this.header.Text = "Mobile Shop Management System";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(236, 226);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(350, 49);
            this.enter.TabIndex = 9;
            this.enter.Text = "Sign In";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignInSignUpDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.header);
            this.Controls.Add(this.exit);
            this.Name = "SignInSignUpDesktop";
            this.Text = "SignInSignUpDesktop";
            this.Load += new System.EventHandler(this.SignInSignUpDesktop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button button1;
    }
}
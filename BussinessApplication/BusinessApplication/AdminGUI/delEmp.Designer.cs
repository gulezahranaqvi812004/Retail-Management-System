namespace BusinessApplication
{
    partial class delEmp
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
            this.header = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(185, 61);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(393, 28);
            this.header.TabIndex = 18;
            this.header.Text = "Mobile shop management system";
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(290, 118);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(147, 28);
            this.menu.TabIndex = 19;
            this.menu.Text = "Admin Menu";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(112, 358);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 44);
            this.exit.TabIndex = 30;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(601, 358);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(96, 44);
            this.ok.TabIndex = 29;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(171, 256);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 28;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(295, 255);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(243, 26);
            this.password.TabIndex = 27;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(295, 191);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(243, 26);
            this.name.TabIndex = 26;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(205, 190);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Name";
            // 
            // delEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.Name = "delEmp";
            this.Text = "delEmp";
            this.Load += new System.EventHandler(this.delEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
    }
}
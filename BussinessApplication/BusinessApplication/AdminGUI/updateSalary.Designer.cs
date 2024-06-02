namespace BusinessApplication
{
    partial class updateSalary
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
            this.menu = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(288, 102);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(147, 28);
            this.menu.TabIndex = 20;
            this.menu.Text = "Admin Menu";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(177, 45);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(393, 28);
            this.header.TabIndex = 19;
            this.header.Text = "Mobile shop management system";
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(273, 287);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(238, 26);
            this.salaryBox.TabIndex = 32;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salary.Location = new System.Drawing.Point(167, 288);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(68, 25);
            this.salary.TabIndex = 31;
            this.salary.Text = "Salary";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(137, 229);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(273, 230);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(238, 26);
            this.password.TabIndex = 29;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(273, 166);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(238, 26);
            this.name.TabIndex = 28;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(171, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(78, 368);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(85, 30);
            this.exit.TabIndex = 33;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // updateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.Name = "updateSalary";
            this.Text = "updateSalary";
            this.Load += new System.EventHandler(this.updateSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
    }
}
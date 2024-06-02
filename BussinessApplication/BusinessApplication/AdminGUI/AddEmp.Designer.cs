namespace BusinessApplication
{
    partial class AddEmp
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(177, 193);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(279, 194);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(238, 26);
            this.name.TabIndex = 20;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(143, 257);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(279, 258);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(238, 26);
            this.password.TabIndex = 21;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(56, 391);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(85, 30);
            this.exit.TabIndex = 24;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salary.Location = new System.Drawing.Point(173, 316);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(68, 25);
            this.salary.TabIndex = 25;
            this.salary.Text = "Salary";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(279, 315);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(238, 26);
            this.salaryBox.TabIndex = 26;
            this.salaryBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(584, 391);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(85, 30);
            this.ok.TabIndex = 27;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 42);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mobile Shop Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(141, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 42);
            this.label2.TabIndex = 67;
            this.label2.Text = "Add a new employee";
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddEmp";
            this.Text = "AddEmp";
            this.Load += new System.EventHandler(this.AddEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace BusinessApplication
{
    partial class ViewDevices
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
            this.Uname = new System.Windows.Forms.TextBox();
            this.Urole = new System.Windows.Forms.TextBox();
            this.uPassword = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exit.Location = new System.Drawing.Point(737, 479);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(110, 41);
            this.exit.TabIndex = 42;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(101, 204);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(150, 26);
            this.Uname.TabIndex = 47;
            // 
            // Urole
            // 
            this.Urole.Location = new System.Drawing.Point(315, 204);
            this.Urole.Name = "Urole";
            this.Urole.Size = new System.Drawing.Size(146, 26);
            this.Urole.TabIndex = 48;
            // 
            // uPassword
            // 
            this.uPassword.Location = new System.Drawing.Point(536, 204);
            this.uPassword.Name = "uPassword";
            this.uPassword.Size = new System.Drawing.Size(134, 26);
            this.uPassword.TabIndex = 49;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(97, 167);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(51, 20);
            this.UserName.TabIndex = 50;
            this.UserName.Text = "Name";
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Location = new System.Drawing.Point(553, 167);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(78, 20);
            this.UserPassword.TabIndex = 51;
            this.UserPassword.Text = "Password";
            // 
            // UserRole
            // 
            this.UserRole.AutoSize = true;
            this.UserRole.Location = new System.Drawing.Point(323, 167);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(42, 20);
            this.UserRole.TabIndex = 52;
            this.UserRole.Text = "Role";
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ok.Location = new System.Drawing.Point(101, 479);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(110, 41);
            this.ok.TabIndex = 53;
            this.ok.Text = "Add";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Role,
            this.Password,
            this.salary});
            this.dataGridView1.Location = new System.Drawing.Point(88, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(837, 200);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uSalary
            // 
            this.uSalary.Location = new System.Drawing.Point(726, 204);
            this.uSalary.Name = "uSalary";
            this.uSalary.Size = new System.Drawing.Size(134, 26);
            this.uSalary.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Salary";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.update.Location = new System.Drawing.Point(255, 479);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 41);
            this.update.TabIndex = 57;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.del.Location = new System.Drawing.Point(397, 479);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(110, 41);
            this.del.TabIndex = 58;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // import
            // 
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.import.Location = new System.Drawing.Point(557, 479);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(141, 41);
            this.import.TabIndex = 59;
            this.import.Text = "Import Data";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(106, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(714, 42);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mobile Shop Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(156, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(642, 42);
            this.label4.TabIndex = 62;
            this.label4.Text = "Employee Management Portal";
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // Role
            // 
            this.Role.Frozen = true;
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            this.Role.Width = 150;
            // 
            // Password
            // 
            this.Password.Frozen = true;
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // salary
            // 
            this.salary.Frozen = true;
            this.salary.HeaderText = "Salary";
            this.salary.MinimumWidth = 8;
            this.salary.Name = "salary";
            this.salary.Width = 150;
            // 
            // ViewDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.import);
            this.Controls.Add(this.del);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uSalary);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.UserRole);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.uPassword);
            this.Controls.Add(this.Urole);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.exit);
            this.Name = "ViewDevices";
            this.Load += new System.EventHandler(this.ViewDevices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox Urole;
        private System.Windows.Forms.TextBox uPassword;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Label UserRole;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox uSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}
namespace BusinessApplication
{
    partial class AdminMenu
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
            this.empAdd = new System.Windows.Forms.Button();
            this.delEmp = new System.Windows.Forms.Button();
            this.viewEmp = new System.Windows.Forms.Button();
            this.updateEmp = new System.Windows.Forms.Button();
            this.addDevice = new System.Windows.Forms.Button();
            this.delDevice = new System.Windows.Forms.Button();
            this.viewDevice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(446, 345);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 36);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // empAdd
            // 
            this.empAdd.Location = new System.Drawing.Point(102, 150);
            this.empAdd.Name = "empAdd";
            this.empAdd.Size = new System.Drawing.Size(217, 36);
            this.empAdd.TabIndex = 8;
            this.empAdd.Text = "Add an employee";
            this.empAdd.UseVisualStyleBackColor = true;
            this.empAdd.Click += new System.EventHandler(this.empAdd_Click);
            // 
            // delEmp
            // 
            this.delEmp.Location = new System.Drawing.Point(446, 150);
            this.delEmp.Name = "delEmp";
            this.delEmp.Size = new System.Drawing.Size(226, 36);
            this.delEmp.TabIndex = 9;
            this.delEmp.Text = "Delete an employee";
            this.delEmp.UseVisualStyleBackColor = true;
            this.delEmp.Click += new System.EventHandler(this.delEmp_Click);
            // 
            // viewEmp
            // 
            this.viewEmp.Location = new System.Drawing.Point(446, 219);
            this.viewEmp.Name = "viewEmp";
            this.viewEmp.Size = new System.Drawing.Size(226, 36);
            this.viewEmp.TabIndex = 10;
            this.viewEmp.Text = "Maintain expenditures";
            this.viewEmp.UseVisualStyleBackColor = true;
            this.viewEmp.Click += new System.EventHandler(this.viewEmp_Click);
            // 
            // updateEmp
            // 
            this.updateEmp.Location = new System.Drawing.Point(252, 402);
            this.updateEmp.Name = "updateEmp";
            this.updateEmp.Size = new System.Drawing.Size(217, 36);
            this.updateEmp.TabIndex = 11;
            this.updateEmp.Text = "Update Salary ";
            this.updateEmp.UseVisualStyleBackColor = true;
            this.updateEmp.Click += new System.EventHandler(this.updateEmp_Click);
            // 
            // addDevice
            // 
            this.addDevice.Location = new System.Drawing.Point(102, 287);
            this.addDevice.Name = "addDevice";
            this.addDevice.Size = new System.Drawing.Size(217, 36);
            this.addDevice.TabIndex = 12;
            this.addDevice.Text = "Add a device";
            this.addDevice.UseVisualStyleBackColor = true;
            this.addDevice.Click += new System.EventHandler(this.addDevice_Click);
            // 
            // delDevice
            // 
            this.delDevice.Location = new System.Drawing.Point(446, 271);
            this.delDevice.Name = "delDevice";
            this.delDevice.Size = new System.Drawing.Size(226, 36);
            this.delDevice.TabIndex = 13;
            this.delDevice.Text = "Delete device";
            this.delDevice.UseVisualStyleBackColor = true;
            this.delDevice.Click += new System.EventHandler(this.delDevice_Click);
            // 
            // viewDevice
            // 
            this.viewDevice.Location = new System.Drawing.Point(93, 219);
            this.viewDevice.Name = "viewDevice";
            this.viewDevice.Size = new System.Drawing.Size(217, 36);
            this.viewDevice.TabIndex = 14;
            this.viewDevice.Text = "Maintain Employees";
            this.viewDevice.UseVisualStyleBackColor = true;
            this.viewDevice.Click += new System.EventHandler(this.viewDevice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(714, 42);
            this.label2.TabIndex = 61;
            this.label2.Text = "Mobile Shop Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(245, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 62;
            this.label1.Text = "Admin Menu";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewDevice);
            this.Controls.Add(this.delDevice);
            this.Controls.Add(this.addDevice);
            this.Controls.Add(this.updateEmp);
            this.Controls.Add(this.viewEmp);
            this.Controls.Add(this.delEmp);
            this.Controls.Add(this.empAdd);
            this.Controls.Add(this.exit);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button empAdd;
        private System.Windows.Forms.Button delEmp;
        private System.Windows.Forms.Button viewEmp;
        private System.Windows.Forms.Button updateEmp;
        private System.Windows.Forms.Button addDevice;
        private System.Windows.Forms.Button delDevice;
        private System.Windows.Forms.Button viewDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace Employee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textboxEmpID = new TextBox();
            textboxFName = new TextBox();
            textboxLName = new TextBox();
            textboxPosi = new TextBox();
            dataGridViewEmployeList = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            buttonSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Empolyee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 111);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Employee ID *";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 166);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 221);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Last Name *";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 285);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Position *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(335, 35);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 5;
            label6.Text = "Employee List:";
            // 
            // textboxEmpID
            // 
            textboxEmpID.Location = new Point(43, 129);
            textboxEmpID.Name = "textboxEmpID";
            textboxEmpID.Size = new Size(199, 23);
            textboxEmpID.TabIndex = 6;
            textboxEmpID.TextChanged += EmpID_TextChanged;
            // 
            // textboxFName
            // 
            textboxFName.Location = new Point(43, 184);
            textboxFName.Name = "textboxFName";
            textboxFName.Size = new Size(199, 23);
            textboxFName.TabIndex = 7;
            textboxFName.TextChanged += FName_TextChanged;
            // 
            // textboxLName
            // 
            textboxLName.Location = new Point(43, 239);
            textboxLName.Name = "textboxLName";
            textboxLName.Size = new Size(199, 23);
            textboxLName.TabIndex = 8;
            textboxLName.TextChanged += LName_TextChanged;
            // 
            // textboxPosi
            // 
            textboxPosi.Location = new Point(43, 303);
            textboxPosi.Name = "textboxPosi";
            textboxPosi.Size = new Size(199, 23);
            textboxPosi.TabIndex = 9;
            textboxPosi.TextChanged += Posi_TextChanged;
            // 
            // dataGridViewEmployeList
            // 
            dataGridViewEmployeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployeList.Columns.AddRange(new DataGridViewColumn[] { ID, FirstName, LastName, Position });
            dataGridViewEmployeList.Location = new Point(331, 71);
            dataGridViewEmployeList.Name = "dataGridViewEmployeList";
            dataGridViewEmployeList.Size = new Size(603, 441);
            dataGridViewEmployeList.TabIndex = 10;
            dataGridViewEmployeList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 25;
            ID.Name = "ID";
            ID.Width = 140;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.Name = "FirstName";
            FirstName.Width = 140;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            LastName.Width = 140;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.Name = "Position";
            Position.Width = 140;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(50, 377);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(172, 78);
            buttonSubmit.TabIndex = 11;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 540);
            Controls.Add(buttonSubmit);
            Controls.Add(dataGridViewEmployeList);
            Controls.Add(textboxPosi);
            Controls.Add(textboxLName);
            Controls.Add(textboxFName);
            Controls.Add(textboxEmpID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textboxEmpID;
        private TextBox textboxFName;
        private TextBox textboxLName;
        private TextBox textboxPosi;
        private DataGridView dataGridViewEmployeList;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Position;
        private Button buttonSubmit;
    }
}

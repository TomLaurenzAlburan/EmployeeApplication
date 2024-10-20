namespace Employee
{
    public partial class Form1 : Form
    {
        public string EmpID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Posi { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.buttonSubmit.Enabled = true;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Posi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.createHeaders();

        }
        public Form1(string EmpID, string FName, string LName, string Posi)
        {
            
            this.EmpID = EmpID;
            this.FName = FName;
            this.LName = LName;
            this.Posi = Posi;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string empID = this.textboxEmpID.Text;
            string fName = this.textboxFName.Text;
            string lName = this.textboxLName.Text;
            string posi = this.textboxPosi.Text;


            this.dataGridViewEmployeList.Rows.Add(empID, fName, lName, posi);


            this.clearFields();
            this.buttonSubmit.Enabled = true;
        }

        private object[] getFields()
        {

            return new object[] { this.EmpID, this.FName, this.LName, this.Posi };
        }

        private void createHeaders()
        {
            this.dataGridViewEmployeList.Columns.Add("col_id", "ID");
            this.dataGridViewEmployeList.Columns.Add("col_fName", "First Name");
            this.dataGridViewEmployeList.Columns.Add("col_lName", "Last Name");
            this.dataGridViewEmployeList.Columns.Add("col_position", "Position");
        }
        private void clearFields()
        {
            this.textboxEmpID.Clear();
            this.textboxFName.Clear();
            this.textboxLName.Clear();
            this.textboxPosi.Clear();
            this.textboxEmpID.Focus();

            this.buttonSubmit.Enabled = false;

        }
        private void enableSubmitButton()
        {
            if (this.textboxEmpID.Text.Length > 0 && this.textboxFName.Text.Length > 0 && this.textboxLName.Text.Length > 0 && this.textboxPosi.Text.Length > 0)
            {
                this.buttonSubmit.Enabled = true;
            }
        }
        private void textBoxPosi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSubmit.PerformClick();
            }
            this.enableSubmitButton();
        }
        private void textBoxEmpID_KeyUp(object sender, KeyEventArgs e)
        {
            this.enableSubmitButton();
        }
        private void textBoxFName_KeyUp(object sender, KeyEventArgs e)
        {
            this.enableSubmitButton();
        }
        private void dataGridViewEmployeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

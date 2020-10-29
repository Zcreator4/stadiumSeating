using System;
using System.Windows.Forms;

namespace stadiumSeating
{
    public partial class frmStadiumSeating : Form
    {
        public frmStadiumSeating()
        {
            InitializeComponent();
        }

        private void btnCalculateIncome_Click(object sender, EventArgs e)
        {
            const int CLASS_A_COST = 15;
            const int CLASS_B_COST = 12;
            const int CLASS_C_COST = 9;

            String classATicketsStr = txtClassA.Text;
            String classBTicketsStr = txtClassB.Text;
            String classCTicketsStr = txtClassC.Text;

            int classATicketsSoldNum = Convert.ToInt32(classATicketsStr);
            int classBTicketsSoldNum = Convert.ToInt32(classBTicketsStr);
            int classCTicketsSoldNum = Convert.ToInt32(classCTicketsStr);

            int ClassAIncomeNum = classATicketsSoldNum * CLASS_A_COST;
            int ClassBIncomeNum = classBTicketsSoldNum * CLASS_B_COST;
            int ClassCIncomeNum = classCTicketsSoldNum * CLASS_C_COST;

            int totalIncome = ClassAIncomeNum + ClassBIncomeNum + ClassCIncomeNum;

            txtClassAIncome.Text = ClassAIncomeNum.ToString("C");
            txtClassBIncome.Text = ClassBIncomeNum.ToString("C");
            txtClassCIncome.Text = ClassCIncomeNum.ToString("C");
            txtTotalIncome.Text = totalIncome.ToString("C");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Clear();
            txtClassB.Clear();
            txtClassC.Clear();

            txtClassAIncome.Clear();
            txtClassBIncome.Clear();
            txtClassCIncome.Clear();
            txtTotalIncome.Clear();

            txtClassA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmStadiumSeating_Load(object sender, EventArgs e)
        {

        }
    }
}




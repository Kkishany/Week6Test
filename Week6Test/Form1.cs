using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Week6Test
{
    
    public partial class Form1 : Form
    {
        private SqlConnection conobj;
        private SqlCommand cmdobj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            private void button1_Click(object sender, EventArgs e)
            {
                using (Conobj = new SqlConnection(ConfigurationManager.ConnectionStrings["mastercon"].ConnectionString))
                {
                    using (adaobj = new SqlDataAdapter("Select * from Employee", Conobj))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(adaobj);
                        ds = new DataSet();
                        adaobj.Fill(ds, "Employee");



                        DataRow dr = ds.Tables["Employee"].NewRow();
                        dr["EmployeeNo"] = TxtEmployeeNo.Text;
                        dr["EmployeeName"] = TxtEmployeeName.Text;
                        dr["EmployeeSalary"] = TxtEmployeeSalary.Text;
                        dr["EmployeeType"] = grpEmployeeType.Text;
                        if (radiopayroll.Checked)
                        {
                            dr["EmployeeType"] = 'p';
                        }
                        else
                        {
                            dr["EmployeeType"] = 'c';
                        }
                    }
    }
}

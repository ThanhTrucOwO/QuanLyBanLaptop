using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.UtilsGUI;
using static BUS.EmployeeManage;
using System.Xml.Linq;
using static GUI.FormMainMenu;
using static Utils.Number;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormAuthenEmployee : Form
    {
        private Auth auth = new Auth();
        public FormAuthenEmployee()
        {
            InitializeComponent();
            initializationDataEmployee();
        }
        public void initializationDataEmployee()
        {
            tb_employee.ColumnCount = 3;
            tb_employee.Columns[0].Name = "Mã nhân viên";
            tb_employee.Columns[1].Name = "Tên nhân viên";
            tb_employee.Columns[2].Name = "Chức vụ";
            autoSizetb(tb_employee);
            

            
            setDataEmployee(listEmployee());
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FormEmployee fEmployee = new FormEmployee();
            guna2Panel1.Controls.Clear();
            fEmployee.TopLevel = false;
            guna2Panel1.Controls.Add(fEmployee);
            fEmployee.Dock = DockStyle.Fill;
            fEmployee.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FormEmployee fEmployee = new FormEmployee();
            guna2Panel1.Controls.Clear();
            fEmployee.TopLevel = false;
            guna2Panel1.Controls.Add(fEmployee);
            fEmployee.Dock = DockStyle.Fill;
            fEmployee.Show();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            if (tb_employee.RowCount > 1)
                if (tb_employee.CurrentRow != null)
                {
                    int rowindex = tb_employee.CurrentCell.RowIndex;
                    if (tb_employee.Rows.Count - 2 >= rowindex)
                    {
                        tb_employee.ReadOnly = true;
                        string id = tb_employee.Rows[rowindex].Cells[0].Value.ToString();
                        bool quyen = radAdmin.Checked;
                        string result = auth.saveAuth(id, quyen);
                        if (result == "success")
                        {
                            MessageBox.Show("Đã sửa đổi quyền", "Thông báo", MessageBoxButtons.OK);
                            setDataEmployee(listEmployee());
                        }
                        else
                            MessageBox.Show("fail", "Thông báo", MessageBoxButtons.OK);
                    }

                }
        }
        public void setDataEmployee(List<NhanVien> list)
        {
            List<NhanVien> result = new List<NhanVien>();
            foreach (NhanVien item in list)
            {
                if (item.Id != ("admin"))
                    result.Add(item);
            }
            tb_employee.Rows.Clear();

            foreach (NhanVien item in result)
            {

                string[] row = new string[] { item.Id, item.Name,item.ServiceEmployee
                   };
                tb_employee.Rows.Add(row);
            }
        }
        private void tb_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.inp_search.Text;
            List<NhanVien> list = searchEmployee(search);
            setDataEmployee(list);
        }

        private void radEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

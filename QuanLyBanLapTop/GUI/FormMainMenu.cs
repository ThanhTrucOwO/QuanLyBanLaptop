using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.FormSell;
using static BUS.Login;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormMainMenu : Form
    {
        FormPromotion fPromotion = new FormPromotion();
        FormSell fSell = new FormSell();
        FormProduct fProduct = new FormProduct();
        FormCustomer fCustomer = new FormCustomer();
        FormEmployee fEmployee = new FormEmployee();
        public static List<Panel> listPanel = new List<Panel>();
        FormBill fBill = new FormBill();
        FormProductType formProductType = new FormProductType();
        FormProductManufacture fProductManufacture = new FormProductManufacture();
        FormWareHouse fWarehouse = new FormWareHouse();
        FormStatistic formStatistic = new FormStatistic();
        private Auth control = new Auth();
        FormAuthenEmployee formAuthenEmployee = new FormAuthenEmployee();
        

        public static string path = "D:\\E\\DoAnC-_QuanLyBanLapTop\\Image\\";

        public FormMainMenu()
        {
            InitializeComponent();
            addListPanel();
            incognitoPanel();
            checkKeyUser();
        }
        public void checkKeyUser()
        {
            int idQuyen = currentAcc.IdQuyen;
            QuyenDTO quyen = control.auth(idQuyen);
            
            if (quyen.NameAuth == "admin" || quyen.NameAuth == "manager")
            {
                    
                if (!quyen.NameAuth.Contains("admin"))
                    this.cart_Quyen.Dispose();
            }
            else
            {
                
                this.btn_product.Dispose();
                this.btn_promotion.Dispose();
                this.btn_employee.Dispose();
                this.btn_customer.Dispose();
                this.btn_warehouse.Dispose();
                this.btn_statistical.Dispose();
            }

        }
        public void incognitoPanel()
        {
            foreach(Panel value in listPanel)
            {
                value.Visible = false;
            }

        }
        public static void displayPanel(Panel p)
        {
            foreach (Panel value in listPanel)
            {
                value.Visible = false;
            }
            if (p != null)
            {
               
                p.Visible = true;
            }
        }
        public void addListPanel()
        {
            listPanel.Add(this.panel_sell);
            listPanel.Add(this.panel_product);
            listPanel.Add(this.panel_employee);
            

        }


        private void btn_promotion_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fPromotion = new FormPromotion();
                pnlBody.Controls.Clear();
                fPromotion.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fPromotion);
                
                fPromotion.Show();
                displayPanel(null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            fSell = new FormSell();
            displayPanel(this.panel_sell);
            pnlBody.Controls.Clear();
            fSell.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fSell);
           
            fSell.Show();



        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
               
                fProduct = new FormProduct();
                displayPanel(this.panel_product);
                pnlBody.Controls.Clear();
                fProduct.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fProduct);
                
                fProduct.Show();
            }
            
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fCustomer = new FormCustomer();
                pnlBody.Controls.Clear();
                fCustomer.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fCustomer);
                
                fCustomer.Show();
                displayPanel(null);
            }
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fEmployee = new FormEmployee();
                displayPanel(this.panel_employee);
                pnlBody.Controls.Clear();
                fEmployee.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fEmployee);
                fEmployee.Show();
                displayPanel(panel_employee);
            }
        }

        private void btn_sellCart_Click(object sender, EventArgs e)
        {

            pnlBody.Controls.Clear();
            fSell = new FormSell();
            fSell.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fSell);
            
            fSell.Show();
            
        }
        public bool saveBill()
        {
            if (fSell.purchaseProduct.listChiTietHoaDonDTO.Count > 0)
            {
                var ev = MessageBox.Show("Hoá đơn chưa được lưu bạn có muốn lưu lại không", "Lưu hoá đơn", MessageBoxButtons.YesNoCancel);
                if (ev == DialogResult.Yes)
                {
                    string idBill = fSell.purchaseProduct.idBill + "";
                    fSell.purchaseProduct.saveOrder();
                    MessageBox.Show("Hoá đơn đã được lưu, mã hoá đơn: " + idBill, "Thông báo", MessageBoxButtons.OK);
                    fSell = new FormSell();
                    return true;

                }
                else if (ev == DialogResult.No)
                {
                    fSell.purchaseProduct.restartBill();
                    return true;
                }
                else{
                    return false;
                }

            }
            return true;
        }

        private void btn_billCart_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fBill = new FormBill();
                pnlBody.Controls.Clear();
                fBill.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fBill);
                
                fBill.Show();
                displayPanel(panel_sell);
            }

        }

        private void panel_sell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fWarehouse = new FormWareHouse();
                pnlBody.Controls.Clear();
                fWarehouse.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fWarehouse);
                
                fWarehouse.Show();
                displayPanel(null);
            }
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                formStatistic = new FormStatistic();
                pnlBody.Controls.Clear();
                formStatistic.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(formStatistic);
                
                formStatistic.Show();
                displayPanel(null);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fProduct.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fProduct);
            
            fProduct.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            formProductType = new FormProductType();
            formProductType.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(formProductType);
            
            formProductType.Show();
            displayPanel(panel_product);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fProductManufacture = new FormProductManufacture();
            fProductManufacture.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fProductManufacture);
            
            fProductManufacture.Show();
            displayPanel(panel_product);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cartEmployee_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fEmployee.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fEmployee);
            
            fEmployee.Show();
            
        }

        private void cart_employee_Click(object sender, EventArgs e)
        {
            
            pnlBody.Controls.Clear();
            fEmployee = new FormEmployee();
            fEmployee.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fEmployee);
            
            fEmployee.Show();
        }

        private void cart_Quyen_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            formAuthenEmployee.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(formAuthenEmployee);
            
            formAuthenEmployee.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using BUS;
using DTO;
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
using static BUS.CustomerManage;
using static BUS.BillManage;
using static Utils.Number;
using static GUI.FormMainMenu;
namespace GUI
{
    public partial class FormInfoCustomer : Form
    {
        private string idCustomer;
        private CustomerManage customerManage = new CustomerManage();
        private ProductManage productManage = new ProductManage();
        private BillManage billManage = new BillManage();
        FormCustomer fcustomer;
        public FormInfoCustomer(string idCustomer)
        {
            InitializeComponent();
            this.idCustomer = idCustomer;
            initializationDataBill();
            initializationDetails();
            initializationInfoCustomer();
        }
        public void initializationDataBill()
        {
            tb_bill.ColumnCount = 7;
            tb_bill.Columns[0].Name = "ID";
            tb_bill.Columns[1].Name = "Ngày tạo";
            tb_bill.Columns[2].Name = "Tổng tiền";
            tb_bill.Columns[3].Name = "Tiền đã giảm";
            tb_bill.Columns[4].Name = "Tiền phải trả";
            tb_bill.Columns[5].Name = "Trạng thái";
            tb_bill.Columns[6].Name = "Loại thanh toán";

            autoSizetb(tb_bill);
            setDataBill(customerManage.searchBillInCustomer(this.idCustomer));

        }
        public void initializationDetails()
        {
            tb_detailsBill.ColumnCount = 6;
            tb_detailsBill.Columns[0].Name = "Tên sản phẩm";
            tb_detailsBill.Columns[1].Name = "Đơn giá";
            tb_detailsBill.Columns[2].Name = "Số lượng mua";
            tb_detailsBill.Columns[3].Name = "Tổng tiền";
            tb_detailsBill.Columns[4].Name = "Tiền đã giảm";
            tb_detailsBill.Columns[5].Name = "Thành tiền";
            autoSizetb(tb_detailsBill);
        }
        public void initializationInfoCustomer()
        {
            KhachHang customer = customerManage.searchCustomerToId(this.idCustomer);
            txt_id.Text = customer.Id;
            txt_name.Text = customer.Name;
            txt_phone.Text = customer.Phone;
            txt_address.Text = customer.Address;
            txt_email.Text = customer.Email;
        }
        public void setDataBill(List<HoaDon> listBill)
        {

            this.tb_bill.Rows.Clear();
            foreach (HoaDon value in listBill)
            {
                
                string[] row = new string[] {value.IdBill.ToString(), value.DateBill.Day+"/"+value.DateBill.Month+"/"+value.DateBill.Year,
                    changeMoney(value.SumPay.ToString("0")),changeMoney(value.DiscountMoney.ToString("0")),changeMoney(value.Pay.ToString("0"))
                ,value.Status,value.TypePay};
                tb_bill.Rows.Add(row);
            }
        }
        public void setDataDetailsBill(int idBill)
        {
            this.tb_detailsBill.Rows.Clear();
            List<ChiTietHoaDonDTO> list = listDetailsBill(idBill);
            foreach (ChiTietHoaDonDTO item in list)
            {
                SanPham p = productManage.searchId(item.IdProduct);
                string[] row = new string[] {p.NameProduct, changeMoney(p.UnitPrice.ToString("0")),
                    item.QuantityProduct.ToString(), changeMoney((item.MoneyDown+item.IntoMoney).ToString("0")),
                    changeMoney(item.MoneyDown.ToString("0")),changeMoney(item.IntoMoney.ToString("0")) };
                tb_detailsBill.Rows.Add(row);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            string text = this.inp_search.Text;
            if (text == "")
            {
                List<HoaDon> list = billManage.searchBill(text, customerManage.searchBillInCustomer(this.idCustomer));
                setDataBill(list);
            }
        }

        private void eventClickCellBill(object sender, DataGridViewCellEventArgs e)
        {
            if (tb_bill.RowCount > 1)
                if (tb_bill.CurrentRow != null)
                {
                    int rowindex = tb_bill.CurrentCell.RowIndex;

                    if (rowindex <= tb_bill.RowCount - 2)
                    {
                        int idBill = int.Parse(tb_bill.Rows[rowindex].Cells[0].Value.ToString());
                        setDataDetailsBill(idBill);
                    }

                }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = this.inp_search.Text;
            List<HoaDon> list = billManage.searchBill(text, customerManage.searchBillInCustomer(this.idCustomer));
            setDataBill(list);
        }

        private void eventKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string text = this.inp_search.Text;
                List<HoaDon> list = billManage.searchBill(text, customerManage.searchBillInCustomer(this.idCustomer));
                setDataBill(list);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            fcustomer = new FormCustomer();
            pnlBody.Controls.Clear();
            fcustomer.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fcustomer);

            fcustomer.Show();
            displayPanel(null);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_detailsBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_Click(object sender, EventArgs e)
        {

        }

        private void txt_address_Click(object sender, EventArgs e)
        {

        }

        private void txt_phone_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_titleProduct_Click(object sender, EventArgs e)
        {

        }
    }
}

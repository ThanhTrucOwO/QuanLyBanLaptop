using BUS;
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
using static Utils.Number;

namespace GUI
{
    public partial class FormStatistic : Form
    {
        private ProductStatistics productStatistics = new ProductStatistics();
        private FormRankStatistic formRank;
        public FormStatistic()
        {
            InitializeComponent();
            InitializeTbStatistic();
            setDataYear();
            statisticAll(cbb_manux.Text);
            
            
        }
        public void statisticAll(string year)
        {
            Dictionary<string, string> statistic = productStatistics.overview(year);
            txt_customer.Text = statistic["customer"]+"";
            txt_employee.Text = statistic["employee"]+"";
            txt_nameProduct.Text = statistic["product"] + "";
            string total = float.Parse(statistic["total"]).ToString("0");
            total = changeMoney(total);



            txt_totalMoney.Text = total;
        }
        public void InitializeTbStatistic()
        {
            tb_month.ColumnCount = 5;
            tb_month.Columns[0].Name = "Quý";
            for(int i = 1; i < 5; i++)
            {
                tb_month.Columns[i].Name = "Quý "+(i).ToString();
            }
            autoSizetb(tb_month);

        }
        public void setDataTbStatistic(string year)
        {
            tb_month.Rows.Clear();
            Dictionary<string, string> sumMonth = productStatistics.totalMonth(year);
            string[] a = new string[5];
            a[0] = "Doanh thu";
            for (int i = 1; i <= 4; i++)
            {
                float sum = 0;
                for (int j = 0; j < 3; j++)
                    sum += float.Parse(sumMonth[(i*3-j).ToString()]);
                
                a[i] = changeMoney(sum.ToString("0")+"");
            }
            
            tb_month.Rows.Add(a);
        }
        public void setDataYear()
        {
            string[] year = { "2020", "2021","2022", "2023" };
            cbb_manux.DataSource = year;
            cbb_manux.SelectedIndex = 0;
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {

        }

        private void cbb_manu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = cbb_manux.Text;
            statisticAll(year);
            setDataTbStatistic(year);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //formCreateDetailPromotion.ShowDialog();
            //this.Show();
            this.formRank = new FormRankStatistic(this.cbb_manux.Text);
            pnlBody.Controls.Clear();
            formRank.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(formRank);
            
            formRank.Show();
        }
    }
}

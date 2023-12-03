using BUS;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Utils.Number;

namespace GUI
{
    public partial class FormRankStatistic : Form
    {
        private string year;
        private ProductStatistics productStatistics = new ProductStatistics();
        private FormStatistic formStatistic;
        public FormRankStatistic(string year)
        {
            InitializeComponent();
            this.year = year;
            InitializeTbTopProduct();
            setDataTopProduct(this.year);
            
            installChart(gunaChart1);
            this.label1.Text = "Biểu đồ doanh thu hàng tháng năm " + year;
        }
        public void InitializeTbTopProduct()
        {
            tb_topProduct.ColumnCount = 4;
            tb_topProduct.Columns[0].Name = "Top";
            tb_topProduct.Columns[1].Name = "Tên sản phẩm";
            tb_topProduct.Columns[2].Name = "Số lượng bán";
            tb_topProduct.Columns[3].Name = "Doanh thu";
        }

        public void installChart(Guna.Charts.WinForms.GunaChart chart)
        {

            
            Dictionary<string, string> data = productStatistics.totalMonth(year);
           
            // Data arrays.
            string[] seriesArray = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                seriesArray[i - 1] = "Tháng " + i.ToString();
            }

            float[] pointsArray = new float[12];

            for (int i = 1; i <= 12; i++)
            {
                pointsArray[i - 1] = float.Parse(float.Parse(data[i.ToString()]).ToString("0"));
            }
            //Chart configuration
            chart.Misc.BarCornerRadius = 10;
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            for (int i = 1; i <= 12; i++)
            {
                dataset.DataPoints.Add("Tháng " + i.ToString(), pointsArray[i-1]);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
        public void setDataTopProduct(string year)
        {
            List<Dictionary<string, string>> list = productStatistics.topProduct(year);
            tb_topProduct.Rows.Clear();
            int index = 1;
            foreach (Dictionary<string, string> item in list)
            {
                string[] row = new string[4];
                row[0] = index.ToString();
                row[1] = item["name"];
                row[3] = changeMoney(float.Parse(item["total"]).ToString("0"));
                row[2] = item["quantity"];
                index++;
                tb_topProduct.Rows.Add(row);
            }
        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            formStatistic = new FormStatistic();
            guna2Panel1.Controls.Clear();
            formStatistic.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(formStatistic);
            
            formStatistic.Show();
        }
    }

}

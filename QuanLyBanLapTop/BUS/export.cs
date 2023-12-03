
using DAO;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using DTO;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Number;


namespace BUS
{
    public class export
    {
        
        public static string exportBillExcel(HoaDon bill, List<ChiTietHoaDonDTO> listDt, List<SanPham> listP)
        {

            try
            {
                // khởi tạo wb rỗng
                XSSFWorkbook wb = new XSSFWorkbook();

                // Tạo ra 1 sheet
                ISheet sheet = wb.CreateSheet();

                // Bắt đầu ghi lên sheet

                // Tạo row
                var row0 = sheet.CreateRow(5);
                // Merge lại row đầu 3 cột
                row0.CreateCell(5); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
                sheet.AddMergedRegion(cellMerge);
                row0.GetCell(5).SetCellValue("Thông tin hoá đơn" + bill.IdBill);

                // Ghi tên cột ở row 1
                var row1 = sheet.CreateRow(6);
                row1.CreateCell(4).SetCellValue("Tên sản phẩm");
                row1.CreateCell(5).SetCellValue("Số lượng mua");
                row1.CreateCell(6).SetCellValue("Đơn giá");
                row1.CreateCell(7).SetCellValue("Tiền đã giảm");
                row1.CreateCell(8).SetCellValue("Thành tiền");
                // bắt đầu duyệt mảng và ghi tiếp tục
                int rowIndex = 7;
                for (int i = 0; i < listDt.Count; i++)
                {
                    var rowInd = sheet.CreateRow(rowIndex);
                    rowInd.CreateCell(4).SetCellValue(listP[i].NameProduct + "");
                    rowInd.CreateCell(5).SetCellValue(listDt[i].QuantityProduct + "");
                    rowInd.CreateCell(6).SetCellValue(changeMoney(listP[i].UnitPrice.ToString("0")) + "");
                    rowInd.CreateCell(7).SetCellValue(changeMoney(listDt[i].MoneyDown.ToString("0")) + "");
                    rowInd.CreateCell(8).SetCellValue(changeMoney((listDt[i].IntoMoney - listDt[i].MoneyDown).ToString("0")) + "");
                    rowIndex++;
                }
                var rowNext = sheet.CreateRow(rowIndex);
                rowNext.CreateCell(7).SetCellValue("Tổng thanh toán");
                rowNext.CreateCell(8).SetCellValue(changeMoney(bill.Pay.ToString("0")));

                rowIndex++;
                rowNext = sheet.CreateRow(rowIndex);
                rowNext.CreateCell(4).SetCellValue("Ngày thanh toán");
                rowNext.CreateCell(5).SetCellValue(bill.DateBill.ToString());

                rowIndex++;
                rowNext = sheet.CreateRow(rowIndex);
                rowNext.CreateCell(4).SetCellValue("Nhân viên thực hiện");

                rowNext.CreateCell(5).SetCellValue(new NhanVienDao().searchEmployee(bill.IdEmployee).Name);
                // xong hết thì save file lại
                FileStream fs = new FileStream(@"D:\E\DoAnC-_QuanLyBanLapTop\Excel\Bill\HoaDon_" + bill.IdBill + ".xlsx", FileMode.CreateNew);
                wb.Write(fs);
                return "success";
            }catch(Exception e)
            {
                return "error";
            }
        }

        public static void exportBillPDF(HoaDon bill, List<ChiTietHoaDonDTO> listDt, List<SanPham> listP)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Thông tin hoá đơn " + bill.IdBill;
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 16, XFontStyle.Bold);
            XFont fontContent = new XFont("Verdana", 10, XFontStyle.Regular);
            XFont fontItem = new XFont("Verdana", 8, XFontStyle.Regular);
            graph.DrawString("Thông tin hoá đơn " + bill.IdBill, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopCenter);
            graph.DrawString("Tên sản phẩm", fontContent, XBrushes.Black, new XRect(0,30, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Số lượng mua", fontContent, XBrushes.Black, new XRect(100, 30, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Đơn giá", fontContent, XBrushes.Black, new XRect(200, 30, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Tiền đã giảm", fontContent, XBrushes.Black, new XRect(300, 30, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Thành tiền", fontContent, XBrushes.Black, new XRect(400, 30, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            int y = 60;
            for (int i = 0; i < listDt.Count; i++)
            {
                graph.DrawString(listP[i].NameProduct.Substring(0,12)+"...", fontItem, XBrushes.Black, new XRect(0, y, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString(listDt[i].QuantityProduct.ToString(), fontItem, XBrushes.Black, new XRect(100, y, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString(changeMoney(listP[i].UnitPrice.ToString("0")), fontItem, XBrushes.Black, new XRect(200, y, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString(changeMoney(listDt[i].MoneyDown.ToString("0")) + "", fontItem, XBrushes.Black, new XRect(300, y, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString(changeMoney((listDt[i].IntoMoney - listDt[i].MoneyDown).ToString("0")) + "", fontItem, XBrushes.Black, new XRect(400, y, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                y += 20;
            }
            
            graph.DrawString("Tổng thanh toán "+ changeMoney(bill.Pay.ToString("0")), fontItem, XBrushes.Black, new XRect(250, y+=20, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Ngày thanh toán " + bill.DateBill.Day + "/" + bill.DateBill.Month + "/" + bill.DateBill.Year, fontItem, XBrushes.Black, new XRect(250, y+=20, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("Nhân viên thực hiện " + new NhanVienDao().searchEmployee(bill.IdEmployee).Name, fontItem, XBrushes.Black, new XRect(250, y += 20, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            string pdfFilename = "D:\\E\\DoAnC-_QuanLyBanLapTop\\PDF\\HoaDon_" + bill.IdBill + ".pdf";
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);
        }
        public static string exportExcelPromotion(Dictionary<string,string> listDetails, string name )
        {
            
            try
            {
                // khởi tạo wb rỗng
                XSSFWorkbook wb = new XSSFWorkbook();

                // Tạo ra 1 sheet
                ISheet sheet = wb.CreateSheet();

                // Bắt đầu ghi lên sheet

                // Tạo row
                var row0 = sheet.CreateRow(5);
                // Merge lại row đầu 3 cột
                row0.CreateCell(5); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
                sheet.AddMergedRegion(cellMerge);
                row0.GetCell(5).SetCellValue("Thông tin khuyến mãi " + name);

                // Ghi tên cột ở row 1
                var row1 = sheet.CreateRow(6);
                row1.CreateCell(4).SetCellValue("Tên sản phẩm");
                row1.CreateCell(5).SetCellValue("% giảm giá");

                // bắt đầu duyệt mảng và ghi tiếp tục
                int rowIndex = 7;
                foreach (var value in listDetails)
                {
                    var rowInd = sheet.CreateRow(rowIndex);
                    rowInd.CreateCell(4).SetCellValue(value.Key);
                    rowInd.CreateCell(5).SetCellValue(value.Value);
                    rowIndex++;
                }
                // xong hết thì save file lại
                FileStream fs = new FileStream(@"D:\E\DoAnC-_QuanLyBanLapTop\Excel\Promotion\KhuyenMai_" + name + ".xlsx", FileMode.CreateNew);
                wb.Write(fs);
            }catch(Exception e)
            {
                return "error";
            }
            return "success";
        }
        public static string exportExcelReceipt(PhieuYeuCauNhapHang p, List<ChiTietPhieuYeuCauNhapHangDTO> listDt, List<SanPham> listP)
        {
            
            try
            {
                // khởi tạo wb rỗng
                XSSFWorkbook wb = new XSSFWorkbook();

                // Tạo ra 1 sheet
                ISheet sheet = wb.CreateSheet();

                // Bắt đầu ghi lên sheet

                // Tạo row
                var row0 = sheet.CreateRow(5);
                // Merge lại row đầu 3 cột
                row0.CreateCell(5); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
                sheet.AddMergedRegion(cellMerge);
                row0.GetCell(5).SetCellValue("Thông tin phiếu nhập hàng " + p.IdCoupon);

                // Ghi tên cột ở row 1
                var row1 = sheet.CreateRow(6);
                row1.CreateCell(4).SetCellValue("Tên sản phẩm");
                row1.CreateCell(5).SetCellValue("Số lượng nhập");
                row1.CreateCell(6).SetCellValue("Đơn giá");
                
                // bắt đầu duyệt mảng và ghi tiếp tục
                int rowIndex = 7;
                
                for (int i = 0; i < listDt.Count; i++)
                {
                    var rowInd = sheet.CreateRow(rowIndex);
                    rowInd.CreateCell(4).SetCellValue(listP[i].NameProduct + "");
                    rowInd.CreateCell(5).SetCellValue(listDt[i].QuantityImport + "");
                    rowInd.CreateCell(6).SetCellValue(listP[i].UnitPrice.ToString("0") + "");
                    rowIndex++;
                }
                
                var rowNext = sheet.CreateRow(rowIndex);
                rowNext.CreateCell(7).SetCellValue("Tổng thanh toán");
                rowNext.CreateCell(8).SetCellValue(p.IntoMoney.ToString(".0"));
                
                rowIndex++;
                rowNext = sheet.CreateRow(rowIndex);
                rowNext.CreateCell(7).SetCellValue("Ngày lập");
                rowNext.CreateCell(8).SetCellValue(p.DateAdded.ToString());
                
                // xong hết thì save file lại
                FileStream fs = new FileStream(@"D:\E\DoAnC-_QuanLyBanLapTop\Excel\Receipt\PhieuNhapHang_" + p.IdCoupon + ".xlsx", FileMode.CreateNew);
                wb.Write(fs);
            }
            catch (Exception e)
            {
                return "error";
            }
            return "success";
        }
    }
}

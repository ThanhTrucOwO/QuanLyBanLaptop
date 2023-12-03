using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Auth
    {
        private QuyenDAO quyenDao = new QuyenDAO();
        private TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        private EmployeeManage employeeManage = new EmployeeManage();
        NhanVienDao nhanVienDao = new NhanVienDao();
        public QuyenDTO auth(int idQuyen)
        {
            return quyenDao.quyen(idQuyen);
        }
        public string saveAuth(string idEmployee, bool quyen)
        {
            if(idEmployee != null)
            {
                NhanVien employee = employeeManage.searchToId(idEmployee);
                string idQuyen = "";
                string service = "";
                if (!quyen)
                {
                    idQuyen = "7003";
                    service = "Nhân viên";
                    
                }

                else
                {
                    idQuyen = "7002";
                    service = "Quản lý";
                   
                }
                
                taiKhoanDAO.selectAuth(employee.IdUser, idQuyen);
                employee.ServiceEmployee = service;
                nhanVienDao.updateNhanVien(employee);
                return "success";
            }
            return "error";
        }
    }
}

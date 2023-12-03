using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using static BUS.export;

namespace BUS
{
    public class Login
    {
        public static UserDTO currentAcc = null;
        public string login(string userName, string pass)
        {
            if (userName == "")
                return "requeid_user";
            if (pass == "")
                return "requeid_pass";
            TaiKhoanDAO us = new TaiKhoanDAO();
            UserDTO userDTO = new UserDTO(userName, pass);
            UserDTO user = us.searchUser(userDTO);

            if(user != null)
            {
                currentAcc = user;
                return "success";
            }
            else
            {
                return "notFound";
            }
        }
        public void addUser(string user, string pass, string service)
        {

           UserDTO userDTO = new UserDTO(user, pass);
            userDTO.Id = user;
            if (service == "Quản lý")
                userDTO.IdQuyen = 7002;
            else
                userDTO.IdQuyen = 7003;
            new TaiKhoanDAO().addUser(userDTO);
        }

        public static List<UserDTO> listUser()
        {

            return new TaiKhoanDAO().listUser();
        }
    }
}

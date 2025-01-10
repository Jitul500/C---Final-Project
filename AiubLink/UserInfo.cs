using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public class UserInfo
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public DateTime DOB { get; set; }
        public string Password { get; set; }

        public UserInfo(string name, int phone, string userID, string email, byte[] photo, DateTime dob, string password)
        {
            Name = name;
            Phone = phone;
            UserID = userID;
            Email = email;
            Photo = photo;
            DOB = dob;
            Password = password;
        }
    }
}

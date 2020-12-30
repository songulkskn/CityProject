using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{ // mesela user 1 tane ama userın şehirleri çok tane *1-n kuramı*
    public class User
    {
        public User() {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<City> Cities { get; set; } // kullanıcının eklediği şehirler yani kullanıcının şehirleri var.

    }
}
     

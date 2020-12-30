using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{ // bir şehrin fotografları çok tane yani *1-n kuramı* , bir şehrin bir kullanıcı var yani *1-1 kuramı*
    public class City { 
        public  City()  // bu bir constrac.
        {
            Photos = new List<Photo>();
        }
        public int  Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Photo>  Photos{ get; set; } // şehrinlerin  fotoğrafları için
        public User user { get; set; } // şehrin ekleyeni yani kullanıcısı var.
    }
}

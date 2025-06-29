using GladiusObjex.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Sıpa
{
    public class Users : gsBase
    {
        private string _Name;
        [Display(Name = "Ad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Name { get => _Name; set { _Name = value; SetUpdated("Name", value); } }

        private string _LastName;
        [Display(Name = "Soy Ad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string LastName { get => _LastName; set { _LastName = value; SetUpdated("LastName", value); } }
        
        private string _EPosta;
        [Display(Name = "E-Posta")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string EPosta { get => _EPosta; set { _EPosta = value; SetUpdated("EPosta", value); } }

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private bool _IsAdmin;
        public bool IsAdmin { get => _IsAdmin; set { _IsAdmin = value; SetUpdated("IsAdmin", value); } }


        private string _UserName;
        [Display(Name = "Kullanıcı Ad")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string UserName { get => _UserName; set { _UserName = value; SetUpdated("UserName", value); } }
        

        private string _UserPass;
        [Display(Name = "Kullanıcı Şifre")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string UserPass { get => _UserPass; set { _UserPass = value; SetUpdated("UserPass", value); } }

        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }


        private string _PhoneNumber;
        [Display(Name = "Telefon No")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string PhoneNumber { get => _PhoneNumber; set { _PhoneNumber = value; SetUpdated("PhoneNumber", value); } }



    }
}

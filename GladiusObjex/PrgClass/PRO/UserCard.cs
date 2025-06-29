using GladiusObjex.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace GladiusObjex.PrgClass.PRO
{
    public class UserCard : gsBase
    {
        private string _Name;
        [Display(Name = "Ad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Name { get => _Name; set { _Name = value; SetUpdated("Name", value); } }

        private string _UserPhone;
        [Display(Name = "Telefon No")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string UserPhone { get => _UserPhone; set { _UserPhone = value; SetUpdated("UserPhone", value); } }


        private string _UserPhone2;
        [Display(Name = "Telefon No 2")]
        [DataType("nvarchar")]
        [StringLength(20)]
        public string UserPhone2 { get => _UserPhone2; set { _UserPhone2 = value; SetUpdated("UserPhone2", value); } }


        private string _LastName;
        [Display(Name = "Soyad")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string LastName { get => _LastName; set { _LastName = value; SetUpdated("LastName", value); } }


        private string _UserName;
        [Display(Name = "Kullanıcı Adı")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string UserName { get => _UserName; set { _UserName = value; SetUpdated("UserName", value); } }


        private string _UserPassword;
        [Display(Name = "Kullanıcı Şifresi")]
        [DataType("nvarchar")]
        [StringLength(500)]

        public string UserPassword { get => _UserPassword; set { _UserPassword = value; SetUpdated("UserPassword", value); } }



        private int _UserNo;
        public int UserNo { get => _UserNo; set { _UserNo = value; SetUpdated("UserNo", value); } }

        private int _UserType;
        public int UserType { get => _UserType; set { _UserType = value; SetUpdated("UserType", value); } }

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }


        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }

        public UserCard getuser(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            UserCard myUser = new UserCard();

            myUser = mng.GetObject<UserCard>(Ref);

            return myUser;
        }
        public UserCard()
        {
            TableName = "UserCard";
            Columns.Add(new ObjColumn("Name", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("LastName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserPassword", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserNo", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("UserPhone", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("UserPhone2", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));
            Columns.Add(new ObjColumn("UserType", SqlDbType.Int, "", false, false));



            this.Name = "";
            this.LastName = "";
            this.UserPassword = "";
            this.UserName = "";
            this.UserNo = 0;
            this.IsPassive = false;
            this.UserPhone = "";
            this.UserPhone2 = "";
            this.Image = null;
            this.UserType = 0;


        }
    }
}


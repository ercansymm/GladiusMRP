using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using GladiusObjex.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.PRO
{
    public class Clinets : gsBase
    {
        private string _ClinetAddres;
        [Display(Name = "Adres")]
        [DataType("nvarchar")]
        [StringLength(4000)]
        public string ClinetAddres { get => _ClinetAddres; set { _ClinetAddres = value; SetUpdated("ClinetAddres", value); } }

        private string _CardName;
        [Display(Name = "Adı")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(4000)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }



        private int _ClinetPhone;
        public int ClinetPhone { get => _ClinetPhone; set { _ClinetPhone = value; SetUpdated("ClinetPhone", value); } }
        
        private int _ClinetPhone2;
        public int ClinetPhone2 { get => _ClinetPhone2; set { _ClinetPhone2 = value; SetUpdated("ClinetPhone2", value); } }
          
        private int _ClinetPhone3;
        public int ClinetPhone3 { get => _ClinetPhone3; set { _ClinetPhone3 = value; SetUpdated("ClinetPhone3", value); } }

        private string _Taxoffice;
        [Display(Name = "VergiDaires")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string Taxoffice { get => _Taxoffice; set { _Taxoffice = value; SetUpdated("Taxoffice", value); } }
        
        private string _ClinetEmail;
        [Display(Name = "Email")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string ClinetEmail { get => _ClinetEmail; set { _ClinetEmail = value; SetUpdated("ClinetEmail", value); } }


        private int _ClinetNo;
        public int ClinetNo { get => _ClinetNo; set { _ClinetNo = value; SetUpdated("ClinetNo", value); } }

        private int _TaxNumber;
        public int TaxNumber { get => _TaxNumber; set { _TaxNumber = value; SetUpdated("TaxNumber", value); } }

        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private byte[] _Image;
        public byte[] Image { get => _Image; set { _Image = value; SetUpdated("Image", value); } }

        public Clinets GetClinets(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            Clinets myClinets = new Clinets();

            myClinets = mng.GetObject<Clinets>(Ref);

            return myClinets;
        }
        public Clinets()
        {
            TableName = "Clinet";
            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClinetAddres", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClinetPhone", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("ClinetPhone2", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("ClinetPhone3", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("ClinetNo", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Taxoffice", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("ClinetEmail", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("TaxNumber", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Image", SqlDbType.Image, "", false, false));


            this.TaxNumber = 0;
            this.Taxoffice = "";
            this.CardName = "";
            this.ClinetAddres = "";
            this.ClinetPhone = 0;
            this.ClinetPhone2= 0;
            this.ClinetPhone3= 0;
            this.ClinetNo = 0;
            this.IsPassive = false;
            this.Description = "";
            this.ClinetEmail = "";
            this.Image = null;



        }
    }
}

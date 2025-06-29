using DevExpress.XtraReports.UI;
using GladiusObjex.GKernel;
using GladiusObjex.Tool;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionGladius.SpecialClass
{
    public class BaseList
    {
        public Dictionary<int, string> CardType()
        {
            Dictionary<int, string> lst = new Dictionary<int, string>();

            lst.Add(0, "Mamül");
            lst.Add(1, "Yarı Mamül");
            lst.Add(2, "Hammadde");
            return lst;
        }

        public Dictionary<int, string> UserType()
        {
            Dictionary<int, string> lstc = new Dictionary<int, string>();
            lstc.Add(0, "Yönetici");
            lstc.Add(1, "Müdür");
            lstc.Add(2, "İşçi");

            return lstc;

        }



        public string createOrderNo(int year, string month, string firmCode)
        {
            string code = firmCode;
            string barcode = "";

            DbManager dbm = new DbManager(false, "erpConnStr");
            int lengthYear = (code.Length) + 1;
            int lengthMonth = (code.Length) + 5;

            int isOk = int.Parse(dbm.ExecuteScalar(String.Format(
       @"select count(WorkOrderNo) 
   from WorkOrder 
   where LEFT(WorkOrderNo, {0}) = '{1}' 
   AND SUBSTRING(WorkOrderNo, {2}, 4) = '{3}' 
   AND SUBSTRING(WorkOrderNo, {4}, 2) = '{5}'",
       code.Length, code, lengthYear, year, lengthMonth, month), CommandType.Text).ToString());

            if (isOk > 0)
            {
                string value = dbm.ExecuteScalar(String.Format(
            @"select top 1 WorkOrderNo 
       from WorkOrder 
       where LEFT(WorkOrderNo, {0}) = '{1}' 
       AND SUBSTRING(WorkOrderNo, {2}, 4) = '{3}' 
       AND SUBSTRING(WorkOrderNo, {4}, 2) = '{5}' 
       order by CAST(RIGHT(WorkOrderNo, 4) AS INT) desc",
            code.Length, code, lengthYear, year, lengthMonth, month), CommandType.Text).ToString();

                int lastValue = int.Parse(value.Substring(value.Length - 4, 4));

                lastValue++;

                string a = lastValue.ToString().PadLeft(6, '0');

                barcode = code + year.ToString() + month + a;
            }
            else
            {
                barcode = code + year.ToString() + month + "000001";
            }

            return barcode;
        }




        public string GetShortCode(DateTime ScTarih)
        {
            string myDate = ScTarih.ToString("yyMMdd"); // Tarih kısmını oluştur
            string nextBarcode;

            DbManager dbm = new DbManager(false, "erpConnStr");

            // SQL sorgusu ile en büyük barkodu al
            string query = $"SELECT TOP 1 Barcode FROM WorkPrint WHERE Barcode LIKE '{myDate}%' ORDER BY Barcode DESC";
            object result = dbm.ExecuteScalar(query, System.Data.CommandType.Text);

            if (result == null || result == DBNull.Value)
            {
                // Eğer barkod bulunamazsa 0001 ile başla
                nextBarcode = myDate + "0001";
            }
            else
            {
                // Bulunan barkodun sayısal kısmını artır
                string lastBarcode = result.ToString();
                int numericPart = int.Parse(lastBarcode.Substring(6, 4)); // Son 4 haneyi al
                nextBarcode = myDate + (numericPart + 1).ToString("D4"); // Artır ve 4 basamaklı yap
            }

            return nextBarcode;
        }


    }
}
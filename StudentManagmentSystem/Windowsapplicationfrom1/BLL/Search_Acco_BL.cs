using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1.BLL
{
    class Search_Acco_BL
    {
        public DataTable Search_ACCOANDSendToDAL(Accounts aACount)
        {
            DataTable result = null;
            if (aACount.AID == "")
            {

                return result;
            }

            else
            {
               Search_Acco_DAL sAdal = new Search_Acco_DAL();
                result = sAdal.SearchACCODAL(aACount);
                return result;

            }
        }
        public DataTable GetExistingSearchAccoFromBL()
        {
            Search_Acco_DAL sda = new Search_Acco_DAL();
            DataTable dt = sda.GetExisingSearchAccountinfo();
            return dt;
        }
    }
}


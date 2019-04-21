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
    class Search_Result_BL
    {
        public DataTable Search_RESANDSendToDAL(Result aRES)
        {
            DataTable result = null;
            if (aRES.ID =="")
            {

                return result;
            }

            else
            {
                Search_Result_DAL sRdal = new Search_Result_DAL();
                result = sRdal.SearchACCODAL(aRES);
                return result;

            }
        }
        public DataTable GetExistingSearchRESFromBL()
        {
            Search_Result_DAL sRda = new Search_Result_DAL();
            DataTable dt = sRda.GetExisingSearchResultinfo();
            return dt;
        }
    }
}
    


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
    class Search_Student_BL
    {
        public DataTable Search_StudentANDSendToDAL(Search aSearch)
        {
            DataTable result = null;
            if (aSearch.Id == "" && aSearch.Name == "" && aSearch.Age == 0 && aSearch.Faculty == "" && aSearch.ParmanentAdress == "" && aSearch.PresentAdress == "" && aSearch.Gender == "" && aSearch.ContactNo == "" && aSearch.Bloodgroup == "")
            {

                return result;
            }

            else
            {
                Search_Student_DAL sdal = new Search_Student_DAL();
                result = sdal.SearchStudentDAL(aSearch);
                return result;

            }
        }
        public DataTable GetExistingStudentSearchFromBL()
        {
            Search_Student_DAL sda = new Search_Student_DAL();
            DataTable dt = sda.GetExisingSearchDAL();
            return dt;
        }
    }
}
                               
    

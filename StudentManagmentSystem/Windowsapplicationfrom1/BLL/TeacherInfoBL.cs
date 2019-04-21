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
    class TeacherInfoBL
    {
        public DataTable Show_TeacherInfoBL()
        {
         
                TeacherInfoDAL atea = new TeacherInfoDAL();
                DataTable result = atea.Show_TeacherInfoDAL();
                return result;

        }
    }
}

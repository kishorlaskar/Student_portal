using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;

namespace WindowsFormsApplication1.BLL
{
    class CourseInfoBL
    {
        public DataTable Show_CoureseInfoBL()
        {

            CourseInfoDAL atea = new CourseInfoDAL();
            DataTable result = atea.Show_CourseInfoDAL();
            return result;

        }
    }
}

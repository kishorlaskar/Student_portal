using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1.BLL
{
    class ResultBL
    {
        public string Message { get; private set; }

        public bool ValidANewResultAndSendToDA(Result aResult)

        {

            if (aResult.ID == " ")
            {
                Message = "ID is Invalid";
                return false;
            }
            else
            {
                if (aResult.Name == "")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aResult.Depertment == " ")
                    {
                        this.Message = "Depertment  is overload";
                        return false;
                    }
                    else
                    {
                        if (aResult.CourseTitle == " ")
                        {
                            this.Message = "CourseTitle  is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aResult.CourseCode == " ")
                            {
                                this.Message = "CourseCode is  Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aResult.Gread == " ")
                                {
                                    this.Message = "Grade   is Invalid";
                                    return false;
                                }
                                else
                                {
                                    if (aResult.SGPA <= 0 ||aResult.SGPA >4)
                                    {
                                        this.Message = "SGPA   is Invalid";
                                        return false;
                                    }


                                    else
                                    {
                                        ResultDA ResultDAOBJ = new ResultDA();
                                        bool result = ResultDAOBJ.SaveANewResultToDB(aResult);
                                        return result;
                                    }
                                }
                            }
                        }
                    }
                }
            }
             

        }
        public bool UpdateANewResultAndSendToDA(Result aResult)
        {

            if (aResult.ID == " ")
            {
                this.Message = "ID is Incorrect";
                return false;
            }
            else
            {
                if (aResult.Name == "")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aResult.Depertment == " ")
                    {
                        this.Message = "Depertment  is overload";
                        return false;
                    }
                    else
                    {
                        if (aResult.CourseTitle == " ")
                        {
                            this.Message = "CourseTitle is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aResult.CourseCode == " ")
                            {
                                this.Message = "CourseCode is  Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aResult.Gread == " ")
                                {
                                    this.Message = "Gread  is Invalid";
                                    return false;
                                }
                                else
                                {
                                    if (aResult.SGPA < 0 ||aResult.SGPA >4 )
                                    {
                                        this.Message = "SGPA is Overlaped";
                                        return false;
                                    }
                                

                                            else
                                            {
                                                ResultDA ResultDAOBJ = new ResultDA();
                                                bool result = ResultDAOBJ.UpdateANewResultToDB(aResult);
                                                return result;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
        public bool DeleteANewResultAndSendToDA(Result aResult)
        {

            if (aResult.ID == " ")
            {
                this.Message = "ID is Incorrect";
                return false;
            }


            else
            {
                ResultDA ResultDAOBJ = new ResultDA();
                bool result = ResultDAOBJ.DeleteANewResultToDB(aResult);
                return result;
            }
        }
        public DataTable GetExistingResultBL()
        {
            DataTable dt = new DataTable();
            ResultDA ResultDAOBJ = new ResultDA();
            dt = ResultDAOBJ.GetExistingResultFromDB();
            return dt;
        }
        public DataTable GetExistingCourseTitle(Result aResult)
        {
            DataTable dt = new DataTable();
            ResultDA ResultDAOBJ = new ResultDA();
            dt = ResultDAOBJ.GetsCourseTitle(aResult);
            return dt;
        }
    }
}
                          

  
    



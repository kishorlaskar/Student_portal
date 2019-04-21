using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication1.DAL.DAO;



namespace WindowsFormsApplication1.BLL
{
    class CourseBL
    {

        public string Message = " ";
      

        //   private Course aCoursesInformation;

        public bool ValidateNewCourseandSendToDA(DAL.DAO.CourseO aCourseInfo)
        {
            if (aCourseInfo.Id == " ")
            {
                this.Message = "ID is Incorrect";
                return false;
            }
            else
            {
                if (aCourseInfo.Name == "")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aCourseInfo.Credit <= 0 || aCourseInfo.Credit > 5)
                    {
                        this.Message = "Credit  is overload";
                        return false;
                    }
                    else
                    {
                        if (aCourseInfo.Semister == " ")
                        {
                            this.Message = "Semister  is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aCourseInfo.Teacher == " ")
                            {
                                this.Message = "Teacher is  Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aCourseInfo.CourseFee == " ")
                                {
                                    this.Message = "Course Fee  is Incorrect";
                                    return false;
                                }
                                else
                                {
                                    CourseDA CourseDAOBj = new CourseDA();
                                    bool result = CourseDAOBj.SaveNewCourseToDB(aCourseInfo);
                                    return result;
                                }
                            }
                        }
                    }
                }
            }
        }
        public DataTable GetExistingCoursesBL()
        {
            DataTable dt = new DataTable();
            CourseDA CourseDAOBJ = new CourseDA();
            dt = CourseDAOBJ.GetExistingCoursesFromDB();
            return dt;
        }
        public bool UpdateNewCourseandSendToDA(DAL.DAO.CourseO aCourseInfo)
        {
            if (aCourseInfo.Id == " ")
            {
                this.Message = "Id is incorrect";
                return false;
            }
            else
            {
                if (aCourseInfo.Name == " ")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aCourseInfo.Credit <= 0 || aCourseInfo.Credit> 100)
                    {
                        this.Message = "Credit  is Overlaped";
                        return false;
                    }
                    else
                    {
                        if (aCourseInfo.Semister == " ")
                        {
                            this.Message = "Semister is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aCourseInfo.Teacher == " ")
                            {
                             this.   Message = "Teacher Info  is Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aCourseInfo.CourseFee == " ")
                                {
                                    this.Message = "CourseFee is Incorrect";
                                    return false;
                                }
                                
                                            else
                                            {
                                                CourseDA CourseDAOBj = new CourseDA();
                                                bool result = CourseDAOBj.UpdateNewCourseToDB(aCourseInfo);
                                               return result;

                                            }
                                        }
                                    }

                                }


                            }
                        }
                    }
        public bool DeletACourseBL(DAL.DAO.CourseO aCourseInfo)
        {
            if (aCourseInfo.Id == " ")
            {
                this.Message = "Id is incorrect";
                return false;
            }
           

                                else
                                {
                                    CourseDA CourseDAOBj = new CourseDA();
                                    bool result = CourseDAOBj.DeletACourseFromDB(aCourseInfo);
                                    return result;

                                }
                            }
                        }

                    }


      
        
       





























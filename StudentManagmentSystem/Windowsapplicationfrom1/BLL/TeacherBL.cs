using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1.BLL
{
    class TeacherBL
    {
        public string Message { get; private set; }

        public bool ValidateANewTeacherAndSendToDA(Teacher aTeacher)
        {

            if (aTeacher.ID == " ")
            {
                this.Message = "ID is Incorrect";
                return false;
            }
            else
            {
                if (aTeacher.Name == "")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aTeacher.Desegnation == " ")
                    {
                        this.Message = "Dsignation  is overload";
                        return false;
                    }
                    else
                    {
                        if (aTeacher.Depertment == " ")
                        {
                            this.Message = "Depertment  is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aTeacher.ContactNo == " ")
                            {
                                this.Message = "ContactNo is  Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aTeacher.CourseAdvisor== " ")
                                {
                                    this.Message = "CourseAdvisor   is Invalid";
                                    return false;
                                }
                                else
                                {
                                    if (aTeacher.CouncellingHour == " ")
                                    {
                                        this.Message = "CouncellingHour   is Invalid";
                                        return false;
                                    }
                                    else
                                    {
                                        if (aTeacher.Salary <= 0 || aTeacher.Salary > 1000000)
                                        {
                                            this.Message = "Salary  is Overlaped";
                                            return false;
                                        }
                                        else
                                        {
                                            if (aTeacher.Adress == " ")
                                            {
                                                this.Message = "Adress is Overlaped";
                                                return false;
                                            }

                                            else
                                            {
                                                TeacherDA TeacherDAOBJ = new TeacherDA();
                                                bool result = TeacherDAOBJ.SaveANewTeachertoDB(aTeacher);
                                                return result;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        public DataTable GetExistingTeacherBL()
        {
            DataTable dt = new DataTable();
            TeacherDA TeacherDAOBJ = new TeacherDA();
            dt = TeacherDAOBJ.GetExistingTeacherToDB();
            return dt;
        }

        public bool UpdateANewTeacherAndSendToDA(Teacher aTeacher)
        {

            if (aTeacher.ID == " ")
            {
                this.Message = "ID is Incorrect";
                return false;
            }
            else
            {
                if (aTeacher.Name == "")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aTeacher.Desegnation == " ")
                    {
                        this.Message = "Dsignation  is overload";
                        return false;
                    }
                    else
                    {
                        if (aTeacher.Depertment == " ")
                        {
                            this.Message = "Depertment  is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aTeacher.ContactNo == " ")
                            {
                                this.Message = "ContactNo is  Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aTeacher.CourseAdvisor == " ")
                                {
                                    this.Message = "CourseAdvisor  is Invalid";
                                    return false;
                                }
                                else
                                {
                                    if (aTeacher.CouncellingHour == " ")
                                    {
                                        this.Message = "CouncellingHour   is Invalid";
                                        return false;
                                    }
                                    else
                                    {
                                        if (aTeacher.Salary <= 0 || aTeacher.Salary > 1000000)
                                        {
                                            this.Message = "Salary  is Overlaped";
                                            return false;
                                        }
                                        else
                                        {
                                            if (aTeacher.Adress == " ")
                                            {
                                                this.Message = "Adress is Overlaped";
                                                return false;
                                            }

                                            else
                                            {
                                                TeacherDA TeacherDAOBJ = new TeacherDA();
                                                bool result = TeacherDAOBJ.UpdateANewTeachertoDB(aTeacher);
                                                return result;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
        public bool DeleteANewTeacherAndSendToDA(Teacher aTeacher)
        {

            if (aTeacher.ID == " ")
            {
                this.Message = "ID is Incorrect";
                return false;
            }
           

                                            else
                                            {
                                                TeacherDA TeacherDAOBJ = new TeacherDA();
                                                bool result = TeacherDAOBJ.DeleteANewTeachertoDB(aTeacher);
                                                return result;
                                            }
                                        }
                                    }
                                }
                          



    


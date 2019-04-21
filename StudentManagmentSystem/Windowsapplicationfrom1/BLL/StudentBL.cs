using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1.BLL
{
    class StudentBL
    {
        public string Message = " ";
        public bool ValidateNewStudentandSendToDA(Student aStudent)
        {
       
       
            if (aStudent.Id == " ")
            {
                this.Message = "Id is incorrect";
                return false;
            }
            else
            {
                if (aStudent.Name == " ")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aStudent.Age <= 0 || aStudent.Age > 100)
                    {
                        this.Message = "Age is unmatched";
                        return false;
                    }
                    else
                    {
                        if (aStudent.Faculty == " ")
                        {
                            this.Message = "Faculty is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aStudent.ParmanentAdress == " ")
                            {
                                this.Message = "Parmanent Adress is Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aStudent.PresentAdress == " ")
                                {
                                    this.Message = "Present Adress is Incorrect";
                                    return false;
                                }
                                else
                                {
                                    if (aStudent.Gender == " ")
                                    {
                                        this.Message = "Gender is Incorrect";
                                        return false;

                                    }
                                    else
                                    {
                                        if (aStudent.ContactNo == " ")
                                        {
                                            this.Message = "Contact Number is Incorrect";
                                            return false;
                                        }
                                        else
                                        {
                                            if (aStudent.Bloodgroup == " ")
                                            {
                                                this.Message = "Bloodgroup is Incorrect";
                                                return false;
                                            }
                                            else
                                            {
                                                StudentDA StudentDAOBj = new StudentDA();
                                                bool result = StudentDAOBj.SaveNewStudentToDB(aStudent);
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
    
    public DataTable GetExistingStudentFromBL()
        {

           StudentDA StudentDAobj = new StudentDA();
            DataTable  dt = StudentDAobj.GetExistingStudentFromDB();
            return dt;
        }
        public bool UpdateNewStudentandSendToDA(Student aStudent)
        {


            if (aStudent.Id == " ")
            {
                this.Message = "Id is incorrect";
                return false;
            }
            else
            {
                if (aStudent.Name == " ")
                {
                    this.Message = "Name is Incorrect";
                    return false;
                }
                else
                {
                    if (aStudent.Age <= 0 || aStudent.Age > 100)
                    {
                        this.Message = "Age is unmatched";
                        return false;
                    }
                    else
                    {
                        if (aStudent.Faculty == " ")
                        {
                            this.Message = "Faculty is incorrect";
                            return false;
                        }
                        else
                        {
                            if (aStudent.ParmanentAdress == " ")
                            {
                                this.Message = "Parmanent Adress is Incorrect";
                                return false;
                            }
                            else
                            {
                                if (aStudent.PresentAdress == " ")
                                {
                                    this.Message = "Present Adress is Incorrect";
                                    return false;
                                }
                                else
                                {
                                    if (aStudent.Gender == " ")
                                    {
                                        this.Message = "Gender is Incorrect";
                                        return false;

                                    }
                                    else
                                    {
                                        if (aStudent.ContactNo == " ")
                                        {
                                            this.Message = "Contact Number is Incorrect";
                                            return false;
                                        }
                                        else
                                        {
                                            if (aStudent.Bloodgroup == " ")
                                            {
                                                this.Message = "Bloodgroup is Incorrect";
                                                return false;
                                            }
                                            else
                                            {
                                                StudentDA StudentDAOBj = new StudentDA();
                                                bool result = StudentDAOBj.UpdateNewStudentToDB(aStudent);
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
        public bool DeleteAStudentandSendFromDA(Student aStudent)
        {


            if (aStudent.Id == " ")
            {
                this.Message = "Id is incorrect";
                return false;
            }
            else
            {
                StudentDA StudentDAOBj = new StudentDA();
                bool result = StudentDAOBj.DeleteAStudentFromDB(aStudent);
                return result;
               
             

                                            }
                                        }

       
    }

                                }




    
        

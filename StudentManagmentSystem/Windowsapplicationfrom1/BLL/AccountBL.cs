using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1.BLL
{
    class AccountBL
    {
        public string Message { get; private set; }

        public bool ValidateAnewAccountAndSendToDA(Accounts accounts)
        {
            if (accounts.AID == " ")
            {
                this.Message = "ID IS INCORRECT";
                return false;
            }
            else
            {
                if (accounts.AdmissonFee == " ")
                {
                    this.Message = "Admission  is Fee";
                    return false;
                }
                else
                {
                    if (accounts.LibraryFee == " ")
                    {
                        this.Message = "Library is  Incorrect";
                        return false;
                    }
                    else
                    {
                        if (accounts.LabratoreyFee == " ")
                        {
                            this.Message = "LabretoryFee   is Invalid";
                            return false;
                        }
                        else
                        {
                            if (accounts.LibraryFee == " ")
                            {
                                this.Message = "LibraryFee   is Invalid";
                                return false;
                            }
                            else
                            {
                                if (accounts.SemisterFee == " ")
                                {
                                    this.Message = "Semister  is Overlaped";
                                    return false;
                                }
                                else
                                {
                                    if (accounts.TotalPaid == " ")
                                    {
                                        this.Message = "TotalPaid is Overlaped";
                                        return false;
                                    }
                                    else
                                    {
                                        if (accounts.TransPortFee == " ")
                                        {
                                            this.Message = "TransportFee is Invalid";
                                            return false;
                                        }

                                        else
                                        {
                                            if (accounts.TutionFee == "")
                                            {
                                                this.Message = "Tution Fee is Invalid";
                                                return false;
                                            }
                                            else
                                            {
                                                if (accounts.Waiver == " ")
                                                {
                                                    this.Message = "Waiver Is Invalid";
                                                    return false;
                                                }
                                                else
                                                {
                                                    if (accounts.ExtraCarriculamFee == " ")
                                                    {
                                                        this.Message = "ExtraCurriCUlamFee is Incorrect";
                                                        return false;
                                                    }
                                                    else
                                                    {
                                                        if (accounts.Due == " ")
                                                        {
                                                            this.Message = "Due Is Not Found";
                                                            return false;
                                                        }
                                                        else
                                                        {
                                                            AccountDA AccountDAOBJ = new AccountDA();
                                                            bool result = AccountDAOBJ.SaveANewAccountToDB(accounts);
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

                }
            }
        }
        public bool UpdateAnewAccountAndSendToDA(Accounts accounts)
        {
            if (accounts.AID == " ")
            {
                this.Message = "ID IS INCORRECT";
                return false;
            }
            else
            {
                if (accounts.AdmissonFee == " ")
                {
                    this.Message = "Admission  is Fee";
                    return false;
                }
                else
                {
                    if (accounts.LibraryFee == " ")
                    {
                        this.Message = "Library is  Incorrect";
                        return false;
                    }
                    else
                    {
                        if (accounts.LabratoreyFee == " ")
                        {
                            this.Message = "LabretoryFee   is Invalid";
                            return false;
                        }
                        else
                        {
                            if (accounts.LibraryFee == " ")
                            {
                                this.Message = "LibraryFee   is Invalid";
                                return false;
                            }
                            else
                            {
                                if (accounts.SemisterFee == " ")
                                {
                                    this.Message = "Semister  is Overlaped";
                                    return false;
                                }
                                else
                                {
                                    if (accounts.TotalPaid == " ")
                                    {
                                        this.Message = "TotalPaid is Overlaped";
                                        return false;
                                    }
                                    else
                                    {
                                        if (accounts.TransPortFee == " ")
                                        {
                                            this.Message = "TransportFee is Invalid";
                                            return false;
                                        }

                                        else
                                        {
                                            if (accounts.TutionFee == "")
                                            {
                                                this.Message = "Tution Fee is Invalid";
                                                return false;
                                            }
                                            else
                                            {
                                                if (accounts.Waiver == " ")
                                                {
                                                    this.Message = "Waiver Is Invalid";
                                                    return false;
                                                }
                                                else
                                                {
                                                    if (accounts.ExtraCarriculamFee == " ")
                                                    {
                                                        this.Message = "ExtraCurriCUlamFee is Incorrect";
                                                        return false;
                                                    }
                                                    else
                                                    {
                                                        if (accounts.Due == " ")
                                                        {
                                                            this.Message = "Due Is Not Found";
                                                            return false;
                                                        }
                                                        else
                                                        {
                                                            AccountDA AccountDAOBJ = new AccountDA();
                                                            bool result = AccountDAOBJ.UpdateANewAccountToDB(accounts);
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

                }
            }
        }
        public bool DeleteAnewAccountAndSendToDA(Accounts accounts)
        {
            if (accounts.AID == " ")
            {
                this.Message = "AID IS INCORRECT";
                return false;
            }
          
        else
           {
             AccountDA AccountDAOBJ = new AccountDA();
            bool result = AccountDAOBJ.DeleteANewAccountToDB(accounts);
            return result;
       }
   }
        public DataTable GetExistingAccountBL()
        {
            DataTable dt = new DataTable();
            AccountDA AccountDAOBJ = new AccountDA();
            dt = AccountDAOBJ.GetExistingAccountFromDB();
            return dt;
        }


    }
}
                                        




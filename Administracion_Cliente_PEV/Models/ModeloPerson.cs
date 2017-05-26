using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using PA.BusinessEntity.Base;
using System.Data;
using PA.Adapters;
namespace Administracion_Cliente_PEV.Models
{
    public class ModeloPerson
    {
        //Cliente n = new Cliente();


        public static Queue<Person> ListPerson()
        {
            try
            {
                Queue<Person> lista_persona = new Queue<Person>();
                using (SqlConnection co = new SqlConnection())
                {
                    co.ConnectionString = SqlDBAdapter.GetConexionAdventureWorks2014();
                    co.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = co;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Person.GetListPerson";

                        using (SqlDataReader re = cmd.ExecuteReader())
                        {
                            Person persona;
                            //= new  Person();

                            while (re.Read())
                            {
                                persona = new Person();
                            

                               persona.BusinessEntityID =int.Parse( re["BusinessEntityID"].ToString());
                                persona.PersonType = re["PersonType"].ToString();
                                persona.NameStyle = re["NameStyle"].ToString();
                                persona.Title= re["Title"].ToString();
                                persona.FirstName= re["FirstName"].ToString();
                                persona.MiddleName= re["MiddleName"].ToString();
                                persona.LastName =re["LastName"].ToString();
                                persona.Suffix = re["Suffix"].ToString();
                                persona.EmailPromotion  =int.Parse( re["EmailPromotion"].ToString());
                                persona.AdditionalContactInfo = re["AdditionalContactInfo"].ToString();
                                persona.Demographics = re["Demographics"].ToString();
                                persona.rowguid = re["rowguid"].ToString();
                                persona.ModifiedDate =DateTime.Parse( re["ModifiedDate"].ToString());

                                lista_persona.Enqueue(persona);


                            }


                        }

                    }

                    co.Close();
                }

                return lista_persona;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public static Person uniquePerson(string BusinessEntityID)
        {
            Person persona = new Person();
            try
            {
             
                using (SqlConnection co = new SqlConnection())
                {
                    co.ConnectionString = SqlDBAdapter.GetConexionAdventureWorks2014();
                    co.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = co;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Person.GetPerson";
                        SqlParameter pa = new SqlParameter();
                        pa.ParameterName = "@BusinessEntityID";
                        pa.Value = int.Parse(BusinessEntityID);
                        cmd.Parameters.Add(pa);
                        
                        

                        using (SqlDataReader re = cmd.ExecuteReader())
                        {

                            //= new  Person();

                            while (re.Read())
                            {



                                persona.BusinessEntityID = int.Parse(re["BusinessEntityID"].ToString());
                                persona.PersonType = re["PersonType"].ToString();
                                persona.NameStyle = re["NameStyle"].ToString();
                                persona.Title = re["Title"].ToString();
                                persona.FirstName = re["FirstName"].ToString();
                                persona.MiddleName = re["MiddleName"].ToString();
                                persona.LastName = re["LastName"].ToString();
                                persona.Suffix = re["Suffix"].ToString();
                                persona.EmailPromotion = int.Parse(re["EmailPromotion"].ToString());
                                persona.AdditionalContactInfo = re["AdditionalContactInfo"].ToString();
                                persona.Demographics = re["Demographics"].ToString();
                                persona.rowguid = re["rowguid"].ToString();
                                persona.ModifiedDate = DateTime.Parse(re["ModifiedDate"].ToString());

                        


                            }


                        }

                    
                    }

                    co.Close();
                }

                return persona;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
      
  
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BusinessEntity.Base
{
   public  class Person
    {


        public int BusinessEntityID { set; get; }
        public string PersonType { set; get; }
        public string NameStyle { set; get; }
        public string Title { set; get; }
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public string Suffix { set; get; }
        public int EmailPromotion { set; get; }
        public string AdditionalContactInfo { set; get; }
        public string Demographics { set; get; }
        public string rowguid { set; get; }
        public DateTime ModifiedDate { set; get; }






    }
}

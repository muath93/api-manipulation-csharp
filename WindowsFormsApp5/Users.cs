using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{

    public class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Address
    {
        public string Property =>  city;
        
        //public String Property()
        //{
        //    return city;
        //}
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }

    public class RootObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
      //  public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
    //    public Company company { get; set; }

        private Address _address;

        public RootObject(Address address)
        {
            _address = address;
        }
        public String city
        {
          get { return _address.city; }
        }
        public String street
        {
            get { return _address.street; }
        }

        public String zipcode
        {
            get { return _address.zipcode; }
        }
    }

}
   


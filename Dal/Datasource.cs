using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.DataObjects;
namespace Dal
{
    public static  class Datasource
    {
        public static  List<Person> PersonList { get; set; }
            = new List<Person>() { new Person() { Tz="1111",Name = "sara" },
                                    new Person() { Tz="2222", Name="esti" } };
        public static void CreatePersonData()
        {

        }
    }
}

using Dal;
using Dal.DataObjects;
namespace BL
{
    public static class PersonBL
    {

        public static  List<Person> GetPersonList()
        {
            return Datasource.PersonList;
        }
        public static Person GetPersonById( string id)
        {
            var x = from p in Datasource.PersonList
                    where p.Tz.CompareTo(id) == 0
                    select p;
            return x.ToList()[0];
        }
    }
}
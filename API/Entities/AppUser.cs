namespace API.Entities
{
    public class AppUser
    {
        public int Id {get; set;} //id is property in AppUser. AppUser is entity. Id is primary key for database. 
        //property can get or set data from other classes. 
        //public is access modifier for property and class too. As Id property should get and set data, it needs to be public. 

        public string UserName{get; set;} //UserName is property of string type. 
    }
}
namespace ASPTestAPIUdemy.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }


        //If you reference with a foreign key, the many side has to have a collection
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
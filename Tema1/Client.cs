namespace Tema1
{
    public class Client 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public override string ToString()
        {
            return ("Client id is: " + Id + ", " + "First name: " + FirstName + ", " + "Last name: " + LastName + ", " +"Birth Year: " + BirthYear ) ;
            
        }

        


       
    }
}
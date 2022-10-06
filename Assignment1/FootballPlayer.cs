namespace Assignment1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public void ValidateId()
        {
            if (Id < 1)
            {
                throw new ArgumentOutOfRangeException("Id must be a positive number!");
            }
        }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("you need to write Name");
            }
            else if (Name.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Name needs to be atleast 2 character");
            }
        }

        public void ValidateAge()
        {
            if (Age < 1)
            {
                throw new ArgumentOutOfRangeException("you are not old enough");
            }
        }
        
        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
            {
                throw new ArgumentOutOfRangeException("Invalid Shirt Number");
            }
        }

        public override string ToString()
        {
            return "The player " +Name+ " has id " +Id+ " is " +Age+ " years old and has shirtnumber "+ShirtNumber;
        }



    }
}
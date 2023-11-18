namespace TestSolid
{
    public abstract class Writer : IVlogger
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AuthorBio
        {
            get
            {
                return $"My name is {FirstName} {LastName}";
            }
        }

        public Writer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract void Write();
        
        public abstract void Vlog();
    }
}

namespace TestSolid
{
    public abstract class Promoter
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string MyBusinessCard
        {
            get
            {
                return string.Format("{0}, {1}, {2}", FirstName, LastName, Phone); 
            }
        }

        public Promoter(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public void Promote()
        {
            ShareWithInnerCirlces();
            UsePaidAds();
        }

        protected abstract void ShareWithInnerCirlces();
        protected abstract void UsePaidAds();
    }
}

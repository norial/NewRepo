namespace AddressCreator
{
    class Address
    {
        int appartment;
        string house;
        string street;
        string city;
        string country;
        int index;
        string address;
        public string UserAddress
        {
            get { return address; }
            set { address = value; }
        }

        public int Appartment
        {
            get { return appartment; }
            set { appartment = value; }
        }
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public void UserInput()
        {
            while (String.IsNullOrEmpty(Country))
            {
                Country = AddressUserInput(nameof(Country));
            }
            while (String.IsNullOrEmpty(City))
            {
                City = AddressUserInput(nameof(City));
            }
            while (String.IsNullOrEmpty(Street))
            {
                Street = AddressUserInput(nameof(Street));
            }
            while (String.IsNullOrEmpty(House))
            {
                House = AddressUserInput(nameof(House));
            }
            while (Appartment == 0 || Appartment == null)
            {
                Appartment = AddressUserInput(nameof(Appartment), Appartment);
            }
            while (Index == 0 || Index == null)
            {
                Index = AddressUserInput(nameof(Index), Index);
            }
            Console.Clear();
            AddressCreator();
            Console.WriteLine("Nice, Your address is saved\nPress Enter to go to Menu.");
        }






        private int AddressUserInput(string userInputAddressName, int userInputAddress)
        {
            Console.Clear();
            Console.Write($"Enter Your {userInputAddressName} here: ");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int result);
            userInputAddress = result;
            return userInputAddress;
        }
        private string AddressUserInput(string userInputAddress)
        {
            Console.Clear();
            Console.Write($"Enter Your {userInputAddress} here: ");
            userInputAddress = Console.ReadLine();
            return userInputAddress;
        }

        public string AddressCreator()
        {
            UserAddress = $"{Country}, {City}, {Street}, {House}, {Appartment.ToString()}, {Index.ToString()}";
            return UserAddress;
        }

    }
}

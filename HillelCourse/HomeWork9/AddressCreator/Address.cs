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
            set {  address = value; }
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
            bool isParse;
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        while (country == null || country == "")
                        {
                            Console.Clear();
                            Console.Write("Enter Your country here: ");
                            country = Console.ReadLine();
                        }
                        break;

                    case 1:
                        while (city == null || city == "")
                        {
                            Console.Clear();
                            Console.Write("Enter Your city here: ");
                            city = Console.ReadLine();
                        }
                        break;
                    case 2:
                        while (street == null || street == "")
                        {
                            Console.Clear();
                            Console.Write("Enter Your street here: ");
                            street = Console.ReadLine();
                        }
                        break;
                    case 3:
                        while (house == null || house == "")
                        {
                            Console.Clear();
                            Console.Write("Enter Your house here: ");
                            house = Console.ReadLine();
                        }
                        break;
                    case 4:
                        while (appartment == 0 || appartment == null)
                        {
                            Console.Clear();
                            Console.Write("Enter Your appartment here: ");
                            string userInput = Console.ReadLine();
                            int.TryParse(userInput, out int result);
                            appartment = result;
                        }
                        break;
                    case 5:
                        while (index == 0 || index == null)
                        {
                            Console.Clear();
                            Console.Write("Enter Your index here: ");
                            string userInput = Console.ReadLine();
                            int.TryParse(userInput, out int result);
                            index = result;
                        }
                        break;
                }
            }
            Console.Clear();
            AddressCreator();
            Console.WriteLine("Nice, Your address is saved\nPress Enter to go to Menu.");
            
        }

        public string AddressCreator()
        {
            address = $"{country}, {city}, {street}, {house.ToString()}, {appartment.ToString()}, {index.ToString()}";
            return address;
        }
        
    }
}

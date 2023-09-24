using System.Net;

namespace Lesson8
{
    internal class Address
    {
        private int index; // 1111 - 9999

        public int Index
        {
            get { return index; }
            set
            {
                if (value >= 1111 && value <= 9999)
                {
                    index = value;
                }
            }
        }

        public void PrintAddress()
        {
            Console.WriteLine(Index);
        }
    }
}
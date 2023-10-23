namespace LINQ_HomeWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //1) Фільтрація: Дано список цілих чисел: {2, 5, 8, 12, 15, 18, 22}. Відфільтруйте всі числа, які більше 10.
            List<int> numbers = new List<int> { 2, 5, 8, 12, 15, 18, 22 };
            var filteredNumbers = numbers.Where(num => num > 10);

            Console.WriteLine("Filtered numbers greater than 10:");
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //2) Сортування: Дано список імен фруктів: {"Яблуко", "Апельсин", "Банан", "Ківі"}. Відсортуйте цей список в алфавітному порядку.
            List<string> fruits = new List<string> { "Яблуко", "Апельсин", "Банан", "Ківі" };
            var sortedFruits = fruits.OrderBy(fruit => fruit);

            Console.WriteLine("Sorted fruits in alphabetical order:");
            foreach (var fruit in sortedFruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
            //3) Видалення дублікатів: Дано список рядків: {"А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.
            List<string> strings = new List<string> { "А", "Б", "В", "А", "Г", "В" };
            var uniqueStrings = strings.Distinct();

            Console.WriteLine("Unique strings after removing duplicates:");
            foreach (var str in uniqueStrings)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            //4) Підрахунок: Дано список оцінок студентів {85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
            List<int> scores = new List<int> { 85, 92, 78, 95, 88, 90 };
            int count = scores.Count(score => score > 90);

            Console.WriteLine("Number of students with scores greater than 90: " + count);
            Console.WriteLine();
            //5) Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля "Назва" і "Ціна". Відфільтруйте товари,
            //які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.
            List<Product> products = new List<Product>
        {
            new Product { Name = "Product A", Price = 25 },
            new Product { Name = "Product B", Price = 30 },
            new Product { Name = "Product C", Price = 40 },
            new Product { Name = "Product D", Price = 20 },
            new Product { Name = "Product E", Price = 60 },
        };

            var filteredAndSortedProducts = products.Where(product => product.Price < 50).OrderBy(product => product.Price);

            Console.WriteLine("Filtered and sorted products with price less than 50:");
            foreach (var product in filteredAndSortedProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine();
            //6) Пошук максимального за індексом: Дано список цілих чисел {10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом (позицією) в списку.
            List<int> nums = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };
            int maxNumber = nums.Max();

            Console.WriteLine("Maximum number in the list: " + maxNumber);
            Console.ReadKey();
        }
    }
}
//У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp.

//Якщо користувач не вводить ключ, він може користуватися тільки безкоштовною версією (створюється екземпляр базового класу),

//якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної версії класу,

//Наведений до базового - DocumentWorker.

namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            byte programVersion = 0;
            string programKey = null;
            Console.WriteLine("Press Enter to continue");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                if (programKey == "ProVer2023") programVersion = 1;
                else if (programKey == "ExpertVer2023")  programVersion = 2;
                else programVersion = 0;

                if (programVersion == 0)
                {
                    DocumentWorker documentWorker = new DocumentWorker();
                    Thread.Sleep(3000);
                    documentWorker.OpenDocument();
                    documentWorker.EditDocument();
                    documentWorker.SaveDocument();
                    Console.Write("To upgrade the version enter key: ");
                    programKey = UserInput();
                    Console.WriteLine("Press Enter to continue");
                }

                if (programVersion == 1)
                {
                    ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                    Thread.Sleep(3000);
                    proDocumentWorker.OpenDocument();
                    proDocumentWorker.EditDocument();
                    proDocumentWorker.SaveDocument();
                    Console.Write("To upgrade the version enter key: ");
                    programKey = UserInput();
                    Console.WriteLine("Press Enter to continue");
                }

                if (programVersion == 2)
                {
                    ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                    Thread.Sleep(3000);
                    expertDocumentWorker.OpenDocument();
                    expertDocumentWorker.EditDocument();
                    expertDocumentWorker.SaveDocument();
                    Console.ReadKey();
                }
            }
        }

        //switch (programVersion)
        //{
        //    case 0: DocumentWorker documentWorker = new DocumentWorker();
        //    Thread.Sleep(3000);
        //        documentWorker.OpenDocument();
        //        documentWorker.EditDocument();
        //        documentWorker.SaveDocument();
        //        Console.ReadKey();
        //        break;
        //    case 1: ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
        //        Thread.Sleep(3000);
        //        proDocumentWorker.OpenDocument();
        //        proDocumentWorker.EditDocument();
        //        proDocumentWorker.SaveDocument();
        //        Console.ReadKey();
        //        break;
        //    case 2: ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
        //        Thread.Sleep(3000);
        //        expertDocumentWorker.OpenDocument();
        //        expertDocumentWorker.EditDocument();
        //        expertDocumentWorker.SaveDocument();
        //        Console.ReadKey();
        //        break;
        //}


        private static string UserInput()
        {
            return Console.ReadLine();
        }
    }

}
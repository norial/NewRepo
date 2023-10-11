//// Створіть клас DocumentWorker.

//У тілі класу створіть три методи OpenDocument(), EditDocument(), SaveDocument().

//До тіла кожного з методів додайте виведення на екран відповідних рядків:

//-"Документ відкритий",

//-"Редагування документа доступне у версії Про",

//-"Збереження документа доступне у версії Про".

namespace DocumentWorker
{
    internal class DocumentWorker
    {
        public void OpenDocument()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Opening document");
                Console.WriteLine(" Loading");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Opening document");
                Console.WriteLine(" Loading.");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Opening document");
                Console.WriteLine(" Loading..");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Opening document");
                Console.WriteLine(" Loading...");
                Thread.Sleep(300);
                Console.Clear();
            }
            Console.WriteLine("Document opened!\r\n");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing a document is available in the Pro version\r\n");
        }
         public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document is available in the Pro version\r\n");
        }
        public DocumentWorker()
        {
            Console.WriteLine("Your version is basic");
        }
    }
}

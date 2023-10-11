// Створіть похідний клас ProDocumentWorker.

//Перевизначте відповідні методи, при перевизначенні методів виводьте такі рядки:

//-"Документ відредаговано",

//-"Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт".

namespace DocumentWorker
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Editing is successful\r\n");
        }
        public  override void SaveDocument()
        {
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version\r\n");
        }
        public ProDocumentWorker() : base()
        {
            Console.WriteLine("Now your version is Pro");
        }
    }
}

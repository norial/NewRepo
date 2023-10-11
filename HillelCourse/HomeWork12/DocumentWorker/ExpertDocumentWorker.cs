//Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker.

//Перевизначте відповідний метод.При виклику даного методу необхідно виводити на екран

//- "Документ збережено у новому форматі".
namespace DocumentWorker
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document is successfully saved in a new format\r\n");
        }
        public ExpertDocumentWorker() : base()
        {
            Console.WriteLine("Now your version is Expert");
        }
    }
}

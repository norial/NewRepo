

namespace Lesson11
{
    internal class Weapon // base class for all weapon types
    {
        public virtual void Attack()
        {
            Console.WriteLine("You Attacked!");
        }
    }
}

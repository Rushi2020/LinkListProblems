using System;

namespace LinkListProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                LinkListOperation listOperation = new LinkListOperation();
                listOperation.insert(56);
                listOperation.insert(30);
                listOperation.insert(70);

                listOperation.DeleteFirst();
                listOperation.Display();


                // listOperation.insertAfter(30, 56);
                //listOperation.display();
            }
        }
    }
}
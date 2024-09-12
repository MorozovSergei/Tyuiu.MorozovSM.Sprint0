using Tyuiu.MorozovSM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MorozovSM.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Сергей";
            Console.WriteLine(DataService.GetMessage(name));
            Console.ReadKey();
        }
    }
}

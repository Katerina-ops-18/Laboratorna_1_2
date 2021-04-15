using System;

namespace Lab_1_2
{
    public delegate int MyDelegate(int a, int b);
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ввести дiю--> +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("Перше число --");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Друге число --");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+":
                    MyDelegate myDelegat = (c, b) => c + b; // Робиться додавання чисел
                    double Add = myDelegat(x, y);
                    Console.WriteLine("Вiдповiдь: 0", Add);
                    break;
                case "-":
                    MyDelegate myDelegat1 = (c, b) => c - b; // Робиться вiднiмання чисел
                    double Sub = myDelegat1(x, y);
                    Console.WriteLine("Вiдповiдь: 0", Sub);
                    break;
                case "*":
                    MyDelegate myDelegat2 = (c, b) => c + b; // Робиться множення чисел
                    double Muv = myDelegat2(x, y);
                    Console.WriteLine("Вiдповiдь: 0", Muv);
                    break;
                case "/":
                    MyDelegate myDelegat3 = (c, b) => b != 0 ? c / b : 0; // Робиться дiлення чисел, перевiрка на 0
                    //b=0, то поверне 0, :? - тернарний оператор.
                    double Div = myDelegat3(x, y);
                    Console.WriteLine("Вiдповiдь: 0", Div);
                    break;
            }
            Console.ReadLine();
        }
    }
}

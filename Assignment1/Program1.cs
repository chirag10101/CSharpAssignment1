namespace AssignmentCSharp

{
    internal class Program1
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter 2 numbers");
            int a = 0;
            int b = 0;
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            //2
            Console.WriteLine($"Addition is {a + b}");
            Console.WriteLine($"subtraction is {a - b}");
            Console.WriteLine($"multiplication is {a * b}");
            Console.WriteLine($"division is {a / b}");
            Console.WriteLine("Choose Selection : 1 for add, 2 for sub, 3 for mul and 4 for div ");
            Byte.TryParse(Console.ReadLine(), out byte choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition is {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Substraction is {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"multiplication is {a * b}");
                    break;
                case 4:
                    Console.WriteLine($"division is {a / b}");
                    break;
                default: 
                    Console.WriteLine("Please select Valid choice");
                    break;
            }
            //3 
            for(int i = 0; i < 10; i++) {
                Console.Write("Chirag ");
            }
            Console.WriteLine();
            Console.WriteLine("Using do-while loop :");
            int j = 2;
            do
            {
                Console.Write($"{j} ");
                j+=2;
            } while (j < 20);
            Console.WriteLine("Using while loop :");
            j = 2;
            while(j < 20)
            {
                Console.Write($"{j} ");
                j+=2;
            }
            Console.WriteLine();
            for (int i = 2; i < 20; i+=2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();    
            j = 1;
            do
            {
                Console.Write($"{j} ");
                j += 2;
            } while (j < 20);
            Console.WriteLine();
            j = 1;
            while (j < 20)
            {
                Console.Write($"{j} ");
                j += 2;
            }
            Console.WriteLine();
            for (int i = 1; i < 20; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            int k = 15;
            j = 1;
            do
            {
                Console.Write($"{k * j} " );
                j++;
            }while (j <= 10);
            Console.WriteLine();
            j = 1;
            while (j <= 10)
            {
                Console.Write($"{k * j} ");
                j++;
            }
            Console.WriteLine();
            for(int i=1;i <= 10; i++)
            {
                Console.Write($"{k * i} ");
            }
            Console.WriteLine();
            for(int i = 100; i > 5; i -= 3)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            int x = 10;
            int y = 20;
            Console.Write($"{x} {y}");
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}

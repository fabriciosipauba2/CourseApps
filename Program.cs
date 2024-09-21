
namespace CourseApps
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Calculadora.Menu();
            //StopWatch.Menu();
            //ReverseStopWatch.Menu();
            //TextEditor.Menu();
            MenuApp();


        }
        public static void MenuApp()
        {
            Console.Clear();

            Console.WriteLine("Qual App deseja abrir?");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Cronometro");
            Console.WriteLine("3 - Cronometro Reverso");
            Console.WriteLine("4 - Editor de Texto");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Calculadora.Menu(); break;
                case 2: StopWatch.Menu(); break;
                case 3: ReverseStopWatch.Menu(); break;
                case 4: TextEditor.Menu(); break;
                case 0: System.Environment.Exit(0); break;
                default: MenuApp(); break;

            }
                        
            
           


        }
    }

}
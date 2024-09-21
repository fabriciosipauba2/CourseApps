

namespace CourseApps
{



    public class Calculadora

    {

        public static void Menu() //metodo criado para ser invocado na main e acessar os outros metodos
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção");

            short res = short.Parse(Console.ReadLine()); // res é a variavel criada do tipo short para ler a opçao digitada atraves da conversao Parse

            switch (res) //condicional criada pra definir qual metodo chamar, sendo invocada pelo res e de acordo com que o usuario digitar
            {
                case 1: Soma(); break; //sempre nesse formato, com break no final
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 0: Console.Clear(); Console.WriteLine("Obrigado por usar a calculadora"); Console.ReadKey(); break;
                default: Console.Clear(); Console.WriteLine($"{res} não é uma opção válida"); Console.ReadKey(); Menu(); break; // default é opçao padrao do switch, nesse caso aqui estamos definindo que se for digitado qualquer entrada fora dos cases ele retorna pro menu
                                                                                                                                //default: Menu(); break; // default é opçao padrao do switch, nesse caso aqui estamos definindo que se for digitado qualquer entrada fora dos cases ele retorna pro menu

            }




        }

        public static void Soma()

        {
            Console.Clear(); //comando para limpar a tela
            Console.WriteLine("Primeiro Valor"); //vai ser exibido o parametro entre parenteses, retornando sempre uma string
                                                 //v1 é a variavel definida no tipo float que vai armazenar o valor que o usuario digitar
                                                 //Console.ReadLine sempre retorna um string, entao tenho que converter usando Parse pra mostrar em numero real do float
                                                 //Diferença entre Console.Read para Console.ReadLine é que o primeiro já lê o valor e armazena direto na variavel enquando o Readline espera o usuário dar enter
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); //parametro vazio apenas para pular uma linha

            float resultado = v1 + v2; //resultado é a variavel criado para somar v1 e v2

            Console.WriteLine("O resultado da soma é " + resultado); //aqui estamos imprimindo uma string concatenando com a variavel resultado
                                                                     //Console.WriteLine("O resultado da soma é " +(v1 + v2)); //tambem podemos usar dessa forma, somando direto na string desde que esteja entre parenteses
                                                                     //Console.WriteLine($"O Resulado da soma é {resultado}"); tambem podemos usar dessa forma utilizando $ como interpolação

            Console.ReadKey();

            Menu();

        }

        public static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O Resulado da Subtração é {resultado}");

            Console.ReadKey();

            Menu();

        }

        public static void Multiplicar()

        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();

            Menu();



        }

        public static void Dividir()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse((Console.ReadLine()));

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse((Console.ReadLine()));

            float resultado = v1 / v2;
            Console.WriteLine($"O Resultado da divisão é {resultado}");

            Console.ReadKey();

            Menu();

        }

        

    }

}
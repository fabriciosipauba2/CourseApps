//using System.IO;

namespace CourseApps
{


    public class TextEditor
    {
       
        public static void Menu()
        {

            Console.Clear();
            Console.WriteLine("Welcome to the Text Editor - Choose a option below");
            Console.WriteLine("1 - Open File");
            Console.WriteLine("2 - Create a new file");
            Console.WriteLine("0 - Exit the app");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Create(); break;
                default: Menu(); break;
            }

        }

        public static void Open()
        {
            Console.Clear();
            Console.WriteLine("what file path?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            //sempre que for ler ou salvar arquivo tem que usar using
            //nesse caso 

            {
                string text = file.ReadToEnd();//read to end para ler o arquivo ate o final
                Console.WriteLine(text);

            }

            Console.WriteLine();
            Console.ReadLine();

            Menu();

        }

        public static void Create()
        {
            Console.Clear();
            Console.WriteLine("Type your text below (press ESC to exit)");
            Console.WriteLine("--------------------");

            string text = "";//criamos uma variavel text do tipo string vazia para que deixe escrever a vontade
                             //porem quando dermos enter a aplicaçao fecha
                             //criamos o laço de repetiçao abaixo para evitar isso mas com uma condiçao

            do // o do define que faça isso até que pressione o esc
            {
                text += Console.ReadLine();//chamei a variavel text pra armazenar mas com += para que acrescente tudo que o usuario digitar, senao se usar apenas = ele vai ficar substituindo
                text += Environment.NewLine;//metodo para fazer quebra de linha, fazendo a quebra ao fim de cada leitura do metodo acima

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape); //definimos que enquanto a tecla for diferente de esc, ele vai continuar no laço de reptição

            Save(text);//aqui chamei a funçao de salvar arquivo pedindo para que todos os valores da variavel text seja incluido

        }

        public static void Save(string text) //invocando a string text do metodo anterior pra ser recebido nesse metodo 
        {
            Console.Clear();
            Console.WriteLine("Choose a patch to save");
            var path = Console.ReadLine();//criei a variavel path 

            using (var file = new StreamWriter(path))
            //defini o uso de using ao inves de chamar new streamwriter diretamente para que using abra e fecha assim que utilizar
            //o uso de using evita que seja esquecido de utilizar close pra fechar o streamwriter, evitando conflito e nao deixando mais ningue usar
            //em C# sempre temos que abrir e fechar um arquivo senao fica inutilizado por outros e pode dar conflito na aplicação
            //nesse caso temos que usar using System.IO, sempre conferir se esta invocado
            {
                file.Write(text);

            }

            Console.WriteLine($"File {path} saved successfully");
            Console.ReadLine();
            Menu();

        }


    }
}
using System.Runtime.InteropServices;
using System.Threading; //obrigatório incorporar caso use Thread...

public class StopWatch
{
    
    public static void Menu()
    {

        Console.Clear();
        Console.WriteLine("S - Contador em Segundos");
        Console.WriteLine("M - Contador em Minutos");
        Console.WriteLine("0 - Sair do StopWatch");
        Console.WriteLine("");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        /*string porque o usurio deve digitar 10s por exemplo, entao temos que fazer a leitura como string pelo readline.
        Acrescentamos o ToLower() para converter maiusculas em minusculas porque o c# é caso sensitive,
        entao se o usuario digitar 10S, a nossa aplicaçao vai converter e imprimir o data em minuscula.         
         */
        char type = char.Parse(data.Substring(data.Length - 1, 1));        
        /* O uso do char porque quero pegar apenas um caracter de data
        SubString é um método de string que serve pra pegar um trecho da string, ele é escrito em Substring(1, 1) onde o primeiro valor busca a posição do caracter na string e o segundo busca a quantidade. SEMPRE COMEÇA COM POSIÇÃO ZERO.
        Eu quero pegar apenas um carcter, por isso converto ele em char através do Parse
        O uso de data.Length conta a quantidade de caracteres que o usuario digitou, entao eu uso data.Length - 1 para diminuir 1 carcter, assim buscando o ultimo.
        */
        int time = int.Parse(data.Substring(0, data.Length - 1));
        //Nesse caso estou querendo pegar os numeros tirando s ou m, por isso converto o int para uma substring começando na posiçao zero para pegar todos os carcteres menos o ultimo que deve ser s ou m.

        int multiplier = 1; //variavel multiplier criada pra interagir com dado que usuario digitar, inciando com 1 segundo

        if (type == 'm')
            multiplier = 60; //adicionamos o if pra caso seja digitado m multiplicar por 60, tornando em minutos

        if (time == 0)
            System.Environment.Exit(0); //caso digite zero, ele sai da aplicaçao

        
        //NO IF CASO TENHA APENAS UMA LINHA, NAO PRECISA DE CHAVES

        Start(time * multiplier);

    }

    public static void Start(int time)//defini a variavel time do tipo int para contar ate 10
    {

        int currentTime = 0; //variavel criado para ser percorrida dentro do while
        //significa que iremos percorrer de 0 ate 10
        while (currentTime != time) // while é laço de repetiçao que sempre executa algo dada uma condiçao sempre verdadeira e sempre tem q ter um incremento dentro dela
        {
            currentTime++; //incremento do while, comm ++ para que acrescente 1 ao valor para nao ficar infinito

            Console.Clear();
            Console.WriteLine(currentTime);

            Thread.Sleep(1000); //thread resumidamente é a execução atual do nosso processador, nesse caso estamos pedindo pra ele esperar 1 segundo

        }

        Console.Clear(); //Limpando a tela após a contagem
        Console.WriteLine("StopWatch Finalizado"); //mensagem de aviso ao usuario que a contagemn acabou

        Thread.Sleep(3000);// espera 3 segundo pra fechar a aplicaçao apos a mensagem

        //Console.ReadKey(); //finaliza a aplicaçao somente apos usario clicar

        Menu();

    }
}
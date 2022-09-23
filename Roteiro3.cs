using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

class Program
{
    static int Main()
    {
        int escolha;
        do
        {
            Console.WriteLine("\nDigite o exercicio que deseja de 1 a 3: ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Ex1();
                    break;
                case 2:
                    Ex2();
                    break;
                case 3:
                    Ex3();
                    break;
            }
        }
        while (escolha != 3);
        return 0;
    }

    static int Ex1()
    {
        /*
        1 - Escreva um programa que leia dois números do teclado e em seguida mostra um menu com opções para executar um das quatro operações básicas(+, -, *ou /).Mostrar o resultado da operação executada.Fazer o programa em duas versões: usando comando if e usando switch.
        */

        bool endApp = false;
        while (!endApp)
        {
            double n1, n2, soma, sub, multi, divi;
            int alternativa;
            Console.WriteLine("\nEscolha o método de cálculo: \r\n \n+ = 1, - = 2, X = 3, / = 4 : ");
            alternativa = int.Parse(Console.ReadLine());

            while (alternativa < 1 || alternativa > 4)
            {
                Console.WriteLine("\nVocê escolheu o método de cálculo errado por favor   ");
                Console.WriteLine("\nEscolha o método de cálculo certo: \r\n + = 1, - = 2, X = 3, / = 4 : ");
                alternativa = int.Parse(Console.ReadLine());
            }
            switch (alternativa)
            {
                case 1:
                    {
                        Console.WriteLine("Escreva dois números para somar:\n");
                        n1 = double.Parse(Console.ReadLine());
                        n2 = double.Parse(Console.ReadLine());
                        soma = n1 + n2;
                        Console.WriteLine("A soma é {0}\n", soma);
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Escreva dois números para subtrair:\n");
                        n1 = double.Parse(Console.ReadLine());
                        n2 = double.Parse(Console.ReadLine());
                        sub = n1 - n2;
                        Console.WriteLine("A subtração é {0}\n", sub);
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Escreva dois números para multiplicar:\n");
                        n1 = double.Parse(Console.ReadLine());
                        n2 = double.Parse(Console.ReadLine());
                        multi = n1 - n2;
                        Console.WriteLine("A multiplicação é {0}\n", multi);
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Escreva dois números para dividir:\n");
                        n1 = double.Parse(Console.ReadLine());
                        n2 = double.Parse(Console.ReadLine());
                        divi = n1 - n2;
                        Console.WriteLine("A Divisão é {0}\n", divi);
                    }
                    break;
            }
            Console.Write("Digite 'n' para encerrar o aplicativo ou digite outra palavra para continuar o programa: ");
            if (Console.ReadLine() == "n") endApp = true;
            Console.WriteLine("\n");
        }
        return 0;
    }

    static int Ex2()
    {
        /*
        2 - No livro “O Nome da Rosa” o ritmo da narrativa segue o mesmo da rotina dos monges que se baseia nas horas canônicas.Estas horas são consideradas especiais para estes monges e correspondem aos seguintes nomes e horários:
        a.Matinas - 3 h
        b.Laudes - 5 h(aprox. – ao amanhecer)
        c.Prima - 7 h
        d.Tercia - 9 h
        e.Sexta - meio dia
        f.Noa - 15 h
        g.Vésperas - 18 h(aprox. – ao pôr do sol)
        h.Completas - 21 h
        Faça um programa que leia a hora atual(um número entre 0 e 23) e informe se a hora corresponde a alguma das horas canônicas ou mande a mensagem “Não é uma hora canônica”
        */

        bool endApp = false;

        while (!endApp)
        {

            int horas;
            Console.WriteLine("Digite a hora entre 0 e 23 sem os minutos: ");
            horas = int.Parse(Console.ReadLine());

            while (horas < 0 || horas > 23)
            {

                Console.WriteLine("\nDigite a hora certa entre 0 e 23 sem os minutos:\n");
                horas = int.Parse(Console.ReadLine());
            }

            if (horas != 3 && horas != 5 && horas != 7 && horas != 9 && horas != 12 && horas != 15 && horas != 18 && horas != 21)
            {
                Console.WriteLine("Não é uma hora canônica! \n");
            }

            else
            {
                switch (horas)
                {
                    case 3:
                        {

                            Console.WriteLine("Matinas \n", horas);
                        }
                        break;

                    case 5:
                        {

                            Console.WriteLine("Laudes \n", horas);
                        }
                        break;

                    case 7:
                        {
                            Console.WriteLine("Prima \n", horas);
                        }
                        break;


                    case 9:
                        {
                            Console.WriteLine("Tercia \n", horas);
                        }
                        break;

                    case 12:
                        {
                            Console.WriteLine("Sexta \n", horas);
                        }
                        break;

                    case 15:
                        {
                            Console.WriteLine("Noa \n", horas);
                        }
                        break;

                    case 18:
                        {
                            Console.WriteLine("Vésperas \n", horas);
                        }
                        break;

                    case 21:
                        {
                            Console.WriteLine("Completas \n", horas);
                        }
                        break;
                }

            }

            Console.Write("Digite 'n' para encerrar o aplicativo ou digite outra palavra para continuar o programa: ");
            if (Console.ReadLine() == "n") endApp = true;
            Console.WriteLine("\n");
        }
        return 0;
    }

    static int Ex3()
    {
        /*
        3 - No ocidente estamos acostumados com o nosso formato de datas composto de dias, meses e anos e todas as regras para meses de 28, 30 e 31 dias, além dos anos bissextos. Mas esse nosso calendário, chamado de Gregoriano, foi uma evolução do calendário Juliano(do imperador Julio Cesar). E atualmente ainda se usa(em astronomia, cronologia e alguns sistemas) a Data Juliana.Este formato de data ignora a existência dos meses e é formado APENAS do Ano e o Dia, sendo esse dia um número que vai de 1 a 365(respectivamente de 1º de janeiro à 31 de dezembro).Como algoritmos também é cultura, faça um programa que leia uma data gregoriana nos seus três valores: dia, mês e ano, e a converta para o formato de data Juliana: DiaJuliano e Ano.Exemplo: 
        a. 01 / 01 / 2009   => 1 / 2009
        b. 01 / 02 / 2009   => 32 / 2009(os 31 dias de janeiro + 1)
        c. 19 / 09 / 2009   => 262.2009(os dias de jan a agosto + 19)
        */

        bool endApp = false;

                while (!endApp)
                {
                    int dia, mes, ano, resulto;
                    Console.WriteLine("Digite o dia que deseja : ");
                    dia = int.Parse(Console.ReadLine());

                    while (dia < 1 || dia > 31)
                    {
                        Console.WriteLine("Digite o dia certo :\n");
                        dia = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\nDigite o mês que deseja : ");
                    mes = int.Parse(Console.ReadLine());

                    while (mes < 1 || mes > 12)
                    {

                        Console.WriteLine("Digite o mes certo :\n");
                        mes = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\nDigite o ano que deseja : ");
                    ano = int.Parse(Console.ReadLine());
                    while (ano < 1)
                    {

                        Console.WriteLine("Digite o ano certo :\n");
                        ano = int.Parse(Console.ReadLine());
                    }

                    switch (mes)
                    {
                        case 1:
                            {
                                while (dia < 1 || dia > 31)
                                {
                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }

                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, dia, ano);
                            }
                            break;

                        case 2:
                            {
                                while (dia < 1 || dia > 28)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 31 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);

                            }
                            break;

                        case 3:
                            {
                                while (dia < 1 || dia > 31)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 59 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;


                        case 4:
                            {
                                while (dia < 1 || dia > 30)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 90 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 5:
                            {
                                while (dia < 1 || dia > 31)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 121 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 6:
                            {
                                while (dia < 1 || dia > 30)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 151 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 7:
                            {
                                while (dia < 1 || dia > 31)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 182 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 8:
                            {
                                while (dia < 1 || dia > 31)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 213 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 9:
                            {
                                while (dia < 1 || dia > 30)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 243 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 10:
                            {
                                while (dia < 1 || dia > 31)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 274 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 11:
                            {
                                while (dia < 1 || dia > 30)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 304 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;

                        case 12:
                            {
                                while (dia < 1 || dia > 31)
                                {

                                    Console.WriteLine("Digite o dia certo :\n");
                                    dia = int.Parse(Console.ReadLine());
                                }
                                resulto = 335 + dia;
                                Console.WriteLine("\n{0}/{1}/{2} => {3}/{4} \n", dia, mes, ano, resulto, ano);
                            }
                            break;
                    }

                    Console.Write("Digite 'n' para encerrar o aplicativo ou digite outra palavra para continuar o programa: ");
                    if (Console.ReadLine() == "n") endApp = true;
                    Console.WriteLine("\n");
                }         
        return 0;
    }
}
class Program
{


    static int Main()
    {
        int escolha;
        do
        {
            Console.WriteLine("\nDigite o exercicio que deseja de 1 a 9: ");
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
                case 4:
                    Ex4();
                    break;
                case 5:
                    Ex5();
                    break;
                case 6:
                    Ex6();
                    break;
                case 7:
                    Ex7();
                    break;
                case 8:
                    Ex8();
                    break;
                case 9:
                    Ex9();
                    break;
            }
        }
        while (escolha != 9);
        return 0;
    }

    static int Ex1()
    {
        /*
        1.Ler dois números do teclado e informar o maior.
        */

        int n1, n2;
            Console.WriteLine("Informe dois números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("{0}, É maior que {1}", n1, n2);
            }
            else
            if (n2 > n1)
            {
                Console.WriteLine("{0}, é maior que {1}", n2, n1);
            }
        return 0;
    }

    static int Ex2()
    {
        /*
        2.Ler um número real e informar se ele é positivo negativo ou nulo.
        */

        float num;
            Console.WriteLine("Informe um número");
            num = float.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("{0} Ele é positivo", num);
            }
            else
            {
                if (num < 0)
                {
                    Console.WriteLine("{0} Ele é negativo", num);
                }
                else
                {
                    Console.WriteLine("{0} Ele é nulo", num);
                }
            }
        return 0;
    }

    static int Ex3()
    {
        /*
        3.Ler um número inteiro e dizer se ele é par ou ímpar(dica: use o operador resto da divisão)
        */

        int num;
            Console.WriteLine("Informe um Número");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("O número {0} é par", num);
            }
            else
                Console.WriteLine("O número {0} é ímpar", num);
        return 0;
    }

    static int Ex4()
    {
        /*
        4.Ler um número e informar seu valor absoluto(Exemplo: ABS(10) = 10 / ABS(-10) = 10)
        */

        int abs, num;
            Console.WriteLine("Informe um número para saber seu valor absoluto:");
            abs = int.Parse(Console.ReadLine());
            if (abs < 0)
            {
                num = Math.Abs(abs);
                Console.WriteLine("O número absoluto é: {0} ", num);
            }
            else
            {
                Console.WriteLine("O seu número absoluto é: {0} ", abs);
            }
        return 0;
    }

    static int Ex5()
    {
        /*
        5.Ler um número e informar se ele é divisível por 2 e por 7 ao mesmo tempo.
        */

        int num;
            Console.WriteLine("Informe um número:");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 && num % 7 == 0)
            {
                Console.WriteLine("Esse número é divisível por 2 e por 7");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("Esse número não é divisível por 7 mas é divisivel por 2");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("Esse número não é divisível por 2 mas é divisivel por 7");
            }
            else
            {
                Console.WriteLine("Esse número não é divisível por 2 e nem por 7");
            }
        return 0;
    }

    static int Ex6()
    {
        /*
        6.Ler três números quaisquer e informar o maior e o menor.
        */

        int num1, num2, num3;
            Console.WriteLine("Informe três números:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                if (num3 > num2)
                {
                    Console.WriteLine("O maior número é o {0} e o menor número é {1}.", num1, num2);
                }
                else if (num2 > num3)
                {
                    Console.WriteLine("O maior número é o {0} e o menor número é {1}.", num1, num3);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0} e os outros números são iguais {1}.", num1,num3);
                }
            }
            if (num2 > num1 && num2 > num3)
            {
                if (num3 > num1)
                {
                    Console.WriteLine("O maior número é o {0} e o menor número é {1}.", num2, num1);
                }
                else if (num1 > num3)
                {
                    Console.WriteLine("O maior número é o {0} e o menor número é {1}.", num2, num3);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0} e os outros números são iguais {1}.", num2, num3);
                }
            }
            if (num3 > num2 && num3 > num1)
            {
                if (num1 > num2)
                {
                    Console.WriteLine("O maior número é o {0} e o menor número é {1}.", num3, num2);
                }
                else if (num2 > num1)
                {
                    Console.WriteLine("O maior número é o {0} e o menor número é {1}.", num3, num1);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0} e os outros números são iguais {1}.", num3, num2);
                }
            }
            else if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Todos os números são iguais");
            }
        return 0;
    }

    static int Ex7()
    {
        /*
        7.Ler três números e informar a soma dos dois maiores.
        */

        int num1, num2, num3, soma;
            Console.WriteLine("Informe três números: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                if (num3 > num2)
                {
                    soma = num1 + num3;
                    Console.WriteLine("A soma dos dois maiores é {0}.", soma);
                }
                else if (num2 > num3)
                {
                    soma = num1 + num2;
                    Console.WriteLine("A soma dos dois maiores é {0}.", soma);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0} e os dois outros números são iguais não podendo realizar a soma.", num1);
                }
            }
            if (num2 > num1 && num2 > num3)
            {
                if (num3 > num1)
                {
                    soma = num2 + num3;
                    Console.WriteLine("A soma dos dois maiores é {0}.", soma);
                }
                else if (num1 > num3)
                {
                    soma = num2 + num1;
                    Console.WriteLine("A soma dos dois maiores é {0}.", soma);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0} e os dois outros números são iguais não podendo realizar a soma.", num2);
                }
            }
            if (num3 > num2 && num3 > num1)
            {
                if (num1 > num2)
                {
                    soma = num3 + num1;
                    Console.WriteLine("A soma dos dois maiores é {0}.", soma);
                }
                else if (num2 > num1)
                {
                    soma = num3 + num2;
                    Console.WriteLine("A da soma dos dois maiores é {0}.", soma);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0} e os dois outros números são iguais não podendo realizar a soma.", num3);
                }
            }
            else if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Todos os números são iguais");
            }
            if (num1 == num2 && num1 > num3)
            {
                soma = num1 + num2;
                Console.WriteLine("A soma dos dois maiores é {0}.", soma);
            }
            else if (num2 == num3 && num2 > num1)
            {
                soma = num2 + num3;
                Console.WriteLine("A soma dos dois maiores é {0}.", soma);
            }
            else if (num1 == num3 && num3 > num2)
            {
                soma = num3 + num1;
                Console.WriteLine("O resultado da soma dos dois maiores é {0}.", soma);
            }
        return 0;
    }

    static int Ex8()
    {
        /*
        8.Ler quatro notas(de 0 a 100) de um aluno; calcular a média aritmética das notas; verificar se o aluno foi aprovado ou não. (média deve ser maior ou igual a 60)
        */

        int n1, n2, n3, n4, ma;
            Console.WriteLine("Digite as quatro notas:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            ma = (n1 + n2 + n3 + n4) / 4;
            if ((n1 >= 0 && n1 <= 100) && (n1 >= 0 && n1 <= 100))
            {
                if (ma >= 60)
                {
                    Console.WriteLine("O aluno foi aprovado");
                }
                else
                {
                    Console.WriteLine("O aluno não foi aprovado");
                }
            }
            else
            {
                Console.WriteLine("O aluno não foi aprovado");
            }
        return 0;
    }

    static int Ex9()
    {
        /*
        9.Escreva um programa para o cálculo do salário líquido de um funcionário, levando-se em conta: 
        a.Salário Bruto = horas trabalhadas * salário hora;
        b.Desconto = 0 % do salário bruto, se este for menor que R$350, 00
        c.Desconto = 10 % do salário bruto, se este for maior que R$350, 00 e menor que R$1000, 00
        d.Desconto = 20 % do salário bruto, se este for maior que R$1000, 00.
        Os valores de horas trabalhadas e salário hora deverão ser recebidos através do dispositivo de entrada.Sabe - se ainda que o salário líquido é igual ao salário bruto subtraído do desconto. 
        */

        double SB, HT, SH, SL;
            Console.WriteLine("Informe o salário hora do funcioário e as horas trabalhadas pelo mesmo:");
            HT = double.Parse(Console.ReadLine());
            SH = double.Parse(Console.ReadLine());
            SB = HT * SH;
            if (SB < 350.00)
            {
                SL = SB;
                Console.WriteLine("O salário do funcionário é {0}", SL);
            }
            else
            if (SB > 350.00 && SB < 1000.00)
            {
                SL = SB * 0.9;
                Console.WriteLine("O salário do funcionário é{0}", SL);
            }
            else
            {
                SL = SB * 0.8;
                Console.WriteLine("O salário do funcionário é {0}", SL);
            }
        return 0;
    }


}
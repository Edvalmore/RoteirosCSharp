class Program
{
    static int Main()
    {
        int escolha;
        do
        {
            Console.WriteLine("\nDigite o exercicio que deseja de 1 a 8: ");
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
            }
        }
        while (escolha != 8);
        return 0;
    }

    static int Ex1()
    {
        /*
        Roteiro 2 ATP
        Exercício 1) Faça um programa que receba dois números, calcule e mostre a subtração do primeiro número pelo segundo.
        */

        int n1, n2, sub;
            Console.WriteLine("Entre com 2 números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            sub = n1 - n2;
            Console.WriteLine($"A subtração é: {sub}");

        return 0;
    }

    static int Ex2()
    {
        /*
        Exercício 2) Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas, considerando peso 2 para a primeira nota e peso 3 para a segunda nota.
        */

        double n1, n2, p1, p2, mp;
            Console.WriteLine("Entre com dois números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            p1 = 2;
            p2 = 3;
            mp = ((n1 * p1) + (n2 * p2)) / (p1 + p2);
            Console.WriteLine("A média é: {0}", mp);
        return 0;
    }

    static int Ex3()
    {
        /*
        Exercício 3) Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, sabendo - se que este sofreu um desconto de 10 %.
        */

        double n1, n2, p1, p2, mp;
            Console.WriteLine("Entre com dois números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            p1 = 2;
            p2 = 3;
            mp = ((n1 * p1) + (n2 * p2)) / (p1 + p2);
            Console.WriteLine("A média é: {0}", mp);
        return 0;
    }

    static int Ex4()
    {
        /*
        Exercício 4) Faça um programa que calcule e mostre a área de um trapézio. Sabe - se que: A = ((base maior - base menos) *altura) / 2
        */

        int b1, b2, h, area;
            Console.WriteLine("Informe a base maior, base menor e a altura do trapézio respectivamente:");
            b1 = int.Parse(Console.ReadLine());
            b2 = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            area = ((b1 - b2) * h) / 2;
            Console.WriteLine("A área do trapésio é: {0}", area);
        return 0;
    }
    static int Ex5()
    {
        /*
        Exercício 5) Faça um programa que receba o valor do salário mínimo e o valor do salário de um funcionário, calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.
        */

        double n1, n2, quant;
            Console.WriteLine("Informe o valor do salário mínimo e o sálario do funcionário:");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            quant = n2 / n1;
            Console.WriteLine("Esse funcionário recebe, {0} salários mínimos", quant);
        return 0;
    }

    static int Ex6()
    {
        /*
        Exercício 6) Faça um programa que receba o valor dos catetos de um triângulo, calcule e mostre o valor da hipotenusa.  
        Obs: Para calcular a raiz quadrada use a função sqrt() como abaixo: 
        y = Math.Sqrt(x)  // calcula a raiz quadrada de x coloca o resultado na variável y.
        */

        double n1, n2, soma, h;
            Console.WriteLine("Informe os valores dos catetos:");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            soma = (n1 * n1) + (n2 * n2);
            h = Math.Sqrt(soma);
            Console.WriteLine("A hipotenusa é: {0}", h);
        return 0;
    }

    static int Ex7()
    {
        /*
        Exercício 7) Faça um programa que receba o raio, calcule e mostre:
        a) o comprimento de uma esfera, sabe - se que C = 2πR;
        b) a área de uma esfera, sabe - se que A = πR2;
        c) o volume de uma esfera, sabe - se que V = 4 / 3πR3.
        Obs: Para calcular o raio ao quadrado ou ao cubo você pode usar a função pow() como abaixo: 
        Z = Math.Pow(x, y)  // calcula a potência: XY e coloca o resultado na variável Z.
        */

        double n1, x, z, comp, area, volume;
            Console.WriteLine("Informe o raio de uma esfera:");
            n1 = double.Parse(Console.ReadLine());
            x = Math.Pow(n1, 2);
            z = Math.Pow(n1, 3);
            comp = 2 * 3.14 * n1;
            Console.WriteLine("O comprimento da esfera é: {0}", comp);
            area = 3.14 * x;
            Console.WriteLine("A área da esfera é: {0}", area);
            volume = 4 / 3 * 3.14 * z;
            Console.WriteLine("O volume da esfera é: {0}", volume);
        return 0;
    }

    static int Ex8()
    {
        /*
        Exercício 8) Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e mostre a medida do terceiro ângulo. Sabe - se que a soma dos ângulos de um triângulo é 180.
        */

        int n1, n2, medida;
            Console.WriteLine("Informe dois ângulos de um triângulo:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            medida = 180 - (n1 + n2);
            Console.WriteLine("A medida do terceiro ângulo é: {0}", medida);
        return 0;
    }
}
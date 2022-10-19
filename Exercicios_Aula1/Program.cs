/* Exercicio 1


class exe1
{



    static void Main(string[] args)
    {
      int comprimento = 0;
      int altura = 0;
      int area = 0;



        Console.Write("Introduz a comprimento: ");
        comprimento = int.Parse(Console.ReadLine());
        Console.Write("Intorduz a  altura: ");
        altura = int.Parse(Console.ReadLine());

        area = comprimento * altura;


        Console.Write("a area do retangulo é: " + area);
        Console.Read();

    }
}

*/















    using System.Drawing;

    class exe2

    {
         static void Main(string[] args)
         {
            double SS = 0.20;
            double irs = 0;
            double salariobruto = 0;
            double descontoSS = 0;
            double descontoIrs = 0;

            Console.Write("Qual o valor do salario bruto: ");
            salariobruto = int.Parse(Console.ReadLine());

            descontoSS = salariobruto * SS;

            if (salariobruto < 500)
            {
           
                salariobruto = salariobruto - descontoSS;
                Console.Write("Este empregado recebera: " +salariobruto);
            }

                else if (salariobruto >=500 && salariobruto <1000) 
                {
                irs = 0.12;

                descontoIrs = salariobruto * irs;
                salariobruto = salariobruto - descontoIrs - descontoSS;
                }

                else if (salariobruto >=1000 && salariobruto < 1500)
                {
                irs = 0.15;
                descontoIrs = salariobruto * irs;
                salariobruto = salariobruto - descontoIrs - descontoSS;
                }

                else if (salariobruto > 1500)
                {
                irs = 0.18;
                descontoIrs = salariobruto * irs;
                salariobruto = salariobruto - descontoIrs - descontoSS;
                }



                Console.Write("Este empregado recebera: " + salariobruto);
                Console.Read();



         }

    }


/*

class exe3
{
    static void Main(string[] args)
    {
        int fatorial;
        int contador;
        int resultado = 1;

        Console.Write("Introduza o numero fatorial: ");
        fatorial = int.Parse(Console.ReadLine());

              for (contador = fatorial; contador >= 1; contador--)
            {

              resultado = resultado * contador;

            }

        

        Console.Write("O fatorial é " + resultado);
        Console.Read();

    }
}

*/





/*
class exe4
{
    static void Main(string[] args)
    {
        double area;
        double basee;
        double altura;
        int calculo;


        Console.Write("Introduza o tamanho da base do triangulo: ");
        basee = int.Parse(Console.ReadLine());
        Console.Write("Introduza a altura do triangulo: ");
        altura = int.Parse(Console.ReadLine());

        area = basee * altura /2;


        Console.Write("A area do triangulo: " +area);
        Console.Read();

    }
}

*/







/*
class exe5
{
    static void Main(string[] args)
    {
        double SS = 0.20;
        double irs = 0;
        double salariobruto = 0;
        double descontosSS = 0;
        double descontosIrs = 0;

        Console.Write("Qual o valor do salario bruto: ");
        salariobruto = Int32.Parse(Console.ReadLine());

        descontosSS = salariobruto * SS;


        switch (salariobruto)
        {


            case < 500:

              //  if (salariobruto < 500)
               // {



                    salariobruto = salariobruto - descontosSS;
                    Console.Write("Recebera: " + salariobruto);

                // }

                break;



            case <1000:
                //  if(salariobruto >= 500 && salariobruto < 1000)
                //  {


                irs = 0.12;

                    descontosIrs = salariobruto * irs;
                    salariobruto = salariobruto - descontosIrs - descontosSS;
                //   }

                break;



            case <1500:
                //     if (salariobruto >= 1000 && salariobruto < 1500)
                //  {

                irs = 0.15;
                descontosIrs = salariobruto * irs;
                salariobruto = salariobruto - descontosIrs- descontosSS ;

                //     }
                break;



            case >1500:

                //   if(salariobruto > 15000)
                //  {


                irs = 0.18;
                descontosIrs = salariobruto * irs;
                salariobruto = salariobruto - descontosIrs - descontosSS;
                //  }

                break;

            default:
                Console.Write("Ordernado indesponivel: ");
                break;





        }

        Console.Write("Este empregado recebera: " + salariobruto);
        Console.ReadKey();



    }
}

 




/*

class exe7
{
    static void Main(string[] args)
    {
        int fatorial;
        int contador;
        int resultado = 1;

        Console.Write("Introduza o numero fatorial: ");
        fatorial = int.Parse(Console.ReadLine());

        contador = fatorial;

        while (contador >= 1)
        {
            resultado = resultado * contador;
            contador = contador - 1;
        }

        Console.Write("O fatorial é " + resultado);
        Console.Read();

    }
}

*/

/* double salario = 0;
Console.WriteLine("O seu salário é");
salario = Int32.Parse(Console.ReadLine());
double sal = salario - (salario * 0.20);
double irs1 = sal - (salario * 0.12);
double irs2 = sal - (salario * 0.15);
double irs3 = sal - (salario * 0.18);
switch (salario)
{



    case < 500:

        Console.Write("O empregado receberá : " + sal);

        break;


    case < 1000:

        Console.Write("O empregado receberá : " + irs1);

        break;



    case < 1500:

        Console.Write("O empregado receberá : " + irs2);

        break;




    case > 1500:

        Console.Write("O empregado receberá : " + irs3);

        break;






}
Console.ReadLine();

*/
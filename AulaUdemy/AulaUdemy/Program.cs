using System;
using System.Globalization;
using System.Collections.Generic;

namespace AulaUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //int idade = 12;
            //double saldo = 10.35784;
            //string nome = "maria";

            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais" , nome, idade, saldo );

            //Console.WriteLine($"{nome} Tem {idade} anos e tem saldo igual a {saldo:F3} Reais");

            //Console.WriteLine("Nome " + nome + " Idade " + idade + " saldo " + saldo.ToString("F2", CultureInfo.InvariantCulture));


            //int a = 10;
            //int b = ++a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //double convD;
            //float convF;

            //convD = 5.1;
            //convF = (float)convD;

            //Console.WriteLine(convF);




            //int cont = 5;
            //int cont1 = 2;

            //double resultado = (double)cont / cont1;

            //Console.WriteLine(resultado);




            //Console.WriteLine("Digite uma frase");

            //string frase = Console.ReadLine();

            //Console.WriteLine("Voce digitou" + frase);




            //string frase1 = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string s = Console.ReadLine();
            //string[] v = s.Split(' ');


            //string[] v = Console.ReadLine().Split(' ');
            //string a = v[0];
            //string b = v[1];
            //string c = v[2];


            //Console.WriteLine("Voce digitou: ");
            //Console.WriteLine(frase1);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);


            //var primeiraCompra = new Conta
            //{
            //    Numero = 1234567,
            //    NomeTitular = "Matheus",
            //    Saldo = 2500.0,
            //    DataAbertura = Convert.ToDateTime("15/02/2019")
            //};



            //Console.WriteLine(primeiraCompra.Sacar(500, primeiraCompra.Saldo));
            //Console.ReadKey();


            //var primeiraCompra = new ContaCorrente();
            //var segundaCompra = new ContaCorrente();

            //Console.WriteLine("total de conta corrente "+ ContaCorrente.totalContaCorrente);
            //Console.WriteLine("total de conta na segunda instancia " + ContaCorrente.totalContaCorrente);



            //-------------------------------------------------------------------------------------------------------------
            //----------------------Variaveis nullas ----------------------------------------------------------------------


            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X is NULL");
            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("Y e NULL");


            //double? a = null;
            //double? b = 10;

            //double c = a ?? 1;
            //double d = b ?? 1;



            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //------------------------------------------------------------------------------------------
            //-----------------------------------------Vetores------------------------------------------

            //int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[10];

            //for(int i = 0; i<n; i++)
            //{
            //    int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = b;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(vect[i]);
            //}
            //double sum = 0.0;
            //for(int i =0; i<n; i++)
            //{
            //    sum += vect[i];
            //}

            //Console.WriteLine("total:"+sum);

            //int n = int.Parse(Console.ReadLine());
            //ContaCorrente[] vect = new ContaCorrente[n];

            //int s1 = Calculatorcs.Sum(2, 3);
            //int s2 = Calculatorcs.Sum(2, 3, 3);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //Modificadores Ref and Out--------------------------------------------------------

            //int a = 10;
            //Calculatorcs.Triple(ref a);        //ref a variavel tem que estar inicializada
            //Console.WriteLine(a);

            //------------------------------------------
            // A varievel passada como Parâmetro out não precisa ter sido inicializada

            //int a =10;
            //int triple;
            //Calculatorcs.TripleOut(a, out triple);     
            //Console.WriteLine(triple);



            //-----------------------------------------------------------------------------------
            //-----------Laço for each------------------------------------------------------


            //string[] vect = new string[] { "Matheus", "Prado", "Lima" };
            //foreach(string obj in vect)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("-----------------------------");

            //for (int j=0; j< vect.Length; j++)
            //{
            //    Console.WriteLine(vect[j]);
            //}

            //-----------------------------------------------------------------------------------
            //------------------LISTAS----------------------------------------------------------

            //List<string> lis = new List<string> { "Maria", "Alex" };
            //List<string> list = new List<string>();

            //list.Add("Matheus");
            //list.Add("Prado");
            //list.Add("Gustavo");
            //list.Add("Limeira");
            //list.Insert(2, "Lima");
            //list.Add("Mathias");
            //list.Add("Kaua");
            //list.Add("Xbox");
            //list.Add("Fifa");

            //foreach (string obj in list)
            //{
            //}

            //string s1 = list.Find(Calculatorcs.Test);
            //Console.WriteLine("Fisrt 'L': "+ s1);


            //string s2 = list.Find(x => x[0] == 'M');
            //Console.WriteLine("Fisrt 'M': " + s2);


            //string s3 = list.FindLast(x => x[0] == 'M');
            //Console.WriteLine("Last 'M': " + s3);


            //int s4 = list.FindIndex(x => x[0] == 'M');
            //Console.WriteLine(" first Index  'M': " + s4);


            //int s5 = list.FindLastIndex(x => x[0] == 'M');
            //Console.WriteLine(" Last Index  'M': " + s5);

            //Console.WriteLine("List count: "+ list.Count);


            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //Console.WriteLine("----------------------");
            //foreach(string obj in list2)
            //{
            //    Console.WriteLine(obj);
            //}



            //list.Remove("Prado");
            //Console.WriteLine("------------------------------");
            //foreach(string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}


            //list.RemoveAll(x => x[0] == 'M');
            //Console.WriteLine("------------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}


            //list.RemoveRange(2,2);
            //Console.WriteLine("------------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}


            //-------------------------------------------------------------------------------------------
            // Exercicio List----------------------------------------------------------------------------


            //Console.Write("Quantos employees quer registrar? ");

            //int n = int.Parse(Console.ReadLine());



            //List<Employee> list = new List<Employee>();



            //for (int i = 1; i <= n; i++)
            //{

            //    Console.WriteLine("Employee #" + i + ":");

            //    Console.Write("Id: ");

            //    int id = int.Parse(Console.ReadLine());

            //    Console.Write("Name: ");

            //    string name = Console.ReadLine();

            //    Console.Write("Salario: ");

            //    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    list.Add(new Employee(id, name, salario));

            //    Console.WriteLine();

            //}



            //Console.Write("Entre com o id do Employee que deseja aumentar o salario: ");

            //int searchId = int.Parse(Console.ReadLine());



            //Employee emp = list.Find(x => x.Id == searchId);

            //if (emp != null)
            //{

            //    Console.Write("Entre com a porcentagem: ");

            //    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    emp.IncreaseSalary(percentage);

            //}

            //else
            //{

            //    Console.WriteLine("Id 404 kk");

            //}



            //Console.WriteLine();

            //Console.WriteLine("Updated list of employees:");

            //foreach (Employee obj in list)
            //{

            //    Console.WriteLine(obj);

            //}


            //-----------------------------------------------------------------------------------------------
            //---------Conjunto------------------------------------------------------------------------------


            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            B.Add(10);

            B.Add(10);
            B.Remove(10);

            foreach (int a in A)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("--------------------------");
            foreach (int b in B)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("Digite um valor inteiro");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine(N + ", Pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine(N + ", Nao pertence ao conjunto B");
            }
            Console.WriteLine("------------------");

            //Remove de A todos os numeros iguais no B
            A.ExceptWith(B);
            foreach (int a in A)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("--------------------------");


            // faz a união de A com B (Lembrando que em conjuntos não se repete numeros); 
            A.UnionWith(B);
            foreach (int a in A)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("--------------------------");
            //-----------------------------------------------------------------------------------------------



            Console.ReadKey();
          
        }
        
      


    }
}

// using System;

// namespace Aula02
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int mes;

//             Console.WriteLine("Digite um número do mês");
//             mes = int.Parse(Console.ReadLine());

//             switch(mes){
//                 case 1:
//                 Console.WriteLine("Janeiro");
//                 break;
//                 case 2: 
//                 Console.WriteLine("feveiro");
//                 break;
//                 case 3: 
//                 Console.WriteLine("março");
//                 break;
//                 case 4: 
//                 Console.WriteLine("abril");
//                 break;
//                 case 5: 
//                 Console.WriteLine("maio");
//                 break;
//                 case 6: 
//                 Console.WriteLine("junho");
//                 break;
//                 case 7: 
//                 Console.WriteLine("julho");
//                 break;
//                 case 8: 
//                 Console.WriteLine("agosto");
//                 break;
//                 case 9: 
//                 Console.WriteLine("setembro");
//                 break;
//                 case 10: 
//                 Console.WriteLine("outubro");
//                 break;
//                 case 11: 
//                 Console.WriteLine("novembro");
//                 break;
//                 case 12: 
//                 Console.WriteLine("dezembro");
//                 break;

//                 default:
//                 Console.WriteLine("mês inválido");
//                 break;
//             } 
//         }
//     }
// }


// using System;

// namespace AULA02
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n = int.Parse(Console.ReadLine());

//             int inicio = 1;

//             for (int i = 1; i <= n; i++)
//             {
                
//                 Console.WriteLine($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)} \n");
                
//             }
//         }
//     }
// }


using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int total = 0;

            while(condicao == true) {
                Console.WriteLine("Digite um valor, 0 para sair");
                int D = int.Parse(Console.ReadLine());
                int rest = D % 2;
                switch (D)
                {
                    case 0:
                        Console.WriteLine("Você saiu da aplicação");
                        condicao= false;
                        break;
                    default:
                        if (rest == 0){
                            total = 5*D + 20;
                        }
                        else
                        {
                            total = 5*(D+1) + 20;
                        }
                        Console.WriteLine($@"O valor de entrada é {D} e a soma dos seus 5 primeiros pares é {total}");
                        break;
                }
            }
            
        }
    }
}
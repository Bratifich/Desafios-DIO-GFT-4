using static System.Console;
public class Program
{

    static void Demo1()
    {
        int a =2;
        a = Adicionar20(a);
        WriteLine($"O Valor da variavel a é {a}");
    }

    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Rafael";
        p1.Idade = 34;
        p1.Documento = "123456";

        Pessoa p2 = p1.Clone();
        //Pessoa p2 = new Pessoa();
        //p2.Documento = p1.Documento;
        //p2.Nome = p1.Nome;
        //p2.Idade = p1.Idade;

        TrocarNome(p1, "José");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    }

    static void Demo3()
    {
            StructPessoa p1 = new StructPessoa()
        {
            Documento = "123546",
            Idade = 30,
            Nome = "Ricardo"
        };

        var p2 = p1;

        p1 = TrocarNome(p1, "João");

        WriteLine($@"
                    O nome p1 é: {p1.Nome}
                    O nome p2 é: {p2.Nome}
                    ");
    }

    static void Demo4()
    {
        string nome = "Ricardo";
        TrocarNome(nome, "José");

        WriteLine($"O novo nome é {nome}");
    }

    static void Demo5()
    {
        int[] pares = new int[]{0,2,4,6,8};

        MudarParaImpar(pares);

        WriteLine($"Os ímpares {string.Join(",", pares)}");

    }

    static void Demo6()
    {
        int[] numeros = new int[]{0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar:");
        var numero = int.Parse(ReadLine());
        
        var idxEncontrado = EncontrarNumnero(numeros, numero);
        if (idxEncontrado >= 0)
        {
            WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
        else
        {
            WriteLine($"O número digitado não foi encontrado");
        }
    }


    static int Adicionar20(int x)
    {
        return x +20;
    }

    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }

    static void TrocarNome(string nome, string nomeNovo)
    {
         nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumnero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
            {
                return i;
            }
        }    
        return -1;
    }


    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {

        foreach(var item in pessoas)
        {
            if (item.Nome == pessoa.Nome)
            { 
                return true;
            }
        }
        return false;
    }


    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
    {

        foreach(var item in pessoas)
        {
            if (item.Equals(pessoa))
            { 
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
        // List<Pessoa> pessoas = new List<Pessoa>()
        // {
        // new Pessoa(){Nome = "Ricardo"},
        // new Pessoa(){Nome = "José"},
        // new Pessoa(){Nome = "Maria"},
        // new Pessoa(){Nome = "Fabiana"},
        // new Pessoa(){Nome = "Eduardo"},
        // };

         List<StructPessoa> pessoas = new List<StructPessoa>()
        {
        new StructPessoa(){Nome = "Ricardo"},
        new StructPessoa(){Nome = "José"},
        new StructPessoa(){Nome = "Maria"},
        new StructPessoa(){Nome = "Fabiana"},
        new StructPessoa(){Nome = "Eduardo"},
        };


        // WriteLine("Digite a pessoa que deseja encontrar:");
        // var nome = ReadLine();
        // var pessoa = new Pessoa(){Nome = nome};
        // var encontrado =  EncontrarPessoa(pessoas, pessoa);

        WriteLine("Digite a pessoa que deseja encontrar:");
        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};
        var encontrado =  EncontrarPessoa(pessoas, pessoa);

        if(encontrado)
        {
            WriteLine($"{nome} foi encontrado!");
        }
        else
        {
            WriteLine($"{nome} não foi encontrado!");
        }

    }

}
namespace projetolista;

class Program
{
    static void Main(string[] args)
    {
        ClientesPF cl1 = new ClientesPF();

        cl1.id = 1;
        Console.WriteLine("Insira o Nome");
        cl1.nome = Console.ReadLine();
        Console.WriteLine("Insira o CPF");
        cl1.cpf = Console.ReadLine();
        Console.WriteLine("Insira o Endereço");
        cl1.endereço = Console.ReadLine();
        

        ClientesPF cl2 = new ClientesPF();
        cl2.id = 2;
        cl2.nome = "Pedro";
        cl2.cpf = "123456789";
        cl2.endereço = "Rua da Paz";

        ClientesPF cl3 = new ClientesPF();
        cl3.id= 3;
        cl3.nome = "Liara";
        cl3.cpf = "1020304050";
        cl3.endereço = "Rua dos Amores";
        
        List<ClientesPF> lista = new List<ClientesPF>();

        lista.Add(new ClientesPF());
        lista.Add(cl1);
        lista.Add(cl2);
        lista.Add(cl3);

        foreach(ClientesPF aux in lista){

            System.Console.WriteLine("Cliente {0}", aux.nome);
            System.Console.WriteLine("CPF: {0}", aux.cpf);
            System.Console.WriteLine("Endereço: {0}", aux.endereço);
        
        }



    }
}

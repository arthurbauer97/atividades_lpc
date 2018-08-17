using System;

namespace Exercicios
{
    class Program
    {
        public string resp;
        static void Main(string[] args)
        {
            Cliente marco = new Cliente();
            marco.nomeCliente = "Marco antonio";
            marco.id = 1;
            Console.WriteLine("Nome do cliente " + marco.nomeCliente);
            Console.WriteLine("Id do cliente " + marco.id);

            Cliente antonio = new Cliente();
            antonio.nomeCliente = "Antonio";
            antonio.id = 2;
            Console.WriteLine("Nome do cliente " + antonio.nomeCliente);
            Console.WriteLine("Id do cliente " + antonio.id);

            CartaoDeCredito um = new CartaoDeCredito();
            um.numero = 1234;
            um.dataValidade = "02/12/2332";
            um.obterCartao = false;
            if (um.obterCartao != true)
                {
                    Console.WriteLine(um.obterCartao + " Cliente não quer cartao ");

                }else{
                    
                    Console.WriteLine(" Número do cartão " + um.numero + ", Data de validade " + um.dataValidade);
                }

            CartaoDeCredito dois = new CartaoDeCredito();
            dois.obterCartao = true;
            dois.dataValidade = "09/09/2019";
            dois.numero = 1322;
            Console.WriteLine("Obter cartão: " + dois.obterCartao + ", Número do cartão " + dois.numero + ", Data de validade " + dois.dataValidade);


            Agencia AgenciaDeTorres = new Agencia(1);
            AgenciaDeTorres.numeroAgencia = 0955;
            Console.WriteLine("Numero da Agencia " + AgenciaDeTorres.numeroAgencia);


            Conta marcao = new Conta(1212,1000,100);

            Conta arthur = new Conta(1212,2000,100);

            marcao.depositar(150);
            arthur.depositar(100);
            
            Console.WriteLine("Saldo: " + marcao.saldo);
            Console.WriteLine("Saldo: " + arthur.saldo);
        }
    }
}

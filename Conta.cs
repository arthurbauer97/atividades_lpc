namespace Exercicios
{
    public class Conta
    {
        public Conta (int a, double b, double c){
            numero = a;
            saldo = b;
            limite = c;
        }
        public int numero;
        public double saldo;
        public double limite;
        public double limiteInicial = 100.00;

        public Cliente cliente;

        public void saque(double valor){
           saldo = saldo -= valor;
        }
        public void depositar(double ValorDoDeposito){
            saldo = saldo + ValorDoDeposito;
        }
        public void transferencia(double valor, int destino){
           if(this.saldo >= valor){
               this.saldo = this.saldo -= valor;

           }
        }
        public void consultarSaldo(){

        }
    }
}
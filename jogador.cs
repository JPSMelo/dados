public class Jogador
{
    public string nome;
    public string cpf;
    public double saldo;

    public void Depositar(double valor)
    {
        this.saldo = this.saldo + valor;
    }

    public void Debitar(double valor)
    {
        this.saldo = this.saldo - valor;
    }

    public void MostrarSaldo(double valor)
    {
        Console.WriteLine("O seu saldo é de R$ "+ this.saldo  );
    }

    public Jogador()
    {
        this.nome = "João Paulo";
        this.saldo = 50;
    }
}
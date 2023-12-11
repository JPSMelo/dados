conta
public class Conta
{
public int Agencia {get;set;}

public int NumeroConta {get;set;}

public string NomeConta {get;set;}

public Titular titular {get;set;}
public Decimal Saldo {get;set;}

public Decimal VerSaldo()
{
    return Saldo;
}

public void Depositar(decimal valor)
{
    Saldo += valor;
}

public void Sacar(decimal valor)
{
    Saldo -= valor;
}
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Conta
{
    private string numero;

    public string Numero { get; }

    private string nome;

    public string Nome { get; set; }

    //Transformar a conta Saldo com acesso privado
    //public decimal Saldo;        
    //private decimal saldo;

    //declaração da propriedade até a versão 8 do .NET
    /*
    public decimal Saldo
    {
        get { return field; }
        set
        {
            this.Depositar(value);
        }
    }*/

    public decimal Saldo
    {
        get => field;
        set
        {
            if (value >= 0)
                field = value;
            else
                throw new ArgumentException("Saldo não pode ser negativo");
        }
    }

    public Conta(string numero)
    {
        this.numero = numero;
    }

    /*
    //métodos acessadores
    public decimal getSaldo()
    {
        return saldo;
    }*/
    /*
    public void setSaldo(decimal saldo)
    {
        this.Depositar( saldo );
    }*/
    /*
    public string getNumero()
    {
        return numero;
    }
    */
    /*
    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }
    */
    public void Depositar(decimal valor)
    {
        if (valor > 0)
            Saldo += valor;
        else
            Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
    }

    public void Sacar(decimal valor)
    {
        Saldo -= valor;
    }

    public void ImprimirSaldo()
    {
        //Console.WriteLine($"Saldo Atual: {getSaldo():c2}");
        Console.WriteLine($"Saldo Atual: {Saldo:c2}");
    }
}

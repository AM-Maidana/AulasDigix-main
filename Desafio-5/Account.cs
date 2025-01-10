using Desafio5;

public class Account : Customer, IAccountMovement
{
    public Customer customer;
    protected int AccountNumber;
    protected double Balance;
    protected List<Transactions> Transaction { get; set; }

    public Account(Customer customer, int accountNumber, double balance) : base(
        customer.GetName(), customer.Address, customer.GetDob(), customer.GetCardNumber(), customer.GetPin())
    {
        AccountNumber = accountNumber;
        Balance = balance;
        Transaction = new List<Transactions>();
    }

    public int GetAccountNumber() => AccountNumber;
    public void SetAccountNumber(int accountNumber) => AccountNumber = accountNumber;

    public double GetBalance() => Balance;
    public void SetBalance(double balance) => Balance = balance;

    public void CreateTransaction()
    {
        Console.WriteLine("Para qual conta deseja transferir?");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o valor da transferência?");
        double value = double.Parse(Console.ReadLine());

        if (value > Balance)
        {
            throw new BankExcepction("Saldo insuficiente!");
        }
        else
        {
            Balance -= value;
            TransactionsType type = TransactionsType.TED;
            Transaction.Add(new Transactions(AccountNumber, DateTime.Now, type, value));
        }

        Console.WriteLine("Transferência realizada com sucesso!");
        Console.WriteLine("Saldo atual: " + Balance);
    }

    public void Deposit()
    {
        Console.WriteLine("Digite o valor que deseja depositar: ");
        double valueDeposit = double.Parse(Console.ReadLine());

        if (valueDeposit <= 0)
        {
            throw new BankExcepction("Valor inválido! O valor depositado tem que ser maior que R$ 0,00");
        }
        else
        {
            Console.WriteLine($"Depósito no valor de R${valueDeposit} realizado com sucesso!");
            Balance += valueDeposit;
        }

        Console.WriteLine("Saldo atual: " + Balance);
    }

    public void Withdraw()
    {
        Console.WriteLine("Digite o valor que deseja sacar: ");
        double valueWithdraw = double.Parse(Console.ReadLine());

        if (valueWithdraw > Balance)
        {
            throw new BankExcepction("Saldo insuficiente!");
        }
        else
        {
            Console.WriteLine($"Saque no valor de R${valueWithdraw} realizado com sucesso!");
            Balance -= valueWithdraw;
        }

        Console.WriteLine("Saldo atual: " + Balance);
    }

    public void PrintTransaction()
    {
        Console.WriteLine("Seu extrato bancário:");
        if (Transaction.Count == 0)
        {
            Console.WriteLine("Nenhuma transação realizada!");
        }
        else
        {
            foreach (var trans in Transaction)
            {
                Console.WriteLine($"ID: {trans.Id}");
                Console.WriteLine($"Data: {trans.Date}");
                Console.WriteLine($"Tipo: {trans.Transfer}");
                Console.WriteLine($"Valor: {trans.Value}");
            }
        }
    }
}

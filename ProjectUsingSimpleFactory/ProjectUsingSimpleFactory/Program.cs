using PaymentUsingSimpleFactory.Domain;
using PaymentUsingSimpleFactory.Domain.Payments;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*****************************************************************************************************");
        Console.WriteLine("\n\t PROJETO QUE FAZ A PROGRAMAÇÃO DO CÓDIGO USANDO SIMPLE FACTORY");
        Console.WriteLine("Selecione o tipo de transação desejada: \n 1 - Pix \n 2 - Cartão \n 3 - Cheque \n 4 - Boleto ");
        string? typeTransactionIn = Console.ReadLine();

        Console.WriteLine("Digite o valor: ");
        string? valueTransactionIn = Console.ReadLine();

        TypePayment typePayment = VerifyEntrance(typeTransactionIn);
        if (double.TryParse(valueTransactionIn, out double value) == true)
        {
            try
            {
                Payment payment = PaymentSimpleFactory.DoItPayment(typePayment);
                payment.PaymentTransaction(value);
                payment.ReceiveTransaction(value);
                Console.WriteLine("\n Transação concluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private static TypePayment VerifyEntrance(string? typeTransactionIn)
    {
        switch(typeTransactionIn)
        {
            case "1":
                return TypePayment.Pix;
            case "2":
                return TypePayment.Cartao;
            case "3":
                return TypePayment.Cheque;
            case "4":
                return TypePayment.Boleto;
            default:
                throw new Exception("\n Valor de entrada de tipo de transação inválido.");
        }
    }
}
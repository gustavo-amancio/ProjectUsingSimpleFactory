using PaymentUsingSimpleFactory.Domain;
using PaymentUsingSimpleFactory.Domain.Payments;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*****************************************************************************************************");
        Console.WriteLine("\n\t PROJETO QUE FAZ A PROGRAMAÇÃO DO CÓDIGO USANDO SIMPLE FACTORY");
        Console.WriteLine("Selecione o tipo de transação desejada: \n 1 - Pix \n 2 - Cartão \n 3 - Cheque \n 4 - Boleto ");
        string? typeTransactionIn = Console.ReadLine(); // coleta os dados de transação

        Console.WriteLine("Digite o valor: ");
        string? valueTransactionIn = Console.ReadLine(); // coleta o valor a ser inserido no pagamento

        TypePayment typePayment = VerifyEntrance(typeTransactionIn); // defino qual é o tipo de entrada
        if (double.TryParse(valueTransactionIn, out double value) == true) //converto o valor para double
        {
            try
            {
                Payment payment = PaymentSimpleFactory.DoItPayment(typePayment); // chamo o método que faz o pagamento, passando o parâmetro necessário para instanciar o objeto certo
                payment.PaymentTransaction(value); // faz o pgto
                payment.ReceiveTransaction(value); // recebe a transação 

                Console.WriteLine("\n Transação concluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // imprime o erro na tela
            }
        }
        else
        {
            Console.WriteLine("\n O valor de entrada não foi um valor numérico válido!");
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
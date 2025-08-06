using ByteBankIO;
using System.Data;
using System.Text;
using System.Threading.Channels;

partial class Program
{
    static void Main(string[] args)
    {
        UsarStreamDeEntrada();

        System.Console.WriteLine("Aplicação finalizada...");

        Console.ReadLine();
    }
}
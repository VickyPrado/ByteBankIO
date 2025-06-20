using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var caminhoArquivo = "contas.txt";
        var fluxoAquivo = new FileStream(caminhoArquivo, FileMode.Open);

        var buffer = new byte[1024]; // 1KB

        fluxoAquivo.Read(buffer, 0, 1024);

        //public override int Read(byte[] array, int offset, int count)


        Console.ReadLine();
    }
}
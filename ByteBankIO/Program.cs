using ByteBankIO;
using System.Data;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var caminhoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;
        
        var fluxoAquivo = new FileStream(caminhoArquivo, FileMode.Open);

        var buffer = new byte[1024]; // 1KB


        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoAquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }        

        //public override int Read(byte[] array, int offset, int count)
        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer);
        Console.Write(texto);

        /*
        foreach(var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */
    }
}
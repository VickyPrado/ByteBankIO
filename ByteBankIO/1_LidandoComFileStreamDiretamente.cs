using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var caminhoArquivo = "contas.txt";

        using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;
            var buffer = new byte[1024]; // 1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            //public override int Read(byte[] array, int offset, int count)
            fluxoArquivo.Close();
            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bitesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bitesLidos);
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
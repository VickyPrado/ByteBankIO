﻿using ByteBankIO;

partial class Program
{
    static void UsandoStreamReader()
    {
        var caminhoArquivo = "Contas.txt";
        using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoArquivo);

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                var msg = $"{contaCorrente.Titular.Nome}: Conta {contaCorrente.Numero}, Ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";

                Console.WriteLine(msg);

            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            // 375 4644 2483.13 Jonatan
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComInt = int.Parse(agencia);
            var numeroComInt = int.Parse(numero);
            var saldoComDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
            resultado.Depositar(saldoComDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}
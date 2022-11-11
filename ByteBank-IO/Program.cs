using System;
using System.IO;
using System.Text;


namespace ByteBank_IO
{
  class Program
  {
    static void Main(string[] args)
    {
      var enderecoDoArquivo = "contas.txt";
      var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
      var numeroDeBytesLidos = -1;
      var buffer = new byte[1024]; //1KB

      numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

      fluxoDoArquivo.Read(buffer, 0, 1024);

      while (numeroDeBytesLidos != 0)
      {
        fluxoDoArquivo.Read(buffer, 0, 1024);
        EscreverBuffer(buffer);

      }


      Console.ReadLine();
    }
    static void EscreverBuffer(byte[] buffer)
    {

      var utf8 = new UTF8Encoding();

      var texto = utf8.GetString(buffer);
      Console.Write(texto);

      /*
      foreach (var meuByte in buffer)
      {
          Console.Write(meuByte);
          Console.Write(" ");
      }
      */
    }
  }
}

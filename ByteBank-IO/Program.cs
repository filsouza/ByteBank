﻿using System;
using System.IO;

namespace ByteBank_IO
{
  class Program
  {
    static void Main(string[] args)
    {
      var enderecoDoArquivo = "contas.txt";
      var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

      var buffer = new byte[1024]; //1KB

      fluxoDoArquivo.Read(buffer, 0, 1024);


      Console.ReadLine();
    }
  }
}

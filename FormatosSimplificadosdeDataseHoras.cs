using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace test
{
   public class Program
    {
      
     public static void Main(string[] args)
      {
        /* 
          A letra D em maiúscula, nos dá o formato da data por extenso. Vamos rodar a aplicação para ver o resultado.
          sábado, 23 de setembro de 2017
        */           
        DateTime data = new DateTime(2017, 9, 23);
        Console.WriteLine(data.ToString("D")); //Saturday, September 23, 2017

        /*
        Podemos utilizar esse formato para imprimir documentos legais, jornais, etc. 
        Se você quiser usar um formato diferente, por exemplo, a data sem o ano, usaremos a letra m.

        E como resultado, temos somente 23 de setembro que é uma data por extenso, porém está resumida. 
        O m minúsculo, geralmente significa minutos, mas quando ele vem sozinho, ele significa dia e mês por extenso.
         */
           Console.WriteLine(data.ToString("m")); //September 23


          Console.WriteLine(data.ToString("Y")); //setembro de 2017

          Console.WriteLine(data.ToString("G")); //9/23/2017 12:00:00 AM

          Console.WriteLine(data.ToString("g")); //9/23/2017 12:00 AM //sem os segundos

          /*
            Esse é um formato ideal para você fazer a conversão de volta de string para dateTime, sem ter nenhuma perda de conversão.

            Podemos lembrar que a letra "O", tem o formato de "vai e volta" e com isso podemos associar a esse formato. 
            Vamos ver se conseguimos transformar essa string em dateTime.
           */

           //ida de DataTime to String
        Console.WriteLine(data.ToString("O"));// 2017-09-23T13:14:15.9870000 

        //volta String to Datetime
        Console.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));//23/09/2017 00:00:00.000

        Console.WriteLine(data.ToString("t"));//12:00 AM



         
      }  
    }
}
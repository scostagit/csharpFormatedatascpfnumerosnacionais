using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Globalization;


namespace test
{
   public class Program
    {
      
     public static void Main(string[] args)
      {
     
        DateTime data = new DateTime(2017, 9, 23);
        Console.WriteLine(data);

        // Quando colocamos a letra d em minúsculo, estamos pedindo para mostrar somente a data sem a hora!
        Console.WriteLine(data.ToString("d")); //mostra so a data
        
        /*
        data no formato brasieliro
        é importante colocar o CultureInfo() sendo ele um tipo de formatação de data? Pois, nós podemos estar trabalhando
         com um computador que talvez não esteja na cultura brasileira, pode ser um servidor internacional, uma máquina de outro país, 
         ou outro cenário, o importante é garantir que a impressão dessa data seja no formato pt-BR.
         */
        Console.WriteLine(data.ToString("d", new CultureInfo("pt-BR", false)));

        //So dia e mes
        Console.WriteLine(data.ToString("dd/mm")); //20/00 Por que?
        
        /*
        Por que apareceu 00 no lugar do mês? Lembre-se que o ToString() é Case Sensitive, isto significa que o "m" minúsculo é o
         minuto e não o mês! Então devemos trocar o "m" minúsculo pelo "M" maiúsculo.
         */
          //Correto dia/mes
        Console.WriteLine(data.ToString("dd/MM")); 

        //Ano com dois digitos
        Console.WriteLine(data.ToString("dd/MM/yy"));
      }  
    }
}
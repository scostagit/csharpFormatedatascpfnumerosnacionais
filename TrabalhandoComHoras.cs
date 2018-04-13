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
        DateTime data = new DateTime(2017, 9, 23, 13, 14, 15, 987);
        Console.WriteLine(data);

        //Somente Hora e minuto       
        Console.WriteLine(data.ToString("hh:mm"));

        //Hora, munito, segundos e  millesegundo.
        Console.WriteLine(data.ToString("HH:mm:ss.fff"));
      }  
    }
}
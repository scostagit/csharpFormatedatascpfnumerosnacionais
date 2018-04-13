using System;
/*using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;*/
using Caelum.Stella.CSharp.Validation;

namespace test
{


   public class Program
    {
      
     public static void Main(string[] args)
      {
     
        string cpf1 = "86288366757";
        string cpf2 = "98745366797";
        string cpf3 = "22222222222";
		 
		ValidarCPF(cpf3);
      }
	   
	private static void ValidarCPF(string cpf)
    {
        try
        {
            new CPFValidator().AssertValid(cpf);
            Console.WriteLine("CPF válido: " + cpf);
        }
        catch (Exception exc)
        {
            Console.WriteLine("CPF inválido: " + cpf + " : " + exc.ToString());
        }
    }
      
     
    }


}
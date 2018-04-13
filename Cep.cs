using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;


namespace test
{
   public class Program
    {
      
     public static void Main(string[] args)
      {
     	string cep = "01001000";
		string url = "https://viacep.com.br/ws/" + cep + "/json/";
	
        /*
        Como resultado, não temos uma string, e sim uma Task, já que esse método é Assíncrono. Para extrair uma string 
        a partir dessa task, temos que consultar a propriedade Result. Essa propriedade transformará isso em um resultado síncrono, 
        sendo possível consumir o valor dele a partir de uma variável string.
         */
		string result = new HttpClient().GetStringAsync(url). Result;

        string urlXMl = "https://viacep.com.br/ws/" + cep + "/xml/";
        string resultXML = new HttpClient().GetStringAsync(urlXMl). Result;
	
		Console.WriteLine(result);
        Console.WriteLine(urlXMl);


        /*
             result
            {
                "cep": "01001-000",
                "logradouro": "Praça da Sé",
                "complemento": "lado ímpar",
                "bairro": "Sé",
                "localidade": "São Paulo",
                "uf": "SP",
                "unidade": "",
                "ibge": "3550308",
                "gia": "1004"
            }
            resultXML
            <?xml version="1.0" encoding="UTF-8"?>
            <xmlcep>
            <cep>01001-000</cep>
            <logradouro>Praça da Sé</logradouro>
            <complemento>lado ímpar</complemento>
            <bairro>Sé</bairro>
            <localidade>São Paulo</localidade>
            <uf>SP</uf>
            <unidade></unidade>
            <ibge>3550308</ibge>
            <gia>1004</gia>
            </xmlcep>
         */
      }  
    }
}
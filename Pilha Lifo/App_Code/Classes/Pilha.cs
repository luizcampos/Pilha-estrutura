using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Pilha
{
    public static List<String> Inserir(String palavra, List<String> pilhaPalavras)
    {
        if (pilhaPalavras.Count() == 0)
        {
            pilhaPalavras.Add(palavra);
        }
        else
        {
            pilhaPalavras.Add("");

            int tamanho = pilhaPalavras.Count();

            for (int i = tamanho - 1; i >= 0; i--)
            {
                if (pilhaPalavras[i] != "")
                    pilhaPalavras[i + 1] = pilhaPalavras[i];
            }

            pilhaPalavras[0] = palavra;
        }
        return pilhaPalavras;

    }

    public static String Mostrar(List<String> pilhaPalavras)
    {
        string dados = @"<table class='table table-hover table-striped' id='tabela'>
                                    <thead>
                                        <tr>
                                            <td>Palavra</td>
                                        </tr>
                                    </thead>
                                    <tbody>";

        foreach (String pa in pilhaPalavras) //a cada looping desse laço ele retorna um valor do pilhaPalavras para String
            dados += @"     <tr><td>" + pa + @"</td></tr>";

        dados += @"     </tbody></table>";
        return dados;
    }

    public static String Topo(List<String> pilhaPalavras)
    {
        //if(pilhaPalavras.Count() != 0)
        string dados = @"<table class='table table-hover table-striped' id='tabela'>
                                    <thead>
                                        <tr>
                                            <td>Palavra</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>" + pilhaPalavras[0] + @"</td>
                                        </tr>
                                    </tbody>
                        </table>";
        return dados;
    }

    public static void Retirar(List<String> pilhaPalavras)
    {
        pilhaPalavras.RemoveAt(0);
    }
}
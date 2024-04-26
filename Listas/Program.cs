using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //Adicionar na posição que quiser da lista
            list.Insert(2, "Gustavo");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Mostrar o tamanho da lista
            Console.WriteLine("List count:" + list.Count);

            //Mostrar na lista a primeira ocorrencia que começa com 'A'
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //Mostrar na lista a ultima ocorrencia que começa com 'A'
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' : " + s2);

            //Mostrar na lista a posição do primeiro elemento que começa com 'A'
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //Mostrar na lista a posição do ultimo elemento que começa com 'A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //Filtrar a lista com os elementos que satisfaçam o predicado
            List<string> list2 = list.FindAll(x => x.Length == 4);
            Console.WriteLine("----------------------");
            foreach (string obj in list2) 
            {
                Console.WriteLine(obj);
            }

            //Remover elementos da lista
            list.Remove("Alex");
            Console.WriteLine("----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TheLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            libLinkedList.ILinkedList<string> myList = new libLinkedList.SinglyLinkedList<string>();

            // Hinzufügen von 6 string-Variablen
            string[] strings = { "Algorithmen", "und", "Datenstrukturen", "finde", "ich", "super" };
            foreach (string s in strings)
            {
                myList.Add(s);
                Console.WriteLine("Hinzufügen: {0}",s);
            }


            // Prüfen ob bestimmte Werte in der Listen enthalten sind 
            string[] contains = { "Algorithmen", "Datenstrukturen", "Mathematik", "blöd", "super"};
            foreach (string s in contains)
            {
                Console.WriteLine("{0} vorhanden: {1}", s, myList.Contains(s));
            }


            // Ausgeben von Werten an bestimmter Stelle
            int[] idx = { 0, 5, 7, 2, 4, 3, 6 };
            foreach (int i in idx)
            {
                Console.WriteLine("An der Stelle {0} befíndet sich: '{1}'", i, myList.FindByIndex(i));
            }

            // Löschen von bestimmten Werten mit Ausgabe, ob der Wert danach nicht mehr enthalten ist
            string[] delete = { "und", "Datenstrukturen" };
            foreach (string s in delete)
            {
                myList.Remove(s);
                Console.WriteLine("Entferne '{0}'", s);
                Console.WriteLine("'{0}' vorhanden: {1}", s, myList.Contains(s));
            }

            foreach (object s in myList)
            {
                Console.WriteLine(s);
            }
            foreach (object s in myList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();











        }
    }
}

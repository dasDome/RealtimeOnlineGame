using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    // Die Implementierung wurde der Pseudocode-Version des Hauptartikels nachempfunden.
    public class Quicksort
    {/*
        private static Comparator<Object> co = new Comparator<Object>();

        public static void sort(List<Object> unorderedList)
        {
            Console.WriteLine("sort");
            quicksort(0, unorderedList.Count - 1, ref unorderedList);

        }
        private static void quicksort(int links, int rechts, ref List<Object> unorderedList)
        {
            Console.WriteLine("quicksort");
            if (links < rechts)
            {
                int teiler = teile(links, rechts, ref unorderedList);
                quicksort(links, teiler - 1, ref unorderedList);
                quicksort(teiler + 1, rechts, ref unorderedList);
            }

        }
        private static int teile(int links, int rechts, ref List<Object> unorderedList)
        {
            int i = links;
            //Starte mit j links vom Pivotelement
            int j = rechts - 1;
            Object pivot = unorderedList.ElementAt(rechts);

            do
            {
                //Suche von links ein Element, welches größer als das Pivotelement ist
                while (co.compare(unorderedList.ElementAt(i), pivot) == 1 && i < rechts)//daten[i] <= pivot && i < rechts
                    i += 1;

                //Suche von rechts ein Element, welches kleiner als das Pivotelement ist
                while (co.compare(unorderedList.ElementAt(j), pivot) == -1 && j > links)//(daten[j] >= pivot && j > links)
                    j -= 1;

                if (i < j)
                {
                    Object z = unorderedList.ElementAt(i);
                    unorderedList[i] = unorderedList.ElementAt(j);
                    // tausche daten[i] mit daten[j]
                    unorderedList[j] = z;
                }

            } while (i < j);
            //solange i an j nicht vorbeigelaufen ist 

            // Tausche Pivotelement (daten[rechts]) mit neuer endgültiger Position (daten[i])

            if (co.compare(unorderedList.ElementAt(i), pivot) == -1)
            {
                Object z = unorderedList.ElementAt(i);
                unorderedList[i] = unorderedList.ElementAt(rechts);
                // tausche daten[i] mit daten[rechts]
                unorderedList[rechts] = z;
            }
            Console.WriteLine("teile");
            return i; // gib die Position des Pivotelements zurück
        }


        */

    }
}


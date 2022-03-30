using System;

namespace SiralamaAlgoritmalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bubble Sort Algoritması
            void BubbleSort(int[] dizi)
            {
                int temp;
                for (int i = 0; i < dizi.Length; i++)
                {
                    for (int j = 1; j < dizi.Length - i; j++)
                    {
                        if (dizi[j - 1] > dizi[j])
                        {
                            //Swap işlemi
                            temp = dizi[j - 1];
                            dizi[j - 1] = dizi[j];
                            dizi[j] = temp;
                        }
                    }
                }
            }

            //Selection Sort Algoritması
            void SelectionSort(int[] dizi)
            {
                int minSayininIndisi,temp;
                for(int i = 0; i < dizi.Length; i++)
                {
                    minSayininIndisi = i;
                    for(int j = i + 1; j < dizi.Length; j++)
                    {
                        if(dizi[j] < dizi[minSayininIndisi])
                        {
                            minSayininIndisi = j;
                        }
                    }
                    //Swap işlemi
                    temp = dizi[i];
                    dizi[i] = dizi[minSayininIndisi];
                    dizi[minSayininIndisi] = temp;
                }
            }

            //Insertion Sort Algoritması
            void InsertionSort(int[] dizi)
            {
                int j,eleman;
                for(int i = 1; i < dizi.Length; i++)
                {
                    eleman = dizi[i];
                    j = i - 1;
                    while(j >= 0 && dizi[j] > eleman)
                    {
                        dizi[j + 1] = dizi[j];
                        j--;
                    }
                    dizi[j + 1] = eleman;
                }
            }

            //Kullanıcıdan sayılar alarak dizi oluşturma
            Console.Write("Dizi kaç elemanlı olsun: ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[elemanSayisi];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((i + 1) + ". elemanı girin: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Girdiğiniz dizi: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            //Bubble Sort'u çağırma
            BubbleSort(array);
            Console.WriteLine();
            Console.Write("Bubble Sort yöntemiyle sıralanmış dizi: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            //Selection Sort'u çağırma
            SelectionSort(array);
            Console.WriteLine();
            Console.Write("Selection Sort yöntemiyle sıralanmış dizi: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            //Insertion Sort'u çağırma
            InsertionSort(array);
            Console.WriteLine();
            Console.Write("Insertion Sort yöntemiyle sıralanmış dizi: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

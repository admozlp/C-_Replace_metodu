using System;

namespace ConsoleApp1
{
    class Program
    {
        static string rep(string metin,string s1, string s2)
        {
            string k1 = "";
            int degiseceklenght = 0;
            int metinlenght = 0;
            int lenghts2 = 0;
            foreach (char s in s1)            
                degiseceklenght++;
            foreach (char s in s2)
                lenghts2++;
            foreach (char s in metin)            
                metinlenght++;            
            int i = 0;
            int j=0;
            string dizi = "";
            int temp = degiseceklenght;
            while (i<metinlenght)
            {
                j = i;
                degiseceklenght = temp;
                degiseceklenght += j;
                dizi = "";
                while(j<degiseceklenght && j < metinlenght)
                {
                    dizi += metin[j];
                    j++;
                }
                if(dizi == s1)
                {               
                    int a = 0;
                    j = i;              
                    while (a < j)
                    {
                        k1 += metin[a];
                        a++;
                    }
                    degiseceklenght = temp;
                    int sinir = a + degiseceklenght;
                    int b = 0;
                    int sin = j + lenghts2;
                    while(j< sin)
                    {
                        k1 += s2[b];
                        b++;
                        j++;
                    }                                       
                    while (sinir < metinlenght)
                    {
                        k1 += metin[sinir];
                        sinir++;
                    }
                    return k1;
                }
                i++;
            }
            return k1;            
        }
        static void Main(string[] args)
        {
            string metin = "Merhaba Uzaya";
            string metin2 = rep(metin, "Merhaba", "Git");
            if (metin2 == "")
                Console.WriteLine("Metin içeriğinde bulunmuyor");
            else
                Console.WriteLine(metin2);
        }
    }
}

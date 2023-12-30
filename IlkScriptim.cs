using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void BolenleriBul(int ilkSayi, int ikinciSayi)
    {
        List<int> siraliSayilar = new List<int>();
        List<int> ikiyeBolunen = new List<int>();
        List<int> uceBolunen = new List<int>();
        List<int> dordeBolunen = new List<int>();
        List<int> beseBolunen = new List<int>();

        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            siraliSayilar.Add(i);

            if (i % 2 == 0)
                ikiyeBolunen.Add(i);
            if (i % 3 == 0)
                uceBolunen.Add(i);
            if (i % 4 == 0)
                dordeBolunen.Add(i);
            if (i % 5 == 0)
                beseBolunen.Add(i);
        }

        print("Sıralı Sayılar: " + string.Join("-", siraliSayilar));
        print("İkiye Bölünen Sayılar: " + string.Join("-", ikiyeBolunen));
        print("Üçe Bölünen Sayılar: " + string.Join("-", uceBolunen));
        print("Dörde Bölünen Sayılar: " + string.Join("-", dordeBolunen));
        print("Beşe Bölünen Sayılar: " + string.Join("-", beseBolunen));
    }

    private void Start()
    {
        BolenleriBul(6, 77);
    }
}
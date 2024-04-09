using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Test2 : MonoBehaviour
{


    void Start()
    {
        //  int a = 5;
        //  int b = 2;
        //  int c = 106735;
        //  ToonInformatie(a,b);
        //  Debug.Log(uitkomstVermenigvuldiging(a,b));
        //  Debug.Log(drieVermenigvuldiger(a, b, c));

        string voornaam = "Quinten";
        string achternaam = "Woolderink";
        int leeftijd = 14;

        Debug.Log( verwelkomingszin(voornaam, achternaam, leeftijd));

        oneidigeloop(100, 100);
    }

    void ToonInformatie(int num1, int num2)
    {
        int oplossing = num1 + num2;
        Debug.Log("antwoord " + oplossing);
    } 

    int uitkomstVermenigvuldiging(int num1, int num2)
    {
        int oplossing = num1 * num2;
        return oplossing;
    }


    int drieVermenigvuldiger(int num1, int num2, int num3)
    {
        int oplossing = num1 * num2 * num3;
        return oplossing;
    }

    //hallo voornaam, achternaam je bent leeftijd jaar oud!

    string verwelkomingszin(string voornaam, string achternaam, int leeftijd)
    {
        string deZin = "Hallo " + voornaam + ", " + achternaam + " je bent " +leeftijd + " jaar oud!";
        return deZin;
    }
    
    void oneidigeloop(int num1, int num2)
    {
        int antwoord = num1 * num2;
        for (int i = 1; i <= antwoord; i++)
        {
            Debug.Log(i);
        }

    }
}
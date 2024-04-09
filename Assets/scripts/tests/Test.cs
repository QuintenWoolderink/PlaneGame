using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        ToonInformatie("quinten", 14, 1.85);
        ToonInformatie("maurijn", 23, 1.96);
    }

    void ToonInformatie(string naam, int leeftijd, double lengte)
    {
        Debug.Log("Hallo " + naam);
        Debug.Log("Je bent " + leeftijd + " jaar oud");
        Debug.Log("Je lengte is " + lengte + " meter lang");

        if (magIkAlcoholDrinken(leeftijd))
        {
            Debug.Log("Je mag alcohol drinken");
        }else
        {
            Debug.Log("Je mag geen alcohol drinken");
        }

        if (atractieToegang(lengte))
        {
            Debug.Log("Je mag wel in de attractie");
        }else
        {
            Debug.Log("Je bent te klein");
        }
        string randomGreeting = getRandomGreeting();

        Debug.Log(randomGreeting);
    }



    bool magIkAlcoholDrinken(int leeftijd)
    {
        if(leeftijd >= 18)
        {
            return true;
        }else
        {
            return false;
        }
    }



    bool atractieToegang(double lengte)
    {
        if(lengte >= 1.55)
        {
            return true;
        }
        else
        { return false; }
    }

    string getRandomGreeting()
    {
        System.Random random = new System.Random();
        int randomInt = random.Next(2);

        if(randomInt == 0)
        {
            return "Hey hoi, hoe gaat het";
        }
        else if(randomInt == 1)
        {
            return "Hallo, hoe is het met jou?";
        }else
        {
            return "Goedendag!";
        }
    }



}




using System;
using System.Linq;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    [SerializeField] string frase;    
    
    char[] vogais = { 'a', 'e', 'i', 'o', 'u'};

    int consoantes;

    void Start()
    {

        foreach (char c in frase.ToLower())
        {
            if (Char.IsDigit(c) || !Char.IsLetter(c) || vogais.Contains(c))
            {
                continue;
            }
            consoantes++;
        }
        print("A frase possui "+ consoantes +" consoantes");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

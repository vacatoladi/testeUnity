using System;
using UnityEngine;

public class Exercicio04 : MonoBehaviour
{




    [SerializeField] bool HealthPotion;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (HealthPotion)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

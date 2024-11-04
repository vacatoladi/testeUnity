using UnityEngine;

public class Exercicio07 : MonoBehaviour
{

    int dado = 10;

    string numero;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int r = Random.Range(1, dado);
        numero = r.ToString();

        print("Dado de 10 faces caiu em "+numero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

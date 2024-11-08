using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class Exercicio08 : MonoBehaviour
{


    [SerializeField] int hora = 0;
    [SerializeField] int dia = 0;
    int delay = 10000;
    [SerializeField] float segundos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        segundos += Time.deltaTime;

        Task.Delay(delay).ContinueWith(_ =>
        {
            if (hora == 24)
            {
                print("se passaram "+dia+"dia");
                hora = 0;
                dia++;
            }
            else 
            { 
                hora++; 
            }
        });

        delay += 10000;


    }
}

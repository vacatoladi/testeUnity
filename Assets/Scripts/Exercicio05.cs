using UnityEngine;
using UnityEngine.UIElements;

public class Exercicio05 : MonoBehaviour
{



    [SerializeField] int exp = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(exp >= 50)
        {
            print("Missão bem-sucedida");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class Exercicio08 : MonoBehaviour
{
    int frames = 0;

    [SerializeField] int hora = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (frames >= 6600)
        {
            if (hora == 24)
            {
                hora = 0;
            }
            else
            {
                hora ++;
            }

            frames = 0;
        }
        else
        {
            frames++;
        }
        
    }
}

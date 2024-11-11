using UnityEngine;

public class RepeticaoEx05 : MonoBehaviour
{

    int dificuldade;
    int fases = 1;


    void Start()
    {
        while (fases <= 6)
        {
            dificuldade += 5;
            
            print("Fase "+ fases +" finalizada, dificuldade agora em "+dificuldade);

            fases++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

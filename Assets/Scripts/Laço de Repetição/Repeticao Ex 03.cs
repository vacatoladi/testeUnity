using UnityEngine;

public class RepeticaoEx03 : MonoBehaviour
{

    int fases = 10;
    int moedas = 0;

    void Start()
    {
        while (fases > 0)
        {
            moedas += 3;
            if (fases == 1)
            {
                print("Você coletou no total de "+moedas+" moedas");
            }
            fases--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

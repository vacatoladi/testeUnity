using UnityEngine;

public class RepeticaoEx04 : MonoBehaviour
{
    int combos = 6;
    int pontuacao;
    void Start()
    {
        while (combos >= 0)
        {
            pontuacao += 10;
            if (combos == 0)
            {
                print("pontuação total = "+pontuacao);
            }
            combos --;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

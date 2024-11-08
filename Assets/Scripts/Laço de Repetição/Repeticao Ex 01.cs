using System.Threading.Tasks;
using UnityEngine;

public class RepeticaoEx01 : MonoBehaviour
{

    int contagem = 5;
    int contagem2 = 5;
    int ms = 1000;

    void Start()
    {
        
        while (contagem >= 0)
        {
            Task.Delay(ms).ContinueWith(_ =>
            {
                if (contagem2 == 0)
                {
                    
                    print("Inicio da Partida!");
                }
                else
                {
                    print(contagem2);
                    contagem2-=1;
                }
            });
            ms += 1000;
            contagem--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

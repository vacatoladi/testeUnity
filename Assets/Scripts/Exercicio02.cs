using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    [SerializeField] bool PowerUp = false;
    void Start()
    {
        if (PowerUp == true)
        {
            print("Power up coletado");
        }
        else
        {
            print("Nenhum Power-up encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

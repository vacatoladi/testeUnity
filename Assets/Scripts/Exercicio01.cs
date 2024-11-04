using UnityEngine;

public class Exercicio01 : MonoBehaviour
{

    [SerializeField] int VidaPlayer = 100;

    string vida;

    void Start()
    {
        if (VidaPlayer <= 0)
        {
            vida = "GameOver";
            print(vida);
        }
        else
        {
            vida = "Personagem Vivo";
            print(vida);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

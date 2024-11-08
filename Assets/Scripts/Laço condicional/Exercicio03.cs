using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    [SerializeField] bool powerup = false;
    [SerializeField] int vida = 100;
    void Start()
    {
        if (vida <= 0 && powerup == false)
        {
            print("GameOver");
        } 
        else if (vida <= 0 && powerup == true)
        {
            
            print("Ainda não, vida atual 50");
            vida = 50;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

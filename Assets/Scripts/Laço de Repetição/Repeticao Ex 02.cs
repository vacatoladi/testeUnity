using UnityEngine;

public class RepeticaoEx02 : MonoBehaviour
{
    int golpe = 5;
    int Dano = 20;
    void Start()
    {
        while (golpe >= 0)
        {
            if (golpe == 0)
            {
                Dano = 20;
            } else
            {
                print("Você deu uma porrada de "+Dano+" de dano");
                Dano += 2;
            }
            golpe--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

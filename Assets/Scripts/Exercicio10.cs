using UnityEngine;

public class Exercicio10 : MonoBehaviour
{

    [SerializeField] int potion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Poção 0 = cura / Poção 1 = velocidade / Poção 2 = mana / Poção 3 = stamina");

        switch (potion)
        {
            case 0:
                print("Poção de cura ativada");
                break;

            case 1:
                print("Poção de velocidade ativada");
                break;
                
            case 2:
                print("Poção de mana ativada");
                break;

            case 3:
                print("Poção de stamina ativada");
                break;


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

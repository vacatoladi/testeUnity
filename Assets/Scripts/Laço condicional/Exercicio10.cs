using UnityEngine;

public class Exercicio10 : MonoBehaviour
{

    [SerializeField] int potion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Po��o 0 = cura / Po��o 1 = velocidade / Po��o 2 = mana / Po��o 3 = stamina");

        switch (potion)
        {
            case 0:
                print("Po��o de cura ativada");
                break;

            case 1:
                print("Po��o de velocidade ativada");
                break;
                
            case 2:
                print("Po��o de mana ativada");
                break;

            case 3:
                print("Po��o de stamina ativada");
                break;


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

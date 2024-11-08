using UnityEngine;

public class Exercicio06 : MonoBehaviour
{

    // 0 for warrior / 1 for mage

    [SerializeField] int ChosenChar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (ChosenChar)
        {
            case 0:
                print("Guerreiro escolhido");
                break;

            case 1:
                print("Mago escolhido");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using Unity.VisualScripting;
using UnityEngine;

public class Exercicio09 : MonoBehaviour
{

    [SerializeField] int TeamA;
    [SerializeField] int TeamB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (TeamA == TeamB && TeamA >= 3)
        {
            print("Um Empate emocionante");
        }
        else if (TeamA == TeamB)
        {
            print("Empate");
        }
        else if (TeamB > TeamA)
        {
            print("Time B venceu");
        }
        else
        {
            print("Time A venceu");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}


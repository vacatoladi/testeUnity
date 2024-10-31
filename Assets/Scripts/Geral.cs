using UnityEngine;

public class Geral : MonoBehaviour
{

    int PlayerHealth = 10;

    float CarSpeed = 125.5f;

    double Speed = 120.2;

    string PlayerName = "Rivenge";

    char Nickname = 'R';

    bool Alive = true;  

    void Start()
    {
        Debug.Log("hello World!!");

        print(PlayerName);

        print(Alive);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

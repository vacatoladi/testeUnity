using UnityEngine;

public class RepeticaoEx06 : MonoBehaviour
{
    int numero = 0;
    void Start()
    {
        while (numero <= 10000)
        {
            if (numero % 5 == 0 && numero % 3 == 0)
            {
                print("fizz buzz");
            } else if (numero % 5 == 0)
            {
                print("buzz");
            } else if(numero % 3 == 0)
            {
                print("fizz");
            } else
            {
                print(numero);
            }
            numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

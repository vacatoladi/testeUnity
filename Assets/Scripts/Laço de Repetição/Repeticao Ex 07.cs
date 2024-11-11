using UnityEngine;

public class RepeticaoEx07 : MonoBehaviour
{

    int[] Lotofacil = { 7, 2, 6, 5, 10, 21, 12, 9, 60, 1, 23, 45, 98, 25 };
    int maior;

    void Start()
    {
        foreach(int i in Lotofacil)
        {
            if(maior < i)
            {
                maior = i;
            }
        }
        print(maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

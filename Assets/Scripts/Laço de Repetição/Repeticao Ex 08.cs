using UnityEngine;

public class RepeticaoEx08 : MonoBehaviour
{

    [SerializeField] string frase = "";
    string novaFrase;

    void Start()
    {
        
        for (int i = frase.Length;i > 0;i--)
        {
            novaFrase += frase[i - 1];
        }
        print(novaFrase);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

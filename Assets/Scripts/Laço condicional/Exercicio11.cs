using UnityEngine;

public class Exercicio11 : MonoBehaviour
{

    [SerializeField] int mood;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        print("Npc Mood / 0 = feliz, 1 = triste, 2 = bravo, 3 = Medo");


        switch (mood) {
        
            case 0:
                print("Player\nVoc� poderia me emprestar a Vara de pesca");
                print("Pescador\nClaro, pega aqui");
                break;

            case 1:
                print("Player\nVoc� poderia me emprestar a Vara de pesca");
                print("Pescador\nPode pegar, mas voc� vai me devolver mesmo, n�?");
                break;

            case 3:
                print("Player\nVoc� poderia me emprestar a Vara de pesca");
                print("Pescador\nSe voc� n�o me devolver eu te quebro");
                break;

            case 4:
                print("Player\nVoc� poderia me emprestar a Vara de pesca");
                print("Pescador\nCla-claro, pode pegar, � toda sua, s� n�o me machuque");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

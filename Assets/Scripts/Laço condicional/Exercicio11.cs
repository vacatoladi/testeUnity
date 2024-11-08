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
                print("Player\nVocê poderia me emprestar a Vara de pesca");
                print("Pescador\nClaro, pega aqui");
                break;

            case 1:
                print("Player\nVocê poderia me emprestar a Vara de pesca");
                print("Pescador\nPode pegar, mas você vai me devolver mesmo, né?");
                break;

            case 3:
                print("Player\nVocê poderia me emprestar a Vara de pesca");
                print("Pescador\nSe você não me devolver eu te quebro");
                break;

            case 4:
                print("Player\nVocê poderia me emprestar a Vara de pesca");
                print("Pescador\nCla-claro, pode pegar, é toda sua, só não me machuque");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

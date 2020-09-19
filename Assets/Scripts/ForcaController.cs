using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForcaController : MonoBehaviour
{
    public Text time;
    public float timeInSeconds;
    //public float treasure;
    public Text huntedTreasure;
    public TreasureSpawner spawner;
    public GameObject restartGO;
    public int numberOfTreasures;
    private float initialTime;

    public Text numeroDeAcertos;
    public Text numeroDeErros;
    public Text textInputLetras;

    void Start()
    {
        initialTime = timeInSeconds;
            time.text = ((int)timeInSeconds).ToString();
               // treasure = 0;
                 //   huntedTreasure.text = "R$ 0,00";
    }

    void Update()
    {
       // huntedTreasure.text = "R$" + treasure;
            time.text = ((int)timeInSeconds).ToString();
                timeInSeconds -= Time.deltaTime;
                    if (timeInSeconds <= 0)
                    {
                        Time.timeScale = 0;
                            restartGO.SetActive(true);
                                GameObject.Find("txt_message").GetComponent<Text>().text = "Parabéns você coletou" + huntedTreasure.text + "!";
                    }
    }

    public void Restart()
    {
        timeInSeconds = initialTime;
           // treasure = 0;
               // huntedTreasure.text = "R$" + treasure;
                    time.text = ((int)timeInSeconds).ToString();
                        Time.timeScale = 1;
                            restartGO.SetActive(false);

        var treasureChests = GameObject.FindGameObjectsWithTag("Treasure");
            foreach (var chest in treasureChests)
            {
                Destroy(chest);
            }

        spawner.Spawn(numberOfTreasures);
    }

    public void VerficaletraDigitada()
    {
        var letraDigitada = GameObject.Find("TextInputLetras").GetComponent<Text>().text;
        if(letraDigitada.Length > 0)
        {
            letraDigitada = letraDigitada.Substring(letraDigitada.Length - 1);
            print(letraDigitada);
            var palavraTeste = "jogo";

        }


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer3 : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    public static float elapsedTime;  //VARIABILE TIMER PER OGNI LIVELLO
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = Timer2.elapsedTime;
    }

    // Update is called once per frame
    void Update()
    {
         if(timerText != null){
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        score = minutes * 60 + seconds;
        }
        
    }
}

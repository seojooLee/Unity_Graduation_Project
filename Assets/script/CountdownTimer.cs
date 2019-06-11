using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour 
{
    public static float   currentTime = 0f;
    public static float startingTime = 5f;
    float loadingTime = 5.0f;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        loadingTime -= Time.deltaTime;
        currentTime = startingTime;
    }
    void Update()
    {    
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0.0");
    if(currentTime<=3)
        {
            countdownText.color = Color.red;
        }
        if(currentTime <= 0)
        {
            currentTime = 0;
         }
    }
     
}

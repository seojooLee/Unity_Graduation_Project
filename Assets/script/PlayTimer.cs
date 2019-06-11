using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTimer : MonoBehaviour
{
    public int playtime = 0;//<< store later in playerprefs
    private int seconds = 0;
    private int minutes = 0;
    private int hours = 0;
    private int days = 0;
    private bool timeVisible = true;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Playtimer");
    }

    private IEnumerator Playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = (playtime % 60);
            minutes = (playtime / 60)%60;
             
        }
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(100, 100, 40, 40), "ShowTime"))
        {
            if (timeVisible)
                timeVisible = false;
            else timeVisible = true;
        }

        if(timeVisible)
        GUI.Label(new Rect(50, 50, 720, 58), "Playtime ="+minutes.ToString() + "분"+seconds.ToString() + "초"); 
    }

    void SetData()
    {
        PlayerPrefs.SetString("minutes", minutes.ToString());
        PlayerPrefs.SetString("second", seconds.ToString());
         
    } 
   

    // Update is called once per frame
    void Update()
    {
        
    }
}

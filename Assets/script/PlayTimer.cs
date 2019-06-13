using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//https://answers.unity.com/questions/424856/time-based-score-system.html

public class PlayTimer : MonoBehaviour
{
    public int playtime = 0;//<< store later in playerprefs
    public static int seconds = 0;
    public static int minutes = 0;
    public GameObject Canvas;
    public Text txt;
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
            minutes = (playtime / 60) % 60;
            txt.text = minutes.ToString() + "분" + seconds.ToString() + "초";

        }
    }

    //  public void OnGUI()
    //  {
    //if(GUI.Button(new Rect(100, 100, 40, 40), "ShowTime"))
    //{
    //    if (timeVisible)
    //        timeVisible = false;
    //    else timeVisible = true;
    //}

    // if(timeVisible)

    // GUI.Label(new Rect(50, 50, 720, 58), "Playtime ="+minutes.ToString() + "분"+seconds.ToString() + "초");

    // }

    void SetData()
    {
        PlayerPrefs.SetString("minutes", minutes.ToString());
        PlayerPrefs.SetString("second", seconds.ToString());

    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
    public static void stopTimer()
    {
        PlayerPrefs.SetString("minutes", minutes.ToString());
        PlayerPrefs.SetString("second", seconds.ToString());

    }


    // Update is called once per frame
    void Update()
    {

    }

}


//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;

//public class PlayTimer : MonoBehaviour
//{ 
//    float timer = 0;
//    public Text myText = null;
//    int intTimer = 0;
//    int counter = 0;
//    int ifstopTime = 0;


//    private void Update()
//    {
//        timer += Time.deltaTime;
//        if (ifstopTime == 0)
//            changeText();
//        else
//            myText.text = "";

//    }

//    public void changeText()
//    {
//        intTimer = (int)timer;
//        myText.text = "Timer : "+timer;

//    }
//    void Awake()
//    {
//        DontDestroyOnLoad(transform.gameObject);
//        if (FindObjectsOfType(GetType()).Length > 1)
//        { 
//            Destroy(gameObject);
//        }
//    }

//    public  void stopTimer()
//    {
//        counter++;
//        if (counter % 2 == 0)
//        {
//            ifstopTime = 1;
//        }
//        else
//        {
//            ifstopTime = 0;
//        }
//    } 
//}
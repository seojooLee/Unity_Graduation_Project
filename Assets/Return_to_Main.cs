using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Return_to_Main : TSceneController
{
    public static int CookieCount;
    public GameObject CookieDisplay;
    public int InternalCookie;
    SaveLoad Save = new SaveLoad();

    public Transform player;

    public override void Start()
    {
        base.Start();
        prevScene = "02.2Dfirst";
        if (prevScene == "02.2Dfirst")
        {
            player.position = new Vector3(44.8f, 5.11f, 12.36f);
        }
    }


    void Update()
    {
        InternalCookie = CookieCount;
        CookieDisplay.GetComponent<Text>().text = "클릭 수 : " + InternalCookie;

        if (CountdownTimer.currentTime == 0)
        {
            if (InternalCookie <= 2)
            {
                CookieDisplay.GetComponent<Text>().text = "실패";
                CookieDisplay.GetComponent<Text>().color = Color.red;
                SceneManager.LoadScene("02.2Dfirst");
                CountdownTimer.currentTime = 0;
                CookieDisplay.GetComponent<Text>().text = "클릭 수 : " + InternalCookie;

            }
            else
            {
                CookieDisplay.GetComponent<Text>().text = "성공";
                CookieDisplay.GetComponent<Text>().color = Color.blue;
                Debug.Log("성공했습니다.");
                SceneManager.LoadScene(1);


            }
        }




    }

}

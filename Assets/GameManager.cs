using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : TSceneController
{
    private int score = 0;

    

    [SerializeField]
    private Text scoreTxt;

    [SerializeField]
    private Text mainTxt;

    [SerializeField]
    private GameObject heart;


    //[SerializeField]
    //private Text sstxt;

    [SerializeField]
    private GameObject panel;

    public Transform player;
    public GameObject object1; //drag the gameobject which have that script you want to disable, in the inspector.
    robot script;


    public static GameManager _instance = null;
    public static GameManager instance {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    public void Score()
    {
        score++;
        scoreTxt.text = "모은 하트 수: " + score;

        if(score == 5)
        {
            GameOver();
            Debug.Log("asdf");
        }
        
    }

    private bool stopTrigger = false;

    public override void Start()
    {
        base.Start();
        prevScene = "03.2Dsecond";

      //  player.position = new Vector3(51.72f, 5.11f, 27.92f);
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("y", transform.position.y);
        PlayerPrefs.SetFloat("z", transform.position.z);
    }

    private void GameOver()
    {
        mainTxt.text = "성공!";
        stopTrigger = false;
        StopCoroutine(CreateHeartRoutine());
        panel.SetActive(true); 
        SceneManager.LoadScene(1);

    }


    public void GameStart()
    {
        stopTrigger = true;
        panel.SetActive(false);
        StartCoroutine(CreateHeartRoutine());
        Debug.Log("시작");
    }

    IEnumerator CreateHeartRoutine()
    {
        while (stopTrigger)
        {
            CreateHeart();
            yield return new WaitForSeconds(1);
        }
        
    }

    private void CreateHeart()
    {
        //Vector2 pos = new Vector2(1.15f, 2.73f);
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.1f, 0));
        pos.z = 0.0f;
        Instantiate(heart, pos, Quaternion.identity);
    }
}

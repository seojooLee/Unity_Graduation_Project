using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    public Text nameText;
    public Text scoreText;
    private System.Random random = new System.Random();
    public static int playerScore;
    public static string playerName;
    static User user = new User();
    //txt.text = PlayerPrefs.GetString("Name")+"님";


    // Start is called before the first frame update
    void Start()
    {
        playerScore = PlayerPrefs.GetInt("sec");
         scoreText.text = playerScore+"점";
 
    }
    public static void Onsubmit()
    {
       //playerName = nameText.text;
        playerName = PlayerPrefs.GetString("Name");

        PostToDataBase();
    }

    public void OngetScore()
    {

        // scoreText.text = RetrieveFromDataBase().userScore.ToString();
        RetrieveFromDataBase();
    }
 
    private void UpdateScore()
    {
         nameText.text = "" + user.userName; 
        scoreText.text = "" + user.userScore+"점";
    }
    public static  void Displayscore()
    {
        
        Debug.Log("Displayscore() 실행합니다. ");
        ScoreManager.seoseo = user.userName;
        ScoreManager.score_T = user.userScore;
         //score.SetScore(user.userName, "kills", user.userScore);


    }
    public static void PostToDataBase()
    {
        User user = new User();
        RestClient.Put("https://wizardsofoz-6659d.firebaseio.com/" + playerName + ".json", user);
    }

    private void RetrieveFromDataBase()
    {
 
        RestClient.Get<User>("https://wizardsofoz-6659d.firebaseio.com/" + playerName + ".json").Then(response =>
        {
            user = response;
            UpdateScore();
            Displayscore();
        });
 
    }
}

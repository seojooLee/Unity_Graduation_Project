using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    public InputField nameText;
    public Text scoreText;
    private System.Random random = new System.Random();
    public static int playerScore;
    public static string playerName;
    User user = new User();
    //txt.text = PlayerPrefs.GetString("Name")+"님";


    // Start is called before the first frame update
    void Start()
    {
         // playerScore = random.Next(0, 101);
        playerScore = PlayerPrefs.GetInt("time"); 

        //scoreText.text = "score : "+playerScore;

    }
    public void Onsubmit()
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
        scoreText.text = "Score Text : " + user.userScore;
    }
    private void PostToDataBase()
    {
        User user = new User();
        RestClient.Put("https://wizardsofoz-6659d.firebaseio.com/" + playerName + ".json", user);
    }

    private void RetrieveFromDataBase()
    {
        RestClient.Get<User>("https://wizardsofoz-6659d.firebaseio.com/" + nameText + ".json").Then(response =>
        {
            user = response;
            UpdateScore();
        });
 
    }
}

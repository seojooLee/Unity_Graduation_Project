using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScoreController : MonoBehaviour
{

    // The map we're building is going to look like:
    //
    //	LIST OF USERS -> A User -> LIST OF SCORES for that user
    //
    User user = new User();

    Dictionary<string, Dictionary<string, int>> playerScores;

    public static string seoseo;
    public static int score_T;
    public static int Min;
    int changeCounter = 0;

    void Start()
    {
    }

    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            DEBUG_INITIAL_SETUP();

        }  
    }

            void Init()
    {

        Debug.Log("ScoreManager : init() 함수 실행합니다 ");


        if (playerScores != null)
        {
            Debug.Log("playerScores null 이 아닙니다.  ");

            return;
        }
        else
        {
            Debug.Log("null 입니다. ");
        }

        playerScores = new Dictionary<string, Dictionary<string, int>>();
        Debug.Log("playerScores : " + playerScores);
    }

    public void Reset()
    {
        changeCounter++;
        playerScores = null;
    }

    public int GetScore(string username, string scoreType)
    {
        Init();

        if (playerScores.ContainsKey(username) == false)
        {
            // We have no score record at all for this username
            return 0;
        }

        if (playerScores[username].ContainsKey(scoreType) == false)
        {
            return 0;
        }

        return playerScores[username][scoreType];
    }

    public void SetScore(string username, string scoreType, int value)
    {
        Debug.Log("SetScore : " + seoseo + " : " + score_T);

        Init();

        Debug.Log("SetScore() 실행 " + username + "" + "" + value);


        changeCounter++;

        if (playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = new Dictionary<string, int>();
        }

        playerScores[username][scoreType] = value;
    }

    public void ChangeScore(string username, string scoreType, int amount)
    {
        Init();
        int currScore = GetScore(username, scoreType);
        SetScore(username, scoreType, currScore + amount);
    }

    public string[] GetPlayerNames()
    {
        Init();
        return playerScores.Keys.ToArray();
    }

    public string[] GetPlayerNames(string sortingScoreType)
    {
        Init();

        return playerScores.Keys.OrderByDescending(n => GetScore(n, sortingScoreType)).ToArray();
    }

    public int GetChangeCounter()
    {
        return changeCounter;
    }

    public void DEBUG_ADD_KILL_TO_QUILL()
    {
        ChangeScore("quill18", "min", 1);
    }

    public void DEBUG_INITIAL_SETUP()
    {
        Debug.Log(" DEBUG_INITIAL_SETUP : 기본 설정 창 실행 ");
 
        SetScore(seoseo, "kills", score_T);

        //SetScore(name, "kills", score_seo);

        //SetScore(name, "kills", score);
        //Debug.Log(name + ""  + "" + score);
        //SetScore(name, "kills" + score);
        //SetScore("bob", "kills", 1000);
        //SetScore("bob", "deaths", 14345);

        //SetScore("AAAAAA", "kills", 3);
        //SetScore("BBBBBB", "kills", 2);
        //SetScore("CCCCCC", "kills", 1);
        //SetScore(user.userName, "kills", user.userScore);

        Debug.Log(GetScore("quill18", "kills"));
    }

}

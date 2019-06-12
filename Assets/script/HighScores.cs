using System.Collections;
 using UnityEngine;
using UnityEngine.Networking;

public class HighScores : MonoBehaviour
{
    const string privateCode = "FukWGJ6CiEC1Aj1IpRg_vwX6ZqQNeUqUuoRDpLlbuSSA";
    const string publicCode = "5d01016e3ebb3b1870d0b44c";
    const string webURL = "http://dreamlo.com/lb/";

      void Awake()
    {
        AddNewHighscore("Sebastian", 50);
        AddNewHighscore("seojoo", 100);
        AddNewHighscore("mary", 30);
    }


    public void AddNewHighscore(string username, int score)
    {
        StartCoroutine(UploadNewHighscore(username,score));
    }


    IEnumerator UploadNewHighscore(string username, int score)
    {
      //   WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL(username) + "/" + score);
        UnityWebRequest www = UnityWebRequest.Get(webURL + privateCode + "/add/" + UnityWebRequest.EscapeURL(username) + "/" + score);

        yield return www;

        if (string.IsNullOrEmpty(www.error))
            print("Upload Successful");
        else
        {
            print("Error uploading " + www.error);
        }

    }



}

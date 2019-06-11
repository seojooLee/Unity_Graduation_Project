using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LoadMainView()
    {
        SceneManager.LoadScene("GameMain");
        //currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        //SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

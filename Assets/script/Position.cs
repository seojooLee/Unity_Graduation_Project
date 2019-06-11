using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour
{

    void Start()
    {
        load();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "trigger")
        {
            Application.LoadLevel("lvl2");
            save();
            Debug.Log("loading level");
        }

    }
    public void Back()
    {
        Application.LoadLevel("lvl1");
        load();
        Debug.Log("loading level and previous position");
    }

    void load()
    {
        if (PlayerPrefs.GetFloat("x") != null)
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
            save();
        }
    }

    void save()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("y", transform.position.y);
        PlayerPrefs.SetFloat("z", transform.position.z);
    }
}
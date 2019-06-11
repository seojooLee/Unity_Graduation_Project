using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItem : MonoBehaviour
{
    public GameObject item;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
       screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,Camera.main.transform.position.z));
        StartCoroutine(itemWave());
    }
    private void spawnThink()    {
        GameObject a = Instantiate(item) as GameObject;
        a.transform.position = new Vector2(36.12F, Random.Range(-screenBounds.y, screenBounds.y));
       // a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator itemWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnThink(); 
        }
    
    } 

}

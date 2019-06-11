using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : TSceneController
{ 
    public Transform player;
     private GameObject coin1; 
     // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
      //  Manager.SetActive(false);
        if(prevScene == "SampleScene")
        {  
         Destroy(GameObject.FindGameObjectWithTag("Coin"));
            player.position = new Vector3(44.8f, 5.11f, 12.36f);
 
            //2d게임이 여러개일 경우에는 playerprefebs를 사용해볼게용
            //그냥 new Vector3에 넣으면 될듯^^
            // Camera.main.transform.position = new Vector3(60f, 5f, -10f);
        } 
    }
     
}

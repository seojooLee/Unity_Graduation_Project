using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : TSceneController0
{
    public Transform player1;
    private GameObject coin1; 

    // Start is called before the first frame update
    public override void Start()
    {
        if (prevScene == "03.2Dsecond")
        {
            Destroy(GameObject.FindGameObjectWithTag("Coin2"));
        //    player1.position = new Vector3(51.72f, 5.11f, 27.92f);
            //2d게임이 여러개일 경우에는 playerprefebs를 사용해볼게용
            //그냥 new Vector3에 넣으면 될듯^^
            // Camera.main.transform.position = new Vector3(60f, 5f, -10f);
        }
    }

}

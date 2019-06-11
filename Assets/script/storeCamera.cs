using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storeCamera : MonoBehaviour
{
    public GameObject FPCamera;
    Vector3 cameraPosition;
     




    public void StoreCamera1()
    {
        cameraPosition = FPCamera.gameObject.transform.position;
 
        Debug.Log(cameraPosition);
  
    }
    public void RetrieveCamera()
    {
        FPCamera.transform.position = cameraPosition;
     }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class WebCam : MonoBehaviour
{
    int currentCamIndex = 0;
    public Text start;
    WebCamTexture tex;
    public RawImage display;
     

    public void SwapCam_Clicked()
    {
        if (WebCamTexture.devices.Length > 0)
        {
            currentCamIndex += 1;
            currentCamIndex %= WebCamTexture.devices.Length;
        } 
    }

    public void StartStopCam_Clicked()
    {
        if(tex != null)
        {
            display.texture = null;
            tex.Stop();
            tex = null;

        }
        else
        {
            WebCamDevice device = WebCamTexture.devices[currentCamIndex];
            tex = new WebCamTexture(device.name);
            display.texture = tex;
            float antiRotate = -(360 - tex.videoRotationAngle);
            tex.Play();


        }  
    }
 private string _SavePath =@"C:\Users\";
    int _CaptureCounter = 0;

   public void TakeSnapshot()
    {
        Texture2D snap = new Texture2D(tex.width, tex.height);
        snap.SetPixels(tex.GetPixels());
        snap.Apply();

        System.IO.File.WriteAllBytes(_SavePath + _CaptureCounter.ToString() + ".png",
            snap.EncodeToPNG());
        ++_CaptureCounter;

 
    }

    public RawImage rawimage;
    // Start is called before the first frame update
    

    void Start()
    {
        //rawimage.texture = tex;
        //rawimage.material.mainTexture = tex;
        // tex.Play();
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

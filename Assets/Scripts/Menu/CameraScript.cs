using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    public int currentCamIndex = 0;

    public RawImage display;

    //public Text startStopText;

    WebCamTexture tex;

    public void SwapCam_Clicked()
    {
        if(WebCamTexture.devices.Length > 0)
        {
            currentCamIndex += 1;
            currentCamIndex %= WebCamTexture.devices.Length;

            // if tex is not null:
            // stop the web cam
            // start the web cam

            if (tex != null)
            {
                StopWebCam();
                StartStopCam_Clicked();
            }
        }
    }

    public void StartStopCam_Clicked()
    {
        if(tex!= null)
        {
            StopWebCam();
            //startStopText.text = "Start Camera";
        }
        else
        {
            WebCamDevice device = WebCamTexture.devices[currentCamIndex];
            tex = new WebCamTexture(device.name);
            display.texture = tex;

            //float antiRotate = -(360 - tex.videoRotationAngle);
            //Quaternion quatRot = new Quaternion();
            //quatRot.eulerAngles = new Vector3(0, 0, antiRotate);
            //display.transform.rotation = quatRot;

            tex.Play();
            //startStopText.text = "Stop Camera";
        }
    }

    private void StopWebCam()
    {
        display.texture = null;
        tex.Stop();
        tex = null;
    }

}

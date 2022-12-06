using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject bakzplayer;
    public Camera main_camera;
    public float pixelToUnits=40f;
    public float smothTime=2f;
    private Vector3 velocity;
    
    
    void Update()
    {
        
        if (bakzplayer != null){
            float player_x = bakzplayer.transform.position.x;
            float player_y = bakzplayer.transform.position.y;
            float rounded_x = RoundToNearesPixel (player_x);
            float rounded_y = RoundToNearesPixel (player_y);

            Vector3 new_pos = new Vector3 (rounded_x, rounded_y , -10f);
            main_camera.transform.position = Vector3.SmoothDamp (main_camera.transform.position, new_pos, ref velocity, smothTime);
            
        }
    }
    public float RoundToNearesPixel(float unityUnits){
        float valueInpixsels = unityUnits* pixelToUnits;
        valueInpixsels =Mathf.Round (valueInpixsels);
        float roundedUnityunits = valueInpixsels*(1/pixelToUnits);
        return roundedUnityunits;
    }
}

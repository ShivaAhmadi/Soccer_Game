using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float moveSpeed=0.05f;
    
    void Start()
    {
        
    }

    void Update()
    {
       transform.position=Vector2.Lerp(transform.position,Camera.main.ScreenToWorldPoint (Input.mousePosition),moveSpeed);
       Vector3 difference= Camera.main.ScreenToWorldPoint(Input.mousePosition)- transform.position;
       difference.Normalize ();

       
       //float rotation_z=Mathf.Atan2 (difference.y , difference.x) * Mathf.Rad2Deg;
       //transform.rotation = Quaternion.Euler (0f,0f,rotation_z);
        
    }
}

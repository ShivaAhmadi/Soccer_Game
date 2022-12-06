using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    void Start()
    {
        int rand = Random.Range(0,2);
        if (rand ==0){
            this.GetComponent<Rigidbody2D> ().velocity=new Vector2 (-5f,0f);

        }
        else if (rand ==1){
            this.GetComponent <Rigidbody2D> ().velocity = new Vector2 (5f, 0f);
            
        }
        
    }


    void Update()
    {
        
    }
}

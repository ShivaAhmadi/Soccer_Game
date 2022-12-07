using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] public Vector2 minMaxVerticalPos;
    public Rigidbody2D rigid;
    public bool UseMovePosition;
    //private Transform gate;
    //private float distanceball = 0.1f;

    void Awake()
    {
    rigid = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        int rand = Random.Range(0,2);
        if (rand ==0){
            this.GetComponent<Rigidbody2D> ().velocity=new Vector2 (-5f,0f);

        }
        else if (rand ==1){
            this.GetComponent <Rigidbody2D> ().velocity = new Vector2 (5f, 0f);
            
        }
        
        //gate=GameObject.FindGameObjectWithTag ("gatetop").GetComponent<Transform>();
    }

    void Update()
    {
        /*if(Mathf.Lerp((ball.transform.position.x, gate.position, distanceball)))
        {

        }*/
    }

}

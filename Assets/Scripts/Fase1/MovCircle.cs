using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCircle : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField]private Transform p1, p2;
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private Transform p;

    [SerializeField]private float Vel;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        p = p1;
    }

    void Update(){

        if(rb.position == (Vector2)p1.position){
            p = p2;
        }
        else if(rb.position == (Vector2)p2.position){
            p = p1;
        }

        rb.position = Vector2.MoveTowards(rb.position, p.position, Vel*Time.deltaTime);
    }
}

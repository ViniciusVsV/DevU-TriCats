using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPlayer : MonoBehaviour{
   [SerializeField] private Transform Inicio;

   private Rigidbody2D rb;
   private int cont = 0;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if(cont == 0)
            rb.position = Inicio.position;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Circulo")){
            cont++;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Circulo")){
            cont--;
        }
    }
}
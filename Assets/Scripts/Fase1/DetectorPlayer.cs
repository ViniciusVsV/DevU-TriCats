using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DetectorPlayer : MonoBehaviour

{
   public int cont = 0;
   [SerializeField] private Transform Inicio;
   private Rigidbody2D rb;

   private void Start() {
        rb = GetComponent<Rigidbody2D>();
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
    private void Update() {
        if(cont == 0){
            rb.position = Inicio.position;
        }
        
    }

}

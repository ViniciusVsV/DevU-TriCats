using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSelector : MonoBehaviour{
    [SerializeField] private Transform catPosition;
    

    void Start(){
        catPosition = GetComponent<Transform>();
    }

    void Update(){
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        catPosition.position = mousePosition;
    }
}

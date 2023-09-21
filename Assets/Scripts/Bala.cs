using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    
    public float velocidad = 5f;

    void Start()
    {
        
    }

    void Update()
    {

        Vector2 novaPos = transform.position;
        novaPos.y += velocidad * Time.deltaTime;
        transform.position = novaPos;

        float limitealtoY = Camera.main.orthographicSize;

if (transform.position.y >= limitealtoY){

    Destroy(this.gameObject);
    
}
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numero : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {

        Vector2 nouPos = transform.position;
        nouPos.y = nouPos.y - 2f * Time.deltaTime;
        transform.position = nouPos;
        destruir();
    }

    private void destruir(){

        Vector2 costatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        if(transform.position.y <= costatInferiorIzq.y){

        Destroy(gameObject);

        }

    }
}

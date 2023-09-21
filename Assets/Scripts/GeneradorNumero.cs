using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNumero : MonoBehaviour
{
    
    public GameObject _prefabNumero;

    void Start()
    {
        InvokeRepeating("GenerarNumero", 1f, 3f);
    }



    void Update()
    {
        
    }

    private void GenerarNumero(){

        GameObject numero = Instantiate(_prefabNumero);
        Vector2 CostatSuperiorDer = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
        Vector2 CostatInferiorIzq = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        numero.transform.position = new Vector2(Random.Range(CostatSuperiorDer.x, CostatInferiorIzq.y), CostatSuperiorDer.y);
    }

}

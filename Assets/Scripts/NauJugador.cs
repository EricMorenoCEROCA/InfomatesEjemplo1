using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{

public float _velNau;

    void Start()
    {
        _velNau = 5f;
    }
    void Update()
    {
        float direccionHorizontal = Input.GetAxisRaw("Horizontal");
        float direccionVertical = Input.GetAxisRaw("Vertical");

        Vector2 direccionindicada = new Vector2(direccionHorizontal, direccionVertical).normalized;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        float anchura = spriteRenderer.bounds.size.x / 2;
        float limiteizquierdaX = -Camera.main.orthographicSize * Camera.main.aspect + anchura;
        float limitederechaX = Camera.main.orthographicSize * Camera.main.aspect - anchura;                        
        float limitealtoY = Camera.main.orthographicSize - anchura;
        float limitebajoY = -Camera.main.orthographicSize + anchura;

        Vector2 novaPos = transform.position;
        novaPos += direccionindicada * _velNau * Time.deltaTime;


        novaPos.x = Mathf.Clamp(novaPos.x, limiteizquierdaX, limitederechaX);
        novaPos.y = Mathf.Clamp(novaPos.y, limitebajoY, limitealtoY);

        transform.position = novaPos;

        if(Input.GetKeyDown(KeyCode.Space)){

            shoot();
            shoot1();

        }

    }

private void shoot(){
    GameObject Bala = Instantiate(Resources.Load("Prefabs/bala") as GameObject);
    Vector2 a = this.transform.position;
    a.x = a.x - 0.2f;
    Bala.transform.position = a;

}

private void shoot1(){
    GameObject Bala = Instantiate(Resources.Load("Prefabs/bala") as GameObject);
    Vector2 a = this.transform.position;
    a.x = a.x + 0.2f;
    Bala.transform.position = a;

}
}

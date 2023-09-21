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

        Vector2 direccionindicada = newVector2(direccionHorizontal, 0);
        Vector2 novaPos = transform.position;
        novaPos += direccionindicada * _velNau * Time.deltaTime;
        transform.position = novaPos;
    }
}

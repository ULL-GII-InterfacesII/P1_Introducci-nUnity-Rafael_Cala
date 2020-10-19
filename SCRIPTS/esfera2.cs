using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera2 : MonoBehaviour
{
    // Start is called before the first frame update
    private int counterClicked = 0;
    private int counterByFrame = 0;
    private const int ID = 2;

    void Start()
    {
        Debug.Log("Hello Object: " + gameObject.name + "\tID: " + ID);
    }

    // Update is called once per frame
    void Update()
    {
        counterByFrame++;
        Debug.Log("Iteracion numero: " + counterByFrame + " del objeto " + gameObject.name);
    }

    // Funcion que imprime un mensaje cada vez que se clicka sobre el collider del gameObject
    void OnMouseDown() {
        counterClicked++;
        Debug.Log("Ha pulsado en " + gameObject.name + " " + counterClicked + " veces.");
    }
}

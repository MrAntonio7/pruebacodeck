using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    //Atributos o propiedades
    private float vida = 100.0f;
    private bool muerto;

    public float Ataque(bool isParry, bool hayArma)
    {

        //Implementa aquí la función sobre la que se va a realizar la prueba
        if (vida > 0)
        {
            if (isParry) {
                vida = vida - 20;
            }
            if (hayArma)
            {
                vida = vida - 10;
            }
            else
            {
                vida = vida - 8;
            }

            return ComprobarVidaBoss(vida);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ComprobarVidaBoss(vida);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public float ComprobarVidaBoss(float vida)
    {
        if (vida <= 0)
        {
            this.muerto = true;
            Debug.Log("El boss ha muerto. Victoria!!");
            return vida;
        }
        else
        {
            this.muerto = false;
            Debug.Log("El boss sigue vivo, animo");
            return vida;
        }
    }
}
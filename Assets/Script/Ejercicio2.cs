using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // Start is called before the first frame update

    //Solicitar el ingreso del precio de 3 productos y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.

    public float producto1, producto2, producto3, dinero_disponible;

    void Start()
    {
        dinero_disponible = dinero_disponible - (producto1 + producto2 + producto3);

        if (dinero_disponible >= 0)
        {
            Debug.Log("La suma de los 3 productos NO supera el monto de dinero disponible");
            Debug.Log("Sobran: $" + dinero_disponible);
        }
        else
        {
            Debug.Log("La suma de los 3 productos SI supera el monto de dinero disponible");
            Debug.Log("Faltan: $" + dinero_disponible * -1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

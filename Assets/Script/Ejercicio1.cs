using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update

    //Crea un programa que pida dos números al usuario y responda si son iguales o no lo son.

    public int numero1;
    public int numero2;
    
    void Start()
    {
        if(numero1 == numero2)
        {
            Debug.Log("Los números son iguales");
        }
        else
        {
            Debug.Log("Los números no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

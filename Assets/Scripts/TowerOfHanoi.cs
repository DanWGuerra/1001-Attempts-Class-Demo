using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerOfHanoi : MonoBehaviour
{

    public int rings;

    void Start()
    {
        if(rings > 0)
        {
            towerOfHanoi(rings, 'A', 'C', 'B'); // A, B y C son los nombres de los ejes
        }
        else
        {
            Debug.Log("Cantidad de anillos no valida");
        }
        
    }

    void towerOfHanoi(int n, char fromRod, char toRod, char auxRod)
    {
        if (n == 1)
        {
            Debug.Log("Mover disco 1 desde el eje " + fromRod + " al eje " + toRod);
            return;
        }
        towerOfHanoi(n - 1, fromRod, auxRod, toRod);
        Debug.Log("Mover disco " + n + " desde el eje " + fromRod + " al eje " + toRod);
        towerOfHanoi(n - 1, auxRod, toRod, fromRod);
    }
}

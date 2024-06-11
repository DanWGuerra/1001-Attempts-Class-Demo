using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesla : MonoBehaviour
{
    [SerializeField]
    GameObject RayosFX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivarTesla());
    }

    IEnumerator ActivarTesla()
    {
        yield return new WaitForSeconds(1);
        RayosFX.SetActive(true);

    }
}

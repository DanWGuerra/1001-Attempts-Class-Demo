using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sierra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Muro"))
        {
            Destroy(gameObject);
        }
    }


}

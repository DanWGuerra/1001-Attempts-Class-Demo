using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public GameObject PrefabBala, Jugador;
    public Transform PosDisparo;
    public float CadenciaDisparo, velocidadBala;

    // Start is called before the first frame update
    void Start()
    {
        Jugador = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(Disparar());
    }

    // Update is called once per frame
    void Update()
    {
        VerAlJugador(); 
    }

    void VerAlJugador()
    {
        if(Jugador != null)
        {
            Vector3 direccion = Jugador.transform.position - transform.position;
            float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angulo);
        }
    }

    IEnumerator Disparar()
    {
        yield return new WaitForSeconds(CadenciaDisparo);
        GameObject BalaIns = Instantiate(PrefabBala);
        BalaIns.transform.position = PosDisparo.position;
        Rigidbody2D rbBala = BalaIns.GetComponent<Rigidbody2D>();
        rbBala.AddForce(PosDisparo.right * velocidadBala, ForceMode2D.Impulse);
        Destroy(BalaIns, 6f);
        StartCoroutine(Disparar());
    }
}

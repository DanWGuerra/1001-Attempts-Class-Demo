using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform PosIzq, PosDer;
    public GameObject Sierra;
    public float SpeedSierra;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemigos());
    }

    IEnumerator Enemigos()
    {
        if (GameManager.Vivo)
        {
            float seconds = Random.Range(3, 6);
            yield return new WaitForSeconds(seconds);
            int Pos = Random.Range(1, 3);
            if (Pos == 1)
            {
                GameObject sierraIns = Instantiate(Sierra);
                sierraIns.transform.position = PosIzq.position;
                sierraIns.GetComponent<Rigidbody2D>().velocity = new Vector2(SpeedSierra * Time.deltaTime, 0);
                if (sierraIns.transform.position.x >= 7.1)
                {
                    Destroy(sierraIns);
                }
            }
            else
            {

                GameObject sierraIns = Instantiate(Sierra);
                sierraIns.transform.position = PosDer.position;
                sierraIns.GetComponent<Rigidbody2D>().velocity = new Vector2(-SpeedSierra * Time.deltaTime, 0);
                if (sierraIns.transform.position.x <= -7f)
                {
                    Destroy(sierraIns);
                }

            }

            seconds = Random.Range(3, 6);
            yield return new WaitForSeconds(seconds);
            StartCoroutine(Enemigos());
        }
        
    }
}

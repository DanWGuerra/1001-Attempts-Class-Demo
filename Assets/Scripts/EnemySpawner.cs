using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform PosIzq, PosDer, PosMosca;
    public GameObject Sierra, Tesla, Mosca;
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
            int enemigo = Random.Range(1, 4);
            switch (enemigo)
            {
                //Sierra
                case 1:
                    int Pos = Random.Range(1, 3);
                    if (Pos == 1)
                    {
                        GameObject sierraIns = Instantiate(Sierra);
                        sierraIns.transform.position = PosIzq.position;
                        sierraIns.GetComponent<Rigidbody2D>().velocity = new Vector2(SpeedSierra * Time.deltaTime, 0);
                      
                    }
                    else
                    {

                        GameObject sierraIns = Instantiate(Sierra);
                        sierraIns.transform.position = PosDer.position;
                        sierraIns.GetComponent<Rigidbody2D>().velocity = new Vector2(-SpeedSierra * Time.deltaTime, 0);
                    

                    }
                    break;

                //Tesla
                case 2:
                    GameObject TeslaIns = Instantiate(Tesla);
                    float PosY = Random.Range(-1.64f, 3.1f);
                    TeslaIns.transform.position = new Vector2(7.46f, PosY);
                    Destroy(TeslaIns, 3.5f);
                    break;
        
                //Mosca
                case 3:
                    GameObject MoscaIns = Instantiate(Mosca);
                    MoscaIns.transform.position = PosMosca.position;
                    Destroy(MoscaIns, 5f);
                    break;

                default:
                    Debug.Log("Enemigo no existe");
                    break;
            }

            StartCoroutine(Enemigos());
        }
        
    }
}

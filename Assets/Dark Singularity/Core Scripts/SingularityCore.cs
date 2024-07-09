using UnityEngine;
//[RequireComponent(typeof(SphereCollider))]
public class SingularityCore : MonoBehaviour
{
    //This script is responsible for what happens when the pullable objects reach the core
    //by default, the game objects are simply turned off


    //void OnTriggerStay (Collider other) {
    //    if(other.GetComponent<SingularityPullable>()){
    //        other.gameObject.SetActive(false);
    //    }
    //}


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<SingularityPullable>())
        {
            collision.gameObject.SetActive(false);
        }
    }

    void Awake(){
        if(GetComponent<CircleCollider2D>()){
            GetComponent<CircleCollider2D>().isTrigger = true;
        }
    }
}

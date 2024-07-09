using UnityEngine;
//[RequireComponent(typeof(SphereCollider))]
public class Singularity : MonoBehaviour
{
    //This is the main script which pulls the objects nearby
    [SerializeField] public float GRAVITY_PULL = 100f;
    public static float m_GravityRadius = 1f;

    void Awake() {
        m_GravityRadius = GetComponent<CircleCollider2D>().radius;

        if(GetComponent<CircleCollider2D>()){
            GetComponent<CircleCollider2D>().isTrigger = true;
        }
    }
    
    //void OnTriggerStay (Collider other) {
    //    if(other.attachedRigidbody && other.GetComponent<SingularityPullable>()) {
    //        float gravityIntensity = Vector3.Distance(transform.position, other.transform.position) / m_GravityRadius;
    //        other.attachedRigidbody.AddForce((transform.position - other.transform.position) * gravityIntensity * other.attachedRigidbody.mass * GRAVITY_PULL * Time.smoothDeltaTime);
    //    }
    //}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.attachedRigidbody && collision.GetComponent<SingularityPullable>())
        {
            float gravityIntensity = Vector3.Distance(transform.position, collision.transform.position) / m_GravityRadius;
            collision.attachedRigidbody.AddForce((transform.position - collision.transform.position) * gravityIntensity * collision.attachedRigidbody.mass * GRAVITY_PULL * Time.smoothDeltaTime);
        }
    }
}

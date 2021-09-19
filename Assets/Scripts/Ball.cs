using UnityEngine;

public class Ball : MonoBehaviour
{
    public float damage = 10f;

    void OnCollisionEnter(Collision collision)
    {
        Target target = collision.collider.GetComponent<Target>();
        if(target != null)
        {
            target.TakeDamage(damage);
        }
    }
}

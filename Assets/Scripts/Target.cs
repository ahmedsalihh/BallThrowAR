using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
        //transform.RotateAround(gameObject.transform.position, Vector3.up, Time.deltaTime * 0.2f);
        //transform.RotateAround(gameObject.transform.position, Vector3.up, 20 * Time.deltaTime);

        if (transform.position.y > 1f)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {        
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

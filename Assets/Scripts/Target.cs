using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    float timeCounter = 0f;

    public float speed = 2f;
    public float width = 0.5f;
    public float height = 0.5f;

    Vector3 startPoint;

    void Start()
    {
        startPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
        //transform.RotateAround(gameObject.transform.position, Vector3.up, Time.deltaTime * 0.2f);
        //transform.RotateAround(gameObject.transform.position, Vector3.up, 20 * Time.deltaTime);

        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter * width) + startPoint.x;
        float y = Mathf.Sin(timeCounter * height) + startPoint.y;
        float z = startPoint.z;

        transform.position = new Vector3(x, y, z);

        //if (transform.position.y > 1f)
        //{
        //    Destroy(gameObject);
        //}
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

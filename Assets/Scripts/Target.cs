using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;


    public float speed;
    public float width;
    public float height;

    float timeCounter = 0f;
    Vector3 startPoint;

    int direction;

    void Start()
    {
        int number = Random.Range(1, 255);
        direction = number % 2 == 0 ? 1 : -1;

        Debug.Log(gameObject.name);
        Debug.Log(direction);
        startPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        timeCounter += Time.deltaTime * speed;

        float x = direction *  Mathf.Cos(timeCounter) * width + startPoint.x;
        float y = Mathf.Sin(timeCounter) * height + startPoint.y;
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

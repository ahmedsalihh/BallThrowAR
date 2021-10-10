using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100f;


    public float speed;
    public float width;
    public float height;

    float timeCounter = 0f;
    int direction = 0;
    Vector3 startPoint;

    void Start()
    {
        int number = Random.Range(1, 255);
        direction = number % 2 == 0 ? 1 : -1;
        startPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //Rigidbody rbTarget = gameObject.GetComponent<Rigidbody>();
        //Vector3 angularForce = AddForceAtAngle(speed, 100f, direction, startPoint);
        //
        //Debug.Log(angularForce);
        //
        //rbTarget.AddForce(angularForce);
    }

    //public Vector3 AddForceAtAngle(float force, float angle, int direction, Vector3 startPoint)
    //{
    //    angle *= Mathf.Deg2Rad;
    //    float xComponent = direction * Mathf.Cos(angle) * width + startPoint.x;
    //    float yComponent = Mathf.Sin(angle) * height + startPoint.y;
    //    float zComponent = gameObject.transform.position.z;
    //
    //    return new Vector3(xComponent, yComponent, zComponent);
    //}

    // Update is called once per frame
    void Update()
    {

        timeCounter += Time.deltaTime * speed;
        
        float x = direction *  Mathf.Cos(timeCounter) * width + gameObject.transform.position.x;
        float y = Mathf.Sin(timeCounter) * height + gameObject.transform.position.y;
        float z = gameObject.transform.position.z;
        
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

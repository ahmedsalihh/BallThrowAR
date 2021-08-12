using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject arCamera;
    Rigidbody rb;

    public float force = 500f;

    // Update is called once per frame
    void Update()
    {
        //if (Time.time >= nextTimeToFire)
        //{
        //    Instantiate(gameObject, arCamera.transform.position + arCamera.transform.forward * 1f, Quaternion.identity);
        //}
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            // add force to balls rigidbody in 3D space depending on swipe time, direction and throw forces
            rb.isKinematic = false;
            rb.AddForce(arCamera.transform.forward * 200f);

            // Destroy ball in 4 seconds
            Destroy(gameObject, 3f);

        }
        else if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

            Destroy(gameObject, 3f);

            Instantiate(gameObject, arCamera.transform.position + arCamera.transform.forward * 0.5f, Quaternion.identity);
        }
    }

    void Shoot()
    {
        rb = GetComponent<Rigidbody>();

        rb.isKinematic = false;
        rb.useGravity = true;
        rb.AddForce(arCamera.transform.forward * force);
    }
}

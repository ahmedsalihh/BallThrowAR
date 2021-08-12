using UnityEngine;

public class CanvasShoot : MonoBehaviour
{
    public Rigidbody ball;
    public GameObject arCamera;

    public float force = 350f;
    public float fireRte = 15f;
    private float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRte;
            Shoot();
        }
    }

    void Shoot()
    {
        Rigidbody ballGO = Instantiate(ball, arCamera.transform.position + arCamera.transform.forward * 0.5f, Quaternion.LookRotation(arCamera.transform.forward, arCamera.transform.up));
        ballGO.AddForce(arCamera.transform.forward * force);
    }
}

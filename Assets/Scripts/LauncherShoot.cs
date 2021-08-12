using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody ball;
    public Transform launcherEnd;
    public GameObject arCamera;

    public float force = 350f;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Rigidbody ballGO = Instantiate(ball, launcherEnd.position, launcherEnd.rotation);
        //    var dir = arCamera.transform.forward;
        //    dir.y = 0.0f;
        //    ballGO.AddForce(dir * force);
        //}

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            Rigidbody ballGO = Instantiate(ball, launcherEnd.position, launcherEnd.rotation);
            var dir = arCamera.transform.forward;
            dir.y = 0.0f;
            ballGO.AddForce(dir * force);
        }
    }

    //public Vector3 AddForceAtAngle(float force, float angle)
    //{
    //    angle *= Mathf.Deg2Rad;
    //    float xComponent = Mathf.Cos(angle) * force;
    //    float zComponent = Mathf.Sin(angle) * force;
    //    return new Vector3(xComponent, 0, zComponent);
    //}
}

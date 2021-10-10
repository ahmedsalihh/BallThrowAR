using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;
    
    void Start()
    {
        StartSpawn();
    }

    void StartSpawn()
    {

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            GameObject target = Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity);
            Rigidbody rbTarget = target.GetComponent<Rigidbody>();
            rbTarget.AddForce((Camera.main.transform.position - target.transform.position).normalized * 5000f);
        }
    }
}

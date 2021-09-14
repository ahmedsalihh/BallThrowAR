using UnityEngine;

public class BalloonsScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);

        if(transform.position.y > 1f)
        {
            Destroy(gameObject);
        }
    }
}

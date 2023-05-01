using UnityEngine;

public class Rock : MonoBehaviour 
{
    private float speed = 3f;
    private float xLimit = -5f;

    private void Update() 
    {
        if (transform.position.x < xLimit) Destroy(gameObject);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
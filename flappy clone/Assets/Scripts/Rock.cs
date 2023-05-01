using UnityEngine;

public class Rock : MonoBehaviour 
{
    private float speed = 3f;
    private float xLimit = -5f;

    private void Start()
    {
        GameManager.instance.EndGame += GameOver;
    }

    private void Update() 
    {
        if (transform.position.x < xLimit) Destroy(gameObject);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void GameOver()
    {
        speed = 0;
    }

    private void OnDestroy() 
    {
        GameManager.instance.EndGame -= GameOver;
    }
}
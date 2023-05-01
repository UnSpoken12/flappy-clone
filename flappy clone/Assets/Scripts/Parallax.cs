using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float xLimit = -6.2f;
    private float speed = 5f;

    [SerializeField] private Transform[] list;
    
    void Update()
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].position.x < xLimit) list[i].position = Vector3.zero;
            list[i].Translate(Vector3.left * (speed / (i+1)) * Time.deltaTime);
        }
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}

using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float xLimit = -6.2f;
    private float speed = 1f;
    [SerializeField] private Transform[] list;
    
    void Update()
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].position.x < xLimit) list[i].position = Vector3.zero;
            list[i].Translate(new Vector3(-1, 0, 0) * (speed / (i+1)) * Time.deltaTime);
        }
    }
}

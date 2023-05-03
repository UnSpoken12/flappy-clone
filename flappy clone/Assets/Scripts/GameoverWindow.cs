using UnityEngine;

public class GameoverWindow : MonoBehaviour
{
    private void OnEnable() => GetComponent<Animator>().SetTrigger("Gameover");
}

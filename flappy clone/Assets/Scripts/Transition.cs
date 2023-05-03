using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private float transitionTime = 1.15f;

    public void FadeIn()
    {
        StartCoroutine(nameof(FadeTransition));
    }

    private IEnumerator FadeTransition()
    {
        anim.SetTrigger("BeginFade");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

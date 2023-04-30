using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIHandler ui;
    [SerializeField] private Parallax background;
    [SerializeField] private GameObject player;

    private float lerpSpeed = 0.5f;
    private float initialTime;
    public float score;

    void Start()
    {
        ui.gameStarted += GameStart;
    }

    private void Update() 
    {
        score = background.GetSpeed() * (Time.time - initialTime);
    }

    private void GameStart()
    {
        StartCoroutine(nameof(StartingAnimation));
        score = 0;
    }

    private IEnumerator StartingAnimation()
    {
        Vector3 startPoint = new(-3.5f, -1.1f, 0f);
        Vector3 endPoint = new(-2f, -1.1f, 0);
        float journeyLength = Vector3.Distance(startPoint, endPoint);
        initialTime = Time.time;

        float distanceCovered = (Time.time - initialTime) * lerpSpeed;
        float fractionOfJourney = distanceCovered / journeyLength;

        while (fractionOfJourney < 1)
        {
            distanceCovered = (Time.time - initialTime) * lerpSpeed;
            fractionOfJourney = distanceCovered / journeyLength;
            player.transform.position = Vector3.Lerp(startPoint, endPoint, fractionOfJourney);
            yield return null;
        }
    }

    private void OnDisable() 
    {
        ui.gameStarted -= GameStart;
    }
}
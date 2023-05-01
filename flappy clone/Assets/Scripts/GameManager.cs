using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private State gameState;

    public event Action EndGame = delegate { };

    [SerializeField] private UIHandler ui;
    [SerializeField] private Parallax background;
    [SerializeField] private Spawner spawner;
    [SerializeField] private GameObject player;

    private float lerpSpeed = 0.5f;
    private float initialTime;
    public float score = 0;

    private void Awake() 
    {
        instance = this;
    }

    private void Update() 
    {
        if (gameState == State.Running)
        {
            score = background.GetSpeed() * (Time.time - initialTime);
        }

        if (Input.GetKeyDown(KeyCode.L)) 
        {
            ChangeGameState(State.End);
        }
    }

    public void ChangeGameState(State newState)
    {
        gameState = newState;
        switch (gameState)
        {
            case State.Start:
                StartCoroutine(nameof(StartingAnimation));
                break;
            case State.Running:
                initialTime = Time.time;
                break;
            case State.End:
                background.SetSpeed(0);
                spawner.SetSpawning(false);
                EndGame();
                // Change player animation
                break;
        }
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

        ChangeGameState(State.Running);
    }
}

public enum State 
{
    Start,
    Running,
    End
}
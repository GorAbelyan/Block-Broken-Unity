using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle1;
    [SerializeField] AudioClip[] Audio;

    public Vector2 PaddleToballVector;
    bool isStarted = false;

    AudioSource myAudioSource;

    void Start()
    {
        PaddleToballVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        LockBallToPaddle();
        LaunchOnMouseClick();
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 10f);
            isStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        if (isStarted) return;
        Vector2 paddlepos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + PaddleToballVector;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isStarted)
        {
            AudioClip clip = Audio[UnityEngine.Random.Range(0, Audio.Length)];
            myAudioSource.PlayOneShot(clip);
        }
    }
}

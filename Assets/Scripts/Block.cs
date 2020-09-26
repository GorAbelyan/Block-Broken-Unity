using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip Clip;
    Level1 level;
    GameStatus status;

    private void Start()
    {
        level = FindObjectOfType<Level1>();
        status = FindObjectOfType<GameStatus>();
        level.countingBlock();
    }
    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(Clip, Camera.main.transform.position);
        Destroy(gameObject, 0.05f);
        level.BlockDestroyed();
        status.AddToScore();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }
}

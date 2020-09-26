using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level1 : MonoBehaviour
{

    [SerializeField] public int blockingBreaksCount = 0;

    StartScripts sceneLoader;
    public void Start()
    {
        sceneLoader = FindObjectOfType<StartScripts>();
    }

    public void countingBlock()
    {
        blockingBreaksCount++;
    }
    public void BlockDestroyed()
    {
        blockingBreaksCount--;
        if (blockingBreaksCount <= 0)
        {
            sceneLoader.StartGameButton();
        }
    }
}

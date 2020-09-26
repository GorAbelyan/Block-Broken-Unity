using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] Camera MainCamera;

    void Start()
    {

    }

    void Update()
    {

        Vector2 paddlePosition = new Vector2(Input.mousePosition.x / Screen.width * MainCamera.transform.position.x*2, 1f);
        paddlePosition.x = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16f, minX, maxX);
        transform.position = paddlePosition;
        Debug.Log(transform.position);
    }
}

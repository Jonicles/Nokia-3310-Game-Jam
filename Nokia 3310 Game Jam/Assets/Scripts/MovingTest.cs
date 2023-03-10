using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTest : MonoBehaviour
{
    float speed = -3;
    GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.Instance;
    }
    void Update()
    {
        transform.position += new Vector3(0, gameManager.PixelSize * speed) * Time.deltaTime;
    }
}

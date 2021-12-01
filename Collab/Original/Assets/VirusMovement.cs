using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 movedirection;
    private Transform playerPos;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("bacteria player").GetComponent<Transform>();
        movedirection = new Vector2(playerPos, 1);
    }

    void Update()
    {

        rb.AddForce(movedirection * speed * Time.deltaTime, ForceMode2D.Impulse);

    }
}

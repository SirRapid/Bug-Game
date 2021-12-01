using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    public float speed;
    private Transform playerPos;

    void Start(){
        playerPos = GameObject.FindGameObjectWithTag("virus").GetComponent<Transform>();
    }

    void Update(){

        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

}
}

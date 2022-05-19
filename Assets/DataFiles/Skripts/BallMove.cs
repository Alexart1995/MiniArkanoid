using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float speed = 5.0f;
    void Start()
    {
        MoveBall(new Vector2(0,1));
    }
    public void MoveBall(Vector2 dir)
    {
        Rigidbody2D Ball;
        Ball = GetComponent<Rigidbody2D>();
        dir = dir.normalized;
        Ball.velocity = dir * speed;
        Ball.AddForce(Ball.velocity * speed);
    }
}

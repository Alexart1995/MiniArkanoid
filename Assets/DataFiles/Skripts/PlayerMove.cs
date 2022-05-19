using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;

    
    public Rigidbody2D rack;

    public void MoveLeft()
    {
        rack.velocity = Vector2.left * speed;
    }

    public void MoveRight()
    {
        rack.velocity = Vector2.right * speed;
    }
    public void StopMove()
    {
        rack.velocity = Vector2.zero;
    }



    //private void FixedUpdate()
    //{
    //    rack.velocity = new Vector2(-1, 0) * speed;
    //}
    //public void LeftMove()
    //{

        //rack.transform.position = new Vector3(tra);
    //    rack.velocity = new Vector2(-1, 0) * speed;
    //}
    //public void RightMove()
    //{
    //    rack.velocity = new Vector2(1, 0) * speed;
    //}

    //private void FixedUpdate()
    //{
    //    float v = Input.GetAxisRaw("Horizontal");
    //    GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    //}
}

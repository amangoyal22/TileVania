using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Controls
    [SerializeField] private float moveSpeed = 1f;
    
    // cache
    private Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (IsFacingRight())
        {
            myRigidBody.velocity = new Vector2(moveSpeed,0f);
        }
        else
        {
            myRigidBody.velocity = new Vector2(-moveSpeed,0f);
        }
    }

    public bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.velocity.x)),1f);
    }
}

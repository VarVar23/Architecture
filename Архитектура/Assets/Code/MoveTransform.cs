using System;
using UnityEngine;

class MoveTransform : IMove
{
    private Rigidbody2D _rigidBody;
    private Vector3 _move;
    public float Speed { get; protected set; }

    public MoveTransform(Rigidbody2D rigidbody, float speed)
    {
        _rigidBody = rigidbody;
        Speed = speed;
    }  

    public void Move(float horizontal, float vertical, float deltaTime)
    {
        var speed = Speed * deltaTime;
        _move.Set(horizontal * speed, vertical * speed, 0);
        _rigidBody.AddForce(_move);
    }
}


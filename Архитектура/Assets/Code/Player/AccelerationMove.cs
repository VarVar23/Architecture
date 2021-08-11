using UnityEngine;
internal class AccelerationMove : MoveTransform
{
    private float _acceleration;

    public AccelerationMove(Rigidbody2D rigidbody, float speed, float acceleration)
        : base (rigidbody, speed)
    {
        _acceleration = acceleration;
    }

    public void AddAcceleration() =>
        Speed += _acceleration;

    public void DecAcceleration() =>
        Speed -= _acceleration;
}


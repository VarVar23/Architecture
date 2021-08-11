using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Transform _player;
    private Vector3 _move;

    private void Start() =>
        _player = FindObjectOfType<Player>().transform;

    void Update() =>
        Move();

    private void Move()
    {
        _move.Set(_player.position.x, 0, -10);
        transform.position = _move;
    }
}

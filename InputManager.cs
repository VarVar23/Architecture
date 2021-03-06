using System;
using UnityEngine;

class InputManager : MonoBehaviour, IInput
{
    private Player _player;

    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }
    public float DeltaTime { get; private set; }
    public bool Fire1 { get; private set; }

    private void Start() =>
        _player = FindObjectOfType<Player>();

    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Fire1 = Input.GetButtonDown("Fire1");
        DeltaTime = Time.deltaTime;

        _player.InputManager(this);
    }
}


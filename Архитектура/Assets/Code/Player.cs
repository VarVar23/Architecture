using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _acceliration;
    [SerializeField] private Rigidbody2D _bullet;
    [SerializeField] private Transform _barrel;
    [SerializeField] private float _force;
    [SerializeField] private int _damage;
    private Rigidbody2D _rigidBody;
    private IMove _moveTransform;
    private IInput _inputManager;
    private IShoot _shoot;
    private IDamager _damager;

    public float Hp;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _moveTransform = new AccelerationMove(_rigidBody, _speed, _acceliration);
    }

    private void Update()
    {
        _moveTransform.Move(_inputManager.Horizontal, _inputManager.Vertical, _inputManager.DeltaTime);
        
        if(_inputManager.Fire1)
        {
            _shoot.ShootBullet(_rigidBody, _barrel);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) =>
        _damager.Damage(this, _damage);
        
    public void InputManager(IInput input) =>
        _inputManager = input;

    public void Shoot(IShoot shoot) =>
        _shoot = shoot;

    public void Damager(IDamager damager) =>
        _damager = damager;
}

using UnityEngine;

class Shoot : MonoBehaviour, IShoot
{
    private float _force = 5;

    public Shoot(float force) =>
        _force = force;

    private void Start() =>
        FindObjectOfType<Player>().Shoot(this);

    public void ShootBullet(Rigidbody2D prefabBullet, Transform pointBullet)
    {
        var bullet = Instantiate(prefabBullet, pointBullet.position, pointBullet.rotation);
        bullet.AddForce(pointBullet.up * _force);
    }
}


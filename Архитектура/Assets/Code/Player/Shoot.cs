using UnityEngine;

public class Shoot : MonoBehaviour, IShoot
{
    [SerializeField] private float _force = 200;

    //public Shoot(float force) => // Не понимаю, зачем нам конструктор, к которому мы не обращаемся (Объект нигде не создается)
    //    _force = force;

    private void Start() =>
        FindObjectOfType<Player>().Shoot(this);

    public void ShootBullet(Rigidbody2D prefabBullet, Transform pointBullet, BulletPool<Bullet> pool)
    {
        //var bullet = Instantiate(prefabBullet, pointBullet.position, pointBullet.rotation); было до пула
        var bullet = pool.GetFreeElement();
        bullet.transform.position = pointBullet.position;
        bullet.GetComponent<Rigidbody2D>().AddForce(pointBullet.up * _force);
    }
}


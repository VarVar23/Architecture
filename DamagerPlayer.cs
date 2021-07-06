using UnityEngine;
class DamagerPlayer : MonoBehaviour, IDamager
{

    private void Start()
    {
        
    }
    public void Damage(Player player, int damage)
    {
        player.Hp -= damage;

        if(player.Hp <= 0)
        {
            Death(player);
        }
    }

    private void Death(Player player) =>
        Destroy(player);

}


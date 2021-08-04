using UnityEngine;

namespace EnemyNamespace
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private GameObject _skillBox;
        void Start()
        {
            // Enemy.CreateSkillBoxEnemy(new Health(100f, 100f)); // Не получилось разобраться с фабрикой :(

            // Как понял я:
            Enemy.SkillBox = _skillBox;
            Enemy.CreateSkillBoxEnemyByOleg(new Health(100f, 100f)); 
        }
    }
}


using UnityEngine;

namespace EnemyNamespace
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private GameObject _skillBox;
        void Start()
        {
            // Enemy.CreateSkillBoxEnemy(new Health(100f, 100f)); // �� ���������� ����������� � �������� :(

            // ��� ����� �:
            Enemy.SkillBox = _skillBox;
            Enemy.CreateSkillBoxEnemyByOleg(new Health(100f, 100f)); 
        }
    }
}


using UnityEngine;

namespace EnemyNamespace
{
    public class Enemy : MonoBehaviour
    {
        public Health Health { get; private set; }
        public static GameObject SkillBox;

        [SerializeField] private float _speed;

        private IMoveEnemy _move;

        private void Start() =>
            _move = new MoveEnemy(_speed, this);


        private void Update() =>
            _move.Move(Time.deltaTime);


        //public static SkillBox CreateSkillBoxEnemy(Health hp)
        //{
        //    var skillBoxEnemy = Instantiate(Resources.Load<SkillBox>(Constance.SkillBoxPath));
        //    skillBoxEnemy.Health = hp;

        //    return skillBoxEnemy;
        //}

        // �� ������� �����������, ���� ���� ���, ��� � ����� :(

        public static GameObject CreateSkillBoxEnemyByOleg(Health hp)
        {
            var skillBoxEnemy = Instantiate(SkillBox, Vector3.zero, Quaternion.identity);
            return skillBoxEnemy;
        }
    }
}


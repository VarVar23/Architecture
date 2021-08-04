using UnityEngine;

namespace EnemyNamespace
{
    class MoveEnemy : IMoveEnemy
    {
        public float Speed { get; private set; }
        private Enemy _enemy; 

        public MoveEnemy(float speed, Enemy enemy)
        {
            Speed = speed;
            _enemy = enemy;
        }

        public void Move(float deltaTime) =>
            _enemy.transform.Translate(Vector3.right * Speed * deltaTime); /* Тут можно было бы прописать логику движения и я честно верю, что 
                                                                              когда-нибудь она будет адекватной */
        
    }
}

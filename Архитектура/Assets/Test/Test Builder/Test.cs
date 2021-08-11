using UnityEngine;


class Test : MonoBehaviour
{
    private GameObjectBuilder gameObjectBuilder => new GameObjectBuilder();
    [SerializeField] private Transform _parent;
    [SerializeField] private Sprite _sprite;
    private void Start()
    {
        GameObject newGameObject = gameObjectBuilder.Visual.Name("OOO").Scale(new Vector3(0.25f, 0.25f, 0.25f)).Sprite(_sprite).Physics.CircleCollider2D().Rigidbody2d();
        newGameObject.transform.SetParent(_parent);
    }
}


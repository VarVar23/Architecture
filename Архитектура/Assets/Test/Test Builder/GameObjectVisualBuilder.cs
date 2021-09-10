using UnityEngine;

public class GameObjectVisualBuilder : GameObjectBuilder
{
    public GameObjectVisualBuilder(GameObject gameObject)
        : base(gameObject) { }
    
    public GameObjectVisualBuilder Name(string name)
    {
        _gameObject.name = name;
        return this;
    }

    public GameObjectVisualBuilder Sprite(Sprite sprite)
    {
        var component = GetOrAddComponet<SpriteRenderer>();
        component.sprite = sprite;

        return this;
    }

    public GameObjectVisualBuilder Scale(Vector3 scale)
    {
        var component = GetOrAddComponet<Transform>();
        component.localScale = scale;

        return this;
    }

    private T GetOrAddComponet<T>() where T : Component
    {
        var result = _gameObject.GetComponent<T>();

        if(!result)
        {
            result = _gameObject.AddComponent<T>();
        }

        return result;
    }
}


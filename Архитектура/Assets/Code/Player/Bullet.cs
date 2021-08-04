using UnityEngine;
using System.Collections;
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _timeLife;

    private void OnEnable() =>
        StartCoroutine(nameof(LifeTime));

    private void OnDisable() =>
        StopCoroutine(nameof(LifeTime));

    private void Deactivate() =>
    gameObject.SetActive(false);



    private IEnumerator LifeTime()
    {
        yield return new WaitForSecondsRealtime(_timeLife);

        Deactivate();
    }


   
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _spawnSpeed = 2f;

    private bool _isActive = true;
    private Coroutine _coroutine;

    private void Start()
    {
        _coroutine = StartCoroutine(GetSkeleton());
    }
    private void OnDisable()
    {
        StopCoroutine(_coroutine);
        _isActive = false;
    }

    private IEnumerator GetSkeleton()
    {
        var wait = new WaitForSeconds(_spawnSpeed);

        while (_isActive)
        {
            SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

            spawnPoint.CreateEnemy();

            yield return wait;
        }
    }
}

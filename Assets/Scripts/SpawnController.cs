using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] SpawnPoint[] _spawnPoints;
    [SerializeField] float _spawnSpeed = 2f;
    [SerializeField] Skeleton _skeleton;

    private bool _isActive = true;
    private Coroutine _coroutine;
    private int _minRotationAngle = 0;
    private int _maxRotationAngle = 360;

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
        while (_isActive)
        {
            var wait = new WaitForSeconds(_spawnSpeed);
            SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            Quaternion direction = Quaternion.Euler(0, Random.Range(_minRotationAngle, _maxRotationAngle + 1), 0);
            Instantiate(_skeleton, spawnPoint.transform.position, direction);

            yield return wait;
        }
    }
}

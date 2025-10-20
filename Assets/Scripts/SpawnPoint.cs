using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Enemy _enemy;

    public void CreateEnemy()
    {
        _enemy.Target = _target;
        Instantiate(_enemy, transform.position, Quaternion.identity);
    }


}

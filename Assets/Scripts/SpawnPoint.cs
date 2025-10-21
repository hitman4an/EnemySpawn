using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Enemy _enemy;

    public void CreateEnemy()
    {
        Enemy newEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        newEnemy.SetTarget(_target);
    }


}

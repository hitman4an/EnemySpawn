using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Target _target;

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void Update()
    {
        transform.LookAt(_target.transform);
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }


}

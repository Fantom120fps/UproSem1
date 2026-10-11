using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject _robotObject;
    [SerializeField] private GameObject _turretObject;
    [SerializeField] private GameObject _mosquitObject;

    private IEnemy _robotEnemy;
    private IEnemyAttack _turretEnemy;
    private IEnemy _mosquitEnemy;

    private void Start()
    {
        _robotEnemy = _robotObject.GetComponent<IEnemy>();
        _turretEnemy = _turretObject.GetComponent<IEnemyAttack>();
        _mosquitEnemy = _mosquitObject.GetComponent<IEnemy>();
    }

    private void FixedUpdate()
    {
        _robotEnemy?.Move();
        _turretEnemy?.Attack();
        _mosquitEnemy?.Move();
    }
}
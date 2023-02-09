using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float _interval = 1;
    private float _spawnTime;

    [SerializeField]
    private GameObject[] _original;

    private void Update()
    {
        _spawnTime += Time.deltaTime;

        if(_spawnTime > _interval)
        {
            _spawnTime = 0;

            var randomValue = Random.Range(0 , _original.Length);

            var item = Instantiate(_original[randomValue] , transform.position , Quaternion.identity);

            var rb = item.GetComponent<Rigidbody>();
            var x = Random.Range(-5 , 5);
            var y = Random.Range(3 , 10);
            var z = Random.Range(-5 , 5);

            rb.AddForce(x, y, z , ForceMode.Impulse);

        }
    }
}

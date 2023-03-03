using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField,Header("生成スピード")] private float _interval = 1;

    [SerializeField] private float _spawnTime { get; set; }

    [SerializeField] public GameObject[] _original;

    [SerializeField] private int _maxSpawnCount;


    DestroyObj _destroy;

    private void Update()
    {
        _spawnTime += Time.deltaTime;

        if(_spawnTime > _interval)
        {
            _spawnTime = 0;

            var randomValue = Random.Range(0 , _original.Length);

            //Debug.Log(item);

            for(var i = 0; i <= _maxSpawnCount; i++)
            {
                var item = Instantiate(_original[randomValue], transform.position, Quaternion.identity);

                var rb = item.GetComponent<Rigidbody>();
                var x = Random.Range(-5, 5);
                var y = Random.Range(3, 7);
                var z = Random.Range(-5, 5);

                rb.AddForce(x, y, z, ForceMode.Impulse);

                Debug.Log("Destory前のi" + i);
              
                if(!_destroy)
                {
                    Debug.Log("Destory後のi" + i);
                    i--;
                }
            }
        }
    }

    private void FixedUpdate()
    {

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0,0.2f,0,Space.World);
    }
}

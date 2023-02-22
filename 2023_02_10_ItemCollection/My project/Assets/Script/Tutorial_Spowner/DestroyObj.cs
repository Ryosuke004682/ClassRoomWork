using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Test1_OK");
            StartCoroutine(IDestoryObj());

           
        }
    }

    public IEnumerator IDestoryObj()
    {
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Test2_OK");
        Destroy(this.gameObject);
    }

}

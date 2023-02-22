using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UI;
using UnityEngine.SceneManagement;

public class TIC_PlayerController : MonoBehaviour
{
    [SerializeField]
    private UIManeger manager = null;

    [SerializeField]
    private CountDown timePuls = null;

    private Rigidbody _rb;

    [Header("�A�C�e�����擾�������ɉ��Z�����|�C���g")]
    [Space]
    [SerializeField,Header("�m�[�}��")]  private int N_Score = 0;//10pt
    [SerializeField, Header("���A")]     private int R_Score = 0;//50Pt
    [SerializeField, Header("���ԉ��Z")] private double addTime = 10;

    [Header("�{�[���̓����X�s�[�h")]
    [Space]
    [SerializeField, Header("�X�s�[�h")] private float _speed;

    Vector3 firstPosition = Vector3.down;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical   = Input.GetAxis("Vertical");

        var velocity = new Vector3(horizontal , 0 , vertical).normalized;

        _rb.AddForce(velocity * _speed , ForceMode.Acceleration);

        Reset();
    }

    private void Reset()
    {
        var resetPosition = Vector3.down;

        if(this.transform.position.y <= resetPosition.y)
        {
            this.transform.position = firstPosition;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Nomal"))
        {
            Destroy(other.gameObject);

            manager.Score += N_Score;
        }
        else if (other.gameObject.CompareTag("Rare"))
        {
            Destroy(other.gameObject);

            manager.Score += R_Score;
        }
        else if (other.gameObject.CompareTag("TimerItem"))
        {
            Destroy(other.gameObject);

            timePuls.TimePlus += addTime;
        }
        
    }
}

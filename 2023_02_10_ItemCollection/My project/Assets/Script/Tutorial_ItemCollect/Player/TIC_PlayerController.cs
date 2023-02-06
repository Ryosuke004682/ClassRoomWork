using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIC_PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    public Text _text;

    [Header("アイテムを取得した時に加算されるポイント")]
    [SerializeField,Header("ノーマル")]
    private int score = 0;//10pt

    [SerializeField, Header("レア")]
    private int R_Score = 0;//20Pt

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        _rb.AddForce(horizontal,0,vertical);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Nomal"))
        {
            Destroy(other.gameObject);
            score += 10;
            _text.text = score.ToString();
        }
        else if(other.gameObject.CompareTag("Rare"))
        {
            Destroy(other.gameObject);
            score += 20;
            _text.text = score.ToString();
        }
        
    }
}

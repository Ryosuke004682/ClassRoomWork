using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    [SerializeField, Tooltip("�X�R�A��Text������Ƃ�")]
    public Text scoreText;

    //**�Q�[���o�����X�̃p�����[�^�[**
    [Header("�Q�[���o�����X")]
    [SerializeField, Tooltip("�ʏ�̃|�C���g�̔z��(10�_)")]
    private int _scoreNomal = 0;//10pt

    [SerializeField, Tooltip("���A�̃|�C���g�z��(50�_)")]
    private int _scoreRear = 0;//50pt

    //**UI�̒�`**
    [Header("UI����̐ݒ�")]
    [SerializeField, Tooltip("���Ԃ�Text������Ƃ�")]
    private Text timeText;
}

public class Score
{

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    [SerializeField, Tooltip("スコアのTextを入れるとこ")]
    public Text scoreText;

    //**ゲームバランスのパラメーター**
    [Header("ゲームバランス")]
    [SerializeField, Tooltip("通常のポイントの配分(10点)")]
    private int _scoreNomal = 0;//10pt

    [SerializeField, Tooltip("レアのポイント配分(50点)")]
    private int _scoreRear = 0;//50pt

    //**UIの定義**
    [Header("UI周りの設定")]
    [SerializeField, Tooltip("時間のTextを入れるとこ")]
    private Text timeText;
}

public class Score
{

}

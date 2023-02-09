using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] private double _timer = 0.0;

    private bool isTimeUp;

    private void Update()
    {
        if (0 <= _timer)
        {
            _timer -= Time.deltaTime;
            timerText.text = _timer.ToString("F2");
        }
        else if (0 >= _timer)
        {
            isTimeUp = true;
            Time.timeScale = 0;

            timerText.text = "TimeUp!!";
        }
    }

    public double TimePlus
    {
        get => _addTime;
        set
        {
            _timer = value + _addTime;
            Debug.Log(_addTime);
            timerText.text = _timer.ToString();
        }
    }
    public double _addTime;
}

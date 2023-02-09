using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIManeger : MonoBehaviour
    {
        [SerializeField]
        private Text _text = null;

        public int Score
        {
            get => _score;
            
            set
            {
                _score = value;
                _text.text = value.ToString();
            }
        }
        private int _score;
    }
}


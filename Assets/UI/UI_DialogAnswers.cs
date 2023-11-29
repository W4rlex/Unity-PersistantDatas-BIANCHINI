using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_DialogAnswers : MonoBehaviour
{
    [SerializeField] GameObject _AnswerPanel;
    [SerializeField] Button[] _AnswerButtons;

    public void ShowAnswers(string[] answers)
    {
        for (int i=0; i< _AnswerButtons.Length; i++)
        {
            _AnswerButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text = answers[i];
            if (answers[i] == "")
            {
                _AnswerButtons[i].gameObject.SetActive(false);
            }else
            {
                _AnswerButtons[i].gameObject.SetActive(true);
            }
            
        }

        if (!_AnswerPanel.activeInHierarchy)
        {
            _AnswerPanel.SetActive(true);
        }
    }
}

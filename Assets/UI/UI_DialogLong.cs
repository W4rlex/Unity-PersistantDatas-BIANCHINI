using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_DialogLong : MonoBehaviour
{
    [SerializeField] GameObject _DialogPanel;
    [SerializeField] TMP_Text _longSentenceText;

    public void ShowLongDialog(string longSentence)
    {
        _longSentenceText.text = longSentence;
        if (!_DialogPanel.activeInHierarchy)
        {
            _DialogPanel.SetActive(true);
        }
    }

    public void HideDialog()
    {
        _DialogPanel.SetActive(false);
    }
}

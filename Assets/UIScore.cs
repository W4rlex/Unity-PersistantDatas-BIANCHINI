using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{

    [SerializeField] private TMP_Text _scoreText;

    private void OnEnable()
    {
        ScoreData.OnUpdate += MiseEnFormeScore;
    }

    private void OnDisable()
    {
        ScoreData.OnUpdate -= MiseEnFormeScore;
    }

    public void MiseEnFormeScore(int scoreValue)
    {
        _scoreText.text = scoreValue.ToString();
    }

    
}

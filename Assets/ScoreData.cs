using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "New Score")]

public class ScoreData : ScriptableObject
{
    public int ScoreValue;

    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate; 

    public void UpdateScoreValue(int value)
    {
        ScoreValue = Mathf.Clamp(ScoreValue + value, 0, 999999999);
        UpdateScoreUI();
    }

    public void InitScoreValue(int initValue)
    {
        ScoreValue = Mathf.Clamp(initValue, 0, 999999999);
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        OnUpdate?.Invoke(ScoreValue);
    }
}

  
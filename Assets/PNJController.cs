using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PNJController : MonoBehaviour, ITalking
{

    private DialogSystem _dialogSystem;
    [SerializeField] private int _startSentence;
    [SerializeField] private int _intermediateSentence;
    [SerializeField] private int _endSentence;
    [SerializeField] private QuestDatas _questData;

    private void Start()
    {
        _dialogSystem = GetComponent<DialogSystem>();
    }
    public void Talk()
    {

        if (_questData.IsStarted)
        {
            if (_questData.IsFinished)
            {
                _dialogSystem.StartTalking(_endSentence);
            }
            else
            {
                _dialogSystem.StartTalking(_intermediateSentence);
            }
        }
        else
        {
            _dialogSystem.StartTalking(_startSentence);

        }
    }
} // NOTE : Pour une raison incompréhensible, ajouter un material, qu'importe lequel, sur le sol provoque des mouvement icnontrôlables au Player en cas d'apparition dans la SampleScene.
//          Pour le confort de la correction de cet exercice, abstraction a été faite de certains visuels. Encore pardon.

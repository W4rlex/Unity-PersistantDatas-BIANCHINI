using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    [SerializeField] private DialogDatas _DialogDatas;
    [SerializeField] private UI_DialogLong _UIDialog;
    [SerializeField] private UI_DialogAnswers _UIDialogAnswer;
    [SerializeField] private QuestDatas _QuestDatas;
    private int actualSentence;

    public void StartTalking(int DialogSentenceNumber)
    {
        
        actualSentence = DialogSentenceNumber;
        _UIDialog.ShowLongDialog(_DialogDatas.Sentences[actualSentence].LongSentence);
        int[] answerNumbers = new int[2];
        answerNumbers[0] = _DialogDatas.Sentences[actualSentence].Answer1;
        answerNumbers[1] = _DialogDatas.Sentences[actualSentence].Answer2;
        string[] answers = new string[2];

        for (int i = 0; i < answerNumbers.Length; i++)
        {

            if (answerNumbers[i] == -2)
            {
                answers[i] = "Quitter";
            }
            else if (answerNumbers[i] > -1)
            {
                answers[i] = _DialogDatas.Sentences[answerNumbers[i]].ShortSentence;
            }
            else
            {
                answers[i] = "";
            }

        }// ajouter un "if" au d�but v�rifiant l'�tat "IsFinished" de la qu�te qui si " == true" ouvre le dialogue � la page de validation "Merci de m'avoir aider etc..." puis fin de qu�te.
        // D�sactiver le PNJ une fois la qu�te accomplie (son �me est enfin repos�e, et permet d'�viter tout bug de dialogue facheux).

        _UIDialogAnswer.ShowAnswers(answers);
    }

    public void SelectAnswer(int answerNumber)
    {
        if (_DialogDatas.Sentences[actualSentence].EndSentence)
        {
            _UIDialog.HideDialog();
        }
        else if(answerNumber == 0)
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].Answer1);
        }
        else
        {
            StartTalking(_DialogDatas.Sentences[actualSentence].Answer2);
        }
    }
}

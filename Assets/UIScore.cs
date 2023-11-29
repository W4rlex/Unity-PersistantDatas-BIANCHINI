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

}   // La difficult� ici rencontr�e est que lorsque le compteur de score se fait update dans l'UI, unity utilise l'int scoreValue le plus r�cent de sa m�moire-
    // -mais il met � jour tous les compteurs � la fois avec cette valeur, qui ne correspond qu'� un seul objectif.
    // Solutions? R�ussir � r�duire l'update au compteur int�ress� parmi tout ceux de l'ui OU afficher les objectifs un par un, retirant tout probl�me de coexistance des compteurs.

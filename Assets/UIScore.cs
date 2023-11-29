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

}   // La difficulté ici rencontrée est que lorsque le compteur de score se fait update dans l'UI, unity utilise l'int scoreValue le plus récent de sa mémoire-
    // -mais il met à jour tous les compteurs à la fois avec cette valeur, qui ne correspond qu'à un seul objectif.
    // Solutions? Réussir à réduire l'update au compteur intéressé parmi tout ceux de l'ui OU afficher les objectifs un par un, retirant tout problème de coexistance des compteurs.

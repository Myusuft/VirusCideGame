using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public sealed class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    private static int _score;
    public Text textScoreGameOver;

    public int Score
    {
        get => _score;

        set
        {
            if (_score == value) return;
            _score = value;
            LevelScript.score = _score;

            scoreText.SetText(sourceText:$"{_score}");
        }
        
    }

    [SerializeField] public TextMeshProUGUI scoreText;

    private void Awake() => Instance = this;

    // private void Awake() {
    //     Instance = this;

    //     DontDestroyOnLoad(this.gameObject);
    // } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Platformer.Gameplay{

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public Text scoreText;
    public Text highscoreText;
    int score=0;
    int highscore=0;
    private void Awake(){
        Instance=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text=score.ToString() + " POINTS";
        highscoreText.text="HIGHSCORE: "+highscore.ToString();
    }   
    public void AddPoint(){
        score+=1;
        scoreText.text=score.ToString() + " POINTS";
    }
    // Update is called once per frame
    void Update()
    {
    }
}
}
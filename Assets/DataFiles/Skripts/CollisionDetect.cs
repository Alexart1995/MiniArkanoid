using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    public BallMove BallMove;
    public GameObject ScoreText;
    public GameObject LifeText;
    public AudioSource music;
    public int score = 0;
    public static int HighScore = 0;
    public int lifes = 3;
    public int enemies = 15;

    private void FixedUpdate()
    {
        Text UIScoreText = this.ScoreText.GetComponent<Text>();
        Text UILifeText = this.LifeText.GetComponent<Text>();
        UIScoreText.text = score.ToString();
        UILifeText.text = lifes.ToString();
    }

    void CollisionDetected(Collision2D c)
    {
        Vector3 BallPos = this.transform.position;
        // our object which we use
        Vector3 RacketPos = c.gameObject.transform.position;
        // object with which we collide c
        float RacketHeight = c.collider.bounds.size.x;
        float x;
        float y;

        y = 1;

        x = (BallPos.x - RacketPos.x) / RacketHeight;
        this.BallMove.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
            CollisionDetected(collision);
        if (collision.gameObject.name == "Cube")
        {
            if (music)
                music.Play();
            Destroy(collision.gameObject);
            this.score++;
            if (this.enemies > 0)
                this.enemies--;
            if (this.enemies == 0)
            {
                if (score > HighScore)
                {
                    HighScore = score;
                    ScoreController.HS = HighScore.ToString();
                }
                LoadWinMenu(this.score.ToString());
            }
        }
        if (collision.gameObject.name == "down")
        {
            if (this.lifes > 0)
            {
                this.lifes--;
                this.gameObject.transform.localPosition = new Vector3(0, -4, 0);
            }
            if (this.lifes == 0)
            {
                if (score > HighScore)
                {
                    HighScore = score;
                    ScoreController.HS = HighScore.ToString();
                }
                LoadLostMenu(this.score.ToString());
            }

        }
    }

    public void LoadLostMenu(string s)
    {
        ScoreController.finalScore = s;
        SceneManager.LoadScene("LostMenu");
    }

    public void LoadWinMenu(string s)
    {
        ScoreController.finalScore = s;
        SceneManager.LoadScene("WinMenu");
    }
}

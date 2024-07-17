using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManagerScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject gameOverText;
    public AudioSource hitAudioSource;
    public TextMeshProUGUI scoreText;
    private bool gameOverFlag = false;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-3.0f, 3.0f);
        Instantiate(enemy, new Vector3(x, 2, 3), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("TitleScene");
            }

        scoreText.text = "SCORE" + score;
    }

    private void FixedUpdate()
    {
        if (gameOverFlag == true)
        {
            return;
        }

        int r = Random.Range(0, 50);
        if(r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(enemy, new Vector3(x, 2, 4), Quaternion.identity);

        }

    }

    public void GameOverStart()
    {
        gameOverText.SetActive(true);
        gameOverFlag = true;
    }

    public bool IsGameOver()
    {
        return gameOverFlag;
    }


    //íeÇ∆ìGÇ™è’ìÀ
    public void Hit()
    {
        hitAudioSource.Play();
        score += 1;
    }
}

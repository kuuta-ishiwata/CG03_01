using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    // Start is called before the first frame update

    private GameObject gameMabager;
    private GameManagerScript gameManagerScript;
    public GameObject enemy;
    private int gameTimer = 0;
    void Start()
    {
        Destroy(gameObject, 5);
        transform.rotation = Quaternion.Euler(0, 180, 0);
        //�Q�[���}�l�[�W���[�̃I�u�W�F�N�g��T��
        gameMabager = GameObject.Find("GameManager");
        //�X�N���v�g���l��
        gameManagerScript = gameMabager.GetComponent<GameManagerScript>();
        gameTimer++;
        int max = 50 - gameTimer / 100;
        //�����ō��E��
        int r = Random.Range(0, max);
        if(r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(enemy, new Vector3(x, 0.0f, 15), Quaternion.identity);
            transform.rotation = Quaternion.Euler(0, 180 - 30, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180 + 30, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerScript.IsGameOver() == true)
        {
            return;
        }
        float movespeed = 2.0f;
        Vector3 velocity = new Vector3(0, 0, movespeed * Time.deltaTime);
        transform.position += transform.rotation * velocity;

        //���E�Ŕ��]
        if (transform.position.x > 3)
        {
            transform.rotation = Quaternion.Euler(0, 180 + 30, 0);
        }
        if (transform.position.x < -1)
        {
            transform.rotation = Quaternion.Euler(0, 180 - 30, 0);
        }
        
    }
}

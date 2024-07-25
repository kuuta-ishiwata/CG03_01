using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        float movespeed = 3.0f;
        rb.velocity = new Vector3(0, 0, movespeed);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            //ゲームマネージャーのスクリプトを獲得
            GameObject gameManager;//GameObjectそのものが入る変数
            GameManagerScript gameManagerScript; //Scriptが入る変数
            gameManager = GameObject.Find("GameManager");
            gameManagerScript = gameManager.GetComponent<GameManagerScript>();
            //ゲームマネージャースクリプトの小塗油判定を呼び出す
            gameManagerScript.Hit(transform.position);

            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}

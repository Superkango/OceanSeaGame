using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PruebaDePersonaje : MonoBehaviour
{
    [Range (3, 8)]
    private Rigidbody2D myRigidBody2D;
    private int score = 0 ;
    public int SwimmingSpeed = 5;
    public Text scoreText;
    public Text highScoreText; 
    public Transform lookAt;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        int highScore = PlayerPrefs.GetInt("High Score");
        highScoreText.text = highScore.ToString(); 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myRigidBody2D.velocity = Vector2.left * SwimmingSpeed;
        }

        if (Input.GetKeyDown (KeyCode.RightArrow))
        {
            myRigidBody2D.velocity = Vector2.right * SwimmingSpeed;
        }
    }

    private void Update()
    {
        Vector3 targetPosition = lookAt.position;
        targetPosition.x = targetPosition.x - targetPosition.x;
        targetPosition.y = targetPosition.x - targetPosition.y;

        float angle = Mathf.Atan2(targetPosition.y, targetPosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle); 
    }

    private void OnCollisionEnter2D(Collision2D collision) //Necesita los dos objetos collider y el que detecta tiene que tener un RigyBody
    {   
        if (PlayerPrefs.GetInt("HighScore") < score)
        {
            PlayerPrefs.SetInt("High Score", score);
        }

        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
        

       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoreText.text = "" + score; 
    }


}   



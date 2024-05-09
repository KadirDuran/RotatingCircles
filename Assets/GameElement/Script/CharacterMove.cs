using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 4f;
    public TextMeshProUGUI txtScore;
    public GameObject panel;
    int score = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Circle")
        {
            speed = 0f;
            collision.gameObject.GetComponent<RotataCircle>().move = true;
            gameObject.transform.parent = collision.gameObject.transform;
           
        }
        else if(collision.gameObject.tag == "Orange")
        {
            score++;
            Destroy(collision.gameObject);
            txtScore.text= score.ToString();
        }
        else if(collision.gameObject.tag=="Wall")
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }

    }
    public void RestartGame()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScreen");
    }
    void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
        if(speed==0f)
        {
            transform.rotation = gameObject.transform.parent.rotation;
        }

    }
}

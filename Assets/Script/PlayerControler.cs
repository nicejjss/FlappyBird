using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float height=6f;
    private Rigidbody2D rigidbody2D;
    Score score;
    public AudioSource audioSource;
    public AudioClip point;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        score = GetComponent<Score>();
       
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rigidbody2D.velocity = Vector2.up  * height;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Score.instance.GameOver();
        }

    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            Score.instance.CountScore();
            audioSource.PlayOneShot(point);
        }
    }
   

}

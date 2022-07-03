using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 pos;
    [SerializeField] private float speed=5f;
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if(transform.position.x < -6)
        {
            transform.position = pos;
        }
    }
}

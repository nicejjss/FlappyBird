using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvetoLeft : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed=10f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}

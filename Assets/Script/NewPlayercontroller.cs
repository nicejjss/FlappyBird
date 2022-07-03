using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D ab;
    void Start()
    {
        ab= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

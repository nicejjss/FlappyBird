using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{     [SerializeField]private GameObject obstacle;
      private Vector2 obpos ;
    [SerializeField] float timepos = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawns",0,timepos);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void Spawns()
    {
        float posy = Random.RandomRange(-2.0f,2f);
        Instantiate(obstacle,new Vector2(10f,posy), obstacle.transform.rotation);
    }
}

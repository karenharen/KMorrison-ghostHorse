using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(-8f,5f,.6f);
    public Vector3 rotationDown = new Vector3(0, 0, 0);
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-14.8f, 4.3f, .8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}

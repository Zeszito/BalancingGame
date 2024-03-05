using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody ball_rigidbody;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            DropTheBall();
        }
    }

    private void DropTheBall()
    {
        ball_rigidbody.useGravity = true;
    }
}

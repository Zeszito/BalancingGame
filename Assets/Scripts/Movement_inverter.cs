using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_inverter : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private ConstantForce constantForce;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            constantForce.torque = new Vector3(10, 0, 0);
        }
    }

    private void OnMouseDown()
    {
        constantForce.force *= -1;
    }
}

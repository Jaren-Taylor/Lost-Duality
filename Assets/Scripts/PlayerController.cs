using MiscUtil.Xml.Linq.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject Player;
    [SerializeField]
    private Rigidbody PlayerBody;
    private Vector3 inputVector;

    void Start()
    {
        PlayerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal")*5f, 0, Input.GetAxis("Vertical")* 5f);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
       
    }
    private void FixedUpdate()
    {
        PlayerBody.velocity = inputVector;
    }
}

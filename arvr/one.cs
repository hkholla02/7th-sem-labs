using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Edit -> Project Settings -> Input Manager -> Access
// Remove space in Mouse X, Mouse Y

public class one : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    void Start()
    {
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed * Input.GetAxis("Vertical")*Time.deltaTime);
        transform.Translate(moveSpeed*Input.GetAxis("MouseX")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("MouseY")*Time.deltaTime);
    }
}
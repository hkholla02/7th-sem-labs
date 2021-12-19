using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Physics Material -> DF = 0, SF = 0, Bounciness = 1
//Fiction combine = min, Bounce combine = max
//Sphere -> Light, Rigid body (mass = 0.001) <Add Component>

public class two : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed=10f;
    private Rigidbody rbody;
    private Renderer rend;
    void Start()
    {
        rbody= GetComponent<Rigidbody>();
        rend= GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputx=Input.GetAxis("Horizontal");
        float inputz=Input.GetAxis("Vertical");
        float movex=inputx*moveSpeed*Time.deltaTime;
        float movez=inputz*moveSpeed*Time.deltaTime;
        rbody.AddForce(movex,0f,movez);
    }
    private void OnCollisionEnter(Collision col){
        if(col.collider.name=="Wall1")
            {rend.material.color=Color.blue;}
        else if(col.collider.name=="Wall2")
            {rend.material.color=Color.green;}
        else if(col.collider.name=="Wall3")
            {rend.material.color=Color.yellow;}
        else if(col.collider.name=="Wall4")
            {rend.material.color=Color.red;}
    }
}
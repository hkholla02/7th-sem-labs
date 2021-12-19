using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class three_paddle : MonoBehaviour
{
    private Rigidbody2D rbody;
public float force = 1f;
    // Start is called before the first frame update
    void Start()
    {
      rbody = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {

float moveHorizontal = Input.GetAxis("Horizontal") * force;
float xforce = moveHorizontal * force * Time.deltaTime;
Vector2 movement = new Vector2(moveHorizontal, 0f);
rbody.AddForce(movement);
       
    }
}
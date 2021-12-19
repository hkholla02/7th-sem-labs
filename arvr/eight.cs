using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//3 sprite -> circle -> add circle collider 2D
//1 sprite -> capsule

public class eight : MonoBehaviour
{
    private float _rotationSpeed=20f;
    private Vector3 _horizontalMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement=new Vector3(0f,0f,-Input.GetAxis("Horizontal"));
        transform.Rotate(_horizontalMovement * _rotationSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.Space))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up)*10f, Color.red);
            RaycastHit2D hit= Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up),10f);
            if(hit)
            {
                Debug.Log("Hit Something:"+hit.collider.name);
                hit.transform.GetComponent<SpriteRenderer>().color=Color.red;
            }
        }
        
    }
}

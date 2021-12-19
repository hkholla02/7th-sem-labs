using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//For sphere remove sphere collider and add circle collider 2D, rigid body 2D(mass = 0.001, LA and AD = 0, gravity = 1)
//Add Physics collider 2D to sphere (friction = 0, bounciness = 1)
//For all 4 quad's remove mesh collider and add box collider 2D
//For paddle add rigid body 2D (mass = 5, gravity = 0)
//For paddle -> script -> 10

public class three_ball : MonoBehaviour
{
    public float force;
private Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
rbody = GetComponent<Rigidbody2D>();
rbody.AddForce(new Vector2(3f,1f)* Time.deltaTime * force);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Assets -> animation controller -> add animations -> make transition (arrows)
//For all arrows uncheck 'has exit time' -> for condition click + and add target action
//Parameters -> + -> trigger -> actions
//Add 4 buttons -> onClick -> drag and drop unity chan -> function (animator -> pay(string)) -> string name == animation (eg: RUN00_F)
//If button == 1 then add all 4 onClick's 

public class five : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Run");
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Walk");
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Slide");
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Jump");
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("Win");
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("Wait");
        }
    }
}


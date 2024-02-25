using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool onGround;
    public float fuerza_x;
    // Start is called before the first frame update
    void Start()
    {
       onGround = false;
       fuerza_x = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released");
            if(GetComponent<Rigidbody>() != null){
            GetComponent<Rigidbody>().useGravity = true;

            }
        }

                if(Input.GetKeyUp(KeyCode.A))
                {
                    Vector3 fuerza = new Vector3(fuerza_x,500,0);
                    GetComponent<Rigidbody>().AddForce(fuerza);
                }


                if(Input.GetKeyUp(KeyCode.Z))
                {
                    fuerza_x = fuerza_x - 10; 
                }

                if(Input.GetKeyUp(KeyCode.X))
                {
                    fuerza_x = fuerza_x + 10; 
                }

    }


    void OnCollisionEnter(Collision c){
        Debug.Log("Colision");
        onGround = true; 

    }

    
    void OnCollisionStay(Collision c){
        
        onGround = true; 

    }

     void OnCollisionExit(Collision c){
        Debug.Log("Libre");
        onGround = false; 

    }

}

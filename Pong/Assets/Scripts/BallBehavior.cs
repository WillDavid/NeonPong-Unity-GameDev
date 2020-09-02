using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float speed = 5;


    void Start()
    {

        //Sortear numeros entre 0 e 2
        float speedX = Random.Range(0,2);
        if(speedX == 0){
            speedX = -1;
        }else{
            speedX = 1;
        }
        float speedY = Random.Range(0,2);
        if(speedY == 0){
            speedY = -1;
        }else{
            speedY = 1;
        }


        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * speedY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

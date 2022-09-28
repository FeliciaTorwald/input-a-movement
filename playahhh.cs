using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playahhh : ProcessingLite.GP21
{
    float posX = 0;
    float diameter = 2;
    float speed = 0.05f;
    float posY = 0;
    float v = 1; // constant velocity
    float a = 1; // constant acceleration
    float vy;
    float vx;
    float posY2 = 0;
    float posX2 = 0;
    float maxSpeed = 5;
    



    void Start()
    {
        posX = Width / 2; //middle of the screen
        posY = Height / 2; //middle of screen??

        posX2 = Width / 2; //middle of the screen
        posY2 = Height / 2; //middle of screen??
    }

    void Update()
    {

        if (new Vector2(vx, vy).magnitude > maxSpeed)
        {
           Vector2 krokis = new Vector2(vx, vy).normalized * maxSpeed;

            vy = krokis.y;
            vx = krokis.x;
        }
        Background(50, 166, 240);

        //add our new input to our x position
        posX += Input.GetAxis("Horizontal") * v * Time.deltaTime;

        // add our new input to our x position
        posY += Input.GetAxis("Vertical") * v * Time.deltaTime;

        vx += Input.GetAxis("Horizontal") * Time.deltaTime * a;

        vy += Input.GetAxis("Vertical") * Time.deltaTime * a;

        posX2 += vx * Time.deltaTime;

        posY2 += vy * Time.deltaTime; 

        Circle(posX, posY, diameter);

        Circle(posX2, posY2, diameter);



        v += a * Time.deltaTime; // v increases by acceleration 
        Debug.Log(v); // som print

        if (Input.GetAxisRaw("Vertical") == 0)

        {
            vy *= 1 - Time.deltaTime;


        }

        if (Input.GetAxisRaw("Horizontal") == 0)
        {


            vx *= 1 - Time.deltaTime;
        }

    }
} 

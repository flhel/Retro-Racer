using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace car
{
    public class CarInputSystem : MonoBehaviour
    {
        private CarPhysics carPhysics;
        private float lastFrameSteer = 0;

        void Start()
        {
            carPhysics = GameObject.Find("Car").GetComponent<CarPhysics>();
        }

        void Update()
        {
            carPhysics.Input.Forward = Input.GetAxisRaw("Vertical");

            //carPhysics.Input.Steer = Input.GetAxisRaw("Horizontal");

            //For smooth steering with Keyboard 
            float horizontalInput = Input.GetAxisRaw("Horizontal");


            if (horizontalInput == 0)
            {
                carPhysics.Input.Steer = Mathf.Lerp(0, lastFrameSteer, 0.97f);
            }
            if (horizontalInput > 0)
            {
                carPhysics.Input.Steer = Mathf.Lerp(horizontalInput, lastFrameSteer, 0.99f);
            }
            if (horizontalInput < 0)
            {
                carPhysics.Input.Steer = Mathf.Lerp(horizontalInput, lastFrameSteer, 0.99f);
            }

            lastFrameSteer = carPhysics.Input.Steer;

            Debug.Log(carPhysics.Input.Steer);
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace car
{
    public class CarInputSystem : MonoBehaviour
    {
        private CarPhysics carPhysics;

        void Start()
        {
            carPhysics = GameObject.Find("Car").GetComponent<CarPhysics>();
        }

        void Update()
        {
            carPhysics.Input.Forward = Input.GetAxisRaw("Vertical");
            carPhysics.Input.Steer = Input.GetAxisRaw("Horizontal");
        }
    }

}
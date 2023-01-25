using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Initial Author: https://github.com/ditzel/Mobile-Multiplayer-Action-Game-in-Unity
namespace car
{
    public class CarAnimation : MonoBehaviour
    {
        [HideInInspector]
        public Animator Animator;
        [HideInInspector]
        public GameObject AnimDrivePosition;
        [HideInInspector]
        public CarPhysics CarPhysics;
        [HideInInspector]
        public AudioSource AudioSource;
        public AudioClip Shifting;
        protected Rigidbody Rigidbody;

        // Use this for initialization
        void Awake()
        {
            /*
            Animator = GetComponentInChildren<Animator>();
            AnimDrivePosition = transform.Find("CarMesh").Find("AnimDrivePosition").gameObject;
            */
            CarPhysics = GetComponent<CarPhysics>();
            AudioSource = GetComponent<AudioSource>();
            Rigidbody = GetComponent<Rigidbody>();

        }

        void Update()
        {
            AudioSource.pitch = 0.8f + Rigidbody.velocity.magnitude / 20f;
        }
    }
}
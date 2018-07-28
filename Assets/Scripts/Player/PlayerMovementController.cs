using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CelesteEngine
{
    public class PlayerMovementController : MonoBehaviour
    {
        public float speed = 0.01f;
        public Rigidbody2D rigidBody2D;

        private bool usingGravity = true;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            Vector3 diff = new Vector3(x * speed, y * speed, 0);
            transform.localPosition += diff;

            if (Input.GetKeyUp(KeyCode.Space))
            {
                usingGravity = !usingGravity;
                rigidBody2D.gravityScale = usingGravity ? 1 : 0;
            }
        }
    }
}
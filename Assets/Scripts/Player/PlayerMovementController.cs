using CelesteEngine.Environment;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CelesteEngine.Player
{
    public class PlayerMovementController : MonoBehaviour
    {
        public float walkSpeed = 0.05f;
        public float floatSpeed = 0.1f;
        public Rigidbody2D rigidBody2D;

        private void Start()
        {
            GravityManager.GravityEnabledChanged += TogglePlayerGravity;
        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxis("Horizontal");

            if (GravityManager.GravityEnabled)
            {
                transform.localPosition += new Vector3(x * walkSpeed, 0, 0);
            }
            else
            {
                float y = Input.GetAxis("Vertical");
                rigidBody2D.velocity += new Vector2(x * floatSpeed, y * floatSpeed);
            }
        }

        public void TogglePlayerGravity(bool gravityEnabled)
        {
            rigidBody2D.gravityScale = gravityEnabled ? 1 : 0;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField, Range(0, 10)] public float moveSpeed = 3;
    [SerializeField, Range(0, 10)] public float leftRightSpeed = 4;
    static public bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        // if (isDead == true)
        // {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > LevelBoundary.leftSided)
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < LevelBoundary.rightSided)
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
        }

        // }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField, Range(0, 10)] public float moveSpeed = 3;
    [SerializeField, Range(0, 10)] public float leftRightSpeed = 4;
    public Vector3 jump;
    Rigidbody rb;
    public float jumpForce = 0.7f;
    public GameObject character;
    static public bool isDead = false;
    public float time=0;

    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if(time<6){
            time+=Time.deltaTime;
        }
        else{
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        // if (isDead == true)
        // {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > LevelBoundary.leftSided && this.transform.position.y <= 1){
                character.GetComponent<Animator>().Play("runForwardLeft");
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < LevelBoundary.rightSided && this.transform.position.y <= 1){
                character.GetComponent<Animator>().Play("runForwardRight");
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if (this.transform.position.y == 1)
                // character.GetComponent<Animator>().Play("jump");
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
        else{
            if (this.transform.position.y > 1 || this.transform.position.y < 1){
                character.GetComponent<Animator>().Play("falling");
            }
            else {
                character.GetComponent<Animator>().Play("run");
            }
        }
        }
    }
}

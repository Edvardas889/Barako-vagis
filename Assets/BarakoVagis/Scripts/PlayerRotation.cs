using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {


        if (Input.GetKey("up") && !Input.GetKey("left") && !Input.GetKey("right")) // tik virsu
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            anim.SetInteger("State", 1);
        }
        if (Input.GetKey("up") && Input.GetKey("left") && !Input.GetKey("right")) // i virsu kairiau
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);
            anim.SetInteger("State", 1);
        }
        if (Input.GetKey("up") && Input.GetKey("right") && !Input.GetKey("left")) // i virsu desniau 
        {
            transform.rotation = Quaternion.Euler(0, 0, 315);
            anim.SetInteger("State", 1);
        }

        if (Input.GetKey("down") && Input.GetKey("left") && !Input.GetKey("right")) // apacia kairiau
        {
            transform.rotation = Quaternion.Euler(0, 0, 135);
            anim.SetInteger("State", 1);
        }
        if (Input.GetKey("down") && Input.GetKey("right") && !Input.GetKey("left")) // apacia desniau
        {
            transform.rotation = Quaternion.Euler(0, 0, 225);
            anim.SetInteger("State", 1);
        }

        if (Input.GetKey("down") && !Input.GetKey("left") && !Input.GetKey("right")) // TIK į apačią
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            anim.SetInteger("State", 1);
        }

        if (Input.GetKey("left") && !Input.GetKey("up") && !Input.GetKey("down")) // tik kaire
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            anim.SetInteger("State", 1);
        }
       
        if (Input.GetKey("right") && !Input.GetKey("up") && !Input.GetKey("down")) // tik desne
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            anim.SetInteger("State", 1);
        }


        if (Input.GetKeyUp("right") || Input.GetKeyUp("left") || Input.GetKeyUp("up") || Input.GetKeyUp("down"))  // pakeicia animacija i idle kai atleidzia mygtuka
        {
            anim.SetInteger("State", 0);
        }

    }
}

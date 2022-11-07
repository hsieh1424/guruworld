using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class change : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Player;
    public int changeflag = 0;
    public int changenum = 0;
    public int delay = 120;
    public float y = 0, z = 0;
    // Start is called before the first frame update
    void Start()
    {
        changeflag = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Right")
        {
            changeflag = 1;
        }
        else if (other.gameObject.tag == "Left")
        {
            changeflag=2;
        }
        else if (other.gameObject.tag == "Up")
        {
            changeflag = 3;
        }
        else if (other.gameObject.tag == "Down")
        {
            changeflag = 4;
        }
    }

        private void OnTriggerEnter(Collider other)
    {

            if (other.gameObject.tag == "Player"&& changeflag==1)
            {
                Debug.Log("in1");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
            }
            else if (other.gameObject.tag == "Player" && changeflag ==2)
            {
                Debug.Log("in2");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
            }
            else if (other.gameObject.tag == "Player" && changeflag ==3)
            {
                Debug.Log("in3");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
            }
            else if (other.gameObject.tag == "Player" && changeflag ==4)
            {
                Debug.Log("in4");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), 90);
            } 
       //if (changeflag == 0)
       // {
       //     //if (z - Player.transform.position.z > 0 &&
       //     //    //z - gameObject2.transform.position.z < 0 &&
       //     //    y - Player.transform.position.y > -3 &&
       //     //    y - Player.transform.position.y < 3 )
       //     //{ 
       //     //    Debug.Log("in1");
       //     //    Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
       //     //    Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
       //     //}
       //     //else if (//z - gameObject2.transform.position.z > 0 &&
       //     //    z - Player.transform.position.z < 0 &&
       //     //    y - Player.transform.position.y > -3 &&
       //     //    y - Player.transform.position.y < 3)
       //     //{
       //     //    Debug.Log("in2");
       //     //    Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
       //     //    Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
       //     //}
       //     //else if (z - Player.transform.position.z > -3 &&
       //     //    z - Player.transform.position.z < 3 &&
       //     //    //y - gameObject2.transform.position.y > 0 &&
       //     //    y - Player.transform.position.y < 0)
       //     //{
       //     //    Debug.Log("in3");
       //     //    Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
       //     //    Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
       //     //}
       //     //else if (z - Player.transform.position.z > -3 &&
       //     //    z - Player.transform.position.z <3 &&
       //     //    y - Player.transform.position.y > 0 )
       //     //    //&&y - gameObject2.transform.position.y < 3
       //     //{
       //     //    Debug.Log("in4");
       //     //    Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), 90);
       //     //    Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, 1), 90);
       //     //}
       //     changeflag = 1;
       // }

    }

    private void OnTriggerExit(Collider other)
    {
        if (changeflag != 0)
        {
            changeflag = 0;
            Debug.Log("out");
        }
    }
}

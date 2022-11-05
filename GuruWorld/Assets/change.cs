using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class change : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Player;
    public GameObject Up;
    public GameObject Down;
    public GameObject Right;
    public GameObject Left;
    public int changeflag = 0;
    public int changenum = 0;
    public int delay = 120;
    public float y = 0, z = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameFlag.changeflag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        changeflag = GameFlag.changeflag;
    }

   

        private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag == "Player"&& GameFlag.changeflag == 2)
            {
                Debug.Log("in1");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, -1, 0), 90);
            }
            else if (other.gameObject.tag == "Player" && GameFlag.changeflag == 1)
            {
                Debug.Log("in2");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 90);
            }
            else if (other.gameObject.tag == "Player" && GameFlag.changeflag == 3)
            {
                Debug.Log("in3");
                Ground.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
                Player.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 0, -1), 90);
            }
            else if (other.gameObject.tag == "Player" && GameFlag.changeflag == 4)
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
        if (GameFlag.changeflag != 0)
        {
            GameFlag.changeflag = 0;
            Debug.Log("out");
        }
    }
}

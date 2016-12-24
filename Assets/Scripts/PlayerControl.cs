using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {
	public  float MoveSpeed =3f;
    private float process;
    private bool prop = false;
    private float wall_with = 0.17f;
    private Vector3 player;
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * MoveSpeed);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * MoveSpeed);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }
        PropUsed();


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.name == ("Key"))
        {

            other.gameObject.SetActive(false);
            prop = true;
        }


    }

    private void PropUsed()
    {
        if (Input.GetKeyDown(KeyCode.E) && prop)
        {
            print("PropUsed");
            GameObject door = GameObject.Find("door");
            door.SetActive(false);
            print("PropUsed");
            prop = false;
        }
    }

}

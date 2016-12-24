using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        Debug.Log(other.gameObject);
        if (other.gameObject.name == "player")
        {
            Debug.Log("scene");

            SceneManager.LoadScene("Scene/2");
        }

    }
}

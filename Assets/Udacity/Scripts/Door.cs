using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
	public bool Locked;
    // Create a boolean value called "opening" that can be checked in Update() 
	public bool opening;
	public AudioSource soundSource;
	public AudioClip doorOpen;
	public AudioClip doorLocked;

	void Start() {
		Locked = true;
	    opening = false;
	}


    void Update() {
        // If the door is opening and it is not fully raised
		if (opening == true) {
			if (transform.position.y < 8f) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + (Time.deltaTime * 5f), transform.position.z);
			}
		} 

            // Animate the door raising up
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked

		if (Locked == false) {
			opening = true;
			soundSource.clip = doorOpen;
			soundSource.Play ();
		}
		else {
			soundSource.clip = doorLocked;
			soundSource.Play ();
		}
			
			
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false herez
		Locked = false;
    }
}

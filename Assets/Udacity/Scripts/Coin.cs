using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

	void Update()
	{
		transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + Mathf.Sin (Time.time * 5.0f)/50, this.transform.position.z);
	}


    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
		Instantiate(coinPoof, transform.position, Quaternion.Euler(-90f, 0, 0));
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }
		
}

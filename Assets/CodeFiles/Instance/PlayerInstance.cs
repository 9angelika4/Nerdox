using UnityEngine;
using System.Collections;

public class PlayerInstance : MonoBehaviour {

	public static PlayerInstance localInstace;
	public static string startPoint;

	void Awake () {
		if (!localInstace) {
			DontDestroyOnLoad (this.gameObject);
			localInstace = this;

		} else {

			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextLevelTrigger : MonoBehaviour {
	 
	public string newSceneName ;
	public string startPoint;

	void Start (){
		Debug.Log ("starting ");
	}
	  void OnTriggerEnter ( Collider other ) {
		 
		if (other.CompareTag ("Player")) {
		Debug.Log("on trigger enter");
			SceneManager.LoadScene (newSceneName);
			PlayerInstance.startPoint = startPoint;

		}

	}
	void OnTriggerStary ( Collider other){
		Debug.Log (" on trigger stay  ");
	}
}

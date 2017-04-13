using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FetchScript : MonoBehaviour {
	public Button b_Step;
	private Stepping _step;


	// Use this for initialization
	void Start () {
		_step = b_Step.GetComponent<Stepping> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Fetch(){
		StartCoroutine (Proceed ());
	}

	public IEnumerator Proceed(){
		for (int i = 0; i < 3; i++) {
			yield return new WaitForSeconds (.01f);
			_step.Step ();
		}
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ascript : MonoBehaviour {


	static public int aVal = 50;
	public Text atxt;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {



		atxt.text = ("A " + aVal.ToString());
	}

	public int getAVal(){
		return aVal;
	}
}

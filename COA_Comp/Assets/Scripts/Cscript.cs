using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cscript : MonoBehaviour {

	static public int cVal = 1;
	public Text ctxt;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	


		ctxt.text = "C " + cVal.ToString();
	}

	public int getCVal(){
		return cVal;
	}
}

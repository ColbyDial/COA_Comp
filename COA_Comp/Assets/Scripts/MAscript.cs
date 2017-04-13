using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MAscript : MonoBehaviour {


	static public int maVal = 17;
	public Text matxt;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



		matxt.text = "MA " + maVal.ToString();
	}

	public int getMAVal(){
		return maVal;
	}
}

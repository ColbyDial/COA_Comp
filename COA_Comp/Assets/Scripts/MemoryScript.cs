using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MemoryScript : MonoBehaviour {
	private int rando;
	public static List<Mem> memList = new List<Mem> ();
	public Text memoryCollection;
	private Text memText;

	public class Mem {
		public string location;
		public string decByte;
		//public string decByteString;
		public string hexByte;
		public string hexWord;


	}
	//Mem[] memory = new Mem[200];

	// Use this for initialization
	void Start () {
		Debug.Log ("The MemoryScript is working");

		for (int i = 0; i < 200; i++) {

			Mem tempMem = new Mem ();
			rando = Random.Range (0, 64);

			tempMem.location = i.ToString("00");
			tempMem.decByte = rando.ToString("00");
			//tempMem.decByteString = rando.ToString (000);

			tempMem.hexByte = rando.ToString ("X2");

			memList.Add (tempMem);

			//Debug.Log ("Mem " + tempMem.location + " has a decByte of " + tempMem.decByte + " and a hexByte of " + tempMem.hexByte.ToString());

		}

		InvokeRepeating("UpdateDatMemory", 0, .5f);

			
	}
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateDatMemory(){
		for (int i = 0; i < 200; i++) {
			string hexWord = "";
			string hexByte = "";
			int dec = 0;
			for (int x = 0; x < 4; x++) {
				if ((i + x) < 200) {
					//Debug.Log (memList [i + x].location);
					hexWord += memList [i + x].hexByte.ToString();
				} 
			}
			//Debug.Log (hexWord);
			hexByte = memList[i].hexByte;
			dec = int.Parse (hexByte,System.Globalization.NumberStyles.HexNumber);
			memList [i].decByte = dec.ToString ("00");
			memList [i].hexWord = hexWord;

			memText = memoryCollection.gameObject.transform.GetChild (i).GetComponent<Text> ();
			memText.text = i.ToString () + "\t";

			if (i < 10) {
				memText.text += "\t";
			}

			memText.text += memList [i].decByte + "\t\t" + memList [i].hexByte + "\t" + memList [i].hexWord;




		}
	}

	public string GetMemoryWord(int location){
		return memList [location].hexWord;
	}
}

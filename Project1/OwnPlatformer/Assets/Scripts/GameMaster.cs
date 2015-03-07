using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;


	// Use this for initialization
	void Start () {
		// initialize singleton
		if(gm=null){
			gm = gameObject.GetComponent<GameMaster>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}

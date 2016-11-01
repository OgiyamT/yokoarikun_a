using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public bool flg;
	public int minParce=0;
	public int maxParce=100;
	public int parce;

	// Use this for initialization
	void Start () {
		StartCoroutine (Item_random ());
	}

	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Item_random(){
		while (true) {
			float i = Random.Range (minParce, maxParce);

			if (i <= parce) {
				flg = true;
			} else {
				flg = false;
			}
			if (flg == true) {
				Debug.Log (i+" alt");
			}

			yield return new WaitForSeconds(3.0f);
		}
	}

}
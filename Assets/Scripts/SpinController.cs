using UnityEngine;
using System.Collections;
using System;

public class SpinController : MonoBehaviour {
	void Start () {
		StartCoroutine (SlowLater ());
	}

	public IEnumerator SlowLater(){
		yield return new WaitForSeconds (7);
		while (Hero.HeroSpeed >= 0f) {
			yield return new WaitForSeconds (UnityEngine.Random.Range(0.09f, 0.11f));
			Hero.HeroSpeed -= 0.0001f;
		}
		Vector3 pos = Camera.main.transform.position;
		pos.y -= 0.25f;

		Hero.HeroSpeed = 0;
		RaycastHit x;
		if (Physics.Raycast (pos, Vector3.forward, out x)) {
			Debug.Log (x.transform);
			Hero hit = x.transform.GetComponent<Hero> ();
			Debug.Log (hit.Name);
		}
		else {
			pos.x -= 0.25f;
			if (Physics.Raycast (pos, Vector3.forward, out x)) {
				Debug.Log (x.transform);
				Hero hit = x.transform.GetComponent<Hero> ();
				Debug.Log (hit.Name);
			}
			foreach (GameObject hero in GameObject.FindGameObjectsWithTag("Hero" )) {
				hero.transform.position += new Vector3(-0.25f, 0f, 0f);
			}
		}
	}
}

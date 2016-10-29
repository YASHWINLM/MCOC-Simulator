using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
	public int Stars;
	public string Name;
	public int PI;

	void Update(){
		transform.position += new Vector3 (0.01f,0f,0f);
		if(transform.position.x>1){
			GameObject heroObject = Instantiate (Resources.Load("Prefabs/Hero"), new Vector3(-1f, -0.5f,2f), Quaternion.Euler(new Vector3(0,0,180))) as GameObject;
			Hero hero = heroObject.GetComponent<Hero> ();
			int i = Random.Range (0,4);

			MeshRenderer renderer = heroObject.GetComponent<MeshRenderer> ();
			if(i==0){
				renderer.material = Resources.Load ("Materials/meme") as Material;
			}
			else if(i==1){
				renderer.material = Resources.Load ("Materials/keke") as Material;
			}
			if(i==2){
				renderer.material = Resources.Load ("Materials/danke") as Material;
			}
			if(i==3){
				renderer.material = Resources.Load ("Materials/lit") as Material;
			}
			Destroy (this.gameObject);
		}
	}
}

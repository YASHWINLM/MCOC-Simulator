using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
	public int Stars;
	public string Name;
	public static float HeroSpeed=0.01f;
	void Update(){
		transform.position += new Vector3 (HeroSpeed,0f,0f);
		if(transform.position.x>1){
			GameObject heroObject = Instantiate (Resources.Load("Prefabs/Hero"), new Vector3(-1f, -0.5f,2f), Quaternion.Euler(new Vector3(0,0,180))) as GameObject;
			Hero hero = heroObject.GetComponent<Hero> ();
			int i = Random.Range (0,5);


			if(i==0){
				SetMaterial (heroObject, "Hawkeye");
			}
			else if(i==1){
				SetMaterial (heroObject, "Hulk Buster");
			}
			if(i==2){
				SetMaterial (heroObject, "Antman");
			}
			if(i==3){
				SetMaterial (heroObject, "Unst.");
			}
			if(i==4){
				SetMaterial (heroObject, "venom");
			}
		
			Destroy (this.gameObject);
		}
	}
	void SetMaterial(GameObject target, string path){
		MeshRenderer renderer = target.GetComponent<MeshRenderer> ();
		renderer.material = Resources.Load ("Materials/" + path) as Material;
		target.GetComponent<Hero>().Name = path;
	}
}

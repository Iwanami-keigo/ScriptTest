using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int mp = 53; 
	public void magic (){
		if(this.mp>=5){
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りＭＰは" + this.mp + "。");
		}else{
			Debug.Log ("ＭＰが足りないため魔法が使えない。");
		}
	}
}

		
		

public class Test : MonoBehaviour {
	void Start(){
		Boss attack = new Boss ();
		for (int u = 0; u <= 10; u++) {
			attack.magic ();
		}


		int[] array = new int[5];
		array [0] = 50;
		array [1] = 100;
		array [2] = 150;
		array [3] = 200;
		array [4] = 250;

		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}
		for (int i=4;i>-1; i--) {
			Debug.Log (array [i]);
		}
			}
			void Update(){
			}
			}
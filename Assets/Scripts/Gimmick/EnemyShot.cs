﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Herope;

namespace Herope{
	public class EnemyShot : DamageObject{

		float spd_move;

		// Use this for initialization
		void Start () {
			StartCoroutine (DeleteCount());
		}
		
		// Update is called once per frame
		void Update () {
			transform.Translate(new Vector3 (spd_move,0,0));
			Debug.Log (Mathf.Sin(transform.rotation.z));

			//ScrollManagerからスクロールの速さを取得
			transform.Translate (new Vector3(ScrollManager.Instance.GetScrollSpeed() * Mathf.Cos(transform.rotation.z),0,0));
		}

		public void SetMoveSpeed(float val){
			spd_move = val;
		}

		IEnumerator DeleteCount(){
			yield return new WaitForSeconds (2);
			Destroy (gameObject);
			yield break;
		}
	}
}
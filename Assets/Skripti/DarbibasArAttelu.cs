using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarbibasArAttelu : MonoBehaviour {
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;
	public GameObject garums;
	public GameObject platums;

	public void izkritosais(int skaitlis){
		if (skaitlis == 0) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [0];
		} else if (skaitlis == 1) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		}	
	}
		
	public void mainitPlatumu(){
		float pasreizejaVertiba = garums.GetComponent<Slider> ().value;
		mainigaisAttels.GetComponent <RectTransform> ().sizeDelta = new Vector2 (1F * pasreizejaVertiba, 0);
	}
	}

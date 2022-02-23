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
		float pasreizejaVertiba = platums.GetComponent<Slider> ().value;
		float pasreizejaisGarums = garums.GetComponent<Slider> ().value;
		mainigaisAttels.GetComponent <RectTransform> ().sizeDelta = new Vector2 (100F * pasreizejaVertiba, 180F*pasreizejaisGarums);
		}
	public void mainitGarumu(){
		float pasreizejaVertiba = platums.GetComponent<Slider> ().value;
		float pasreizejaisGarums = garums.GetComponent<Slider> ().value;
		mainigaisAttels.GetComponent <RectTransform> ().sizeDelta = new Vector2 (100F * pasreizejaVertiba, 180F*pasreizejaisGarums);
		}
	public GameObject Krekls1, Krekls2, Krekls3, Krekls4, Bikses1, Bikses2, Bikses3,Bikses4, DimandaCepure, Cepure1, Pickaxe, Axe, Kurpes1,Showel,Cepure3,Cepure4;
	public void CepuresAttelosana(bool vertiba){
		DimandaCepure.SetActive(vertiba);
		Cepure1.SetActive(vertiba);
		Cepure3.SetActive(vertiba);
		Cepure4.SetActive(vertiba);
	}
	public void KrekluAttelosana(bool vertiba){
		Krekls1.SetActive(vertiba);
		Krekls2.SetActive(vertiba);
		Krekls3.SetActive(vertiba);
		Krekls4.SetActive(vertiba);
	}
	public void BiksesAttelosana(bool vertiba){
		Bikses1.SetActive(vertiba);
		Bikses2.SetActive(vertiba);
		Bikses3.SetActive(vertiba);
		Bikses4.SetActive(vertiba);
	}
	public void KurpesUnInstrumentuAttelosana(bool vertiba){
		Kurpes1.SetActive(vertiba);
		Pickaxe.SetActive(vertiba);
		Axe.SetActive(vertiba);
		Showel.SetActive(vertiba);
	}

	}

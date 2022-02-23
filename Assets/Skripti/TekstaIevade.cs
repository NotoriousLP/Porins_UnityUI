using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaIevade : MonoBehaviour {
	public string vards;
	public string vecums;
	public GameObject ievadesVecums;
	public GameObject ievadesVards;

	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		vards = ievadesVards.GetComponent<Text> ().text;
		vecums = ievadesVecums.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text> ().text = "Supervaronis vārdā " + vards.ToUpper () + " ir "+vecums+" gadu vecs!";
	}
	public GameObject SteveTeksts, AlexTeksts;
	public void SteveTekstaIzvele(bool ieslegts){
		SteveTeksts.SetActive (ieslegts);
	}
	public void AlexTekstaIzvele(bool ieslegts){
		AlexTeksts.SetActive (ieslegts);
	}
}

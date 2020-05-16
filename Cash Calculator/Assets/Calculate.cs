using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    public Text quarter;
    public Text one;
    public Text five;
    public Text ten;
    public Text twenty;
    public Text fiftie;
    public Text hunded;
    public void doMath(){
        int quarters = 0;
        int ones = 0;
        int fives = 0;
        int tens = 0;
        int twnties = 0;
        int fifties = 0;
        int hundreds = 0;
        
        
        Text[] variableListText = {hunded,fiftie,twenty,ten,five,one,quarter};
        object[] variableList = {hundreds,fifties,twnties,tens,fives,ones,quarters};
        
        float[] list = {100,50,20,10,5,1,0.25f};
        for(int x = 0; x< list.Length;x++){
                variableListText[x].gameObject.transform.parent.gameObject.SetActive(false);
        }
        string changes = GameObject.FindGameObjectWithTag("Change").GetComponent<Text>().text;
        float change = float.Parse(changes);
        for(int x = 0; x< list.Length;x++){
            if(change/list[x]>= 1){
                variableList[x] = Mathf.FloorToInt(change/list[x]);
                change = change%list[x];
                print(variableList[x] + "   " + x);
                if(change%list[x] == 0){
                    break;
                }
            }
        }for(int x = 0; x< list.Length;x++){
            if(!variableList[x].Equals(0)){
                variableListText[x].gameObject.transform.parent.gameObject.SetActive(true);
                variableListText[x].text = ""+variableList[x];
            }
        }
        

    }
}
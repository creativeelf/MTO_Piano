using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    public GameObject[] buttons;
    public AudioClip note1, note2, note3, note4, note5, note6, note7, note8;
    public AudioSource buttonAudioSource;
    
    //private int[] buttonOrder = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 4, 5, 5, 5, 6, 7, 7, 8, 1};
    private int[] buttonOrder = {1, 3, 1, 7, 3, 1, 2, 3, 7, 5};

    
    
    //private boolean[] buttonOn = new boolean[5];



    private int currentButton = 0;
    private int buttonIncrement = 0;
    //private Hashtable hashMap;
    //public LevelManager_Runaway lm;
    //public GameObject emitter;
    public Material defaultMaterial;
    public Material selectMaterial;
    public GameObject leftHand;
    public GameObject rightHand;

	// Use this for initialization
	void Start () {
        /*
        buttonOrder= new int[10];
        buttonOrder[0] = 1;
        buttonOrder[1] = 3;
        buttonOrder[2] = 1;
        buttonOrder[3] = 7;
        buttonOrder[4] = 3;
        buttonOrder[5] = 1;
        buttonOrder[6] = 2;
        buttonOrder[7] = 3;
        buttonOrder[8] = 7;
        buttonOrder[9] = 5;
*/



        //buttonOrder = {1, 3, 1, 7, 3, 1, 2, 3, 7, 5};

        buttonIncrement = 0;
        currentButton = buttonOrder[buttonIncrement];
        /*for(int i = 1; i < 9; i++)
        {
            hashMap.Add("note" + System.Convert.ToString(i), buttons[i-1]);
        }*/

        //TODO: change material of currentButton
       // emitter.SetActive(false);
        buttons[currentButton].GetComponent<Renderer>().material = selectMaterial;

    }




    public void setCurrentButtonCollision(){


    }



    public void SetCurrentButton(int buttonNum)
    {
        print("triggered:" + buttonNum);
        if(currentButton == buttonNum)
        {
            //cast object from hash table to audiosource
            //buttonAudioSource.clip = hashMap["note" + System.Convert.ToString(buttonNum)] as AudioClip;
            print("current button: " + currentButton);
          

            switch (buttonNum){
            	case 1:
            		buttonAudioSource.clip = note1;
            		break;
            	case 2:
            		buttonAudioSource.clip = note2;
            		break;
            	case 3:
            		buttonAudioSource.clip = note3;
            		break;
            	case 5:
            		buttonAudioSource.clip = note5;
            		break;
            	case 7:
            		buttonAudioSource.clip = note7;
            		break;
            	default:
            		buttonAudioSource.clip = note1;
            		break;

            };
            if (buttonIncrement<10){
            StartCoroutine(ButtonPressed());
            }
        }
    }

    IEnumerator ButtonPressed()
    {
        print("button pressed");
        buttonAudioSource.Play();
   
        //TODO: change material of old currentButton back
        buttons[currentButton].GetComponent<Renderer>().material = defaultMaterial;

        buttonIncrement++;
         print ("button increment: " + buttonIncrement);
         //print ("current array size is "+ buttonOrder.size());

        if (buttonIncrement<10){
        currentButton = buttonOrder[buttonIncrement];
        buttons[currentButton].GetComponent<Renderer>().material = selectMaterial;       
       }else{
        currentButton= buttonOrder[9];

       }
        //TODO: change material of new currentButton
        
        yield return new WaitForSeconds(1f);
    }

/*
    IEnumerator ActivateColliders()
    {
        yield return new WaitForSeconds(2f);
        leftHand.GetComponent<Collider>().enabled = true;
        rightHand.GetComponent<Collider>().enabled = true;
    }
    */
    // Update is called once per frame
    void Update () {
        
	}

    void OnTriggerEnter(Collider other) {
        

    }



}
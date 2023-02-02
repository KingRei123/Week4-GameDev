using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenuBG : MonoBehaviour
{
    public GameObject MainMenu; // This is the main menu container
    public GameObject Credits; // Credits container
    public GameObject Options; // Options container

    [SerializeField] Slider VolSlider;


    // Start is called before the first frame update
    void Start()
    {
        // tell the program to activate the main menu and leave everything inactive
        MainMenu.SetActive(true);
        Options.SetActive(false);
        Credits.SetActive(false);
        AudioListener.volume = VolSlider.value;
        
    }

    public void OptButton() {
        MainMenu.SetActive(false);
        Options.SetActive(true);
        Credits.SetActive(false);
    }

    public void CreditBtn() {
        MainMenu.SetActive(false);
        Options.SetActive(false);
        Credits.SetActive(true);
    }

    public void btnBack() {
        MainMenu.SetActive(true);
        Options.SetActive(false);
        Credits.SetActive(false);
    }

    public void SetVolume() {
        AudioListener.volume = VolSlider.value;
    }
    public void Quit() {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

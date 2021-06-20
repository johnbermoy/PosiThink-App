using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main : MonoBehaviour
{

    public GameObject Main_object;
    public GameObject life_object;
    public GameObject missing;
    public GameObject Depress_panel;
    public GameObject faith;
    public GameObject anxiety;
    public GameObject stress;
    public GameObject lonely;
    public GameObject motiovate;
    public GameObject sad;
    public GameObject calm;
    public GameObject appre;
    public GameObject favo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Favorite()
    {
        favo.SetActive(true);
        Main_object.SetActive(false);
    }

    public void Exit_favo()
    {
        favo.SetActive(false);
        Main_object.SetActive(true);
    }

    public void Motivational()
    {
        Main_object.SetActive(false);
        life_object.SetActive(true);
    }

    public void Menu()
    {
        Main_object.SetActive(true);
        life_object.SetActive(false);
    }

    public void Close_Application()
    {
        Application.Quit();
        Debug.Log("123");
    }

    public void Motivate()
    {
        motiovate.SetActive(true);
        life_object.SetActive(false);
    }


    public void Depress()
    {
        life_object.SetActive(false);
        Depress_panel.SetActive(true);
    }

    public void Missing_Someone()
    {
        missing.SetActive(true);
        life_object.SetActive(false);
    }

    public void Faith()
    {
        faith.SetActive(true);
        life_object.SetActive(false);
    }

    public void Anxiety()
    {
        anxiety.SetActive(true);
        life_object.SetActive(false);
    }

    public void Stress()
    {
        stress.SetActive(true);
        life_object.SetActive(false);
    }

    public void Lonely()
    {
        lonely.SetActive(true);
        life_object.SetActive(false);
    }

    public void Sad()
    {
        sad.SetActive(true);
        life_object.SetActive(false);
    }

    public void Appreciation()
    {
        appre.SetActive(true);
        life_object.SetActive(false);
    }

    public void Depress_Back()
    {
        life_object.SetActive(true);
        Depress_panel.SetActive(false);
        missing.SetActive(false);
        faith.SetActive(false);
        anxiety.SetActive(false);
        stress.SetActive(false);
        lonely.SetActive(false);
        sad.SetActive(false);
        appre.SetActive(false);
        motiovate.SetActive(false);
    }

}

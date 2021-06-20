using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{

    //Object
    public List<GameObject> btn = new List<GameObject>();

    //Buttons
    public List<Button> button = new List<Button>();

    public bool motivate = false;
    public bool missing = false;
    public bool Depress_panel = false;
    public bool faith = false;
    public bool anxiety = false;
    public bool stress = false;
    public bool lonely = false;
    public bool sad = false;
    public bool calm = false;
    public bool appre = false;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Missing_favo()
    {
        missing = true;
        btn[1].SetActive(true);
        ColorBlock colors = button[8].colors;
        colors.normalColor = Color.red;
        colors.highlightedColor = new Color32(255, 100, 100, 255);
        button[8].colors = colors;
    }
    public void Depress_Favo()
    {
        Depress_panel = true;
        btn[0].SetActive(true);
    }
    public void Faith_favo()
    {
        faith = true;
        btn[2].SetActive(true);
    }

    public void Anxiety_Favo()
    {
        anxiety = true;
        btn[4].SetActive(true);
    }

    public void Stress_Favo()
    {
        stress = true;
        btn[3].SetActive(true);
    }
    public void Lonely_favo()
    {
        lonely = true;
        btn[6].SetActive(true);
    }

    public void Sad_favo()
    {
        sad = true;
        btn[7].SetActive(true);
    }

    public void Calm_favo()
    {
        calm = true;
        btn[1].SetActive(true);
    }

    public void Appre_Favo()
    {
        appre = true;
        btn[5].SetActive(true);
    }

    public void Favorite_motivate()
    {
        motivate = true;
        btn[8].SetActive(true);
    }
}

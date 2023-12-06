using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ListManager : MonoBehaviour
{
    public Button nextpage;
    public Button prevpage;
    private List<GameObject> listLevels;
    private int page;
    // Start is called before the first frame update
    void Start()
    {
        page = 1;
        listLevels = new List<GameObject>();
        int l = 1; 
        foreach(Transform level in  transform)
        {

            level.GetComponentInChildren<TextMeshProUGUI>().text = l.ToString();
            l++;
            print(level.name);
            listLevels.Add(level.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePageNext()
    {
        foreach(GameObject level in listLevels)
        {
             
            int levelID = short.Parse(level.GetComponentInChildren<TextMeshProUGUI>().text);
            level.GetComponentInChildren<TextMeshProUGUI>().text = (levelID + 9).ToString();

        }
        page++;
    }


    public void ChangePagePrev()
    {
        if (page >= 2)
        {
            foreach (GameObject level in listLevels)
            {
                int levelID = short.Parse(level.GetComponentInChildren<TextMeshProUGUI>().text);
               
                {

                    level.GetComponentInChildren<TextMeshProUGUI>().text = (levelID - 9).ToString();
                }

            }
            page--;
        }
        
    }

}

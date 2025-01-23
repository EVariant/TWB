using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiMgr : MonoBehaviour
{
    public UI_StartMenu ui_StartMenu;
    public UI_Battle ui_Battle;


    private void Awake()
    {
        ui_StartMenu.Init();
        ui_Battle.Init();



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

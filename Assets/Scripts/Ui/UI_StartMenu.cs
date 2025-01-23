using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StartMenu : MonoBehaviour
{
    public Button btn_NewGame;
    public Button btn_BattleTest;
    public Button btn_Options;
    public Button btn_Quit;

    public void Init()
    {
        Show();

        btn_BattleTest.onClick.AddListener(() => 
        {
            Hide();
            GameMgr.I.scene_Battle.Show();
        });
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _creditsButton;


    public override void Initialize()
    {
                
        _settingsButton.onClick.AddListener(() =>
        {
            ViewManager.Show<SettingsMenuView>();
        });

         
        _creditsButton.onClick.AddListener(() =>
        {
            ViewManager.Show<CreditsView>();
        });
    }

        void Start()
    {

    }

        void Update()
    {

    }
}

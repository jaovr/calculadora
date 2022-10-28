using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Themes : MonoBehaviour {

    // Tema Escuro
    [SerializeField] private Color darkBackGround = Color.black;
    [SerializeField] private Color darkThemeFontColor = Color.red;
    [SerializeField] private Color darkBtnNormal = Color.black;
    [SerializeField] private Color darkNumberNormal = Color.red;
    [SerializeField] private Color darkBtnEspecial = Color.red;
    [SerializeField] private Color darkNumberEspecial = Color.red;
    [SerializeField] private Color darkBtnEquals = Color.red;
    [SerializeField] private Color darkNumberEquals = Color.red;

    // Tema Claro
    [SerializeField] private Color lightBackGround = Color.red;
    [SerializeField] private Color lightThemeFontColor = Color.black;
    [SerializeField] private Color lightBtnNormal = Color.red;
    [SerializeField] private Color lightNumberNormal = Color.white;
    [SerializeField] private Color lightBtnEspecial = Color.red;
    [SerializeField] private Color lightNumberEspecial = Color.white;
    [SerializeField] private Color lightBtnEquals = Color.white;
    [SerializeField] private Color lightNumberEquals = Color.white;

    // UI 
    
    [SerializeField] private Camera myCamera;
    [SerializeField] private Text textDisplayII;
    [SerializeField] private Button[] normalButtons;
    [SerializeField] private Text[] normalButtonFonts;
    [SerializeField] private Button[] especialButtons;
    [SerializeField] private Text[] especialButtonFonts;
    [SerializeField] private Button equalsButton;
    [SerializeField] private Text equalsButtonFont;

    
    private String themeState = "dark";

    void Start() {
        ChangeTheme();
    }

    public void ChangeTheme() {
        if (themeState.Equals("dark")) { 
            ChoiceLightColor();
            this.themeState = "light";
        } else {
            ChoiceDarkColor();
            this.themeState = "dark";
        }
    }

    public void ChoiceDarkColor() {
        myCamera.backgroundColor = darkBackGround;
        textDisplayII.color = darkThemeFontColor;
        foreach (Button button in normalButtons) 
            button.image.color = darkBtnNormal;
        foreach (Text font in normalButtonFonts)
            font.color = darkNumberNormal;
        foreach (Button button in especialButtons)
            button.image.color = darkBtnEspecial;
        foreach (Text font in especialButtonFonts)
            font.color = darkNumberEspecial;
        equalsButton.image.color = darkBtnEquals;
        equalsButtonFont.color = darkNumberEquals;
    }

    public void ChoiceLightColor() {
        myCamera.backgroundColor = lightBackGround;
        textDisplayII.color = lightThemeFontColor;
        foreach (Button button in normalButtons)
            button.image.color = lightBtnNormal;           
        foreach (Text font in normalButtonFonts)
            font.color = lightNumberNormal;
        foreach (Button button in especialButtons)
            button.image.color = lightBtnEspecial;
        foreach (Text font in especialButtonFonts)
            font.color = lightNumberEspecial;
        equalsButton.image.color = lightBtnEquals;
        equalsButtonFont.color = lightNumberEquals;
    }
}
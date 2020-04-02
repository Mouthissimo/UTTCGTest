﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card
{
    private cardTypesEnum cardType;
    private Sprite display;
    private string name;

    /*
    public Card(Sprite arg_display, string arg_name)
    {
        display = arg_display;
        name = arg_name;
    }
    */

    public cardTypesEnum GetCardType()
    {
        return cardType;
    }

    public void SetCardType(cardTypesEnum arg_cardType)
    {
        cardType = arg_cardType;
    }

    public Sprite GetDisplay()
    {
        return display;
    }

    public void SetDisplay(Sprite arg_sprite)
    {
        display = arg_sprite;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string arg_name)
    {
        name = arg_name;
    }
}
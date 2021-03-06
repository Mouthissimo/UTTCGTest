﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CardCollection
{
    private const int TOTAL_COLLECTION = 3;
    private static Sprite cardBack = Resources.Load<Sprite>("Cards/Card_Back") as Sprite;

    private static Card[] cardCollection = new Card[TOTAL_COLLECTION]
    {
        // CARD 0: (Temtem) Nessla
        new Card_Temtem(Resources.Load<Sprite>(
            "Cards/Temtem_Nessla") as Sprite,
            "Nessla",
            "Temtem official artwork",
            cardSetEnum.Alpha,
            cardRarityEnum.Rare,
            3,
            elementTypesEnum.Electric, elementTypesEnum.Water,
            90, 30, 20, 40,
            traitsEnum.Electric_Synthesize,
            "<b>Electric Synthesize:</b> When attacked by a [Electric] technique, the attack restores HP to this Temtem instead of dealing damage.",
            elementTypesEnum.Crystal, elementTypesEnum.Nature, elementTypesEnum.Toxic,
            elementTypesEnum.Fire, elementTypesEnum.Water, elementTypesEnum.Wind
        ),
        
        // CARD 1: (Temtem) Barnshe
        new Card_Temtem(Resources.Load<Sprite>(
            "Cards/Temtem_Barnshe") as Sprite,
            "Barnshe", "tumgir.com/red-fence",
            cardSetEnum.Alpha,
            cardRarityEnum.Rare,
            3,
            elementTypesEnum.Mental, elementTypesEnum.Wind,
            80, 30, 30, 40,
            traitsEnum.Neutrality,
            "<b>Neutrality:</b> This Temtem cannot be affected by any status condition.",
            elementTypesEnum.Crystal, elementTypesEnum.Digital, elementTypesEnum.Electric,
            elementTypesEnum.Earth, elementTypesEnum.Melee, elementTypesEnum.Wind
        ),

        // CARD 2: (Temtem) Gyalis
        new Card_Temtem(Resources.Load<Sprite>(
            "Cards/Temtem_Gyalis") as Sprite,
            "Gyalis",
            "Discord: dCephei#6760",
            cardSetEnum.NULL,
            cardRarityEnum.Rare,
            4,
            elementTypesEnum.Crystal, elementTypesEnum.Melee,
            110, 40, 40, 30,
            traitsEnum.Mirroring,
            "<b>Mirroring:</b> When this Temtem is attacked, the attacker loses 20 HP.",
            elementTypesEnum.Digital, elementTypesEnum.Earth, elementTypesEnum.Fire,
            elementTypesEnum.Electric, elementTypesEnum.Toxic, elementTypesEnum.NULL
        )
    };

    public static Sprite GetCardDisplayBack()
    {
        return cardBack;
    }

    public static Card[] GetCardTemplateCollection()
    {
        return cardCollection;
    }

    public static Card GetCardTemplatebyIndex(int arg_cardIndex)
    {
        return cardCollection[arg_cardIndex];
    }

    public static Card GetCardTemplatebyName(string arg_cardName)
    {
        foreach (Card card in cardCollection)
        {
            if (card.GetName().Equals(arg_cardName))
            {
                return card;
            }
        }

        Debug.Log("The card " + arg_cardName + " doesn't exist.");
        return null;
    }

    public static Card_Temtem CreateNewCardTemtemFromTemplate(Card_Temtem arg_card)
    {
        Card_Temtem loc_card;

        loc_card = new Card_Temtem(
        arg_card.GetDisplay(),
        arg_card.GetName(),
        arg_card.GetCredits(),
        arg_card.GetCardSet(),
        arg_card.GetCardRarity(),
        arg_card.GetPansuns(),
        arg_card.GetElementType_1(),
        arg_card.GetElementType_2(),
        arg_card.GetHp(),
        arg_card.GetAtk(),
        arg_card.GetSpd(),
        arg_card.GetSta(),
        arg_card.GetTrait(),
        arg_card.GetTraitText(),
        arg_card.GetWeakness_1(),
        arg_card.GetWeakness_2(),
        arg_card.GetWeakness_3(),
        arg_card.GetResistance_1(),
        arg_card.GetResistance_2(),
        arg_card.GetResistance_3()
        );

        return loc_card;
    }
}

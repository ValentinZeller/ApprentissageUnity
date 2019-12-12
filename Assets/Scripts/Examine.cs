﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Examine")]
public class Examine : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.LogStringWithReturn(controller.TestVerbDictionnaryWithNoun(controller.interactableItems.examineDictionary, separatedInputWords[0], separatedInputWords[1]));
    }
}

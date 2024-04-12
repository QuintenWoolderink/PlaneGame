using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;

    public CharacterDatabasebase characterDB;
    public Text nameText;
    public Transform player;
    private int selectedOption = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption <= 0) 
        { 
            selectedOption = characterDB.CharacterCount - 1;
        }

        UpdateCharacter(selectedOption);
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        
        if (character != null)
        {
            
            //destroy children of character model
            foreach(Transform child in player)
            {
                Destroy(child.gameObject);
            }
            var characterModel = Instantiate(character.characterModel);
            characterModel.transform.SetParent(player.transform, false);
            
        }

        nameText.text = character.characterName;
    }
}

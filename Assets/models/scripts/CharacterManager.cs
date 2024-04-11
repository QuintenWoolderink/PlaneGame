using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;

    public CharacterDatabasebase characterDB;
    public Text nameText;
    public GameObject characterModel;
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
            var position = characterModel.transform.position;
            var rotation = characterModel.transform.rotation;
            Destroy(characterModel);
            characterModel = Instantiate(character.characterModel, position, rotation);
        }

        nameText.text = character.characterName;
    }
}

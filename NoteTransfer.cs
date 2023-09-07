using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoteTransfer : MonoBehaviour
{
    private string theNote;
    public TMP_InputField inputField;
    public TMP_Text textDisplay;
    private Stack<string> textStack = new Stack<string>();


    public void StoreNote()
    { 
        textStack.Push(inputField.text);
        inputField.text = "";
        displayText();
 
    }

    public void displayText()
    {
        textDisplay.text = "";
        // Create a temporary stack to hold the elements in reverse order
        Stack<string> tempStack = new Stack<string>();

        // Pop elements from the original stack and push them into the temporary stack
        while (textStack.Count > 0)
        {
            string element = textStack.Pop();
            tempStack.Push(element);
        }

        // Pop elements from the temporary stack and display them
        while (tempStack.Count > 0)
        {
            string element = tempStack.Pop();
            textStack.Push(element);
            textDisplay.text+= element + '\n';
        }
    }

    public void deleteText()
    {
        textStack.Pop();
        displayText();
    }
}
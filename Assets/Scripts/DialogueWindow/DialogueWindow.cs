using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;

public class DialogueWindow : MonoBehaviour
{
    public float speedText;
    public string[] lines;

    public Text dialogueText;

    public GameObject dialWindow;
    public GameObject player;

    public float waitingTime = 2f;
    private int index;
    void Start()
    {
        dialWindow.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialWindow.SetActive(true);
        dialogueText.text = string.Empty;
        StartDialogue();
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(speedText);
        }
        NextLine();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopAllCoroutines();
        dialWindow.SetActive(false);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        dialWindow.SetActive(false);
    }
    IEnumerator Wait1()
    {
        yield return new WaitForSeconds(waitingTime);
        dialogueText.text = string.Empty;
        StartCoroutine(TypeLine());
    }

    private void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            StartCoroutine(Wait1());
        }
        else
        {
            StartCoroutine(Wait());
        }
    }
}

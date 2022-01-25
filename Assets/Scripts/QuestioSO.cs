using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quiz Question", fileName = "New Question")]
public class QuestioSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int rightAnswer;


    public string GetQuestion()
    {
        return question; 
    }

    public int GetRightAnswerIndex()
    {
        return rightAnswer;
    }
    public string GetRightAnswer(int index)
    {
        return answers[index];
    }
}
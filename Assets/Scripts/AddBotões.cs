using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AddBotões : MonoBehaviour
{
    [SerializeField]
    private Transform puzzlefield;
    public int quantidadeFotos;
    [SerializeField]
    private GameObject btn;
     void Awake()
    {
        for(int i =0; i < quantidadeFotos; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzlefield, false);
        }
    }
}

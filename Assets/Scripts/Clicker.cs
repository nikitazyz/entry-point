using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] private Button _button;

    private Wallet _wallet;

    public void Initialize(Wallet wallet)
    {
        _wallet = wallet;
    }

    private void Awake()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        _wallet.AddMoney(2);
    }
}

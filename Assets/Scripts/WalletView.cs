using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WalletView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countField;
    private Wallet _wallet;

    public void Initialize(Wallet wallet)
    {
        _wallet = wallet;
    }

    private void Awake()
    {
        _countField.text = _wallet.Money.ToString();
    }


    private void Update()
    {
        _countField.text = _wallet.Money.ToString();
    }
}

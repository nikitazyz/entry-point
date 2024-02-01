using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private Clicker _clicker;
    [SerializeField] private WalletView _walletView;

    private Wallet _wallet;

    private void Awake()
    {
        _wallet = new Wallet(10);

        _clicker.Initialize(_wallet);
        _walletView.Initialize(_wallet);
    }
}

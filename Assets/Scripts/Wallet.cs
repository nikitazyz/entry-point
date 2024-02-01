using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet
{
    public int Money { get; private set; }

    public Wallet(int money)
    {
        Money = money;
    }

    public void AddMoney(int amount)
    {
        Money += amount;
    }

    public bool CanRemoveMoney(int amount) => amount > Money;

    public bool TryRemoveMoney(int amount)
    {
        if (CanRemoveMoney(amount)) 
        {
            return false;
        }

        Money -= amount;
        return true;
    }
}

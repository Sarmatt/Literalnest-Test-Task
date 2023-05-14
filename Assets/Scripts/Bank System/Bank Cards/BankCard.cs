using UnityEngine;

[System.Serializable]
public class BankCard
{
    [SerializeField] private int _cardNumber;
    public int CardNumber => _cardNumber;
    [SerializeField] private int _endMonth;
    public int EndMonth => _endMonth;
    [SerializeField] private int _endYear;
    public int EndYear => _endYear;
    [SerializeField] private int _cvv;
    public int Cvv => _cvv;

    public BankCard(int cardNumber, int endMonth, int endYear, int cvv)
    {
        _cardNumber = cardNumber;
        _endMonth = endMonth;
        _endYear = endYear;
        _cvv = cvv;
    }
}

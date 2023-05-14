using System;
using UnityEngine;

[System.Serializable]
public class Cost
{
   [SerializeField] private int _id;
   public int Id => _id;
   [SerializeField] private string _title;
   public string Title => _title;
   [SerializeField] private CostType _type;
   public CostType Type => _type;
   [SerializeField] private int _moneyAmount;
   public int MoneyAmount => _moneyAmount;
   [SerializeField] private DateTime _date;
   public DateTime Date => _date;

   public Cost(int id, string title, CostType type, int moneyAmount)
   {
      _id = id;
      _title = title;
      _type = type;
      _moneyAmount = moneyAmount;
      _date = DateTime.Now;
   }

   public Cost(Cost cost)
   {
      _id = cost.Id;
      _title = cost.Title;
      _type = cost.Type;
      _moneyAmount = cost.MoneyAmount;
      _date = cost.Date;
   }
}

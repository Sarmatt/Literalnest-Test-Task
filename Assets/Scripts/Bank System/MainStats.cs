using System.Collections.Generic;
using UnityEngine;

public class MainStats : MonoBehaviour
{
   [Header("Start Init")]
   [SerializeField] private CostsContainer _costsContainercontainer;
   
   [Header("In game Init")]
   [SerializeField] private int _moneyAmount;
   [SerializeField] private List<BankCard> _bankCards = new List<BankCard>();
}

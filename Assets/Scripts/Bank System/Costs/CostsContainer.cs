using System;
using System.Collections.Generic;
using UnityEngine;

public class CostsContainer : MonoBehaviour
{
    [SerializeField] private List<Cost> _costs = new List<Cost>();

    private int _lastCostId = 1;
    
    public void AddCost(string title, CostType type, int moneyAmount)
    {
        var cost = new Cost(_lastCostId, title, type, moneyAmount);
        _costs.Add(cost);
        _lastCostId++;
    }

    public void TryRemoveCost(Cost cost)
    {
        foreach (var child in _costs)
        {
            if (child.Id == cost.Id)
            {
                _costs.Remove(child);
                return;
            }
        }
    }

    public List<Cost> GetCostsByEndDate(DateTime date)
    {
        List<Cost> res = new List<Cost>();
        foreach (var cost in _costs)
        {
            if(cost.Date < date)
                res.Add(cost);
        }
        return res;
    }

    public List<Cost> GetCostsByStartAndEndDate(DateTime startDate, DateTime endDate)
    {
        List<Cost> res = new List<Cost>();
        foreach (var cost in _costs)
        {
            if(cost.Date > startDate && cost.Date < endDate)
                res.Add(cost);
        }
        return res;
    }
}

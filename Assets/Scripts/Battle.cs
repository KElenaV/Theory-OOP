using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Battle : MonoBehaviour
{
    [SerializeField] private TMP_Text[] _characteristics;
    
    private List<Warrior> _warriors = new List<Warrior>()
    {
        new Knight(100,20,DamageType.Melee,30),
        new Archer(60,15,0.7f),
        new Dragon(200,30,DamageType.Range)
    };

    private void Start()
    {
        ShowStats();

        StartCoroutine(Fight());
    }

    private IEnumerator Fight()
    {
        _warriors[0].TakeDamage(_warriors[1].GetDamage());
        
        yield return new WaitForSeconds(2);
        
        ShowStats();
    }

    private void ShowStats()
    {
        for (int i = 0; i < _warriors.Count; i++)
        {
            _characteristics[i].text = $"{_warriors[i].GetType()}:\n{_warriors[i].GetInfo()}";
        }
    }
}
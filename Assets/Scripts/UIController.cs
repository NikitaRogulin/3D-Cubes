using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_InputField timeField;
    [SerializeField] private TMP_InputField distanceField;
    [SerializeField] private TMP_InputField speedField;

    public event Action<SpawnData> OnSpawnDataChanged;


    private SpawnData data;

    public void CollectData()
    {
        var speed = ProtectValue(speedField);
        var time = ProtectValue(timeField);
        var distance = ProtectValue(distanceField);
        data = new SpawnData(speed, time, distance);

        OnSpawnDataChanged?.Invoke(data);
    }
    private int ProtectValue(TMP_InputField field)
    {
        var text = field.text;


        if (String.IsNullOrEmpty(text))
        {
            return 0;
        }

        var value = Convert.ToInt32(text);
        if (value >= 0)
        {
            return value;
        }
        else
        {
            return Math.Abs(value);
        }
    }
}

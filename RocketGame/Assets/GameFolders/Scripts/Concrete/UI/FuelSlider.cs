using PlayerFuel;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class FuelSlider : MonoBehaviour
    {
        [SerializeField] Text textFuel;
        Slider _slider;
        Fuel _fuel;
        int fuelPercentage;
        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _fuel = FindAnyObjectByType<Fuel>();
        }
        private void Update()
        {
            _slider.value = _fuel.CurrentFuel;


            if (fuelPercentage == 1)
            {
                textFuel.text = "Fuel% 0";
            }
            else
            {
                int fuelPercentage = Mathf.RoundToInt(_slider.value * 100f);
                textFuel.text = "Fuel% " + fuelPercentage.ToString();
            }
        }
    }

}

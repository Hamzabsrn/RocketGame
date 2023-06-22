using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultAction
{
    public class DefaultInput 
    {
        private DefaultAction _input;


        public bool isForceUp { get; private set; }
        public float Leftright { get;private set; }
        public DefaultInput()
        {
            _input = new DefaultAction();

            _input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += context => Leftright = context.ReadValue<float>();
            _input.Enable();
        }

    }

}
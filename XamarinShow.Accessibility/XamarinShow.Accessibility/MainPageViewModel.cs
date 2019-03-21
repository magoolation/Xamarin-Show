using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinShow.Accessibility
{
    public class MainPageViewModel : ViewModelBase
    {
        private float ios12 = 82.3f;
        private float ios11 = 10.5f;
        private float other = 7.2f;

        public float IOS12
        {
            get => ios12;
            set => SetProperty(ref ios12, value);
        }

        public float IOS11
        {
            get => ios11;
            set => SetProperty(ref ios11, value);
        }

        public float Other
        {
            get => other;
            set => SetProperty(ref other, value);
        }
    }
}
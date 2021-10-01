﻿using ColorPicker.Foundation.Mvvm;

namespace ColorPicker.Foundation.Wpf
{
    public interface IFlowElement
    {
        IFlowElement UseViewModel(ObservableObject vm);
        void OnShow();
    }
}

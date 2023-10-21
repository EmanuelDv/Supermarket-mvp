﻿namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {
        string PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservation { get; set; }
        string SearcValue { get; set; }
        bool IsEdit { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddnewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPayModeListBildingSource(BindingSource payModeList);
        void Show();


    }
}
using System;
using Microsoft.AspNetCore.Components;

namespace MudBlazor.Docs.Components;

public partial class EnumSwitch<TEnum>
{
    private TEnum _value;

    [Parameter]
    public TEnum Value
    {
        get => _value;
        set
        {
            if (_value.Equals(value)) return;
            _value = value;
            ValueChanged.InvokeAsync(value);
        }
    }

    [Parameter] public EventCallback<TEnum> ValueChanged { get; set; }

    private Type Type => typeof(TEnum);
}

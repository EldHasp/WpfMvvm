﻿using System;
using System.Windows.Markup;

namespace WpfMvvm.Converters
{
    /// <summary>Возвращает <see cref="GetTypeConverter.Instance"/>.</summary>
    public class GetTypeConverterExtension : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
            => GetTypeConverter.Instance;
    }
}

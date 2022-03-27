﻿using ModernWpf.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DGP.Genshin.Control.Infrastructure.Observable
{
    /// <summary>
    /// 实现了 <see cref="INotifyPropertyChanged"/> 的对话框
    /// </summary>
    public class ObservableContentDialog : ContentDialog, INotifyPropertyChanged
    {
        /// <inheritdoc/>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 设置字段的值
        /// </summary>
        /// <typeparam name="T">字段类型</typeparam>
        /// <param name="storage">现有值</param>
        /// <param name="value">新的值</param>
        /// <param name="propertyName">属性名称</param>
        protected void Set<T>([NotNullIfNotNull("value")] ref T storage, T value, [CallerMemberName] string propertyName = default!)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            this.OnPropertyChanged(propertyName);
        }

        /// <summary>
        /// 触发 <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="propertyName">属性名称</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
﻿namespace DGP.Genshin.Core
{
    /// <summary>
    /// 为依赖注入提供安全的容器接口
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// 在容器中查找注入的类或对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Find<T>() where T : class;
    }
}

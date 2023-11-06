﻿namespace Berger.Extensions.Abstractions
{
    public interface IModule : IEntity<Guid>
    {
        #region Properties
        string Name { get; set; }
        #endregion

        #region Methods
        public void SetModule(string name);
        #endregion
    }
}
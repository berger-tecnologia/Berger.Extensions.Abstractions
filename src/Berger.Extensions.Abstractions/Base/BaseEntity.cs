﻿using System.Net.Http.Headers;

namespace Berger.Extensions.Abstractions
{
    public class BaseEntity : Auditable, IBaseEntity<Guid>
    {
        #region Properties
        public Guid Id { get; set; }
        #endregion

        #region Methods
        public void SetId(Guid id)
        {
            this.Id = id;
        }
        public void SetId()
        {
            Initialize();
        }
        public void Initialize()
        {
            Id = Guid.NewGuid();
        }
        public Guid GetId()
        {
            return Id;
        }
        #endregion
    }
}
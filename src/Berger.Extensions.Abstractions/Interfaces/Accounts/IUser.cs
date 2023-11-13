namespace Berger.Extensions.Abstractions
{
    public interface IUser<T> : IBaseEntity<Guid> where T : IGender
    {
        #region Properties
        T Gender { get; }
        IMedia Avatar { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        #endregion

        #region Methods
        void Deactivate();
        void SetName(string name);
        void SetSurname(string surname);
        void SetAvatar(Guid mediaId, string avatarUrl);
        #endregion
    }
}
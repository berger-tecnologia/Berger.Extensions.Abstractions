namespace Berger.Extensions.Abstractions
{
    public static class SlugExtension
    {
        public static void SetSlug(this ISlug entity, string name)
        {
            entity.Name = name;
            entity.Slug = name;
        }
        public static void SetCategory(this ICategory entity, Guid id)
        {
            entity.CategoryId = id;
        }
        public static void SetName(this INamed entity, string name)
        {
            entity.Name = name;
        }
        public static void Highlight(this IHighlighted entity)
        {
            entity.Highlighted = true;
        }
    }
}
namespace RPGinventory
{
    public abstract class Obtainableitem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaximumStackableQauntity { get; set; }
        protected Obtainableitem()
        {
            MaximumStackableQauntity = 1;
        }

    }


}
namespace Cityton.Domain.Company
{
    class Company: BaseEntities
    {

        public int MinGroupSize { get; set; }
        public int MaxGroupSize { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<User> Users { get; set; }

    }
}

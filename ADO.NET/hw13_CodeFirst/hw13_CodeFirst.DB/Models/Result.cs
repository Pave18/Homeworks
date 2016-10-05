namespace hw13_CodeFirst.DB.Models
{
    class Result
    {
        public int Id { get; set; }
        public virtual Palyer PlayerId { get; set; }
        public int Time { get; set; }
        public int NumberOfSteps { get; set; }
        public byte Level { get; set; }
    }
}

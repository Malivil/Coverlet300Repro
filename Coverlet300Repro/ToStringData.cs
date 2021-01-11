namespace Coverlet300Repro
{
    public class ToStringData
    {
        public string First { get; set; } = "First";

        public override string ToString() =>
            $"{GetType().Name}{{"
            + $"First: '{First}'"
            + "}}";
    }
}

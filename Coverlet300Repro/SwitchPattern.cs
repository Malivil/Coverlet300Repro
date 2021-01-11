namespace Coverlet300Repro
{
    public class SwitchPattern
    {
        public int Value { get; set; }

        public SwitchPattern(Number value)
        {
            Value = value switch
            {
                Number.One => 1,
                _ => 2
            };
        }
    }
}

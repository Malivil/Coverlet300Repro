namespace Coverlet300Repro
{
    public class MultiLineAssignment
    {
        public float Value { get; set; }

        public MultiLineAssignment()
        {
            Value = 1.0f *
                    2.0f /
                    3.0f;
        }
    }
}

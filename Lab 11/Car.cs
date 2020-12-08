namespace Lab_11
{
    class Car
    {
        public bool WheelAlignmentTuned { get; set; }
        public bool Painted { get; set; }
        public bool OilChanged { get; set; }
        public bool FullInspected { get; set; }
        public bool WheelsReplaced { get; set; }
        public bool BodyRepaired { get; set; }
        public override string ToString()
        {
            return
                $"WheelAlignmentTuned\t--\t{WheelAlignmentTuned}" +
                $"\nPainted\t\t\t--\t{Painted}" +
                $"\nOilChanged\t\t--\t{OilChanged}" +
                $"\nFullInspected\t\t--\t{FullInspected}" +
                $"\nWheelsReplaced\t\t--\t{WheelsReplaced}" +
                $"\nBodyRepaired\t\t--\t{BodyRepaired}";
        }
    }
}

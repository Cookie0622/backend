namespace csBackend
{
    public class Printer
    {
        public int PrinterId { get; set; }
        public required string MaschinenName { get; set; }
        public int MaschinenFormatL { get; set; }
        public int MaschinenFormatB { get; set; }
        public required string FarbFormat { get; set; }
        public int UnbedruckbarerRand { get; set; }

        public override string ToString()
        {
            return $"\n{PrinterId};{MaschinenName};{MaschinenFormatL};{MaschinenFormatB};{FarbFormat};{UnbedruckbarerRand}";
        }
    }
}

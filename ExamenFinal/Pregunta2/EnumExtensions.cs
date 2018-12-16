namespace ExamenParcial
{
    public static class EnumExtensions
    {
        public static string GetMemorySize(this MemorySize me)
        {
            switch (me)
            {
                case MemorySize.Basic:
                    return "8GB";
                case MemorySize.Medium:
                    return "16GB";
                case MemorySize.Pro:
                    return "32GB";
                default:
                    return "8GB";
            }
        }

        public static string GetMemorySpeed(this MemorySpeed me)
        {
            switch (me)
            {
                case MemorySpeed.Fast:
                    return "1400MHz";
                case MemorySpeed.Turbo:
                    return "1600MHz";                
                default:
                    return "1400MHz";
            }
        }

        public static string GetProcessorFrequency(this ProcessorFrequency me)
        {
            switch (me)
            {
                case ProcessorFrequency.Low:
                    return "1.4GHz";
                case ProcessorFrequency.Fast:
                    return "2.4GHz";
                case ProcessorFrequency.Turbo:
                    return "3.5GHz";
                default:
                    return "3.2GHz";
            }
        }

        public static string GetStorageSize(this StorageSize me)
        {
            switch (me)
            {
                case StorageSize.Small:
                    return "512GB";
                case StorageSize.Medium:
                    return "1TB";
                case StorageSize.Huge:
                default:
                    return "2TB";
            }
        }
    }
}
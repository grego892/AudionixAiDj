namespace AudionixAiDj.Data
{
    public class ProgramLogItem
    {
        public int LogPosition { get; set; }
        public string? FileName { get; set; }
        public enum Category
        {
            Music,
            Read,
            Liner,
            Macro,
            Spot
        }

        public Category LogCategory { get; set; }

        public enum PlayStatus
        {
            NotPlayed,
            Playing,
            Played,
            Failed
        }
        public PlayStatus LogPlayStatus { get; set; }

    }
}

namespace Oringinal
{
    /// <summary>
    /// 遊戲狀態的列舉
    /// </summary>
    public enum GameState
    {
        Running,
        Failed,
        End
    }

    /// <summary>
    /// 每一回合的結果資料
    /// </summary>
    public class GameStageResult
    {
        public GameState State
        { get; set; }

        public string Route
        { get; set; }

        public string Message
        { get; set; }

        public GameStageResult()
        {
            Route = string.Empty;
            Message = string.Empty;
        }
    }
}
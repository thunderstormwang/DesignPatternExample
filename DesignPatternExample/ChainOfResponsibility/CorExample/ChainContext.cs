namespace ChainOfResponsibility.CorExample
{
    public class ChainContext
    {
        /// <summary>
        /// 組成責任鏈
        /// </summary>
        /// <returns></returns>
        public static FormatChecker GetCheckers()
        {
            return new LengthChecker(new HeadChecker(new FirstDateChecker(new SecondDateChecker(null))));
        }
    }
}

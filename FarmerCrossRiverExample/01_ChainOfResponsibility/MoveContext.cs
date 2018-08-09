using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    #region (ChainOfResponsibility) 加入  Chain of Responsibility
    /// <summary>
    /// 將 Original 在 ViewModel class 中 Move Method 的判斷式改變為 Chain of Responsibility
    /// 這是 Chain of Resonsibility 的一般化抽象類別
    /// </summary>
    public abstract class MoveHandler
    {
        protected string _suffix;
        protected MoveHandler NextHandler
        { get; private set; }

        public abstract string Move(Role selected, List<Role> source, List<Role> target);

        protected MoveHandler(MoveHandler next, string suffix)
        {
            NextHandler = next;
            _suffix = suffix;
        }

        /// <summary>
        /// 把 item 從 source 移到 data
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="target">The target.</param>
        /// <param name="item">The item.</param>
        protected void MoveItem(Role item, List<Role> source, List<Role> target)
        {
            source.Remove(item);
            target.Add(item);
        }

        /// <summary>
        /// Gets the route string. 取得農夫一人過河的路徑結果字串
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        protected string GetRouteString(Role owner)
        {
            return string.Format("{0} {1}", owner.Name, _suffix);
        }

        /// <summary>
        /// Gets the route string. 取得農夫帶著東西過河的路徑結果字串
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="selected">The selected.</param>
        /// <param name="suffix">The suffix.</param>
        /// <returns></returns>
        //protected string GetRouteString(Role owner, Role selected, string suffix)
        //{
        //    return string.Format("{0} 帶著 {1} {2}", owner.Name, selected.Name, suffix);
        //}

        protected string GetRouteString(Role owner, Role selected)
        {
            return string.Format("{0} 帶著 {1} {2}", owner.Name, selected.Name, _suffix);
        }
    }

    /// <summary>
    /// 農夫是不是在同一邊
    /// </summary>   
    public class FarmerExistHandler : MoveHandler
    {
        public FarmerExistHandler(MoveHandler next, string suffix) : base(next, suffix)
        { }

        public override string Move(Role selected, List<Role> source, List<Role> target)
        {
            //農夫不在不能渡河
            if (!source.Any((x) => x.Name == RoleName.農夫))
            {
                return "不可渡河";
            }
            else
            {
                //農夫在的話，如果有下一個 handler 交給下一個，如果沒有就 return string.Empty
                if (NextHandler != null)
                {
                    return NextHandler.Move(selected, source, target);
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }

    /// <summary>
    /// 只有農夫一個人過河
    /// </summary>
    public class FarmerMoveHandler : MoveHandler
    {
        public FarmerMoveHandler(MoveHandler next, string suffix) : base(next, suffix)
        { }

        public override string Move(Role selected, List<Role> source, List<Role> target)
        {
            if (selected.Name == RoleName.農夫)
            {
                MoveItem(selected, source, target);
                return GetRouteString(selected);
            }
            else
            {
                if (NextHandler != null)
                {
                    return NextHandler.Move(selected, source, target);
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }

    /// <summary>
    /// 農夫帶著某個東西過河
    /// </summary>       
    public class OtherMoveHandler : MoveHandler
    {
        public OtherMoveHandler(MoveHandler next, string suffix) : base(next, suffix)
        { }

        public override string Move(Role selected, List<Role> source, List<Role> target)
        {
            if (selected.Name != RoleName.農夫)
            {
                var farmer = source.FindFarmer();
                MoveItem(farmer, source, target);
                MoveItem(selected, source, target);
                return GetRouteString(farmer, selected);
            }
            else
            {
                if (NextHandler != null)
                {
                    return NextHandler.Move(selected, source, target);
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }

    /// <summary>
    /// 將責任鏈組合起來
    /// </summary>
    public class MoveContext
    {
        private MoveHandler Handler
        { get; set; }

        public MoveContext(string suffix)
        {
            Handler = new FarmerExistHandler(new FarmerMoveHandler(new OtherMoveHandler(null, suffix), suffix), suffix);
        }

        public string Move(Role selected, List<Role> source, List<Role> target)
        {
            return Handler.Move(selected, source, target);
        }
    }
    #endregion
}
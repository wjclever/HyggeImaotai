using System;

namespace hygge_imaotai
{
    /// <summary>
    /// 自定义异常类
    /// </summary>
    public class CustomException:Exception
    {
        #region Constructor

        public CustomException(string message) : base(message)
        {
        }

        #endregion
    }
}

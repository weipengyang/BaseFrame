using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility
{
    /// <summary>
    /// 解析字符串的功能类。后期可通过此类获取应用程序的所有环境变量字符串数据。
    /// </summary>
    public static class StringParser
    {
        /// <summary>
        /// 留作后期扩展，便于对字符串的国际化。
        /// Expands ${xyz} style property values.
        /// </summary>
        public static string Parse(string input)
        {
            return input;
        }

        /// <summary>
        /// 内部调用了string.Format方法进行格式化，但是此方法包含了格式化错误处理。
        /// Calls <c>string.Format</c> on the result.
        /// This method is equivalent to:
        /// <code>return string.Format(formatstring, formatitems);</code>
        /// but additionally includes error handling.
        /// </summary>
        public static string Format(string formatstring, params object[] formatitems)
        {
            try
            {
                return String.Format(formatstring, formatitems);
            }
            catch (FormatException ex)
            {
                LoggingService.Warn(ex.Message, ex);

                StringBuilder b = new StringBuilder(formatstring);
                foreach (object formatitem in formatitems)
                {
                    b.Append("\nItem: ");
                    b.Append(formatitem);
                }
                return b.ToString();
            }
        }
    }
}

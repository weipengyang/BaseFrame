using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.ConfigHelper
{
    public class AppConfigData
    {
        private string _key;

        /// <summary>
        /// 配置项的名称：与配置项的Key对应。
        /// </summary>
        public string Key
        {
            get
            {
                return this._key;
            }
            set
            {
                if (value != this._key)
                {
                    this._key = value;
                }
            }
        }

        private string _value;

        /// <summary>
        /// 获取或设置当前配置项的值：此值是实际要保存到配置文件中的值。
        /// </summary>
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if (value != this._value)
                {
                    this._value = value;
                }
            }
        }

        public void SetValue(string value)
        {
            this.Value = value;
        }

        private AppConfigType _configType;

        /// <summary>
        /// 配置项类型：来源，存放位置。
        /// </summary>
        public AppConfigType ConfigType
        {
            get { return _configType; }
            set
            {
                _configType = value;
            }
        }

        /// <summary>
        /// 设置配置项的类型。
        /// </summary>
        /// <param name="configType">配置项类型。</param>
        public void SetConfigType(AppConfigType configType)
        {
            this.ConfigType = configType;
        }

        /// <summary>
        /// 值是否有效：不等于NullValue则有效；否则无效。
        /// </summary>
        public virtual bool IsValueValid
        {
            get
            {
                return Value != NullValue;
            }
        }

        /// <summary>
        /// 字符串的null值：null。
        /// </summary>
        public static readonly string NullValue = null;
    }
}

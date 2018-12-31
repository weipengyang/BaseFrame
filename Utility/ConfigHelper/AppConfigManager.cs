using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility.ConfigHelper
{
    public class AppConfigManager
    {
        private Dictionary<string, AppConfigData> collection;
        private static AppConfigManager instance = null;
        /// <summary>
        /// 应用程序配置文件默认名称。
        /// </summary>
        private static string AppConfigFileName = "";
        /// <summary>
        /// 所有配置归属的父元素名称：appSettings。
        /// </summary>
        private readonly string AllAppConfigElementName = "appSettings";

        /// <summary>
        /// 用户自定义配置文件默认名称。
        /// </summary>
        private static string UserConfigFileName = "User.config";

        /// <summary>
        /// 获取配置项操作类的实例。
        /// </summary>
        public static AppConfigManager Current
        {
            get
            {
                if (AppConfigManager.instance == null)
                {
                    AppConfigManager.instance = new AppConfigManager();
                }
                return AppConfigManager.instance;
            }
        }

        /// <summary>
        /// 获取应用程序配置文件名称。
        /// </summary>
        protected virtual string CurrentAppConfigFileName
        {
            get
            {
                return AppConfigManager.AppConfigFileName;
            }
        }

        /// <summary>
        /// 实例化配置操作类。
        /// </summary>
        private AppConfigManager()
        {
            if (string.IsNullOrEmpty(AppConfigFileName))
            {
                throw new InvalidOperationException("配置信息没有初始化：请先调用 AppConfigManager.InitAppConfigManager(...) 方法，完成初始化工作。");
            }

            collection = new Dictionary<string, AppConfigData>();
            LoadAllConfigs();
        }

        #region Public

        /// <summary>
        /// 初始化配置文件管理对象。
        /// </summary>
        /// <param name="appConfigFileName">应用程序配置文件名。</param>
        /// <param name="userConfigFileName">用户自定义配置文件名：默认值 User.config 。</param>
        public static void InitAppConfigManager(string appConfigFileName, string userConfigFileName = "User.config")
        {
            if (string.IsNullOrEmpty(appConfigFileName))
            {
                throw new ArgumentException("传入的配置文件名称参数无效：appConfigFileName值不能为空。", "appConfigFileName");
            }
            if (string.IsNullOrEmpty(userConfigFileName))
            {
                throw new ArgumentException("传入的用户自定义配置文件名称参数无效：userConfigFileName值不能为空。", "userConfigFileName");
            }
            AppConfigFileName = appConfigFileName;
            UserConfigFileName = userConfigFileName;
        }

        /// <summary>
        /// 添加或更新配置项：如果不存在，则添加到configType4NewAdded指定类型的位置。
        /// </summary>
        /// <param name="key">配置项对应的Key键。</param>
        /// <param name="configValue">配置项的新值。</param>
        /// <param name="configType4NewAdded">新增配置项的类型。</param>
        /// <returns>更新结果。</returns>
        public ConfigOperationResult AddOrUpdateConfig(string key,
            string configValue, AppConfigType configType4NewAdded)
        {
            if (this.collection.ContainsKey(key))
            {
                return UpdateConfig(key, configValue);
            }
            else
            {
                AppConfigData tmpAppData = new AppConfigData()
                {
                    ConfigType = configType4NewAdded,
                    Key = key,
                    Value = configValue,
                };
                if (configType4NewAdded.IsRegistryConfig())
                {
                    ////RegEditHelp.WriteRegedit(key, configValue);
                    throw new NotSupportedException("暂不支持注册表配置。");
                }
                else
                {
                    Configuration config = GetConfigurationInstance(configType4NewAdded);
                    config.AppSettings.Settings.Add(key, configValue);
                    RefreshConfigurationFile(config);
                }
                this.collection.Add(key, tmpAppData);
            }
            return ConfigOperationResult.Failed;
        }

        /// <summary>
        /// 添加或更新配置项：如果不存在，则默认添加到用户配置文件中。
        /// </summary>
        /// <param name="key">配置项对应的Key键。</param>
        /// <param name="configValue">配置项的新值。</param>
        /// <returns></returns>
        public ConfigOperationResult AddOrUpdateConfig(string key, string configValue)
        {
            return this.AddOrUpdateConfig(key, configValue, AppConfigType.InUserConfigs);
        }

        /// <summary>
        /// 配置项是否存在。
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool IsConfigExists(string key)
        {
            if (this.collection == null || !this.collection.ContainsKey(key))
            {
                return false;
            }
            var tmpConfig = this.collection[key];
            return tmpConfig != null && tmpConfig.IsValueValid;
        }

        public string Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            string result = null;
            if (this.collection.ContainsKey(name) && this.collection[name] != null)
            {
                result = this.collection[name].Value;
            }
            return result;
        }

        public string GetString(string settingName, string defaultValue)
        {
            string text = this.Get(settingName);
            if (string.IsNullOrEmpty(text))
            {
                return defaultValue;
            }
            return text;
        }

        public bool GetBoolean(string settingName, bool defaultValue)
        {
            string text = this.Get(settingName);
            if (string.IsNullOrEmpty(text))
            {
                return defaultValue;
            }
            string text2 = text.Trim().ToLower();
            return text2.Equals("true") || text2.Equals("yes");
        }

        public decimal GetDecimal(string settingName, decimal defaultValue)
        {
            string s = this.Get(settingName);
            decimal result;
            if (!decimal.TryParse(s, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        public int GetInt(string settingName, int defaultValue)
        {
            string s = this.Get(settingName);
            int result;
            if (!int.TryParse(s, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        public DateTime GetDate(string settingName, DateTime defaultValue)
        {
            string s = this.Get(settingName);
            DateTime result;
            if (!DateTime.TryParse(s, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        public float GetFloat(string settingName, float defaultValue)
        {
            string s = this.Get(settingName);
            float result;
            if (!float.TryParse(s, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        public double GetDouble(string settingName, double defaultValue)
        {
            string s = this.Get(settingName);
            double result;
            if (!double.TryParse(s, out result))
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>
        /// 是注册表中定义的配置类型。
        /// </summary>
        /// <param name="configType"></param>
        /// <returns></returns>
        public static bool IsRegistryConfig(Enum configType)
        {
            return IsNeededAppConfigType(configType, AppConfigType.InRegistryConfig);
        }

        #endregion

        private static bool IsNeededAppConfigType(Enum configType, AppConfigType neededConfigType)
        {
            if (configType.GetType() != typeof(AppConfigType))
            {
                return false;
            }
            AppConfigType tmpConfigType = (AppConfigType)configType;
            return tmpConfigType == neededConfigType;
        }

        /// <summary>
        /// 加载所有的配置项。
        /// </summary>
        private void LoadAllConfigs()
        {
            this.LoadAppConfigs();
        }

        /// <summary>
        /// 加载应用程序配置项。
        /// </summary>
        private void LoadAppConfigs()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            this.LoadConfigsFromFile(baseDirectory, this.CurrentAppConfigFileName, AppConfigType.InAppConfigs);
        }

        /// <summary>
        /// 从指定目录的文件，加载指定类型的配置项。
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <param name="configType">加载的配置项的类型。</param>
        private void LoadConfigsFromFile(string path, string filename, AppConfigType configType)
        {
            string baseDirectory = path;
            if (string.IsNullOrEmpty(path))
            {
                baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            }
            string path2 = Path.Combine(path, filename);
            if (!File.Exists(path2))
            {
                return;
            }
            ExeConfigurationFileMap file = new ExeConfigurationFileMap();
            file.ExeConfigFilename = path2;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(file, ConfigurationUserLevel.None);

            if (config.AppSettings.Settings == null)
            {
                return;
            }

            foreach (var tmpKey in config.AppSettings.Settings.AllKeys)
            {
                this.AddConfig2Buffer(tmpKey,
                    config.AppSettings.Settings[tmpKey].Value, configType);
            }
        }

        /// <summary>
        /// 将指定键-值配置对添加到缓存。
        /// </summary>
        /// <param name="key"></param>
        /// <param name="configValue"></param>
        /// <param name="configType"></param>
        private void AddConfig2Buffer(string key, string configValue, AppConfigType configType)
        {
            if (this.collection.ContainsKey(key))
            {
                var conflictConfig = this.collection[key];
                //LoggingService.Info(string.Format("更新冲突的配置项：{0}-{1}-{2}-->{3}-{4}-{5}。",
                //    conflictConfig.ConfigType, conflictConfig.Key,
                //    conflictConfig.Value, configType, key, configValue));

                if (conflictConfig.ConfigType != configType)
                {
                    var oldConfig = new AppConfigData()
                    {
                        ConfigType = conflictConfig.ConfigType,
                        Key = conflictConfig.Key,
                        Value = conflictConfig.Value,
                    };
                    conflictConfig.SetConfigType(configType);
                }
                conflictConfig.SetValue(configValue);
                return;
            }

            if (string.IsNullOrEmpty(configValue))
            {
                this.collection.Add(key, new AppConfigData()
                {
                    ConfigType = configType,
                    Key = key,
                    Value = AppConfigData.NullValue,
                });
            }
            else
            {
                this.collection.Add(key, new AppConfigData()
                {
                    ConfigType = configType,
                    Key = key,
                    Value = configValue,
                });
            }
        }

        /// <summary>
        /// 更新配置项。
        /// </summary>
        /// <param name="key">配置项对应的Key键。</param>
        /// <param name="configValue">配置项的新值。</param>
        /// <returns>更新结果。</returns>
        private ConfigOperationResult UpdateConfig(string key, string configValue)
        {
            if (this.collection.ContainsKey(key))
            {
                var oldConfig = this.collection[key];
                try
                {
                    if (oldConfig.ConfigType.IsRegistryConfig())
                    {
                        ////RegEditHelp.WriteRegedit(key, configValue);
                        throw new NotSupportedException("暂不支持注册表配置。");
                    }
                    else
                    {
                        Configuration config = GetConfigurationInstance(oldConfig.ConfigType);
                        config.AppSettings.Settings[key].Value = configValue;
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection(AllAppConfigElementName);//重新加载新的配置文件 
                    }
                    oldConfig.SetValue(configValue);
                    return ConfigOperationResult.Success;
                }
                catch (Exception err)
                {
                    //LoggingService.Error(string.Format("更新配置错误：{0}-{1}-{2}-->{3}-{4}。",
                    //    oldConfig.ConfigType, oldConfig.Key, oldConfig.Value, key, configValue), err);
                    throw;
                }
            }
            return ConfigOperationResult.NotFoundConfig;
        }

        /// <summary>
        /// 获取指定配置文件的操作类。
        /// </summary>
        /// <param name="configType"></param>
        /// <returns></returns>
        private Configuration GetConfigurationInstance(AppConfigType configType)
        {
            string filename = string.Empty;
            if (configType.IsApplicationConfig())
            {
                filename = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, AppConfigFileName);
            }
            else
            {
                filename = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, UserConfigFileName);
            }

            ExeConfigurationFileMap file = new ExeConfigurationFileMap();
            file.ExeConfigFilename = filename;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(file, ConfigurationUserLevel.None);
            return config;
        }

        /// <summary>
        /// 刷新指定的配置文件。
        /// </summary>
        /// <param name="config">配置文件操作类。</param>
        private void RefreshConfigurationFile(Configuration config)
        {
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(AllAppConfigElementName);//重新加载新的配置文件 
        }

    }


    /// <summary>
    /// 配置类型扩展方法。
    /// </summary>
    internal static class AppConfigTypeHelper
    {
        /// <summary>
        /// 是用户自定义配置类型。
        /// </summary>
        /// <param name="configType"></param>
        /// <returns></returns>
        public static bool IsUserConfig(this Enum configType)
        {
            return IsNeededAppConfigType(configType, AppConfigType.InUserConfigs);
        }

        /// <summary>
        /// 是注册表中定义的配置类型。
        /// </summary>
        /// <param name="configType"></param>
        /// <returns></returns>
        public static bool IsRegistryConfig(this Enum configType)
        {
            return IsNeededAppConfigType(configType, AppConfigType.InRegistryConfig);
        }

        /// <summary>
        /// 是应用程序定义的配置类型。
        /// </summary>
        /// <param name="configType"></param>
        /// <returns></returns>
        public static bool IsApplicationConfig(this Enum configType)
        {
            return IsNeededAppConfigType(configType, AppConfigType.InAppConfigs);
        }

        private static bool IsNeededAppConfigType(Enum configType, AppConfigType neededConfigType)
        {
            if (configType.GetType() != typeof(AppConfigType))
            {
                return false;
            }
            AppConfigType tmpConfigType = (AppConfigType)configType;
            return tmpConfigType == neededConfigType;
        }
    }

}

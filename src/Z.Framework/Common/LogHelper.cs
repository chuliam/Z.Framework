using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z.Framework.Common
{
    /// <summary>
    /// 日志文件工具类
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// 日志文件类型
        /// </summary>
        public enum LogFileType
        {
            Information,
            Trace,
            Warning,
            Error
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public LogHelper()
        {
            this.FilePath = AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <param name="msg">消息正文</param>
        public void WriteLog(string fileName, string msg)
        {
            string filePath = this.FilePath + fileName + " " + DateTime.Today.ToString("yyyyMMdd") + ".Log";

            try
            {
                using (System.IO.StreamWriter sw = System.IO.File.AppendText(filePath))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
                    sw.WriteLine(msg);
                }
            }
            catch
            { }

        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="logFileType">日志文件类型</param>
        /// <param name="msg">消息正文</param>
        public void WriteLog(LogFileType logFileType, string msg)
        {
            this.WriteLog(logFileType.ToString(), msg);
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="logFileType">日志文件类型</param>
        /// <param name="msg">消息正文</param>
        public static void Write(LogFileType logFileType, string msg)
        {
            LogHelper utils = new LogHelper();
            utils.WriteLog(logFileType, msg);
        }

    }
}

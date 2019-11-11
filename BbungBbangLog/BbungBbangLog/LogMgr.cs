using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BbungBbangLog
{
    public class LogMgr
    {
        /// <summary>
        /// 로그 타입
        /// </summary>
        public enum LogType
        {
            GUI,        // GUI 로그
            EXE,        // 행동 로그
        }

        public static string LOG_GUI_FILENAME = "GUI_LOG";      // GUI 로그파일명
        public static string LOG_EXE_FILENAME = "EXE_LOG";      // EXE 로그파일명
        public static string LOG_EXTENSION = ".log";            // 로그파일확장자

        static void Main(string[] args)
        {
        }

        /// <summary>
        /// 로그를 쓰는 메소드
        /// </summary>
        /// <param name="logType">로그의 타입(enum LogType)</param>
        /// <param name="strLog">로그 내용</param>
        /// <param name="bIsWriteDate">로그파일의 내용에 시간을 넣을지 유무</param>
        public static void WriteLog(LogType logType, string strLog, bool bIsWriteDate)
        {
            string strPath = string.Empty;
            DateTime dateNow = DateTime.Now;
            string strDateNow = string.Format("_{0}{1:D2}{2:D2}", dateNow.Year, dateNow.Month, dateNow.Day);

            switch (logType)
            {
                case LogType.GUI:
                    strPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + LOG_GUI_FILENAME + strDateNow + LOG_EXTENSION;
                    break;
                case LogType.EXE:
                    strPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + LOG_EXE_FILENAME + strDateNow + LOG_EXTENSION;
                    break;
                default:
                    return;
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(strPath);
            try
            {
                if (directoryInfo.Exists == false)
                    Directory.CreateDirectory(strPath);

                WriteLog(strPath, strLog, bIsWriteDate);
            }
            catch { }
        }

        /// <summary>
        /// 로그를 쓰는 메소드
        /// </summary>
        /// <param name="strPath">로그 파일 경로</param>
        /// <param name="strLog">로그 내용</param>
        /// <param name="bIsWriteDate">로그파일의 내용에 시간을 넣을지 유무</param>
        public static void WriteLog(string strPath, string strLog, bool bIsWriteDate)
        {
            if (string.IsNullOrEmpty(strLog) == false &&
                string.IsNullOrEmpty(strPath) == false)
            {
                FileInfo fileInfo = new FileInfo(strPath);

                try
                {
                    if (fileInfo.Exists == false)
                    {
                        using (StreamWriter writer = new StreamWriter(strPath))
                        {
                            string strTemp = string.Empty;
                            if (bIsWriteDate)
                                strTemp = string.Format("[{0}] {1}", DateTime.Now, strLog);
                            else
                                strTemp = strLog;
                            writer.WriteLine(strTemp);
                        }
                    }
                    else
                    {
                        using (StreamWriter writer = File.AppendText(strPath))
                        {
                            string strTemp = string.Empty;
                            if (bIsWriteDate)
                                strTemp = string.Format("[{0}] {1}", DateTime.Now, strLog);
                            else
                                strTemp = strLog;
                            writer.WriteLine(strTemp);
                        }
                    }
                }
                catch { }
            }
        }
    }
}

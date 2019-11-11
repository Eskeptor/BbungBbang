using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BbungBbangXml
{
    public class XmlMgr
    {
        public static string LOGIN_FILE = "BBAccount.xml";  // 계정용 XML 파일명
        public static string XML_ROOT = "BBAInfo";          // XML 파일의 최상단 루트
        public static string XML_SUB = "Account";           // XML 파일의 서브 키
        public static string XML_SUB_ID = "ID";             // XML 에서 계정의 ID
        public static string XML_SUB_PW = "PW";             // XML 에서 계정의 PW

        /// <summary>
        /// LoadAccount의 결과값으로 사용할 enum
        /// </summary>
        public enum LoadResult
        {
            Success,            // 성공
            NoData,             // 로드할 데이터 없음
            Fail_FileLoad       // 파일 로드 실패
        }

        static void Main(string[] args)
        {
        }

        /// <summary>
        /// 계정을 불러오는 메소드
        /// (각 배열의 짝수구간에는 ID, 홀수구간에는 PW가 들어있음)
        /// </summary>
        /// <param name="listAccount">불러온 계정을 저장할 리스트(ref)</param>
        /// <returns>로드 결과</returns>
        public static int LoadAccount(ref List<string> listAccount)
        {
            int nResult = (int)LoadResult.NoData;
            string strPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + LOGIN_FILE;
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(strPath);

                XmlNodeList xmlRootNode = xml.SelectNodes(XML_ROOT);
                foreach (XmlNode xmlAccNode in xmlRootNode)
                {
                    listAccount.Add(xmlAccNode[XML_SUB_ID].InnerText);
                    listAccount.Add(xmlAccNode[XML_SUB_PW].InnerText);
                }

                if (listAccount.Count > 0)
                    nResult = (int)LoadResult.Success;
                else
                    nResult = (int)LoadResult.NoData;
            }
            catch 
            {
                nResult = (int)LoadResult.Fail_FileLoad;
            }

            return nResult;
        }

        /// <summary>
        /// 계정 정보를 저장하는 메소드
        /// (각 배열의 짝수구간에는 ID, 홀수구간에는 PW가 들어있음)
        /// </summary>
        /// <param name="listAccount"></param>
        /// <returns></returns>
        public static bool SaveAccount(List<string> listAccount)
        {
            bool bResult = false;
            string strPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + LOGIN_FILE;
            XmlDocument xml = new XmlDocument();
            try
            {
                XmlNode xmlRootNode = xml.CreateElement(XML_ROOT);
                int nSize = listAccount.Count / 2;

                for (int i = 0; i < nSize; i++)
                {
                    XmlNode xmlAccNode = xml.CreateElement(XML_SUB);
                    XmlNode xmlAccNodeID = xml.CreateElement(XML_SUB_ID);
                    XmlNode xmlAccNodePW = xml.CreateElement(XML_SUB_PW);

                    xmlAccNodeID.InnerText = listAccount[i * 2];
                    xmlAccNodePW.InnerText = listAccount[i * 2 + 1];
                    xmlAccNode.AppendChild(xmlAccNodeID);
                    xmlAccNode.AppendChild(xmlAccNodePW);
                    xml.AppendChild(xmlAccNode);
                }
                xml.Save(strPath);
            }
            catch
            {
                bResult = false;
            }

            return bResult;
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BbungBbangXml
{
    public class XmlMgr
    {
        public static string LOGIN_FILE = "BBAccount.xml";
        public static string XML_ROOT = "Account";
        public static string XML_SUB_ID = "ID";
        public static string XML_SUB_PW = "PW";

        public enum LoadResult
        {
            Success, NoData, Fail_FileLoad
        }

        static void Main(string[] args)
        {
        }

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

        
    }
}

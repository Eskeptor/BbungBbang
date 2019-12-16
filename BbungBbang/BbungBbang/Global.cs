using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace BbungBbang
{
    public class Global
    {
        public static string APP_KEY_FORM_NAME = "FormName";
        public static string PATH_USER_FOLDER = "User";
        public static string PATH_DATA_FOLDER = "Data";
        public static string PATH_DONATION_FILE = "Donation.dat";
        public static string PATH_DONATION_DATA = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar +
                                                  PATH_DATA_FOLDER + Path.DirectorySeparatorChar + PATH_DONATION_FILE;

        public enum Page
        {
            Main,       // 메인 페이지
            Input,      // 기입 화면
            Review,     // 현황 화면
            Settings    // 설정 화면
        }

        public enum DonationType
        {
            Normal,         // 주정 헌금
            Thanks,         // 감사 헌금
            MissonWork,     // 선교 헌금
            Build,          // 건축 헌금
            Etc,            // 기타 헌금
            Season,         // 절기 헌금
        }

        public enum ListType
        {
            None,
            UserList,       // 유저 목록 리스트
            UserHistory,    // 유저 히스토리 리스트
        }

        public static Color COLOR_BASIC_BLUE = Color.FromArgb(0, 174, 219);
    }

    [Serializable]
    public class Donation
    {
        public int Money { get; set; }
        public System.DateTime DonationTime { get; set; }
        public Global.DonationType DonationType { get; set; }
    }

    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public List<Donation> Donations = new List<Donation>();

        public User(string strName)
        {
            Name = strName;
        }
    }
}

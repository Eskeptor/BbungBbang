﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

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
            Tithe,          // 십일조
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

        public enum UserDataThreadType
        {
            Load,           // 데이터 로드
            Save,           // 데이터 저장
        }

        public enum InputConfirmType
        {
            Modify,         // 수정 확인
            Add,            // 추가 확인
        }

        public static Color COLOR_BASIC_BLUE = Color.FromArgb(0, 174, 219);
        public static int USER_IDX_NONE = -1;
        public static string[] STR_DONATION_TYPE = new string[]
        {
            "십일조",
            "주정",
            "감사",
            "선교",
            "건축",
            "기타",
            "절기",
        };

        /// <summary>
        /// 셀을 하나로 합쳐주면서 해당셀에 값을 넣는 메소드
        /// </summary>
        /// <param name="worksheet">해당 셀이 존재하는 워크시트</param>
        /// <param name="cell1">병합할 셀의 시작점</param>
        /// <param name="cell2">병합할 셀의 종료점</param>
        /// <param name="nTextInRow">텍스트가 들어갈 셀의 행</param>
        /// <param name="nTextInCol">텍스트가 들어갈 셀의 열</param>
        /// <param name="nFontSize">텍스트의 폰트 크기</param>
        /// <param name="bBold">텍스트의 폰트 굵기</param>
        /// <param name="strText">텍스트</param>
        /// <param name="clr">셀의 색상</param>
        /// <param name="align">정렬</param>
        public static void MergeCell(ref Excel.Worksheet worksheet, 
            object cell1, 
            object cell2, 
            int nTextInRow, 
            int nTextInCol, 
            int nFontSize, 
            bool bBold, 
            string strText,
            Color clr,
            Excel.XlHAlign align = Excel.XlHAlign.xlHAlignCenter)
        {
            if (worksheet != null)
            {
                Excel.Range excelRange = worksheet.get_Range(cell1, cell2);
                excelRange.Merge(true);
                excelRange.Font.Size = nFontSize;
                excelRange.Font.Bold = bBold;
                excelRange.Interior.Color = ColorTranslator.ToOle(clr);
                worksheet.Cells[nTextInRow, nTextInCol] = strText;
                excelRange.HorizontalAlignment = align;
            }
        }


        /// <summary>
        /// 셀에 선을 긋는 메소드
        /// </summary>
        /// <param name="worksheet">선을 그을 워크시트</param>
        /// <param name="cell1">선을 그을 셀범위의 시작점</param>
        /// <param name="cell2">선을 그을 셀범위의 종료점</param>
        /// <param name="lineStyle">선 스타일</param>
        /// 
        public static void DrawLineCell(ref Excel.Worksheet worksheet,
            object cell1,
            object cell2,
            dynamic lineStyle,
            dynamic lineWeight,
            bool bIsOnlySide = false)
        {
            if (worksheet != null)
            {
                Excel.Range excelRange = worksheet.get_Range(cell1, cell2);


                if (bIsOnlySide)
                {
                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = lineWeight;
                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = lineWeight;
                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = lineWeight;
                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = lineWeight;


                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = lineStyle;
                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = lineStyle;
                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = lineStyle;
                    excelRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = lineStyle;
                }
                else
                {
                    excelRange.Borders.Weight = lineWeight;
                    excelRange.Borders.LineStyle = lineStyle;
                }
            }
        }
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

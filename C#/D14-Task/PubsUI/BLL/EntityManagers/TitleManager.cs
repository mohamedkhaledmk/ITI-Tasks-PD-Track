using BLL.Entities;
using BLL.EntityLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL.EntityManagers
{
    public static  class TitleManager
    {
        static DBManager Manager = new();
        public static TitleList SelectALLTitles ()
        {
            try
            {
                return DataTableToTitleList(
                Manager.ExecuteDataTable("SelectALLTitles"));
            }
            catch
            {

            }
            return new();
        }

        public static bool UpdateTitlePrice (string TitleID , decimal Price)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@TitleID"] = TitleID,
                    ["@Price"] = Price
                };
                return Manager.ExecuteNonQuery("UpdateTitlePrice" , Parameters) > 0;
                    
            }
            catch
            {

            }
            return false;
        }

        #region Mapping Functions
        internal static TitleList DataTableToTitleList(DataTable dt)
        {
            TitleList Titles = new TitleList();
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    Titles.Add(DataRowToTitle(item));
                }
            }
            catch
            {

            }
            return Titles;
        }

        internal static Title DataRowToTitle(DataRow Dr)
        {
            Title T = new() { TitleName = String.Empty };
            try
            {
                T.TitleID = Dr["title_id"]?.ToString() ?? "NA";
                T.TitleName = Dr["title"]?.ToString() ?? "NA";

                T.Type = Dr["type"]?.ToString();
                T.PubID = Dr["pub_id"]?.ToString();

                T.Price = Dr.Field<decimal?>("price");
                T.Advance = Dr.Field<decimal?>("advance");
                T.Royalty = Dr.Field<int?>("royalty");
                T.YTD_Sales = Dr.Field<int?>("ytd_sales");

                T.Notes = Dr["notes"]?.ToString();
                T.Pubdate = Dr.Field<DateTime?>("pubdate");

                T.State = EntitySate.UnChanged;

            }
            catch
            {

            }
            return T;

        }

        #endregion
    }
}

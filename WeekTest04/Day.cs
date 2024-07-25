using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTest04
{
    public class Day
    {
        private  Dictionary<string, string> dayMap = new Dictionary<string, string>();
        private  Dictionary<string, string> dayMonthMap = new Dictionary<string, string>();
        private  Dictionary<string, string> yearMap = new Dictionary<string, string>();

        public void FillingMaps()
        {
            dayMap.Add("ראשון", "אחד");
            dayMap.Add("שני", "שני");
            dayMap.Add("שלישי", "שלישי");
            dayMap.Add("רביעי", "רביעי");
            dayMap.Add("חמישי", "חמישי");
            dayMap.Add("שישי", "ששי");

            dayMonthMap.Add("1", "יום אחד");
            dayMonthMap.Add("2", "שני ימים");
            dayMonthMap.Add("3", "שלשה ימים");
            dayMonthMap.Add("4", "ארבעה ימים");
            dayMonthMap.Add("5", "חמשה ימים");
            dayMonthMap.Add("6", "ששה ימים");
            dayMonthMap.Add("7", "שבעה ימים");
            dayMonthMap.Add("8", "ימים שמנה");
            dayMonthMap.Add("9", "ימים תשעה");
            dayMonthMap.Add("10", "עשרה ימים");
            dayMonthMap.Add("11", "אחד עשר יום");
            dayMonthMap.Add("12", "שנים עשר יום");
            dayMonthMap.Add("13", "שלשה עשר יום");
            dayMonthMap.Add("14", "ארבעה עשר יום");
            dayMonthMap.Add("15", "חמשה עשר יום");
            dayMonthMap.Add("16", "ששה עשר יום");
            dayMonthMap.Add("17", "שבעה עשר יום");
            dayMonthMap.Add("18", "שמנה עשר יום");
            dayMonthMap.Add("19", "תשעה עשר יום");
            dayMonthMap.Add("20", "עשרים יום");
            dayMonthMap.Add("21", "אחד ועשרים יום");
            dayMonthMap.Add("22", "שנים ועשרים יום");
            dayMonthMap.Add("23", "שלשה ועשרים יום");
            dayMonthMap.Add("24", "ארבעה ועשרים יום");
            dayMonthMap.Add("25", "חמשה ועשרים יום");
            dayMonthMap.Add("26", "ששה ועשרים יום");
            dayMonthMap.Add("27", "שבעה ועשרים יום");
            dayMonthMap.Add("28", "שמנה ועשרים יום");
            dayMonthMap.Add("29", "תשעה ועשרים יום");
            dayMonthMap.Add("30", "");



            yearMap.Add("תשפ_ד", "חמשת אלפים ושבע מאות ושמנים וארבע");
            yearMap.Add("תשפ_ה", "חמשת אלפים ושבע מאות ושמנים וחמש");
            yearMap.Add("תשפ_ו", "חמשת אלפים ושבע מאות ושמנים ושש");
            yearMap.Add("תשפ_ז", "חמשת אלפים ושבע מאות ושמנים ושבע");
            yearMap.Add("תשפ_ח", "חמשת אלפים ושבע מאות ושמנים ושמנה");
            yearMap.Add("תשפ_ט", "חמשת אלפים ושבע מאות ושמנים ותשע");
            yearMap.Add("תשצ", "חמשת אלפים ושבע מאות ותשעים");
            yearMap.Add("תשצ_א", "חמשת אלפים ושבע מאות ותשעים ואחת");
            yearMap.Add("תשצ_ב", "חמשת אלפים ושבע מאות ותשעים ושתים");





        }

        public string CreateResult()
        {
            if(Month == "30")
            {

            }
            return $"ב{dayMap[DayStr]} בשבת {dayMonthMap[DayMonth]} לירח {Month} שנת {yearMap[Year]} לבריאת העולם";
        }
        
        public Day()
        {
            FillingMaps();
        }

        public string DayStr {  get; set; }
        public string DayMonth { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Result { get { return CreateResult(); } set { } }
    }
}

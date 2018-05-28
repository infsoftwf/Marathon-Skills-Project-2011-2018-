using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarathonProject.Global
{
    public static class globals
    {
        public static string s_GlobalMarathonName = "Marathon Skills 2011";
        public static string s_GlobalMarathonDate = "21.06.2018 06:00:00";

        public static string getTime(TimeSpan time)
        {
            return string.Concat("До старта марафона: ", time.Days != 0 ? String.Format("{0} дней {1} часов {2} минут", time.Days, time.Hours, time.Minutes)
                : String.Format("{0} часов {1} минут", time.Hours, time.Minutes));
        }

        public static string cSQLLSPTR = $"Data Source=localhost;MultipleActiveResultSets=True;Initial Catalog=marathon;Integrated Security=True",
            g_PathCharityFolder = "../../marathon-skills-2018-charity-data",
            g_PathLongMarathon = "../../how-long-is-a-marathon-images",
            g_PathMarathonInfo = "../../MarathonInfo",
            g_PathMapIcons = "../../map-icons",
            g_PathGenderIcons = "../../marathon-skills-2018-gender-icons",
            g_PathBMIIcons = "../../bmi_icons",
            g_PathStatus = "../../marathon-skills-2018-status-icons",
            g_PathFlags = "../../flags";
    }
}

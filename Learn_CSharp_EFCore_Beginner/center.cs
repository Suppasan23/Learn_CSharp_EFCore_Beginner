using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Learn_CSharp_EFCore_Beginner
{
    static class center
    {
        public static bool isExecuted = false;

        public static string CurrentUserID;
        public static string CurrentUserName;
        public static string CurrentFullName;

        public static void DoubleBuffered(this DataGridView dgv, bool settting)
        {
            Type type = dgv.GetType();
            PropertyInfo pi = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, settting, null);

        }
    }
}

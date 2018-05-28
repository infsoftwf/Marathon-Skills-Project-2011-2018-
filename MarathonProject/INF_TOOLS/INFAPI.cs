using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarathonProject.INF_TOOLS.WinAPI;

namespace MarathonProject.INF_TOOLS
{
    public static class INFAPI
    {
        [Flags]
        private enum ExFlags : int
        {
            emaxSymbol = 1,
            emaxUpper = 1,
            emaxLower = 1,
            emaxDigit = 1
        }

        /// <summary>
        /// Проверка наличия требований
        /// </summary>
        /// <param name="m_Str">Строка</param>
        /// <param name="bIsSymbol">Проверка на символы</param>
        /// <param name="bIsUpper">Проверка на заглавные символы</param>
        /// <param name="bIsMaxLength">Проверка на длину</param>
        /// <returns></returns>
        public static bool m_isPresentEx(
            string m_Str,
            bool bIsSymbol = false,
            bool bIsUpper = false,
            bool bIsLower = false,
            bool bIsDigit = false,
            bool bIsMaxLength = false,
            int MaxLength = 0xff)
        {
            try
            {
                if (m_Str != null && m_Str != string.Empty)
                {
                    int cSym = 0, cUpper = 0, cLower = 0, cDigit = 0;

                    foreach (var c in m_Str)
                    {
                        if (bIsSymbol)
                            if (cSym < (int)ExFlags.emaxSymbol && (c == '!' | c == '$' | c == '@' | c == '&' | c == '#' | c == '^' | c == '%'))
                                cSym++;

                        if (bIsUpper)
                            if (cUpper < (int)ExFlags.emaxUpper && Char.IsUpper(c))
                                cUpper++;

                        if (bIsLower)
                            if (cLower < (int)ExFlags.emaxLower && Char.IsLower(c))
                                cLower++;

                        if (bIsDigit)
                            if (cDigit < (int)ExFlags.emaxDigit && Char.IsDigit(c))
                                cDigit++;
                    }

                    if ((bIsSymbol ? cSym >= ((int)ExFlags.emaxSymbol) : true)
                        && (bIsUpper ? cUpper >= ((int)ExFlags.emaxUpper) : true)
                        && (bIsLower ? cLower >= ((int)ExFlags.emaxLower) : true)
                        && (bIsDigit ? cDigit >= ((int)ExFlags.emaxDigit) : true)
                        && (bIsMaxLength ? m_Str.Length == MaxLength : true))
                        return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(string.Format("GetLastError: {0}", System.Runtime.InteropServices.Marshal.GetLastWin32Error()),
                    string.Format("HRESULT: 0x{0:X8}", ex.HResult));
            }
            return (!bIsSymbol && !bIsUpper && !bIsLower && !bIsDigit && m_Str != null) ? true : false;
        }

        public static bool IsInBox(float x, float y, float w, float h)
        {
            POINT MousePosition;
            GetCursorPos(out MousePosition);
            ScreenToClient(GetForegroundWindow(), ref MousePosition);
            return (MousePosition.X >= x && MousePosition.X <= x + w && MousePosition.Y >= y && MousePosition.Y <= y + h);
        }

        public static void RemoveHandlerList(Control c)
        {
            try
            {
                EventHandlerList list = (EventHandlerList)typeof(Control).GetProperty("Events", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(c, null);
                typeof(EventHandlerList).GetMethod("Dispose").Invoke(list, null);
            }
            catch (Exception) { }
        }

        public static void __forceExit(Type ty_out)
        {
            var enumerator = Application.OpenForms;
            for (int ifrm = enumerator.Count; ifrm > 0; ifrm--)
            {
                try
                {
                    if (enumerator[ifrm] == null)
                        continue;

                    if (enumerator[ifrm].GetType() != typeof(MainMenu))
                    {
                        INFAPI.RemoveHandlerList(enumerator[ifrm]);
                        (enumerator[ifrm]).Close();
                    }
                }
                catch (Exception ex) { }
            }
        }
    }
}

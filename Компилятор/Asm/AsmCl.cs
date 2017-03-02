using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Asm
{
    public class AsmCl
    {
        public byte[] runCode(string []tex,int tbc)
        {
          //  string[] text = new string[tbc];
            byte[] reg = new byte[16];
            Regex[] reqqq = new Regex[7];
            Match[] m = new Match[7];
            reqqq[0] = new Regex(@"^LD\s+r(\d{1,2}),\s*#(\d{1,3})$", RegexOptions.IgnoreCase);
            reqqq[1] = new Regex(@"^MOV\s+r(\d{1,2}),\s*r(\d{1,2})$", RegexOptions.IgnoreCase);
            reqqq[2] = new Regex(@"^ADD\s+r(\d{1,2}),\s*r(\d{1,2})$", RegexOptions.IgnoreCase);
            reqqq[3] = new Regex(@"^SUB\s+r(\d{1,2}),\s*r(\d{1,2})$", RegexOptions.IgnoreCase);
            reqqq[4] = new Regex(@"^BR\s+metka(\d{1,2})$", RegexOptions.IgnoreCase);
            reqqq[5] = new Regex(@"^BRGZ\s+metka(\d{1,2}),\s*r(\d{1,2})$", RegexOptions.IgnoreCase);
            reqqq[6] = new Regex(@"^METKA\s+M(\d{1,2})$", RegexOptions.IgnoreCase);

            for (int i = 0; i < tbc; i++) //количество строк
            {
                for (int j = 0; j < 7; j++)
                {
                    m[j] = reqqq[j].Match(tex[i].Trim());
                    if (m[j].Success)
                    {
                        if (j == 0)
                        {
                            int nr = int.Parse(m[j].Groups[1].Value);
                            byte val = byte.Parse(m[j].Groups[2].Value);
                            reg[nr] = val;
                        }
                        if (j == 1)
                        {
                            int nr = int.Parse(m[j].Groups[1].Value);
                            int val = byte.Parse(m[j].Groups[2].Value);
                            reg[nr] = reg[val];
                        }
                        if (j == 2)
                        {
                            int nr = int.Parse(m[j].Groups[1].Value);
                            byte val = byte.Parse(m[j].Groups[2].Value);
                            reg[nr] += reg[val];
                        }
                        if (j == 3)
                        {
                            int nr = int.Parse(m[j].Groups[1].Value);
                            byte val = byte.Parse(m[j].Groups[2].Value);
                            reg[nr] -= reg[val];
                        }
                        if (j == 4)
                        {
                            int nr = int.Parse(m[j].Groups[1].Value);//номер метки на которую прыгаем
                            for (int ii = 0; ii < tbc; ii++)
                            {
                                var reg6 = reqqq[6].Match(tex[ii].Trim());
                                if (reg6.Success)
                                {
                                    int nr1 = int.Parse(reg6.Groups[1].Value);
                                    if (nr == nr1)
                                    {
                                        i = ii;
                                    }
                                }
                            }
                        }
                        if (j == 5)
                        {
                            int nr = int.Parse(m[j].Groups[1].Value);//номер метки на которую прыгаем
                            for (int ii = 1; ii < tbc; ii++)
                            {
                                var reg6 = reqqq[6].Match(tex[ii].Trim());
                                int sd = reg[int.Parse(m[j].Groups[2].Value)];

                                if (reg6.Success && sd > 0)
                                {
                                    int nr1 = int.Parse(reg6.Groups[1].Value);
                                    if (nr == nr1)
                                    {
                                        i = ii;
                                    }
                                }
                            }
                        }
                    }
                }
            }

           
            return reg;
        }

    }
}

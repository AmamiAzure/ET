﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCLR.Editor.Template
{
    public static class TemplateUtil
    {

        public static string ReplaceRegion(string resultText, string region, string replaceContent)
        {
            int startIndex = resultText.IndexOf("//!!!{{" + region);
            if (startIndex == -1)
            {
                throw new Exception($"region:{region} start not find");
            }
            int endIndex = resultText.IndexOf("//!!!}}" + region);
            if (endIndex == -1)
            {
                throw new Exception($"region:{region} end not find");
            }
            int replaceStart = resultText.IndexOf('\n', startIndex);
            int replaceEnd = resultText.LastIndexOf('\n', endIndex);
            if (replaceStart == -1 || replaceEnd == -1)
            {
                throw new Exception($"region:{region} not find");
            }
            if (resultText.Substring(replaceStart, replaceEnd - replaceStart) == replaceContent)
            {
                return resultText;
            }
            resultText = resultText.Substring(0, replaceStart) + "\n" + replaceContent + "\n" + resultText.Substring(replaceEnd);
            return resultText;
        }
    }
}

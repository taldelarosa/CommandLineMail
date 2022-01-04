using System;
using System.Drawing;

namespace DrawingHelper
{
    public class Header
    {

        public Section[] Sections;
        int lines;

        /// <summary>
        /// Instantiates a Header of full console width, and a specified number of lines long
        /// </summary>
        /// <param name="Lines">Number of rows the header should take up in the console window</param>
        public Header(int Lines)
        {
            lines = Lines;
            Section mainSection = new Section(0,0,Console.WindowWidth,Lines);
            this.Sections = new Section[] {mainSection};
        }

        public Header(int Lines, Section[] Sections)
        {
            lines = Lines;
            this.Sections = Sections;
        }

    }
}
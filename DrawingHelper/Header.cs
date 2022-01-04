using System;
using System.Drawing;

namespace DrawingHelper
{
    public class Header
    {

        public Section[] Sections;
        int lines;
        SectionFormattingStyle Style;

        /// <summary>
        /// Instantiates a Header of full console width, and a specified number of lines long
        /// </summary>
        /// <param name="Lines">Number of rows the header should take up in the console window</param>
        public Header(int Lines)
        {
            lines = Lines;
            Section mainSection = new Section("SingleDefaultHeader",SectionFormattingStyle.AnchorMiddle,0,0,Console.WindowWidth,Lines);
            this.Sections = new Section[] {mainSection};
            Style = SectionFormattingStyle.AnchorMiddle;
        }

        public Header(int Lines, Section[] Sections, SectionFormattingStyle Style)
        {
            lines = Lines;
            this.Sections = Sections;
            this.Style = Style;
        }

        private void SetSectionBounds()
        {
            //AnchorLeft - All tags should be written
                // Draw Section[0] Tag:Data at <0,0>
                // Draw Section [1] Tag:Data as far left as remaining Length allows
                // Draw Section [2] Tag:Data as far left as remaining Length allows

            // for(int i = 0; i < this.Sections.Length; i++)
            // {
            //     Section PreviousSection;
            //     if(i > 0)
            //     {
            //         PreviousSection = this.Sections[i-1];
            //     }

            //     switch(this.Sections[i].Style)
            //     {
            //         case SectionFormattingStyle.AnchorLeft:
            //             break;
            //         case SectionFormattingStyle.AnchorMiddle:
            //             break;
            //         case SectionFormattingStyle.AnchorRight:
            //             break;
            //     }
            // }
        }

        public void UpdateSection(int Index, string Text)
        {
            this.Sections[Index].Update(Text);
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp9Project
{
    public class slideData
    {
        public string CharacterName
        { get; set; }
        public string CharacterImagePath
        { get; set; }
        public string BackgroundImagePath
        { get; set; }
        public string DialogText
        { get; set; }
        public slideType Type
        { get; set; }
    }
}
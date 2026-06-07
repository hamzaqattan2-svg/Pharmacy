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
    public class slideManager
    {
        List<slideData> slides = new List<slideData>();
        int currentIndex = 0;

        public slideManager()
        {
        }
        public void AddSlide(slideData slide)
        {
            slides.Add(slide);
        }
        public slideData GetCurrentSlide()
        {
            return slides[currentIndex];
        }
        public bool GoToNext()
        {
            if (currentIndex < slides.Count - 1)
            {
                currentIndex++;
                return true;
            }
            return false;
        }
        public bool GoToBack()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                return true;
            }
            return false;
        }
    }
}

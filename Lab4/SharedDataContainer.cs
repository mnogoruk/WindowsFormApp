using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class SharedDataContainer
    {
        public delegate void MethodChangedData();
        public static event MethodChangedData onActivateRectangle;

        public static Size RectSize { get; set; }

        public static bool ActiveRed { get; set; }
        public static bool ActiveGreen { get; set; }
        public static bool ActiveBlue { get; set; }

        private static bool activeRectangle;
        public static bool ActiveRectangle {
            get { return activeRectangle; }
            set {
                if (value)
                {
                    onActivateRectangle();
                }
                activeRectangle = value;
            }
        }

        public static int CircleRadius { get; set; }

        public static bool ActiveSquare { get; set; }
        public static bool ActiveLength { get; set; }

        public static String InputText { get; set; }
        public static bool ActiveUpper { get; set; }
        public static bool ActiveReverse { get; set; }

        public static List<Color> RectColorList()
        {
            List<Color> list = new List<Color>();
            if (ActiveRed)
                list.Add(Color.Red);
            if (ActiveGreen)
                list.Add(Color.Green);
            if (ActiveBlue)
                list.Add(Color.Blue);
            return list;
        }

        private static SizeForm sizeForm = null;
        public static SizeForm SizeForm
        {
            get
            {
                if (sizeForm is null || sizeForm.IsDisposed)
                {
                    sizeForm = new SizeForm();
                }
                return sizeForm;

            }
            set
            {
                sizeForm = value;
            }
        }

        private static ReverseForm reverseForm = null;
        public static ReverseForm ReverseForm
        {
            get
            {
                if (reverseForm is null || reverseForm.IsDisposed)
                {
                    reverseForm = new ReverseForm();
                }
                return reverseForm;

            }
            set
            {
                reverseForm = value;
            }
        }

        private static InputForm inputForm = null;
        public static InputForm InputForm
        {
            get
            {
                if (inputForm is null || inputForm.IsDisposed)
                {
                    inputForm = new InputForm();
                }
                return inputForm;

            }
            set
            {
                inputForm = value;
            }
        }

        private static MainForm mainForm = null;
        public static MainForm MainForm
        {
            get
            {
                if (mainForm is null || mainForm.IsDisposed)
                {
                    mainForm = new MainForm();
                }
                return mainForm;

            }
            set
            {
                mainForm = value;
            }
        }

        private static CalcForm calcForm = null;
        public static CalcForm CalcForm
        {
            get
            {
                if (calcForm is null || calcForm.IsDisposed)
                {
                    calcForm = new CalcForm();
                }
                return calcForm;

            }
            set
            {
                calcForm = value;
            }
        }

        private static AboutForm aboutForm = null;
        public static AboutForm AboutForm
        {
            get
            {
                if (aboutForm is null || aboutForm.IsDisposed)
                {
                    aboutForm = new AboutForm();
                }
                return aboutForm;

            }
            set
            {
                aboutForm = value;
            }
        }

    }
}

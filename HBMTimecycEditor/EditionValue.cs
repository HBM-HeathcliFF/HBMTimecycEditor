using System.Collections.Generic;
using System.Text.RegularExpressions;
using yt_DesignUI;

namespace HBMTimecycEditor
{
    enum EditionValueType
    {
        AMBIENT_R = 1,
        AMBIENT_G = 2,
        AMBIENT_B = 3,
        AMBIENT_OBJ_R = 4,
        AMBIENT_OBJ_G = 5,
        AMBIENT_OBJ_B = 6,
        SPRITE_BRIGHT = 24,
        SHADOW = 25,
        LIGHT_SHADING = 26,
        POLE_SHADING = 27,
        DRAW_DIST = 28,
        FOG_DIST = 29,
        LIGHT_ON_GROUND = 30,
        POSTFX1_A = 41,
        POSTFX1_R = 42,
        POSTFX1_G = 43,
        POSTFX1_B = 44,
        POSTFX2_A = 45,
        POSTFX2_R = 46,
        POSTFX2_G = 47,
        POSTFX2_B = 48
    }

    enum RangeType
    {
        DOUBLE,
        INT,
        UNSIGNED_INT
    }

    class EditionValue
    {
        public EditionValue(EditionValueType type, RangeType range, ref EgoldsGoogleTextBox egtBox)
        {
            Type = type;
            EGTextBox = egtBox;
            Range = range;
        }

        public void Filter()
        {
            switch (Range)
            {
                case RangeType.DOUBLE:
                    if (Regex.IsMatch(EGTextBox.Text, "[^0-9---.]"))
                    {
                        EGTextBox.Text = EGTextBox.Text.Remove(EGTextBox.Text.Length - 1);
                        EGTextBox.SelectionStart = EGTextBox.TextLength;
                    }
                    break;
                case RangeType.INT:
                    if (Regex.IsMatch(EGTextBox.Text, "[^0-9--]"))
                    {
                        EGTextBox.Text = EGTextBox.Text.Remove(EGTextBox.Text.Length - 1);
                        EGTextBox.SelectionStart = EGTextBox.TextLength;
                    }
                    break;
                case RangeType.UNSIGNED_INT:
                    if (Regex.IsMatch(EGTextBox.Text, "[^0-9]"))
                    {
                        EGTextBox.Text = EGTextBox.Text.Remove(EGTextBox.Text.Length - 1);
                        EGTextBox.SelectionStart = EGTextBox.TextLength;
                    }
                    break;
            }
        }

        public static bool CheckValidData(List<EditionValue> editionValues)
        {
            bool result = true;
            foreach (var editionValue in editionValues)
            {
                if (editionValue.EGTextBox.Text != "")
                {
                    switch (editionValue.Range)
                    {
                        case RangeType.DOUBLE:
                            if (double.Parse(editionValue.EGTextBox.Text.Replace(".", ",")) < -0.1 ||
                                double.Parse(editionValue.EGTextBox.Text.Replace(".", ",")) > 25.4)
                            {
                                editionValue.EGTextBox.Text = "-0.1";
                                result = false;
                            }
                            break;
                        case RangeType.INT:
                            if (int.Parse(editionValue.EGTextBox.Text) < -3600 ||
                                int.Parse(editionValue.EGTextBox.Text) > 3600)
                            {
                                editionValue.EGTextBox.Text = "0";
                                result = false;
                            }
                            break;
                        case RangeType.UNSIGNED_INT:
                            if (int.Parse(editionValue.EGTextBox.Text) > 255)
                            {
                                editionValue.EGTextBox.Text = "0";
                                result = false;
                            }
                            break;
                    }
                }
            }
            return result;
        }

        public int Index { get; set; }
        public int Length { get; set; }
        public int LineNumber { get; set; }
        public EditionValueType Type { get; set; }
        public RangeType Range { get; }
        public EgoldsGoogleTextBox EGTextBox { get; set; }
    }
}
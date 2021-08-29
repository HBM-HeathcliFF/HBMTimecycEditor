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
        //DIRECT_LIGHT_COLOR_R = 7, // Пустышка
        //DIRECT_LIGHT_COLOR_G = 8, // Пустышка
        //DIRECT_LIGHT_COLOR_B = 9, // Пустышка
        SKY_TOP_R = 10,
        SKY_TOP_G = 11,
        SKY_TOP_B = 12,
        SKY_BOTTOM_R = 13,
        SKY_BOTTOM_G = 14,
        SKY_BOTTOM_B = 15,
        SUN_CORE_R = 16,
        SUN_CORE_G = 17,
        SUN_CORE_B = 18,
        SUN_CORONA_R = 19,
        SUN_CORONA_G = 20,
        SUN_CORONA_B = 21,
        SUN_SIZE = 22,
        SPRITE_SIZE = 23,
        SPRITE_BRIGHT = 24,
        SHADOW = 25,
        LIGHT_SHADING = 26,
        POLE_SHADING = 27,
        DRAW_DIST = 28,
        FOG_DIST = 29,
        LIGHT_ON_GROUND = 30,
        LOW_CLOUDS_R = 31,
        LOW_CLOUDS_G = 32,
        LOW_CLOUDS_B = 33,
        FLUFFY_CLOUDS_R = 34,
        FLUFFY_CLOUDS_G = 35,
        FLUFFY_CLOUDS_B = 36,
        WATER_R = 37,
        WATER_G = 38,
        WATER_B = 39,
        WATER_A = 40,
        POSTFX1_A = 41,
        POSTFX1_R = 42,
        POSTFX1_G = 43,
        POSTFX1_B = 44,
        POSTFX2_A = 45,
        POSTFX2_R = 46,
        POSTFX2_G = 47,
        POSTFX2_B = 48,
        //CLOUD_ALPHA = 49, // Пустышка
        UPPER_CLOUDS_ALPHA = 50,
        WATER_FOG_ALPHA = 51,
        ILLUMINATION = 52 // не прописан в timecyc.dat, но может быть добавлен и изменён
    }

    enum RangeType
    {
        UPPER_DOUBLE,
        LOWER_DOUBLE,
        UNSIGNED_DOUBLE,
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
                case RangeType.UPPER_DOUBLE:
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
                case RangeType.UNSIGNED_DOUBLE:
                    if (Regex.IsMatch(EGTextBox.Text, "[^0-9.]"))
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
                    try
                    {
                        switch (editionValue.Range)
                        {
                            case RangeType.UPPER_DOUBLE:
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
                            case RangeType.UNSIGNED_DOUBLE:
                                if (double.Parse(editionValue.EGTextBox.Text.Replace(".", ",")) > 2.55)
                                {
                                    editionValue.EGTextBox.Text = "0";
                                    result = false;
                                }
                                break;
                        }
                    }
                    catch (System.Exception)
                    {
                        editionValue.EGTextBox.Text = "0";
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
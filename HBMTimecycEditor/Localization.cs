using System.Collections.Generic;
using System.Windows.Forms;
using yt_DesignUI;

namespace HBMTimecycEditor
{
    enum LocalizationLanguage
    {
        RUS,
        ENG
    }

    static class Localization
    {
        private static Dictionary<string, string> s_dictionaryRus = new Dictionary<string, string>()
        {
            ["GTA path"] = "Путь к GTA",
            ["Browse"] = "Обзор",
            ["Weather"] = "Погода",
            ["Time"] = "Время",
            ["Multiselect"] = "Выбрать несколько",
            ["Show"] = "Показать",
            ["Draw distance"] = "Дистанция прорисовки",
            ["Fog distance"] = "Дистанция тумана",
            ["Sprite brightness"] = "Яркость освещения",
            ["Light on ground"] = "Свет на земле",
            ["Edit"] = "Изменить",
            ["All"] = "Все",
            ["Midnight"] = "Полночь",
            ["5 AM"] = "5:00",
            ["6 AM"] = "6:00",
            ["7 AM"] = "7:00",
            ["Midday"] = "Полдень",
            ["7 PM"] = "19:00",
            ["8 PM"] = "20:00",
            ["10 PM"] = "22:00",
            ["Weather:"] = "Погода:",
            ["Time:"] = "Время:",
            ["Reset"] = "Сбросить",
            ["Ok"] = "Ок"
        };
        private static Dictionary<string, string> s_dictionaryEng = new Dictionary<string, string>()
        {
            ["Путь к GTA"] = "GTA path",
            ["Обзор"] = "Browse",
            ["Погода"] = "Weather",
            ["Время"] = "Time",
            ["Выбрать несколько"] = "Multiselect",
            ["Показать"] = "Show",
            ["Дистанция прорисовки"] = "Draw distance",
            ["Дистанция тумана"] = "Fog distance",
            ["Яркость освещения"] = "Sprite brightness",
            ["Свет на земле"] = "Light on ground",
            ["Изменить"] = "Edit",
            ["Все"] = "All",
            ["Полночь"] = "Midnight",
            ["5:00"] = "5 AM",
            ["6:00"] = "6 AM",
            ["7:00"] = "7 AM",
            ["Полдень"] = "Midday",
            ["19:00"] = "7 PM",
            ["20:00"] = "8 PM",
            ["22:00"] = "10 PM",
            ["Погода:"] = "Weather:",
            ["Время:"] = "Time:",
            ["Сбросить"] = "Reset",
            ["Ок"] = "Ok"
        };

        public static LocalizationLanguage Language { get; set; } = LocalizationLanguage.ENG;

        public static string Translate(this string line)
        {
            switch (Language)
            {
                case LocalizationLanguage.RUS:
                    if (s_dictionaryRus.ContainsKey(line))
                        return s_dictionaryRus[line];
                    else
                        return line;
                case LocalizationLanguage.ENG:
                    if (s_dictionaryEng.ContainsKey(line))
                        return s_dictionaryEng[line];
                    else
                        return line;
                default:
                    return line;
            }
        }

        public static void TranslateAllControls(Control parent)
        {
            if (parent is EgoldsGoogleTextBox)
            {
                ((EgoldsGoogleTextBox)parent).TextPreview = Translate(((EgoldsGoogleTextBox)parent).TextPreview);
                parent.Refresh();
            }
            else if (parent is ComboBox)
            {
                var items = ((ComboBox)parent).Items;
                for (int i = 0; i < items.Count; i++)
                {
                    items[i] = items[i].ToString().Translate();
                }
            }
            else
            {
                parent.Text = Translate(parent.Text);
            }

            foreach (Control control in parent.Controls)
            {
                TranslateAllControls(control);
            }
        }
    }
}
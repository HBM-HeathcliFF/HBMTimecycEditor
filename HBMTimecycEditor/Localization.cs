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
            ["Shadow"] = "Тень",
            ["Light shading"] = "Лёгкое затенение",
            ["Pole shading"] = "Тень от столбов",
            ["PostFX1"] = "Пост обработка 1",
            ["PostFX2"] = "Пост обработка 2",
            ["Ambient"] = "Эмбиент",
            ["Ambient Obj"] = "Эмбиент объектов",
            ["Red"] = "Красный",
            ["Green"] = "Голубой",
            ["Blue"] = "Зелёный",
            ["Alpha"] = "Альфа",
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
            ["Ok"] = "Ок",
            ["Done!"] = "Готово!",
            ["Enter a value in at least one of the fields"] = "Введите значение хотя бы в одно из полей",
            ["Path to GTA where timecyc.dat will be edited"] = "Путь к гта, в которой будет редактироваться timecyc.dat",
            ["Open explorer to select a folder with GTA"] = "Открыть проводник для выбора папки с гта",
            ["Change application language"] = "Изменить язык приложения",
            ["Weather available for change"] = "Погода, доступная для изменения",
            ["Time of day available for change"] = "Время суток, доступное для изменения",
            ["Multiple weather and time of day selection"] = "Выбор нескольких погод и времён суток",
            ["Show a window for selecting several weather and time of day"] = "Показать окно выбора нескольких погод и времён суток",
            ["Draw distance [-3600; 3600]"] = "Дистанция прорисовки [-3600; 3600]",
            ["Distance at which fog appears in the game [-3600; 3600]"] = "Дистанция, на которой в игре появляется туман [-3600; 3600]",
            ["Brightness of light from lanterns, traffic lights, etc. [-0.1; 25.4]"] = "Яркость света от фонарей, светофоров и тд. [-0.1; 25.4]",
            ["Brightness of the circles on the ground from lanterns, traffic lights, etc. [-0.1; 25.4]"] = "Яркость кругов на земле от фонарей, светофоров и тд. [-0.1; 25.4]",
            ["The visibility of the main shadow falling from moving and some fixed objects"] = "Видимость основной тени, падающей от подвижных и некоторых неподвижных предметов",
            ["Imaginary volume of the shadow. Works only at low effect settings"] = "Мнимая объёмность тени. Работает только на низких настройках эффектов",
            ["Shadow falling from lamp posts at low effect settings"] = "Тень, падающая от фонарных столбов на низких настройках эффектов",
            ["Ambient of the world [0; 255]"] = "Эмбиент мира [0; 255]",
            ["Ambient of skins and vehicles [0; 255]"] = "Эмбиент скинов и транспорта [0; 255]",
            ["Post processing [0; 255]"] = "Пост обработка [0; 255]",
            ["Post processing [0; 255]"] = "Пост обработка [0; 255]",
            ["Make changes to timecyc.dat"] = "Внести изменения в timecyc.dat"
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
            ["Тень"] = "Shadow",
            ["Лёгкое затенение"] = "Light shading",
            ["Тень от столбов"] = "Pole shading",
            ["Пост обработка 1"] = "PostFX1",
            ["Пост обработка 2"] = "PostFX2",
            ["Эмбиент"] = "Ambient",
            ["Эмбиент объектов"] = "Ambient Obj",
            ["Красный"] = "Red",
            ["Голубой"] = "Green",
            ["Зелёный"] = "Blue",
            ["Альфа"] = "Alpha",
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
            ["Ок"] = "Ok",
            ["Готово!"] = "Done!",
            ["Введите значение хотя бы в одно из полей"] = "Enter a value in at least one of the fields",
            ["Путь к гта, в которой будет редактироваться timecyc.dat"] = "Path to GTA where timecyc.dat will be edited",
            ["Открыть проводник для выбора папки с гта"] = "Open explorer to select a folder with GTA",
            ["Изменить язык приложения"] = "Change application language",
            ["Погода, доступная для изменения"] = "Weather available for change",
            ["Время суток, доступное для изменения"] = "Time of day available for change",
            ["Выбор нескольких погод и времён суток"] = "Multiple weather and time of day selection",
            ["Показать окно выбора нескольких погод и времён суток"] = "Show a window for selecting several weather and time of day",
            ["Дистанция прорисовки [-3600; 3600]"] = "Draw distance [-3600; 3600]",
            ["Дистанция, на которой в игре появляется туман [-3600; 3600]"] = "Distance at which fog appears in the game [-3600; 3600]",
            ["Яркость света от фонарей, светофоров и тд. [-0.1; 25.4]"] = "Brightness of light from lanterns, traffic lights, etc. [-0.1; 25.4]",
            ["Яркость кругов на земле от фонарей, светофоров и тд. [-0.1; 25.4]"] = "Brightness of the circles on the ground from lanterns, traffic lights, etc. [-0.1; 25.4]",
            ["Видимость основной тени, падающей от подвижных и некоторых неподвижных предметов"] = "The visibility of the main shadow falling from moving and some fixed objects",
            ["Мнимая объёмность тени. Работает только на низких настройках эффектов"] = "Imaginary volume of the shadow. Works only at low effect settings",
            ["Тень, падающая от фонарных столбов на низких настройках эффектов"] = "Shadow falling from lamp posts at low effect settings",
            ["Эмбиент мира [0; 255]"] = "Ambient of the world [0; 255]",
            ["Эмбиент скинов и транспорта [0; 255]"] = "Ambient of skins and vehicles [0; 255]",
            ["Пост обработка [0; 255]"] = "Post processing [0; 255]",
            ["Пост обработка [0; 255]"] = "Post processing [0; 255]",
            ["Внести изменения в timecyc.dat"] = "Make changes to timecyc.dat"
        };

        public static LocalizationLanguage Language { get; set; } = LocalizationLanguage.ENG;
        public static bool IsChanged { get; set; } = false;

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
                ((EgoldsGoogleTextBox)parent).Invalidate();
            }
            else if (parent is ComboBox)
            {
                var items = ((ComboBox)parent).Items;
                for (int i = 0; i < items.Count; i++)
                {
                    IsChanged = true;
                    items[i] = items[i].ToString().Translate();
                    IsChanged = false;
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

        public static void TranslateAllControlsWithToolTips(Control parent, ref ToolTip toolTip)
        {
            toolTip.SetToolTip(parent, toolTip.GetToolTip(parent).Translate());
            if (parent is EgoldsGoogleTextBox)
            {
                ((EgoldsGoogleTextBox)parent).TextPreview = Translate(((EgoldsGoogleTextBox)parent).TextPreview);
                ((EgoldsGoogleTextBox)parent).Invalidate();
            }
            else if (parent is ComboBox)
            {
                var items = ((ComboBox)parent).Items;
                for (int i = 0; i < items.Count; i++)
                {
                    IsChanged = true;
                    items[i] = items[i].ToString().Translate();
                    IsChanged = false;
                }
            }
            else
            {
                parent.Text = Translate(parent.Text);
            }

            foreach (Control control in parent.Controls)
            {
                TranslateAllControlsWithToolTips(control, ref toolTip);
            }
        }
    }
}
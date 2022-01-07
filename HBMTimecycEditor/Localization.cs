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
            ["Illumination"] = "Освещение",
            ["Upper clouds alpha"] = "Альфа верхних облаков",
            ["Water"] = "Вода",
            ["Water fog alpha"] = "Туман над водой",
            ["Sky top"] = "Небо (верх)",
            ["Sky bottom"] = "Небо (низ)",
            ["Cloud alpha"] = "Прозрачность облаков",
            ["Low clouds"] = "Нижние облака",
            ["Fluffy clouds"] = "Верхние облака",
            ["Sun core color"] = "Внутренний цвет солнца",
            ["Sun corona color"] = "Внешний цвет солнца",
            ["Sun size"] = "Размер солнца",
            ["Sprite size"] = "Размер освещения",
            ["Red"] = "Красный",
            ["Green"] = "Голубой",
            ["Blue"] = "Зелёный",
            ["Alpha"] = "Альфа",
            ["Apply"] = "Применить",
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
            ["The visibility of the main shadow falling from moving and some fixed objects [0; 255]"] = "Видимость основной тени, падающей от подвижных и некоторых неподвижных предметов [0; 255]",
            ["Imaginary volume of the shadow. Works only at low effect settings [0; 255]"] = "Мнимая объёмность тени. Работает только на низких настройках эффектов [0; 255]",
            ["Shadow falling from lamp posts at low effect settings [0; 255]"] = "Тень, падающая от фонарных столбов на низких настройках эффектов [0; 255]",
            ["Ambient of the world [0; 255]"] = "Эмбиент мира [0; 255]",
            ["Ambient of skins and vehicles [0; 255]"] = "Эмбиент скинов и транспорта [0; 255]",
            ["Post processing [0; 255]"] = "Пост обработка [0; 255]",
            ["Post processing [0; 255]"] = "Пост обработка [0; 255]",
            ["Brightness of directional lighting on moving objects [0; 2.55]"] = "Яркость направленного освещения на подвижных предметах [0; 2.55]",
            ["Opacity of main clouds or cloud top [0; 255]"] = "Непрозрачность основных облаков или верхнего облачного слоя [0; 255]",
            ["Water layer color [0; 255]"] = "Цвет водяного слоя [0; 255]",
            ["The brightness and number of layers of white fog above the water [0; 255]"] = "Яркость и количество слоёв белого тумана над водой [0; 255]",
            ["Upper sky color [0; 255]"] = "Цвет верхней части неба [0; 255]",
            ["The color of the lower part of the sky and fog [0; 255]"] = "Цвет нижней части неба и тумана [0; 255]",
            ["The opacity of distant clouds. Changing this setting does not lead to any noticeable changes in the game [0; 255]"] = "Непрозрачность дальних облаков. Изменение данной настройки не приводит ни к каким заметным изменениям в игре [0; 255]",
            ["The color of distant, oblong clouds [0; 255]"] = "Цвет дальних, продолговатых облаков [0; 255]",
            ["The color of the top of the main, broad clouds. Not used in GTA SA [0; 255]"] = "Цвет верхней части основных, широких облаков. Не используется в GTA SA [0; 255]",
            ["The color of the inside of the sun [0; 255]"] = "Цвет внутренней части солнца [0; 255]",
            ["The color of the outer part of the sun, as well as the color of the glare emanating from it and the glare reflected on the water [0; 255]"] = "Цвет внешней части солнца, а также цвет бликов, исходящих от него и бликов, отражающихся на воде [0; 255]",
            ["Sun size [-0.1; 12.7]"] = "Размер солнца [-0.1; 12.7]",
            ["Sprite size [-0.1; 12.7]"] = "Размер освещения [-0.1; 12.7]",
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
            ["Освещение"] = "Illumination",
            ["Альфа верхних облаков"] = "Upper clouds alpha",
            ["Вода"] = "Water",
            ["Туман над водой"] = "Water fog alpha",
            ["Небо (верх)"] = "Sky top",
            ["Небо (низ)"] = "Sky bottom",
            ["Прозрачность облаков"] = "Cloud alpha",
            ["Нижние облака"] = "Low clouds",
            ["Верхние облака"] = "Fluffy clouds",
            ["Внутренний цвет солнца"] = "Sun core color",
            ["Внешний цвет солнца"] = "Sun corona color",
            ["Размер солнца"] = "Sun size",
            ["Размер освещения"] = "Sprite size",
            ["Красный"] = "Red",
            ["Голубой"] = "Green",
            ["Зелёный"] = "Blue",
            ["Альфа"] = "Alpha",
            ["Применить"] = "Apply",
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
            ["Видимость основной тени, падающей от подвижных и некоторых неподвижных предметов [0; 255]"] = "The visibility of the main shadow falling from moving and some fixed objects [0; 255]",
            ["Мнимая объёмность тени. Работает только на низких настройках эффектов [0; 255]"] = "Imaginary volume of the shadow. Works only at low effect settings [0; 255]",
            ["Тень, падающая от фонарных столбов на низких настройках эффектов [0; 255]"] = "Shadow falling from lamp posts at low effect settings [0; 255]",
            ["Эмбиент мира [0; 255]"] = "Ambient of the world [0; 255]",
            ["Эмбиент скинов и транспорта [0; 255]"] = "Ambient of skins and vehicles [0; 255]",
            ["Пост обработка [0; 255]"] = "Post processing [0; 255]",
            ["Пост обработка [0; 255]"] = "Post processing [0; 255]",
            ["Яркость направленного освещения на подвижных предметах [0; 2.55]"] = "Brightness of directional lighting on moving objects [0; 2.55]",
            ["Непрозрачность основных облаков или верхнего облачного слоя [0; 255]"] = "Opacity of main clouds or cloud top [0; 255]",
            ["Цвет водяного слоя [0; 255]"] = "Water layer color [0; 255]",
            ["Яркость и количество слоёв белого тумана над водой [0; 255]"] = "The brightness and number of layers of white fog above the water [0; 255]",
            ["Цвет верхней части неба [0; 255]"] = "Upper sky color [0; 255]",
            ["Цвет нижней части неба и тумана [0; 255]"] = "The color of the lower part of the sky and fog [0; 255]",
            ["Непрозрачность дальних облаков. Изменение данной настройки не приводит ни к каким заметным изменениям в игре [0; 255]"] = "The opacity of distant clouds. Changing this setting does not lead to any noticeable changes in the game [0; 255]",
            ["Цвет дальних, продолговатых облаков [0; 255]"] = "The color of distant, oblong clouds [0; 255]",
            ["Цвет верхней части основных, широких облаков. Не используется в GTA SA [0; 255]"] = "The color of the top of the main, broad clouds. Not used in GTA SA [0; 255]",
            ["Цвет внутренней части солнца [0; 255]"] = "The color of the inside of the sun [0; 255]",
            ["Цвет внешней части солнца, а также цвет бликов, исходящих от него и бликов, отражающихся на воде [0; 255]"] = "The color of the outer part of the sun, as well as the color of the glare emanating from it and the glare reflected on the water [0; 255]",
            ["Размер солнца [-0.1; 12.7]"] = "Sun size [-0.1; 12.7]",
            ["Размер освещения [-0.1; 12.7]"] = "Sprite size [-0.1; 12.7]",
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
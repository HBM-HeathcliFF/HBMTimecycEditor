# HBM Timecyc Editor
HBM Timecyc Editor - приложение для редактирования файла timecyc.dat из игры GTA San Andreas. 
## Функционал
Значения из timecyc.dat, подлежащие изменению:
- Дистанция прорисовки/Draw distance.
- Дистанция тумана (Fog distance) - дистанция, с которой в игре появляется туман.
- Яркость освещения (Sprite brightness) - яркость света от фонарей и светофоров.
- Свет на земле (Light on ground) - яркость освещаемого фонарями и светофорами участка земли.

Значения для изменения вводятся в поля с соответствующими названиями (текст внутри полей). Для изменения значений в timecyc.dat нужно нажать кнопку Изменить (Edit). Можно оставить одно/несколько полей пустыми, для изменения значений достаточно одного заполненного поля. Значения, поля для которых не заполнены, изменяться не будут. При вводе некорректных значений появится окно MessageBox'а с допустимыми для этого поля значениями.

Для изменения значений нужно выбрать погоду и время суток. В приложении есть 2 режима выбора времени и погоды:
- Обычный - выбор всех/определённой погоды и выбор всего/определённого времени. Выбор осуществляется через ComboBox'ы.
- Выборать несколько (Multiselect) - выбор сразу нескольких погод и времён суток. Выбор осуществляется через CheckBox'ы. 

Включить/выключить режим выбора нескольких погод/времён суток (Multiselect) можно с помощью переключателя с соответствующим названием. При включении откроется окно для выбора. Чтобы после закрытия вызвать это окно ещё раз, нужно нажать кнопку Показать (Show). Кнопка Сбросить (Reset) в доп.окне снимает галочки со всех выбранных вариантов. Кнопка Ок, как и "крестик", закрывает окно. После закрытия доп.окна значения сохраняются.

Чтобы указать путь к GTA, в которой будет изменяться timecyc.dat, нужно ввести его вручную в верхнем поле приложения, либо нажать на кнопку Обзор (Browse) и выбрать папку с GTA. Об указании неверного пути через Обзор (Browse) Вам сообщит окно MessageBox'а. При указании неверного пути вручную пропадёт/не отобразиться панель редактирования timecyc.dat.

В правом верхнем углу кнопка смены языка. В данный момент в программе доступно 2 языка: русский и английский. Выбранный язык и путь к GTA сохраняются после перезапуска.

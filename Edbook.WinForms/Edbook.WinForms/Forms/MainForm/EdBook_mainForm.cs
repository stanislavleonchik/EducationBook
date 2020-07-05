using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; // Загружаем библиотеку FontAwesome.Sharp, загруженную через NuGet. Эта штука позволяет сделать классный дизайн.

namespace Edbook.WinForms.Forms.MainForm
{
    public partial class EdBook_mainForm : Form
    {
        #region Поля
        private IconButton currentButton;   // Некая абстрактная кнопка, с которой мы будем работать
        private IconButton currentSubButton;// Некая абстрактная саб-кнопка, с которой мы будем работать
        private Panel leftBorderButton;     // Левая граница для кнопок, которая будет являться у нас панелью
        private Form currentChildForm;      // Поле для работы с дочерней формой
        #endregion
        #region Конструктор формы
        public EdBook_mainForm()
        {
            InitializeComponent();

            leftBorderButton = new Panel();               // Создёам панель, что будет выступать границей для кнопок
            leftBorderButton.Size = new Size(7, 60);      // Задаём размер для этой панели

            panelMain.Controls.Add(leftBorderButton);     // Вписываем данную панель в panelMain

            //this.Text = string.Empty;                   // Убираем верхнюю панель
            //this.ControlBox = false;                    // Убираем ControlBox
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle    // Ограничиваем растягивание формы
            //    (this.Handle).WorkingArea;              // до пределов рабочего пространства монитора

            this.MinimumSize = new Size(800, 600);        // Задаём минимальные размер сжатия формы
            label_userName.Text = currentUser.username;   // Отображаем, под каким пользователем была произведена авторизация

            #region Закрываем панели, которые не должны отображаться, если пользователь не является администратором
            if (currentUser.username != "Администратор")
            {
                iconButton_books.Visible = false;
                iconButton_reports.Visible = false;
                iconButton1_panelOfOthers.Visible = false;
                panel_ofOthers.Height = 60;
            }
            iconButton2_panelOfOthers.Visible = false;    // А ВОТ НЕ УСПЕЛ
            #endregion


        }
        #endregion
        #region Закрытие саб-меню
        private void SubMenuClose()
        {
            if (panel_ofBooks.Visible == true)
                panel_ofBooks.Visible = false;
            if (panel_ofOthers.Visible == true)
                panel_ofOthers.Visible = false;
        }
        #endregion
        #region Метод, отвечающий за изменения отображения активных кнопок
        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                SubMenuClose();                                                     // Скрываем саб-меню, если таковые открыты
                DisableButtonActivation();                                          // Снимаем выделение с кнопки всякий раз, когда у нас активируется иная кнопка
                DisableSubButtonActivation();                                       // Снимаем выделение с кнопки из саб-меню панели навигации

                // Кнопка
                currentButton = (IconButton)sender;                                 // Sender'ом этого метода будет IconButton 
                currentButton.BackColor = Styles.ColorSchemes.clrBlueLight;         // Меняем цвет кнопки, который будет браться из класса цветовых схем и отправляться сюда
                currentButton.ForeColor = color;                                    // Меняем цвет шрифта
                currentButton.TextAlign = ContentAlignment.MiddleCenter;            // Выравниваем содержимое по центру
                currentButton.IconColor = color;                                    // Меняем цвет иконки, который будет браться из класса цветовых схем сюда
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;// Меняем отношение текста к изображению.
                currentButton.ImageAlign = ContentAlignment.MiddleRight;            // Вставляем иконку справа по горизонтали и в центре по вертикали
                // Левая граница
                leftBorderButton.BackColor = color;                                 // Меняем цвет левой границы кнопки, который будет браться из класса цветовых схем сюда
                leftBorderButton.Location = new Point(0, currentButton.Location.Y); // Изменение локации границы  (без этой штуки граница будет появляться не в тех координатах)
                leftBorderButton.Visible = true;                                    // Отображаем всё это
                leftBorderButton.BringToFront();                                    // Выдвигаем на передний план, чтобы было видно
                // Иконка на верхней панели
                iconCurrentChildForm.IconChar = currentButton.IconChar;             // Иконка будет принимать иконку кнопки
                iconCurrentChildForm.IconColor = currentButton.IconColor;           // Иконка будет принимать соответствующий цвет
                
            }
        }
        #endregion
        #region Дизайн для кнопок из саб-меню
        private void ActivateSubButton(object sender, Color color)
        {
            DisableSubButtonActivation();                                              // Снимаем активацию с кнопки саб-меню

            if (sender != null)
            {
                // Кнопка
                currentSubButton = (IconButton)sender;                                 // Sender'ом этого метода будет IconButton 
                currentSubButton.BackColor = Styles.ColorSchemes.clrBlueDarkest2;      // Меняем цвет кнопки, который будет браться из класса цветовых схем и отправляться сюда
                currentSubButton.ForeColor = color;                                    // Меняем цвет шрифта
                currentSubButton.IconColor = color;                                    // Меняем цвет иконки, который будет браться из класса цветовых схем сюда
                // Иконка на верхней панели
                iconCurrentChildForm.IconChar = currentButton.IconChar;               // Иконка будет принимать иконку кнопки
                iconCurrentChildForm.IconColor = currentButton.IconColor;             // Иконка будет принимать соответствующий цвет

            }
        }
        #endregion
        #region Метод закрытия кнопки саб-меню
        private void DisableSubButtonActivation()                                       // Метод снятия выделения с кнопки
        {
            if (currentSubButton != null)                                               // Проверка на то, что есть какая-то выделенная кнопка
            {
                currentSubButton.BackColor = Styles.ColorSchemes.clrBlueDarkest;        // Возвращаем станадртный цвет заденго фона из класса с цветовой схемой
                currentSubButton.ForeColor = Styles.ColorSchemes.clrOfText;             // Возвращаем станадртный цвет текста из класса с цветовой схемой
                currentSubButton.IconColor = Styles.ColorSchemes.clrOfText;             // Возвращаем цвет иконки такой же, какой и цвет текста (берётся из класса цвет.схемы)
            }
        }
        #endregion
        #region Метод отключения отображения активности кнопки
        private void DisableButtonActivation()                                       // Метод снятия выделения с кнопки
        {
            if (currentButton != null)                                               // Проверка на то, что есть какая-то выделенная кнопка
            {
                currentButton.BackColor = Styles.ColorSchemes.clrBlueDark;           // Возвращаем станадртный цвет заденго фона из класса с цветовой схемой
                currentButton.ForeColor = Styles.ColorSchemes.clrOfText;             // Возвращаем станадртный цвет текста из класса с цветовой схемой
                currentButton.TextAlign = ContentAlignment.MiddleCenter;             // Выравниваем содержимое по центру
                currentButton.IconColor = Styles.ColorSchemes.clrOfText;             // Возвращаем цвет иконки такой же, какой и цвет текста (берётся из класса цвет.схемы)
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText; // Возвращаем отношение текста к иконке в изначальную форму
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;              // Выравниваем иконку по левой стороне
            }
        }
        #endregion
        #region Загрузка формы
        private void EdBook_mainForm_Load(object sender, EventArgs e)
        {
            // Первоначальная загрузка формы
            SubMenuClose(); // Закрываем все саб-панели
            ActivateButton(iconButton_main, Styles.ColorSchemes.ColorSchemesOfTabs.color1); // При запуске программы кнопка "главного" раздела навигации будет помечена активной
            iconCurrentChildForm.IconColor = Styles.ColorSchemes.ColorSchemesOfTabs.color1; // Иконка будет соответствовать цвету левой границы кнопки
            label_nameMenu.Text = iconButton_main.Text;                                     // Присваиваем имя верхней панеле согласно тексту кнопки "Главная"
        }
        #endregion
        #region DllImport (user32.DLL) - Захват формы и её перемещение по экрану
        // Данная часть когда позволит нам перемещать форму, используя panelbar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] // Захват формы
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]    // Отправка сообщений
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                               // Метод захвата формы
            SendMessage(this.Handle, 0x112, 0xf012, 0);     // Передача сообщений о захвате формы и действий с ней
        }
        #endregion
        #region Кнопки
        #region Метод открытия дочерних форм
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)   // Если текущая форма не null
            {
                currentChildForm.Close();   // Закрываем текущую открытую дочернюю форму
            }
            currentChildForm = childForm;                       // Присваиваем currentChildForm ту форму, что хотим открыть
            childForm.TopLevel = false;                         // Отключаем TopLevel вывод формы
            childForm.FormBorderStyle = FormBorderStyle.None;   // Убираем границы формы
            childForm.Dock = DockStyle.Fill;                    // Форма будет заполняться на нужной панели работы
            panelWorkSpace.Controls.Add(childForm);             // Добавляем на панель childForm
            panelWorkSpace.Tag = childForm;                     // нуу.... Так надо... Не знаю зачем оно, но оно нужно
            childForm.BringToFront();                           // Вывод childForm на передний план
            childForm.Show();                                   // Отображение childForm на панели работы
            label_nameMenu.Text = childForm.Text;               // Описание верхней панели (над рабочей) будет принимать соответсвущее название по названию формы
        }
        #endregion
        #region Основыне Кнопки меню навигации
        // Кнопка "Главная"
        private void iconButton_main_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color1);

            if (currentChildForm != null)   // Проверка, что рабочая форма не является пустой
            {
                currentChildForm.Close();   // Закрываем форму рабочего пространства
            }
            label_nameMenu.Text = currentButton.Text; // Переименовываем верхний label при возвращении на "главную" страницу
        }

        // Кнопка "Запросы"
        private void iconButton_requests_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color2);

            OpenChildForm(new Requests.Requests_Edbooks());     // Открываем форму запросов
        }

        // Кнопка "Справочники"
        private void iconButton_books_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color3);

            panel_ofBooks.Show(); // Демонстрация панели справочников
        }

        // Кнопка "Отчётность"
        private void iconButton_reports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color4);

            OpenChildForm(new Reports.Reports_Form());
        }
        // Кнопка "Прочее"
        private void iconButton_others_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color5);

            panel_ofOthers.Show(); // Демонстрация панели прочих элементов программы
        }
        #endregion
        #region Кнопки меню навигации - саб-меню Справочники
        private void iconButton1_panelOfBooks_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color1);

            OpenChildForm(new Books.EdBooks.Book_EdBooks());        // Открываем форму "Справочники - Учебные пособия"
        }

        private void iconButton2_panelOfBooks_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color2);

            OpenChildForm(new Books.Chapters.Book_Chapters());      // Открываем форму "Справочники - Разделы"
        }

        private void iconButton3_panelOfBooks_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color5);

            OpenChildForm(new Books.Themes.Book_Themes());          // Открываем форму "Справочники - Темы"
        }

        private void iconButton4_panelOfBooks_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color4);

            OpenChildForm(new Books.Disciplines.Book_Disciplines());// Открываем форму "Справочники - Дисциплины"
        }
        #endregion
        #region Кнопки меню навигации - саб-меню Прочее
        private void iconButton1_panelOfOthers_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color1);

            OpenChildForm(new Others.Others_UserPasswrods());        // Открываем форму "Настройки паролей"
        }

        private void iconButton2_panelOfOthers_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color2);
        }

        private void iconButton3_panelOfOthers_Click(object sender, EventArgs e)
        {
            ActivateSubButton(sender, Styles.ColorSchemes.ColorSchemesOfTabs.color3);

            OpenChildForm(new Others.Others_Reference());        // Открываем форму "Настройки паролей"
        }
        #endregion
        #endregion
    }
}

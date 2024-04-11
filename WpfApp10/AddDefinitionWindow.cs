using System;

namespace MyApplication
{
    public partial class AddDefinitionWindow
    {
        internal object nameTextBox;
        internal object principal_IdTextBox;

        public AddDefinitionWindow()
        {
            InitializeComponent();
            DataContext = new YourDataModel(); // Создание новой модели данных
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public YourDataModel DataContext { get; }


        internal bool? ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
    public class YourDataModel
    {
        public string Name { get; set; }
        public int PrincipalId { get; set; }
        // Дополнительные свойства могут быть добавлены по мере необходимости
    }
}

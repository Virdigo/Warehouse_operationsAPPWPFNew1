using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Warehouse_operationsAPPWPF.Models;
using Warehouse_operationsAPPWPF.Services;

namespace Warehouse_operationsAPPWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReceiptExpenseDocumentDetailsWindow.xaml
    /// </summary>
    public partial class ReceiptExpenseDocumentDetailsWindow : Window
    {
        private readonly int _documentId;
        private readonly ApiServiceInformation _apiService;

        public ReceiptExpenseDocumentDetailsWindow(int documentId)
        {
            InitializeComponent();
            _documentId = documentId;
            _apiService = new ApiServiceInformation();
            LoadDocumentDetails();
        }

        private async void LoadDocumentDetails()
        {
            try
            {
                var details = await _apiService.GetInformationByDocumentIdAsync(_documentId);
                DocumentDetailsListView.ItemsSource = details;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки деталей: {ex.Message}");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
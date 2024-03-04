using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExaminationSystems
{
    public partial class Document : Form
    {
        public Document() => InitializeComponent();

        private void Document_Load(object sender, EventArgs e) => WindowState = FormWindowState.Maximized;

        private void CreateDocument_Click(object sender, EventArgs e)
        {
            bool T = true;

            foreach (GroupBox GB in Controls.OfType<GroupBox>())
            {
                foreach (TextBox TB in GB.Controls.OfType<TextBox>()) if (TB.Text == "") T = false;
                foreach (MaskedTextBox MTB in GB.Controls.OfType<MaskedTextBox>()) if (MTB.Text == "") T = false;
                foreach (ComboBox CB in GB.Controls.OfType<ComboBox>()) if (CB.Text == "") T = false;
                foreach (GroupBox GB2 in Controls.OfType<GroupBox>())
                    foreach (TextBox TB in GB2.Controls.OfType<TextBox>()) if (TB.Text == "") T = false;
            }

            if (T)
            {
                //try
                //{
                    // Создание объекта Document
                    Spire.Doc.Document document = new Spire.Doc.Document();

                    // Загрузка шаблона
                    document.LoadFromFile($@"{Application.StartupPath}\Resources\TT.docx"); //document.LoadFromFile($@"{Application.StartupPath}\..\\TT.docx");

                    //Обработка данных
                    string[] DateString = Statement_Date.Text.Split('.');
                    DateTime StatementDate = new DateTime(Convert.ToInt32(DateString[2]), Convert.ToInt32(DateString[1]), Convert.ToInt32(DateString[0]));
                    DateString = Statement_Date.Text.Split('.');
                    DateTime TestReportDate = new DateTime(Convert.ToInt32(DateString[2]), Convert.ToInt32(DateString[1]), Convert.ToInt32(DateString[0]));
                    string[] KeyMonth = new string[]
                    {"Январь" ,"Февраль","Март","Апрель" ,"Май","Июнь" ,"Июль" ,"Август","Сентябрь","Октябрь","Ноябрь","Декабрь" };
                    string Deviations2 = "соответствует"; if (Deviations.SelectedIndex == 1) Deviations2 = "не соответствует";

                    // Сохранение старых строк — «заполнителей» и новых строк в словаре
                    Dictionary<string, string> replaceDict = new Dictionary<string, string>
                    {
                        { "#EXPERTORGANIZATIONNAME#", ExpertOrganizationName.Text.ToUpper() },
                        { "#ExpertOrganizationAddress#", ExpertOrganizationAddress.Text },
                        { "#ExpertOrganizationNumber#", ExpertOrganizationNumber.Text },
                        { "#ExpertOrganization_Head_Position#", ExpertOrganization_Head_Position.Text },
                        {
                            "#ExpertOrganization_Head_FIO#",
                            $"{ExpertOrganization_Head_Surname.Text} {ExpertOrganization_Head_Name.Text[0]}. {ExpertOrganization_Head_MiddleName.Text[0]}."
                        },
                        { "#Statement_Number#", Statement_Number.Text },
                        {
                            "#Statement_Date#",
                            $"«{StatementDate.Day}» {KeyMonth[StatementDate.Month]} {StatementDate.Year} г."
                        },
                        { "#StatementOrganization_Name#", StatementOrganization_Name.Text },
                        { "#StatementOrganization_Address#", StatementOrganization_Address.Text },
                        { "#ManufacturerOrganization_Name#", ManufacturerOrganization_Name.Text },
                        { "#ManufacturerOrganization_Address#", ManufacturerOrganization_Address.Text },
                        { "#Statement_Name#", Statement_Name.Text },
                        { "#TestReport_Number#", TestReport_Number.Text },
                        {
                            "#TestReport_Date#",
                            $"«{TestReportDate.Day}» {KeyMonth[TestReportDate.Month]} {TestReportDate.Year} г."
                        },
                        { "#TestReport_Organization_Name#", TestReport_Organization_Name.Text },
                        { "#TestReport_Organization_RegistrationNumber#", TestReport_Organization_RegistrationNumber.Text },
                        { "#TestResults_Number1#", TestResults_Number1.Text },
                        { "#TestResults_Number2#", TestResults_Number2.Text },
                        { "#TestResults_Number3#", TestResults_Number3.Text },
                        { "#TestResults_Number4#", TestResults_Number4.Text },
                        { "#TestResults_Number5#", TestResults_Number5.Text },
                        { "#TestResults_Number6#", TestResults_Number6.Text },
                        { "#TestResults_Number7#", TestResults_Number7.Text },
                        { "#TestResults_Number8#", TestResults_Number8.Text },
                        { "#TestResults_Number9#", TestResults_Number9.Text },
                        { "#TestResults_Number10#", TestResults_Number10.Text },
                        { "#Deviations#", Deviations.Text.ToLower() },
                        { "#Deviations2#", Deviations2.ToLower() },
                        {
                            "#ExpertOrganization_Expert#",
                            $"{ExpertOrganization_Expert_Surname.Text} {ExpertOrganization_Expert_Name.Text[0]}. {ExpertOrganization_Expert_MiddleName.Text[0]}."
                        },
                    };

                    foreach (KeyValuePair<string, string> kvp in replaceDict) document.Replace(kvp.Key, kvp.Value, true, true);

                    // Сохранение файла документа
                    document.SaveToFile($@"{Application.StartupPath}\..\ReplacePlaceholders.docx", FileFormat.Docx); document.Close();

                    System.Diagnostics.Process.Start($@"{Application.StartupPath}\..\ReplacePlaceholders.docx"); Close();
                //}
                //catch { MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
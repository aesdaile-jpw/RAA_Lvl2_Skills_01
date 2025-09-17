#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

#endregion

namespace RAA_Lvl2_Skills_01
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // step 1: put any code needed for the form here

            // step 2: open form
            MyForm currentForm = new MyForm()
            {
                Width = 500,
                Height = 450,
                WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen,
                Topmost = true,
            };

            currentForm.ShowDialog();

            // step 3: get form data and do something
            if(currentForm.DialogResult == false)
            {
                // if cancel end the addin
                TaskDialog.Show("My Form", "You clicked Cancel");
                return Result.Cancelled;
            }

            // do stuff now
            string textBoxResult = currentForm.GetTextBoxValue();

            bool checkBoxValue = currentForm.GetCheckBox1Value();

            string radioButtonValue = currentForm.GetGroup1();

            TaskDialog.Show("My Form", "You clicked OK" +
                "\nTextBox: " + textBoxResult +
                "\nCheckBox: " + checkBoxValue.ToString() +
                "\nRadioButton: " + radioButtonValue
                );

            return Result.Succeeded;
        }

        public static String GetMethod()
        {
            var method = MethodBase.GetCurrentMethod().DeclaringType?.FullName;
            return method;
        }
    }
}

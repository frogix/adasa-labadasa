using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adasa_project
{
    public partial class DataInputView : Form
    {
        List<Tuple<string, string>> dependencies = new List<Tuple<string, string>>();
        public DataInputView()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numberOfNodes = (int)numericUpDown1.Value;
            RightComboBox.Items.Clear();
            LeftComboBox.Items.Clear();
            for (int i = 0; i < numberOfNodes; i++)
            {
                LeftComboBox.Items.Add("V" + (i + 1).ToString());
                RightComboBox.Items.Add("U" + (i + 1).ToString());
            }
        }

        private void addConnectionButton_Click(object sender, EventArgs e)
        {
            if (RightComboBox.SelectedItem == null || LeftComboBox.SelectedItem == null)
            {
                MessageBox.Show("One or more jobs were not selected in the checkboxes. Try selecting both!");
                return;
            }
            Tuple<string, string> pairToInput = new Tuple<string, string>(LeftComboBox.SelectedItem.ToString(), RightComboBox.SelectedItem.ToString());
            if (dependencies.Contains(pairToInput))
            {
                MessageBox.Show("Unable to add dependency that is already in the list!");
                return;
            }
            dependencies.Add(new Tuple<string, string>(pairToInput.Item1, pairToInput.Item2));
            UpdateDependenciesList();
        }

        private void UpdateDependenciesList()
        {
            dependenciesList.Items.Clear();
            foreach (Tuple<string, string> keyValue in dependencies)
            {
                dependenciesList.Items.Add(keyValue.Item1 + " -> " + keyValue.Item2);
            }
        }

        private void DeleteConnectionButton_Click(object sender, EventArgs e)
        {
            if (dependenciesList.SelectedItem == null)
            {
                MessageBox.Show("No dependency selected to delete. Firstly choose one from the list");
                return;
            }
            string stringFromList = dependenciesList.SelectedItem.ToString();
            Tuple<string, string> valueToDelete = new Tuple<string, string>(stringFromList.Substring(0,2), stringFromList.Substring(6));
            dependencies.Remove(valueToDelete);
            UpdateDependenciesList();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            bool[,] outputDependecies = new bool[(int)numericUpDown1.Value, (int)numericUpDown1.Value];
            foreach (Tuple<string, string> dependency in dependencies)
            {
                int leftNumber = int.Parse(dependency.Item1[1].ToString());
                int rightNumber = int.Parse(dependency.Item2[1].ToString());
                outputDependecies[leftNumber - 1, rightNumber - 1] = true;
            }

            for (int i = 0; i < outputDependecies.GetLength(0); i++)
            {
                for (int j = 0; j < outputDependecies.GetLength(0); j++)
                {
                    Console.Write(outputDependecies[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

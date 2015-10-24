using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triforce_Heroes_Save_Editor.Classes;
using Triforce_Heroes_Save_Editor.Dictionaries;
using Triforce_Heroes_Save_Editor.Forms;

namespace Triforce_Heroes_Save_Editor
{
    public partial class Main : Form
    {
        private byte[] _saveData;
        private readonly DataTable _dtMaterialsTable;

        public Main()
        {
            InitializeComponent();
            _dtMaterialsTable = new DataTable();
            // Add the columns to the data table
            _dtMaterialsTable.Columns.Add("Material");
            _dtMaterialsTable.Columns.Add("Quantity");
            dgMaterials.DataSource = _dtMaterialsTable;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() != DialogResult.OK) return;

            // Update values
            SaveData();

            // Update Checksum
            ChecksumCalculator.UpdateChecksum(_saveData);

            try
            {

                // Write save file
                File.WriteAllBytes(sfdSave.FileName, _saveData);

                // Inform the user
                MessageBox.Show("Saved successfully!", "Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while attempting to save!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() != DialogResult.OK) return;
            _saveData = File.ReadAllBytes(ofdOpen.FileName);
            LoadData();
            saveToolStripMenuItem.Enabled = true;
        }

        private void tcMain_DragEnter(object sender, DragEventArgs e)
        {
            // They're dragging a file (which may or may not be valid)
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Count() == 1 && Path.GetFileName(files[0]) == "SaveData.bin")
            {
                // Is valid file, show copy effect
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Is invalid file, show none effect
                e.Effect = DragDropEffects.None;
            }
        }

        private void tcMain_DragDrop(object sender, DragEventArgs e)
        {
            // They dropped a valid save file
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Count() == 1 && Path.GetFileName(files[0]) == "SaveData.bin")
            {
                this._saveData = File.ReadAllBytes(files[0]);
            }
            LoadData();
            saveToolStripMenuItem.Enabled = true;
        }


        private void LoadData()
        {
            #region General tab
            // Read the name
            tbName.Text = Encoding.Unicode.GetString(_saveData.Skip(0x330).Take(0x10).ToArray()).TrimEnd('\0');
            // Read the amount of rupees
            numRupees.Value = BitConverter.ToUInt32(_saveData, 0x2B0);

            #endregion

            #region Key Items
            // Clear old items
            lvKeyItems.Items.Clear();
            // Load all key items
            foreach (var item in SaveDictionary.KeyItemsDictionary)
            {
                lvKeyItems.Items.Add(new ListViewItem(new[] {item.Value})
                {
                    Checked = this._saveData.Skip(item.Key).First() == 0x01
                });
            }
            #endregion

            #region Materials
            // Clear old materials
            _dtMaterialsTable.Clear();
            // Load all materials
            foreach (var material in SaveDictionary.MaterialsDictionary)
            {
                var item = _dtMaterialsTable.NewRow();
                item["Material"] = material.Value;
                item["Quantity"] = Convert.ToInt32(_saveData.Skip(material.Key).First()).ToString();
                _dtMaterialsTable.Rows.Add(item);
            }
            #endregion
        }


        private void SaveData()
        {
            #region General tab
            // Save username
            Encoding.Unicode.GetBytes(tbName.Text.PadRight(8, '\0')).CopyTo(_saveData, 0x330);

            // Save rupees
            BitConverter.GetBytes((int)numRupees.Value).CopyTo(_saveData, 0x2B0);
            #endregion

            #region Key Items
            // For each key item...
            for (int i = 0; i < lvKeyItems.Items.Count; i++)
            {
                // Get desired pair
                var pair = SaveDictionary.KeyItemsDictionary.Skip(i).First();
                // Update hex location
                _saveData[pair.Key] = lvKeyItems.Items[i].Checked ? (byte)0x1 : (byte)0x0;
            }
            #endregion

            #region Materials
            // For each material...
            for (int i = 0; i < _dtMaterialsTable.Rows.Count; i++)
            {
                // Get the hex location
                var pair = SaveDictionary.MaterialsDictionary.Skip(i).First();
                // Update it with the proper value
                _saveData[pair.Key] = byte.Parse((string)_dtMaterialsTable.Rows[i]["Quantity"]);
            }
            #endregion
        }

        private void dgMaterials_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Disallow null values
            if (string.IsNullOrWhiteSpace((string)e.FormattedValue))
            {
                e.Cancel = true;
            }

        }

        private void dgMaterials_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // If quantity column
            if (e.ColumnIndex != 1) return;

            // Temporary integer
            int val;
            // They entered a valid number
            if (int.TryParse((string)_dtMaterialsTable.Rows[e.RowIndex][e.ColumnIndex], out val))
            {
                // No negatives or greater than 0xFF
                if (val < 0)
                    _dtMaterialsTable.Rows[e.RowIndex][e.ColumnIndex] = "0";
                else if (val > 255)
                    _dtMaterialsTable.Rows[e.RowIndex][e.ColumnIndex] = "255";

            }
            else
            {
                // Invalid number
                _dtMaterialsTable.Rows[e.RowIndex][e.ColumnIndex] = "0";
            }
        }

        private void maxMaterialsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Set the max materials
            for (var i = 0; i < _dtMaterialsTable.Rows.Count; i++)
            {
                _dtMaterialsTable.Rows[i]["Quantity"] = @"255";
            }
        }

        private void minMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the min materials
            for (var i = 0; i < _dtMaterialsTable.Rows.Count; i++)
            {
                _dtMaterialsTable.Rows[i]["Quantity"] = @"0";
            }
        }

        private void maxRupeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Set the max number of rupees
            numRupees.Value = 99999;
        }

        private void minRupeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set the min number of rupees
            numRupees.Value = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }
    }
}

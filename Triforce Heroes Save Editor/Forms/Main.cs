using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Triforce_Heroes_Save_Editor.Classes;
using Triforce_Heroes_Save_Editor.Dictionaries;

namespace Triforce_Heroes_Save_Editor.Forms
{
    public partial class Main : Form
    {
        private byte[] _saveData;
        private readonly DataTable _dtMaterialsTable;
        private readonly DataTable _dtCostumesTable;

        public Main()
        {
            InitializeComponent();
            // Materials table
            _dtMaterialsTable = new DataTable();
            // Add the columns to the data table
            _dtMaterialsTable.Columns.Add("Material");
            _dtMaterialsTable.Columns.Add("Hex");
            _dtMaterialsTable.Columns.Add("Quantity");
            // Don't auto-generate columns
            dgMaterials.AutoGenerateColumns = false;
            // Set the datasource
            dgMaterials.DataSource = _dtMaterialsTable;

            // Costumes table
            _dtCostumesTable = new DataTable();
            // Add the columns to the data table
            _dtCostumesTable.Columns.Add("Name");
            _dtCostumesTable.Columns.Add("KeyCostume");
            _dtCostumesTable.Columns.Add("CurrentCostumeValue");
            _dtCostumesTable.Columns.Add("CostumeUnlockedHex");
            _dtCostumesTable.Columns.Add("CostumeVisible");
            _dtCostumesTable.Columns.Add("CostumePurchased");
            _dtCostumesTable.Columns.Add("CostumeNewIcon"); 
            // Don't auto-generate columns
            dgCostumes.AutoGenerateColumns = false;
            // Set the data source
            dgCostumes.DataSource = _dtCostumesTable;
            // Set info for combobox
            cbCostumes.DataSource = _dtCostumesTable;
            cbCostumes.DisplayMember = "Name";
            cbCostumes.ValueMember = "CurrentCostumeValue";
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

            // Costume loading

            // Clear old costumes
            _dtCostumesTable.Clear();
            // Load bitarray of costumes
            var boughtCostumesBitArray =
                new BitArray(_saveData.Skip(SaveDictionary.Constants.PurchasedCostumeLocation).Take(0x05).ToArray());
            var unlockedCostumesBitArray =
                new BitArray(_saveData.Skip(SaveDictionary.Constants.UnlockedCostumeLocation).Take(0x05).ToArray());
            var newIconCostumesBitArray =
                new BitArray(_saveData.Skip(SaveDictionary.Constants.NewIconCostumeLocation).Take(0x05).ToArray());
            // Load all costumes
            foreach (var costume in SaveDictionary.CostumeDictionary)
            {
                var item = _dtCostumesTable.NewRow();
                item["Name"] = costume.Value;
                item["CurrentCostumeValue"] = costume.Key.CurrentCostumeValue;
                item["CostumeUnlockedHex"] = costume.Key.CostumeUnlockedHex;
                item["KeyCostume"] = costume.Key.KeyCostume;
                item["CostumePurchased"] = boughtCostumesBitArray[costume.Key.CurrentCostumeValue];
                item["CostumeVisible"] = unlockedCostumesBitArray[costume.Key.CurrentCostumeValue];
                item["CostumeNewIcon"] = !newIconCostumesBitArray[costume.Key.CurrentCostumeValue];
                _dtCostumesTable.Rows.Add(item);
            }
            int currentCostume = _saveData[SaveDictionary.Constants.CurrentCostumeLocation];
            if (SaveDictionary.CostumeDictionary.Any(x => x.Key.CurrentCostumeValue == currentCostume))
            {
                cbCostumes.SelectedValue = currentCostume;
            }
            else
            {
                cbCostumes.Items.Add($"0x{currentCostume:X2} - ?");
                cbCostumes.Text = $"0x{currentCostume:X2} - ?";
            }

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
                item["Hex"] = material.Key;
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
            
            // Save current costume
            _saveData[SaveDictionary.Constants.CurrentCostumeLocation] = byte.Parse((string)cbCostumes.SelectedValue);
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
                // Update it with the proper value
                _saveData[int.Parse((string)_dtMaterialsTable.Rows[i]["Hex"])] =
                    byte.Parse((string)_dtMaterialsTable.Rows[i]["Quantity"]);
            }
            #endregion

            #region Costumes
            // Define our bitarrays
            var boughtCostumesBitArray = new BitArray(8 * 0x05);
            var unlockedCostumesBitArray = new BitArray(8 * 0x05);
            var newIconCostumesBitArray = new BitArray(8 * 0x05, true);
            // For each costume...
            for (int i = 0; i < _dtCostumesTable.Rows.Count; i++)
            {
                boughtCostumesBitArray[int.Parse((string)_dtCostumesTable.Rows[i]["CurrentCostumeValue"])] =
                    _dtCostumesTable.Rows[i]["CostumePurchased"] != DBNull.Value && bool.Parse((string)_dtCostumesTable.Rows[i]["CostumePurchased"]);
                unlockedCostumesBitArray[int.Parse((string)_dtCostumesTable.Rows[i]["CurrentCostumeValue"])] =
                    _dtCostumesTable.Rows[i]["CostumeVisible"] != DBNull.Value && bool.Parse((string)_dtCostumesTable.Rows[i]["CostumeVisible"]);
                newIconCostumesBitArray[int.Parse((string)_dtCostumesTable.Rows[i]["CurrentCostumeValue"])] = 
                    !(_dtCostumesTable.Rows[i]["CostumeNewIcon"] != DBNull.Value && bool.Parse((string)_dtCostumesTable.Rows[i]["CostumeNewIcon"]));
            }
            boughtCostumesBitArray.CopyTo(_saveData, SaveDictionary.Constants.PurchasedCostumeLocation);
            unlockedCostumesBitArray.CopyTo(_saveData, SaveDictionary.Constants.UnlockedCostumeLocation);
            newIconCostumesBitArray.CopyTo(_saveData, SaveDictionary.Constants.NewIconCostumeLocation);
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
                else if (val > 99)
                    _dtMaterialsTable.Rows[e.RowIndex][e.ColumnIndex] = "99";

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
                _dtMaterialsTable.Rows[i]["Quantity"] = @"99";
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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dgCostumes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgCostumes.IsCurrentCellDirty)
            {
                dgCostumes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void unlockAllCostumesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Unlock all costumes
            for (var i = 0; i < _dtCostumesTable.Rows.Count; i++)
            {
                if (!bool.Parse((string)_dtCostumesTable.Rows[i]["KeyCostume"]))
                    _dtCostumesTable.Rows[i]["CostumeVisible"] = true;
            }
        }

        private void purchaseAllCostumesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Purchase all costumes
            for (var i = 0; i < _dtCostumesTable.Rows.Count; i++)
            {
                if (!bool.Parse((string)_dtCostumesTable.Rows[i]["KeyCostume"]))
                    _dtCostumesTable.Rows[i]["CostumePurchased"] = true;
            }
        }

        private void unpurchaseAllCostumesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Unpurchase all costumes
            for (var i = 0; i < _dtCostumesTable.Rows.Count; i++)
            {
                if (!bool.Parse((string)_dtCostumesTable.Rows[i]["KeyCostume"]))
                    _dtCostumesTable.Rows[i]["CostumePurchased"] = false;
            }
        }

        private void makeAllCostumesNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set new icon flag to all
            for (var i = 0; i < _dtCostumesTable.Rows.Count; i++)
            {
                if (!bool.Parse((string)_dtCostumesTable.Rows[i]["KeyCostume"]))
                    _dtCostumesTable.Rows[i]["CostumeNewIcon"] = true;
            }
        }

        private void removeNewCostumeFlagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Revoke new icon flag to all
            for (var i = 0; i < _dtCostumesTable.Rows.Count; i++)
            {
                if (!bool.Parse((string)_dtCostumesTable.Rows[i]["KeyCostume"]))
                    _dtCostumesTable.Rows[i]["CostumeNewIcon"] = false;
            }
        }
    }
}

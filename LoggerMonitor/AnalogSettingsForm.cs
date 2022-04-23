using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerMonitor
{
    public partial class AnalogSettingsForm : Form
    {
        TreeNode selectedNode;

        public class ModifyEventArgs : EventArgs
        {
            int Sensor;
            int SelectedItem;
            string Value;
            public ModifyEventArgs(int sensor, int item, string value)
            {
                Sensor = sensor;
                SelectedItem = item;
                Value = value;
            }
        }

        public AnalogSettingsForm()
        {
            InitializeComponent();
            OK_button.DialogResult = DialogResult.OK;
            Cancel_button.DialogResult = DialogResult.Cancel;
            sensorsTreeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(SensorsTreeView_NodeMouseClick);
            sensorsTreeView.AfterLabelEdit += new NodeLabelEditEventHandler(SensorsTreeView_AfterLabelEdit);

            //ModifyItem += ModifyItems;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {

            sensorsTreeView.EndUpdate();
            //Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            sensorsTreeView.BeginUpdate();
        }

        private void ReadFromLogger_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WriteToLogger_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyItems(object sender, ModifyEventArgs e)
        {
            Close();
        }

        // If a node is clicked, open the file indicated by the TreeNode.
        void SensorsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectedNode = sensorsTreeView.SelectedNode;
            if (e.Node != sensorsTreeView.SelectedNode)
                selectedNode = e.Node;

            sensorsTreeView.LabelEdit = true;
            
            if (!selectedNode.IsEditing)
            {
                if(e.Node.Parent.TreeView.LabelEdit)
                    selectedNode.BeginEdit();
            }

            //e.Node.Text = text;
        }

        private void SensorsTreeView_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!' }) == -1)
                    {
                        // Stop editing without canceling the label change.
                        e.Node.EndEdit(false);
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MessageBox.Show("Invalid tree node label.\n" +
                           "The invalid characters are: '@','.', ',', '!'",
                           "Node Label Edit");
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    /* Cancel the label edit action, inform the user, and
                       place the node in edit mode again. */
                    e.CancelEdit = true;
                    MessageBox.Show("Invalid tree node label.\nThe label cannot be blank",
                       "Node Label Edit");
                    e.Node.BeginEdit();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventor; // Inventor API namespace
using System.Runtime.InteropServices;

namespace ModelStateEditorApp
{
    public partial class MainForm : Form
    {
        private Inventor.Application inventorApp;

        public MainForm()
        {
            InitializeComponent();
            ConnectToInventor();
        }  

        private void ConnectToInventor()
        {
            try
            {
                inventorApp = MarshalCore.GetActiveObject("Inventor.Application") as Inventor.Application;
            }
            catch
            {
                MessageBox.Show("Inventor is not running. Please start Autodesk Inventor.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintEditScope_Click(object sender, EventArgs e)
        {
            PrintEditScope();
        }

        private void btnPrintModelStatesInEdit_Click(object sender, EventArgs e)
        {
            PrintModelStatesInEdit();
        }

        private void btnChangeModelStatesInEdit_Click(object sender, EventArgs e)
        {
            ChangeModelStatesInEdit();
        }

        private void PrintEditScope()
        {
            // Check if the active document is a PartDocument
            if (inventorApp.ActiveDocument is PartDocument partDoc)
            {
                // Access PartComponentDefinition for PartDocument
                PartComponentDefinition partComponentDef = partDoc.ComponentDefinition;

                // Get ModelStates for the PartComponentDefinition
                ModelStates modelStates = partComponentDef.ModelStates;

                switch (modelStates.MemberEditScope)
                {
                    case MemberEditScopeEnum.kEditActiveMember:
                        MessageBox.Show("kEditActiveMember");
                        break;
                    case MemberEditScopeEnum.kEditAllMembers:
                        MessageBox.Show("kEditAllMembers");
                        break;
                    case MemberEditScopeEnum.kEditMultipleMembers:
                        MessageBox.Show("kEditMultipleMembers");
                        break;
                }
            }
            // Check if the active document is an AssemblyDocument
            else if (inventorApp.ActiveDocument is AssemblyDocument assemblyDoc)
            {
                // Access AssemblyComponentDefinition for AssemblyDocument
                AssemblyComponentDefinition assemblyComponentDef = assemblyDoc.ComponentDefinition;

                // Get ModelStates for the AssemblyComponentDefinition
                ModelStates modelStates = assemblyComponentDef.ModelStates;

                switch (modelStates.MemberEditScope)
                {
                    case MemberEditScopeEnum.kEditActiveMember:
                        MessageBox.Show("kEditActiveMember");
                        break;
                    case MemberEditScopeEnum.kEditAllMembers:
                        MessageBox.Show("kEditAllMembers");
                        break;
                    case MemberEditScopeEnum.kEditMultipleMembers:
                        MessageBox.Show("kEditMultipleMembers");
                        break;
                }
            }
            else
            {
                MessageBox.Show("The active document is neither a Part nor an Assembly.");
            }
        }

        private void PrintModelStatesInEdit()
        {
            // Check if the active document is a PartDocument
            if (inventorApp.ActiveDocument is PartDocument partDoc)
            {
                // Access PartComponentDefinition for PartDocument
                PartComponentDefinition partComponentDef = partDoc.ComponentDefinition;

                // Get ModelStatesInEdit collection
                ModelStates modelStates = partComponentDef.ModelStates;
                ObjectCollection inEdit = modelStates.ModelStatesInEdit;

                foreach (ModelState ms in inEdit)
                {
                    MessageBox.Show(ms.Name);
                }
            }
            // Check if the active document is an AssemblyDocument
            else if (inventorApp.ActiveDocument is AssemblyDocument assemblyDoc)
            {
                // Access AssemblyComponentDefinition for AssemblyDocument
                AssemblyComponentDefinition assemblyComponentDef = assemblyDoc.ComponentDefinition;

                // Get ModelStatesInEdit collection
                ModelStates modelStates = assemblyComponentDef.ModelStates;
                ObjectCollection inEdit = modelStates.ModelStatesInEdit;

                foreach (ModelState ms in inEdit)
                {
                    MessageBox.Show(ms.Name);
                }
            }
            else
            {
                MessageBox.Show("The active document is neither a Part nor an Assembly.");
            }
        }

        private void ChangeModelStatesInEdit()
        {
            // Check if the active document is a PartDocument
            if (inventorApp.ActiveDocument is PartDocument partDoc)
            {
                // Access PartComponentDefinition for PartDocument
                PartComponentDefinition partComponentDef = partDoc.ComponentDefinition;

                // Create ObjectCollection for Model States in Edit
                ModelStates modelStates = partComponentDef.ModelStates;
                // Create an ObjectCollection to hold model states to edit
                ObjectCollection modelStatesToEdit = inventorApp.TransientObjects.CreateObjectCollection();

                // Activate the second model state before modifying others (indexing starts at 1 in Inventor API)
                ModelState modelStateToActivate = modelStates[2];
                modelStateToActivate.Activate();

                // Add model states 2 through 4 to the edit collection
                for (int i = 2; i <= 4; i++)
                {
                    modelStatesToEdit.Add(modelStates[i]);
                }

                // Set the model states into edit mode
                modelStates.ModelStatesInEdit = modelStatesToEdit;
            }
            // Check if the active document is an AssemblyDocument
            else if (inventorApp.ActiveDocument is AssemblyDocument assemblyDoc)
            {
                // Access AssemblyComponentDefinition for AssemblyDocument
                AssemblyComponentDefinition assemblyComponentDef = assemblyDoc.ComponentDefinition;

                // Create ObjectCollection for Model States in Edit
                ModelStates modelStates = assemblyComponentDef.ModelStates;
                // Create an ObjectCollection to hold model states to edit
                ObjectCollection modelStatesToEdit = inventorApp.TransientObjects.CreateObjectCollection();

                // Activate the second model state before modifying others (indexing starts at 1 in Inventor API)
                ModelState modelStateToActivate = modelStates[2];
                modelStateToActivate.Activate();

                // Add model states 2 through 4 to the edit collection
                for (int i = 2; i <= 4; i++)
                {
                    modelStatesToEdit.Add(modelStates[i]);
                }

                // Set the model states into edit mode
                modelStates.ModelStatesInEdit = modelStatesToEdit;
            }
            else
            {
                MessageBox.Show("The active document is neither a Part nor an Assembly.");
            }
        }


    }
}
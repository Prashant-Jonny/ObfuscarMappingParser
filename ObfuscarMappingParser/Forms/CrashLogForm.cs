﻿using System;
using System.IO;
using System.Windows.Forms;

namespace ObfuscarMappingParser
{
  partial class CrashLogForm : Form
  {
    private Mapping mapping;

    public CrashLogForm(Mapping mapping)
    {
      this.mapping = mapping;
      InitializeComponent();
    }

    private void btnProcess_Click(object sender, EventArgs e)
    {
      try
      {
        tbValue.Text = mapping.ProcessCrashlogText(tbValue.Text, btnSkipPrefix.Checked);
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, "Unable to process crashlog. Reason: " + ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        try
        {
          tbValue.Text = File.ReadAllText(openFileDialog.FileName);
        }
        catch { }
    }

    private void CrashLogForm_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Text)
             ? DragDropEffects.Move
             : DragDropEffects.None;
    }

    private void CrashLogForm_DragDrop(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        try
        {
          tbValue.Text = File.ReadAllText(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }
        catch {}

      if (e.Data.GetDataPresent(DataFormats.StringFormat))
        tbValue.Text = (string)e.Data.GetData(DataFormats.Text);
    }
  }
}

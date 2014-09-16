﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BrokenEvent.NanoXml;
using BrokenEvent.Shared;

namespace ObfuscarMappingParser
{
  class Configs: DefaultConfigs
  {
    #region Singletone

    private static Configs instance;

    public static Configs Instance
    {
      get
      {
        if (instance == null)
          instance = new Configs();
        return instance;
      }
    }

    private Configs()
    {
#if DEBUG
      LoadDefaults();
#endif

      Load(GetConfigPath(false));
    }

    #endregion

    public override string ApplicationName
    {
      get { return "ObfuscarMappingParser"; }
    }

    public override string ConfigsFilename
    {
      get { return "configs.xml"; }
    }

    private bool showModules;
    private bool groupNamespaces;
    private bool groupModules;
    private SortingTypes sortingType;
    private VSOpener.VisualStudioVersion visualStudioVersion;
    private bool useColumns;
    private bool showOriginal;

    [Obfuscation(Exclude = true)]
    public enum SortingTypes
    {
      OriginalNameAscending,
      OriginalNameDescending,
      NewNameAscending,
      NewNameDescending,
    }

    public bool ShowModules
    {
      get { return showModules; }
      set { showModules = value; }
    }

    public bool GroupNamespaces
    {
      get { return groupNamespaces; }
      set { groupNamespaces = value; }
    }

    public bool GroupModules
    {
      get { return groupModules; }
      set { groupModules = value; }
    }

    public bool UseColumns
    {
      get { return useColumns; }
      set { useColumns = value; }
    }

    public bool ShowOriginal
    {
      get { return showOriginal; }
      set { showOriginal = value; }
    }

    public VSOpener.VisualStudioVersion VisualStudioVersion
    {
      get { return visualStudioVersion; }
      set { visualStudioVersion = value; }
    }

    public SortingTypes SortingType
    {
      get { return sortingType; }
      set { sortingType = value; }
    }

    private class RecentItem
    {
      private string filename;
      private List<string> pdbFiles = new List<string>();

      public RecentItem(string filename)
      {
        this.filename = filename;
      }

      public RecentItem(NanoXmlElement el)
      {
        filename = el.GetAttribute("filename");
        foreach (NanoXmlElement element in el.GetChildElements("Pdb"))
          pdbFiles.Add(element.Value);
      }

      public string Filename
      {
        get { return filename; }
      }

      public IList<string> PdbFiles
      {
        get { return pdbFiles; }
      }

      public void Save(NanoXmlElement el)
      {
        el.AddAttribute("filename", filename);
        foreach (string s in pdbFiles)
          el.AppendChild("Pdb", s);
      }
    }

    private List<RecentItem> recents = new List<RecentItem>();

    public void AddRecent(string item)
    {
      RecentItem r = null;
      foreach (RecentItem recent in recents)
        if (string.Compare(recent.Filename, item, StringComparison.OrdinalIgnoreCase) == 0)
        {
          r = recent;
          recents.Remove(r);
          break;
        }

      if (r == null)
        r = new RecentItem(item);
      
      recents.Insert(0, r);
    }

    public IEnumerable<string> Recents
    {
      get
      {
        foreach (RecentItem item in recents)
          yield return item.Filename;
      }
    }

    public void AddRecentPdb(string filename, string pdb)
    {
      foreach (RecentItem item in recents)
        if (string.Compare(item.Filename, filename, StringComparison.OrdinalIgnoreCase) == 0)
        {
          item.PdbFiles.Add(pdb);
          break;
        }
    }

    public IList<string> GetRecentPdb(string filename)
    {
      foreach (RecentItem item in recents)
        if (string.Compare(item.Filename, filename, StringComparison.OrdinalIgnoreCase) == 0)
          return item.PdbFiles;

      return null;
    }

    public void RemoveRecentPdb(string filename, string pdb)
    {
      foreach (RecentItem item in recents)
        if (string.Compare(item.Filename, filename, StringComparison.OrdinalIgnoreCase) == 0)
        {
          item.PdbFiles.Remove(pdb);
          break;
        }
    }

    public bool HaveRecents
    {
      get { return recents.Count > 0; }
    }

    protected override void Load(NanoXmlElement doc)
    {
      NanoXmlElement recentsEl = (NanoXmlElement)doc["Recents"];
      foreach (NanoXmlElement childElement in recentsEl.ChildElements)
      {
        if (File.Exists(childElement.GetAttribute("filename")))
          recents.Add(new RecentItem(childElement));
      }

      NanoXmlElement settingsEl = (NanoXmlElement)doc["Settings"];
      showModules = Convert.ToBoolean(settingsEl["ShowModules"].Value);
      groupNamespaces = Convert.ToBoolean(settingsEl["GroupNamespaces"].Value);
      groupModules = Convert.ToBoolean(settingsEl["GroupModules"].Value);
      useColumns = Convert.ToBoolean(settingsEl["UseColumns"].Value);
      showOriginal = Convert.ToBoolean(settingsEl["ShowOriginal"].Value);
      sortingType = (SortingTypes)Enum.Parse(typeof(SortingTypes), settingsEl["SortingType"].Value);

      string s = settingsEl["VisualStudioVersion"].Value;
      if (!string.IsNullOrEmpty(s))
        visualStudioVersion = (VSOpener.VisualStudioVersion)Enum.Parse(typeof (VSOpener.VisualStudioVersion), s);
    }

    protected override void Save(NanoXmlElement doc)
    {
      NanoXmlElement recentsEl = doc.AppendChild(new NanoXmlElement("Recents"));
      foreach (RecentItem recent in recents)
        recent.Save(recentsEl.AppendChild(new NanoXmlElement("Item")));

      NanoXmlElement settingsEl = doc.AppendChild(new NanoXmlElement("Settings"));
      settingsEl.AppendChild(new NanoXmlElement("ShowModules", showModules.ToString()));
      settingsEl.AppendChild(new NanoXmlElement("GroupNamespaces", groupNamespaces.ToString()));
      settingsEl.AppendChild(new NanoXmlElement("GroupModules", groupModules.ToString()));
      settingsEl.AppendChild(new NanoXmlElement("UseColumns", useColumns.ToString()));
      settingsEl.AppendChild(new NanoXmlElement("ShowOriginal", showOriginal.ToString()));
      settingsEl.AppendChild(new NanoXmlElement("SortingType", sortingType.ToString()));
      settingsEl.AppendChild(new NanoXmlElement("VisualStudioVersion", visualStudioVersion.ToString()));
    }

    protected override void LoadDefaults()
    {
      showModules = false;
      groupNamespaces = true;
      useColumns = true;
      sortingType = SortingTypes.OriginalNameAscending;
      visualStudioVersion = VSOpener.HighestVersion;
      showOriginal = true;
    }
  }
}
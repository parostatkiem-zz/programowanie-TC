using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace TotalCommander
{
    class Model
    {
        public DriveInfo[] GetAvailableDrives()
        {
            var drives = new List<DriveInfo>();
            //przeniesc chyba do modelu
            foreach (DriveInfo dr in DriveInfo.GetDrives())
            {
                if (dr.IsReady)
                    drives.Add(dr);
            }
            return drives.ToArray();
        }

        public string[] GetDirectoryContents(string path)
        {
            if (!HasReadPermissionOnDir(path)) return null;
            var output = new List<string>();
            output.Add("[..]");
            foreach (string item in Directory.GetDirectories(path))
                output.Add("[" + item + "]");
            output.AddRange(Directory.GetFiles(path));
            output=output.Select(s => s.Replace(path, "")).ToList();
            return output.ToArray();
        }

        public string ItemSelectedAction(string path, string itemName)
        {
            string itemNameWithoutBrackets= itemName.Trim(new char[] { '[',']'});
            FileAttributes attr = File.GetAttributes(path+@"\"+itemNameWithoutBrackets);
            path=path.TrimEnd('\\'); //usuniecie backspace z obecnej ścieżki
            if (attr.HasFlag(FileAttributes.Directory))
            {
                if (itemNameWithoutBrackets == "..")
                    try
                    { return Directory.GetParent(path).ToString(); }
                    catch { return null; } //nie mozna przejść do folderu wyżej
                return path + @"\" + itemNameWithoutBrackets + @"\";
            }
            OpenFile(path + @"\" + itemNameWithoutBrackets);
            return null;
        }

        private void OpenFile(string path)
        {

            Process process = new Process();
            process.StartInfo.FileName = path;
            process.Start();
        }

        private static bool HasWritePermissionOnDir(string path)
        {
            var writeAllow = false;
            var writeDeny = false;
            var accessControlList = Directory.GetAccessControl(path);
            if (accessControlList == null)
                return false;
            var accessRules = accessControlList.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
            if (accessRules == null)
                return false;

            foreach (FileSystemAccessRule rule in accessRules)
            {
                if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write) continue;

                if (rule.AccessControlType == AccessControlType.Allow)
                    writeAllow = true;
                else if (rule.AccessControlType == AccessControlType.Deny)
                    writeDeny = true;
            }

            return writeAllow && !writeDeny;
        }

        private static bool HasReadPermissionOnDir(string path)
        {
           
            var readAllow = false;
            var readDeny = false;
            try
            {
                var accessControlList = Directory.GetAccessControl(path);
                if (accessControlList == null)
                    return false;
                var accessRules = accessControlList.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                if (accessRules == null)
                    return false;

                foreach (FileSystemAccessRule rule in accessRules)
                {
                    if ((FileSystemRights.Read & rule.FileSystemRights) != FileSystemRights.Read) continue;

                    if (rule.AccessControlType == AccessControlType.Allow)
                        readAllow = true;
                    else if (rule.AccessControlType == AccessControlType.Deny)
                        readDeny = true;
                }
            }
            catch(Exception ex) { /*ERROR*/ }
            return readAllow && !readDeny;
        }
       
    }
}

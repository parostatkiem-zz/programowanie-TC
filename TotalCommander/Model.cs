using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;


namespace TotalCommander
{
    class Model
    {
        private const short MaxNumberOfIdenticalFiles= 30; // plik(1).txt plik(2).txt  itd

        #region PublicMethods
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
           // if (!IsValidDirectory(path)) return null;
           
            try { 
            var output = new List<string>();
                var currentDirInfo = new DirectoryInfo(path);
            if (currentDirInfo.Root.Name != currentDirInfo.Name) //nie można przejść wyżej jesli ścieżką jest litera dysku
                output.Add("[..]");
            foreach (string item in Directory.GetDirectories(path,"*", System.IO.SearchOption.TopDirectoryOnly))
                output.Add("[" + item + "]");
            output.AddRange(Directory.GetFiles(path));
            output=output.Select(s => s.Replace(path, "")).ToList();
            return output.ToArray();
            }
            catch { return null; }
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
                    { return Directory.GetParent(path).ToString()+'\\'; }
                    catch { return null; } //nie mozna przejść do folderu wyżej
                return path + @"\" + itemNameWithoutBrackets + @"\";
            }
            OpenFile(path + @"\" + itemNameWithoutBrackets);
            return null;
        }

        public  bool Copy(string sourcePath,string sourceItem,string destinationPath,bool moveInsteadOfCopying=false)
        {
            if(sourceItem!=null) sourceItem = sourceItem.Trim(new char[] { '[', ']' });
            //destinationPath = destinationPath.TrimEnd('\\');
            try
            {
                if(IsValidDirectory(destinationPath)&&IsValidDirectory(sourcePath))
                {
                    //sciezki sa poprawne, mozna dzialac dalej
                    if(sourceItem==null | IsValidDirectory(sourcePath + sourceItem))
                    {
                        //kopiujemy folder
                        string dirName = new DirectoryInfo(sourcePath + sourceItem).Name;
                        Directory.CreateDirectory(Path.Combine(destinationPath, dirName));
                        destinationPath = Path.Combine(destinationPath, dirName)+'\\';
                        CopyFolder(sourcePath + sourceItem, destinationPath,moveInsteadOfCopying);
                        
                       
                    }
                    else
                    {
                        //kopiujemy plik
                        string destItem = sourceItem;
                        for(int i=1;i<=MaxNumberOfIdenticalFiles;i++)
                        {
                            if (CopyFile(sourcePath + sourceItem, destinationPath+ destItem,moveInsteadOfCopying)) return true;
                            destItem = Path.GetFileNameWithoutExtension(sourceItem) + "(" + i + ")" + Path.GetExtension(sourceItem);
                        }

                        return false;
                    }
                    return true;
                }
                else { return false; }
                
               
            }
            catch { return false; }
        }

        public bool Delete(string sourcePath, string sourceItem)
        {
            Console.WriteLine("Source item: " + sourceItem);
            if (sourceItem != null) sourceItem = sourceItem.Trim(new char[] { '[', ']' });
            else sourceItem = "";
            try
            {
                string combinedPath = Path.Combine(sourcePath, sourceItem);            
                //sciezki sa poprawne, mozna dzialac dalej

                if (sourceItem == "" | IsValidDirectory(combinedPath))
                {
                    //usuwamy folder
                    Directory.Delete(combinedPath,true);
                }
                else
                {
                    //usuwamy plik
                    File.Delete(combinedPath);
                }                
               return true;
            }
            catch { }
            return false;
        }
        public bool CreateFolder(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch { return false; }
            return true;
        }
        #endregion

        #region HelperFunctions
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

        private static bool IsValidDirectory(string path)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(path);
                path = path.TrimEnd('\\'); //usuniecie backspace z obecnej ścieżki
                if (attr.HasFlag(FileAttributes.Directory) && HasReadPermissionOnDir(path))
                {
                    return true;
                }

            }
            catch { }

            return false;
        }

        private bool CopyFile(string source,string destination, bool moveInsteadOfCopying = false)
        {
            try
            {
                if (moveInsteadOfCopying)
                    File.Move(source, destination);
                else
                    File.Copy(source, destination);
                return true;
            }
            catch { return false; }
            
        }
        private bool CopyFolder(string source, string destination, bool moveInsteadOfCopying = false)
        {
            try
            {
                string[] sourceFiles = Directory.GetFiles(source, "*", SearchOption.AllDirectories);

                Array.ForEach(sourceFiles, (originalFileLocation) =>
                {        
                    FileInfo originalFile = new FileInfo(originalFileLocation);
                    FileInfo destFile = new FileInfo(originalFileLocation.Replace(source, destination));

                    if (destFile.Exists)
                    {
                        
                        if (originalFile.Length > destFile.Length)
                        {
                            originalFile.CopyTo(destFile.FullName, true);
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(destFile.DirectoryName); 
                        originalFile.CopyTo(destFile.FullName, false); 
                    }

                });
                if (moveInsteadOfCopying) Directory.Delete(source);
                return true;
            }
            catch { return false; }

        }

        #endregion
    }
}

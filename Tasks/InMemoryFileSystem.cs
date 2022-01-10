using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tasks
{
    /// <summary>
    /// 588. Design In-Memory File System
    /// </summary>
    public class InMemoryFileSystem
    {
        private readonly Folder _root = new Folder("/");
        private readonly string _ds = "/";
        
        public IList<string> Ls(string path)
        {
            var (folder, file) = GetFolderByPath(path);
            if (folder == null && file == null) return new List<string>();
            if (folder != null)
            {
                return folder.GetContents();
            }

            return new List<string>() { file.Name };
        }
        
        public void Mkdir(string path)
        {
            if (string.IsNullOrEmpty(path)) return;

            var currentFolder = _root;
            var folders = path.Split(_ds);
            for (var i = 1; i < folders.Length; i++)
            {
                currentFolder = currentFolder.CreateFolder(folders[i]);
            }
        }
        
        public void AddContentToFile(string filePath, string content)
        {
            if (string.IsNullOrEmpty(filePath)) return;
            
            var path = filePath.Split(_ds);
            var folders = new string[path.Length - 1];
            for (var i = 0; i < path.Length - 1; i++)
            {
                folders[i] = path[i];
            }

            var (folder, existingFile) = GetFolderByPath(folders);
            if (folder != null)
            {
                var file = folder.GetFile(path[path.Length - 1]);
                file.AddContent(content);
            }
        }
        
        public string ReadContentFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return null;
            
            var path = filePath.Split(_ds);
            var folders = new string[path.Length - 1];
            for (var i = 0; i < path.Length - 1; i++)
            {
                folders[i] = path[i];
            }

            var (folder, existingFile) = GetFolderByPath(folders);
            if (folder != null)
            {
                var file = folder.GetFile(path[path.Length - 1]);
                return file.GetContent();
            }

            return null;
        }

        private (Folder, FileEntity) GetFolderByPath(string path)
        {
            if (path == "/") return (_root, null);
            return GetFolderByPath(path.Split(_ds));
        }
        
        private (Folder, FileEntity) GetFolderByPath(string[] folders)
        {
            var currentFolder = _root;
            for (var i = 1; i < folders.Length; i++)
            {
                if (i == folders.Length - 1 && currentFolder.HasFile(folders[i]))
                    return (null, currentFolder.GetFile(folders[i]));
                
                currentFolder = currentFolder.Open(folders[i]);
                if (currentFolder == null)
                {
                    return (null, null);
                }
            }

            return (currentFolder, null);
        }

        private class Folder
        {
            private readonly List<Folder> _folders = new List<Folder>();
            private readonly List<FileEntity> _files = new List<FileEntity>();

            public readonly string Name;

            public Folder(string name)
            {
                Name = name;
            }

            public List<string> GetContents()
            {
                var result = new List<string>();
                if (_folders.Count > 0)
                {
                    result.AddRange(_folders.Select(x => x.Name));
                }

                if (_files.Count > 0)
                {
                    result.AddRange(_files.Select(x => x.Name));
                }

                return result.OrderBy(x => x).ToList();
            }

            public Folder CreateFolder(string name)
            {
                var existingFolder = Open(name);
                if (existingFolder != null) return existingFolder;
                
                var folder = new Folder(name);
                _folders.Add(folder);
                return folder;
            }

            public Folder Open(string name)
            {
                return _folders.FirstOrDefault(x => x.Name == name);
            }

            public FileEntity GetFile(string name)
            {
                var file = _files.FirstOrDefault(x => x.Name == name);
                if (file == null)
                {
                    file = new FileEntity(name);
                    _files.Add(file);
                }
                return file;
            }
            
            public bool HasFile(string name)
            {
                var file = _files.FirstOrDefault(x => x.Name == name);
                return file != null;
            }
        }

        private class FileEntity
        {
            private string _content = string.Empty;

            public readonly string Name;

            public FileEntity(string name)
            {
                Name = name;
            }

            public void AddContent(string content)
            {
                _content = string.Concat(_content, content);
            }

            public string GetContent()
            {
                return _content;
            }
        }
    }
}
namespace NFCerta.NFe
{
    using System;
    using System.IO;

    public class DisposableFile : IDisposable
    {
        private readonly string path;

        public DisposableFile(string ext=null)
        {
            path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetTempFileName());
            if (ext != null)
            {
                path += ext;
            }
        }

        public string Path
        {
            get { return path; }
        }

        public void Dispose()
        {
            if (path != null && File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}

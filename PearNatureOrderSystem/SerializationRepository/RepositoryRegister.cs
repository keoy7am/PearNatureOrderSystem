using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationRepository
{
    public class RepositoryRegister
    {
        public RepositoryRegister() { }
        public RepositoryRegister(ISerializer serializer, string filePath)
        {
            this.serializer = serializer;
            this.FilePath = filePath;
        }
        public ISerializer serializer { get; set; }
        public string FilePath { get; set; }
    }
}

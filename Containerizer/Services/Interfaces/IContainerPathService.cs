﻿#region

using System.Collections.Generic;

#endregion

namespace Containerizer.Services.Interfaces
{
    public interface IContainerPathService
    {
        string GetContainerRoot(string id);

        void CreateContainerDirectory(string id);

        string GetSubdirectory(string id, string destination);

        void DeleteContainerDirectory(string id);

        IEnumerable<string> ContainerIds();
    }
}
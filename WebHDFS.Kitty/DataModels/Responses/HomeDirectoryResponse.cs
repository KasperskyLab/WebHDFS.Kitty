﻿namespace WebHDFS.Kitty.DataModels.Responses
{
    public sealed class HomeDirectoryResponse
    {
        public HomeDirectoryResponse(string path)
        {
            Path = path;
        }

        public string Path { get; }
    }
}

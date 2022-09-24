using System;

namespace NHA_Github{

    public class GithubDownloader{

        /// <summary>
        /// Get The Owner Name
        /// </summary>
        public string Name { get; private set; } = "dr-NHA";
        /// <summary>
        /// Get The Repo
        /// </summary>
        public string Repo { get; private set; } = "GTAV-Decompiled-Scripts";
        /// <summary>
        /// Get The Branch
        /// </summary>
        public string Branch { get; private set; } = "Main";

        public GithubDownloader(string Name, string Repo, string Branch){
            this.Name = Name;
            this.Repo = Repo;
            this.Branch = Branch;
        }

        /// <summary>
        /// Get A URL For The Content Via Its Path (Using The Static Variables For The Owner Info)
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public string GetUrlFromFilePath(string FilePath) =>
        Downloading.RawGithubUserContent(Name, Repo, Branch, FilePath);

        
        /// <summary>
        /// Download A String Github User Content From A Content Path (Based Off The Name Repo & Branch Above)
        /// </summary>
        /// <param name="ContentPath"></param>
        /// <param name="OnCompleted"></param>
public void DownloadStringGithubUserContent(string ContentPath, Action<string> OnCompleted) =>
Downloading.DownloadStringGithubUserContent((Name, Repo, Branch, ContentPath), OnCompleted);

public void DownloadStringArrayGithubUserContent(string ContentPath, Action<string[]> OnCompleted) =>
Downloading.DownloadStringArrayGithubUserContent((Name, Repo, Branch, ContentPath), OnCompleted);

        
public void DownloadByteArrayGithubUserContent(string ContentPath, Action<byte[]> OnCompleted) =>
Downloading.DownloadByteArrayGithubUserContent((Name, Repo, Branch, ContentPath), OnCompleted);


}
}

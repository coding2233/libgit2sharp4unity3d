namespace LibGit2Sharp.Core
{
    internal enum GitErrorCategory
    {
        Unknown = -1,
        None,
        NoMemory,
        Os,
        Invalid,
        Reference,
        Zlib,
        Repository,
        Config,
        Regex,
        Odb,
        Index,
        Object,
        Net,
        Tag,
        Tree,
        Indexer,
        Ssl,
        Submodule,
        Thread,
        Stash,
        Checkout,
        FetchHead,
        Merge,
        Ssh,
        Filter,
        Revert,
        Callback,
    }
}

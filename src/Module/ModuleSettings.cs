namespace Kurmann.Videoschnitt.MediaFileWatcher;

public class ModuleSettings
{
    public const string SectionName = "Kurmann.Videoschnitt.MediaFileWatcher";

    public string[] WatchDirectories { get; set; } = [];
}
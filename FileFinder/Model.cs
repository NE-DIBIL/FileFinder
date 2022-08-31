using System.Configuration;
using System.Text.RegularExpressions;

public static class AppModel {
    public static Property<string> Path { get; } = new Property<string>(string.Empty);
    public static Property<string> SearchPattern { get; } = new Property<string>(string.Empty);
    public static Regex SearchRegex => new Regex(SearchPattern.Get());

    static AppModel() {
        var savedPath = ConfigurationManager.AppSettings.Get(nameof(Path));
        var savedSearachPattern = ConfigurationManager.AppSettings.Get(nameof(SearchPattern));
        SearchPattern.Set(savedSearachPattern ?? "");
        Path.Set(savedPath ?? Directory.GetCurrentDirectory());
    }
}
public class Property<T> {
    T value;
    public T Value { get => Get(); set => Set(value); }
    public Property(T defaultValue) {
        value = defaultValue;
    }
    public T Get() {
        return value;
    }
    public void Set(T value) {
        if (this.value == null ? !ReferenceEquals(this.value, value) : !this.value.Equals(value)) {
            this.value = value;
            Changed?.Invoke(value);
        }
    }
    public event ChangedDelegate? Changed;
    public delegate void ChangedDelegate(T newValue);
}

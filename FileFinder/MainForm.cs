public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();
        pathEditor.Control.Bind(AppModel.Path);
        searchPatternEditor.Control.Bind(AppModel.SearchPattern);
    }
}
public static class Sugar {
    public static void Bind<T>(this Control control, Property<T> property) {
        if (property is Property<string> stringProperty && control is TextBox textBox) {
            textBox.DataBindings.Add(nameof(textBox.Text), stringProperty, nameof(stringProperty.Value));
        } else
            throw new Exception();
    }
}
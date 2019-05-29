using System.ComponentModel;
using System.Configuration;

namespace RAMCleaner.Properties
{
    // Ta klasa umożliwia obsługę określonych zdarzeń w klasie ustawień:
    //  Zdarzenie SettingChanging jest wywoływane przed zmianą wartości ustawień.
    //  Zdarzenie PropertyChanged jest wywoływane po zmianie wartości ustawień.
    //  Zdarzenie SettingsLoaded jest wywoływane po załadowaniu wartości ustawień.
    //  Zdarzenie SettingsSaving jest wywoływane przed zapisaniem wartości ustawień.
    internal sealed partial class Settings
    {
        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
            // Dodaj tutaj kod obsługi zdarzenia SettingChangingEvent.
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
            // Dodaj tutaj kod obsługi zdarzenia SettingsSaving.
        }
    }
}
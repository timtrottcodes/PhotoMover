using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace PhotoMover
{
    public enum ThemeMode
    {
        Light,
        Dark
    }

    public class AppTheme
    {
        public Color HeaderBackground { get; set; }
        public Color HeaderText { get; set; }
        public Color HeaderSubtext { get; set; }
        public Color FormBackground { get; set; }
        public Color ControlBackground { get; set; }
        public Color ControlText { get; set; }
        public Color GroupBoxBackground { get; set; }
        public Color GroupBoxText { get; set; }
        public Color GridBackground { get; set; }
        public Color GridAlternateRow { get; set; }
        public Color GridHeaderBack { get; set; }
        public Color GridHeaderText { get; set; }
        public Color ButtonPrimary { get; set; }
        public Color ButtonPrimaryText { get; set; }
        public Color ButtonSecondary { get; set; }
        public Color ButtonSecondaryText { get; set; }
        public Color ButtonDefault { get; set; }
        public Color ButtonDefaultText { get; set; }
        public Color HelpText { get; set; }
        public Color BorderColor { get; set; }
        public Color StatusBarBack { get; set; }
        public Color StatusBarText { get; set; }
    }

    public static class ThemeManager
    {
        private static AppTheme? _lightTheme;
        private static AppTheme? _darkTheme;
        private static ThemeMode _currentMode = ThemeMode.Light;

        public static ThemeMode CurrentMode => _currentMode;

        static ThemeManager()
        {
            InitializeThemes();
            DetectSystemTheme();
        }

        private static void InitializeThemes()
        {
            // Light Theme
            _lightTheme = new AppTheme
            {
                HeaderBackground = Color.FromArgb(45, 45, 48),
                HeaderText = Color.White,
                HeaderSubtext = Color.FromArgb(200, 200, 200),
                FormBackground = Color.WhiteSmoke,
                ControlBackground = Color.White,
                ControlText = Color.FromArgb(30, 30, 30),
                GroupBoxBackground = Color.White,
                GroupBoxText = Color.FromArgb(30, 30, 30),
                GridBackground = Color.White,
                GridAlternateRow = Color.FromArgb(245, 245, 245),
                GridHeaderBack = Color.FromArgb(240, 240, 240),
                GridHeaderText = Color.FromArgb(30, 30, 30),
                ButtonPrimary = Color.FromArgb(0, 122, 204),
                ButtonPrimaryText = Color.White,
                ButtonSecondary = Color.FromArgb(16, 124, 16),
                ButtonSecondaryText = Color.White,
                ButtonDefault = Color.FromArgb(225, 225, 225),
                ButtonDefaultText = Color.FromArgb(30, 30, 30),
                HelpText = SystemColors.GrayText,
                BorderColor = Color.FromArgb(204, 206, 219),
                StatusBarBack = Color.FromArgb(240, 240, 240),
                StatusBarText = Color.FromArgb(30, 30, 30)
            };

            // Dark Theme
            _darkTheme = new AppTheme
            {
                HeaderBackground = Color.FromArgb(30, 30, 30),
                HeaderText = Color.White,
                HeaderSubtext = Color.FromArgb(180, 180, 180),
                FormBackground = Color.FromArgb(45, 45, 48),
                ControlBackground = Color.FromArgb(37, 37, 38),
                ControlText = Color.FromArgb(230, 230, 230),
                GroupBoxBackground = Color.FromArgb(37, 37, 38),
                GroupBoxText = Color.FromArgb(230, 230, 230),
                GridBackground = Color.FromArgb(37, 37, 38),
                GridAlternateRow = Color.FromArgb(45, 45, 48),
                GridHeaderBack = Color.FromArgb(51, 51, 51),
                GridHeaderText = Color.FromArgb(230, 230, 230),
                ButtonPrimary = Color.FromArgb(0, 122, 204),
                ButtonPrimaryText = Color.White,
                ButtonSecondary = Color.FromArgb(16, 124, 16),
                ButtonSecondaryText = Color.White,
                ButtonDefault = Color.FromArgb(62, 62, 64),
                ButtonDefaultText = Color.FromArgb(230, 230, 230),
                HelpText = Color.FromArgb(140, 140, 140),
                BorderColor = Color.FromArgb(63, 63, 70),
                StatusBarBack = Color.FromArgb(0, 122, 204),
                StatusBarText = Color.White
            };
        }

        public static void DetectSystemTheme()
        {
            try
            {
                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        object? value = key.GetValue("AppsUseLightTheme");
                        if (value != null && value is int intValue)
                        {
                            _currentMode = intValue == 0 ? ThemeMode.Dark : ThemeMode.Light;
                            return;
                        }
                    }
                }
            }
            catch
            {
                // If we can't detect, default to light mode
            }

            _currentMode = ThemeMode.Light;
        }

        public static AppTheme GetCurrentTheme()
        {
            return _currentMode == ThemeMode.Dark ? _darkTheme! : _lightTheme!;
        }

        public static AppTheme GetLightTheme()
        {
            return _lightTheme!;
        }

        public static AppTheme GetDarkTheme()
        {
            return _darkTheme!;
        }
    }
}

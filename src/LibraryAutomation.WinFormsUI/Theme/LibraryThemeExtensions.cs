using Syncfusion.WinForms.Controls;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace LibraryAutomation.WinFormsUI.Theme;

internal static class LibraryThemeExtensions
{
    private static readonly float _borderThickness = 1.0f;

    #region Public Methods

    public static void MakePrimary(this SfButton? button)
    {
        custimizeButton(
            button: button,
            backColor: LibraryThemeColors.Primary,
            foreColor: LibraryThemeColors.ForeColor,
            hoverColor: LibraryThemeColors.PrimaryHover,
            hoverForeColor: LibraryThemeColors.ForeColor,
            pressedColor: LibraryThemeColors.PrimaryPressed,
            pressedForeColor: LibraryThemeColors.ForeColor,
            border: true,
            borderColor: LibraryThemeColors.Primary);
    }

    public static void MakeOutline(this SfButton? button)
    {
        custimizeButton(
            button: button,
            backColor: button?.Style.BackColor ?? throw new ArgumentNullException(nameof(button)),
            foreColor: LibraryThemeColors.Primary,
            hoverColor: LibraryThemeColors.PrimaryHover,
            hoverForeColor: LibraryThemeColors.ForeColor,
            pressedColor: LibraryThemeColors.PrimaryPressed,
            pressedForeColor: LibraryThemeColors.ForeColor,
            border: true,
            borderColor: LibraryThemeColors.Primary);
    }

    public static void MakeSuccess(this SfButton? button)
    {
        custimizeButton(
           button: button,
           backColor: LibraryThemeColors.Success,
           foreColor: LibraryThemeColors.ForeColor,
           hoverColor: LibraryThemeColors.SuccessHover,
           hoverForeColor: LibraryThemeColors.ForeColor,
           pressedColor: LibraryThemeColors.SuccessPressed,
           pressedForeColor: LibraryThemeColors.ForeColor,
           border: true,
           borderColor: LibraryThemeColors.Success);
    }

    public static void MakeWarning(this SfButton? button)
    {
        custimizeButton(
           button: button,
           backColor: LibraryThemeColors.Warning,
           foreColor: LibraryThemeColors.ForeColor,
           hoverColor: LibraryThemeColors.WarningHover,
           hoverForeColor: LibraryThemeColors.ForeColor,
           pressedColor: LibraryThemeColors.WarningPressed,
           pressedForeColor: LibraryThemeColors.ForeColor,
           border: true,
           borderColor: LibraryThemeColors.Warning);
    }

    public static void MakeIcon(this SfButton? button)
    {
        if (button == null)
            throw new ArgumentNullException(nameof(button));

        button.Style.BackColor = Color.White;
        button.Style.DisabledBackColor = Color.White;
        button.Style.FocusedBackColor = Color.White;
        button.Style.HoverBackColor = Color.White;
        button.Style.PressedBackColor = Color.White;

        button.Style.Border = null;
        button.Style.HoverBorder = null;
        button.Style.FocusedBorder = null;
        button.Style.PressedBorder = null;
    }

    public static void ApplySkin(this SfForm form)
    {
        // Apply title rule
        StringBuilder titleTextBuilder = new();
        if (!string.IsNullOrEmpty(form.Text))
        {
            titleTextBuilder.Append("LIBRARY AUTOMATION");
            titleTextBuilder.Append(' ');
            titleTextBuilder.Append('-');
            titleTextBuilder.Append(' ');
            titleTextBuilder.Append(form.Text.ToUpper());
        }
        form.Text = titleTextBuilder.ToString();

        // Apply essentials.
        form.AutoScroll = true;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.AllowRoundedCorners = true;
        form.Style.ShadowOpacity = 50;
        form.Style.InactiveShadowOpacity = 25;
        form.Style.TitleBar.Font = new Font("Segoe UI Semibold", 10F);
        form.Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
        form.Style.MdiChild.IconVerticalAlignment = VerticalAlignment.Center;

        // Apply border.
        form.Style.Border = new Pen(Color.FromArgb(50, 42, 102), 1);
        form.Style.InactiveBorder = new Pen(LibraryThemeColors.Primary, 1);

        // Apply colors
        form.Style.TitleBar.BackColor = LibraryThemeColors.Primary;
        form.Style.TitleBar.IconBackColor = form.Style.TitleBar.BackColor;
        form.Style.TitleBar.ForeColor = LibraryThemeColors.ForeColor;
        form.Style.TitleBar.CloseButtonForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.MaximizeButtonForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.MaximizeButtonHoverForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.MaximizeButtonPressedForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.MinimizeButtonForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.MinimizeButtonHoverForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.HelpButtonHoverForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.MinimizeButtonPressedForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.HelpButtonForeColor = form.Style.TitleBar.ForeColor;
        form.Style.TitleBar.HelpButtonPressedForeColor = form.Style.TitleBar.ForeColor;

        form.Style.TitleBar.MaximizeButtonHoverBackColor = Color.FromArgb(113, 96, 232);
        form.Style.TitleBar.MinimizeButtonHoverBackColor = form.Style.TitleBar.MaximizeButtonHoverBackColor;
        form.Style.TitleBar.HelpButtonHoverBackColor = form.Style.TitleBar.MaximizeButtonHoverBackColor;

        form.Style.TitleBar.MaximizeButtonPressedBackColor = Color.FromArgb(136, 122, 235);
        form.Style.TitleBar.MinimizeButtonPressedBackColor = form.Style.TitleBar.MaximizeButtonPressedBackColor;
        form.Style.TitleBar.HelpButtonPressedBackColor = form.Style.TitleBar.MaximizeButtonPressedBackColor;
    }

    #endregion

    #region Private Methods

    private static void custimizeButton(
        SfButton? button,
        Color backColor,
        Color foreColor,
        Color hoverColor,
        Color hoverForeColor,
        Color pressedColor,
        Color pressedForeColor,
        bool border = false,
        Color borderColor = default)
    {
        if (button == null)
        {
            throw new ArgumentNullException(nameof(button));
        }

        button.FocusRectangleVisible = true;

        button.Style.BackColor = button.Style.FocusedBackColor = backColor;
        button.Style.ForeColor = button.Style.FocusedForeColor = foreColor;

        button.Style.HoverBackColor = hoverColor;
        button.Style.HoverForeColor = hoverForeColor;

        button.Style.PressedBackColor = pressedColor;
        button.Style.PressedForeColor = pressedForeColor;

        if (border)
        {
            borderColor = borderColor == default ? backColor : borderColor;
            Pen borderPen = new(borderColor, _borderThickness);
            button.Style.Border = button.Style.FocusedBorder = borderPen;
            button.Style.HoverBorder = borderPen;
            button.Style.PressedBorder = borderPen;
        }
    }

    #endregion
}

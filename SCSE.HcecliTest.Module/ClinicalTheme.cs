namespace SCSE.HcecliTest.Module;

using MudBlazor;

public class ClinicalTheme : MudTheme
{
    public ClinicalTheme()
    {
        Palette = new Palette()
        {
            Background= "#F2F2F2",

            Primary = "#0A3A5A",
            PrimaryDarken= "#3D5687",
            PrimaryLighten = "#3D5687",
            Secondary = "#1EA3DB",
            Tertiary = "#7CB749",
            TertiaryDarken= "#99D961",
            TertiaryLighten = "#99D961",

            LinesDefault = "#CECECE",
            Info = "#1EA3DB",
            Error = "#EF355C",
            Warning = "#D68500",
            Success = "#7CB749",

            ActionDisabledBackground = "#7F7F7F",
            TextPrimary = "#3F3F3F",

            DrawerBackground= "#C1C1C6",
            DrawerIcon = "#FFFFFF",
            DrawerText = "#3F3F3F",
            
            AppbarBackground= "#7CB749",
        };

        LayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "10px",
            AppbarHeight = "42px",
            DrawerMiniWidthLeft = "56px",
            DrawerWidthLeft = "240px",
        };

        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Poppins Regular" },
                FontWeight = 400,
                FontSize = "0.875rem",
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 300,
                FontSize = "6rem",
                LineHeight = 1.167,
                LetterSpacing = "-.01562em"
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 300,
                FontSize = "3.75rem",
                LineHeight = 1.2,
                LetterSpacing = "-.00833em"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 400,
                FontSize = "3rem",
                LineHeight = 1.167,
                LetterSpacing = "0"
            },
            H4 = new H4()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 400,
                FontSize = "2.125rem",
                LineHeight = 1.235,
                LetterSpacing = ".00735em"
            },
            H5 = new H5()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 400,
                FontSize = "1.5rem",
                LineHeight = 1.334,
                LetterSpacing = "0"
            },
            H6 = new H6()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 500,
                FontSize = "1.25rem",
                LineHeight = 1.6,
                LetterSpacing = ".0075em"
            },
            Subtitle1 = new Subtitle1()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 400,
                FontSize = "1rem",
                LineHeight = 1.75,
                LetterSpacing = ".00938em"
            },
            Subtitle2 = new Subtitle2()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 500,
                FontSize = ".875rem",
                LineHeight = 1.57,
                LetterSpacing = ".00714em"
            },
            Body1 = new Body1()
            {
                FontFamily = new[] { "Poppins Regular" },
                FontWeight = 400,
                FontSize = "1rem",
                LineHeight = 1.5,
                LetterSpacing = ".00938em"
            },
            Body2 = new Body2()
            {
                FontFamily = new[] { "Poppins Regular" },
                FontWeight = 400,
                FontSize = ".875rem",
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            Button = new Button()
            {
                FontFamily = new[] { "Poppins Medium" },
                FontWeight = 500,
                FontSize = ".875rem",
                LineHeight = 1.75,
                LetterSpacing = ".02857em",
                TextTransform = "none"
            },
            Caption = new Caption()
            {
                FontFamily = new[] { "Poppins Regular" },
                FontWeight = 400,
                FontSize = ".75rem",
                LineHeight = 1.66,
                LetterSpacing = ".03333em"
            },
            Overline = new Overline()
            {
                FontFamily = new[] { "Poppins Regular" },
                FontWeight = 400,
                FontSize = ".75rem",
                LineHeight = 2.66,
                LetterSpacing = ".08333em",
                TextTransform = "none"
            }
        };

        Shadows = new Shadow();

        ZIndex = new ZIndex();
    }
}
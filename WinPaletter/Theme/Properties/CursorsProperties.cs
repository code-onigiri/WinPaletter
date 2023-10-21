﻿using System.Drawing;

namespace WinPaletter.Theme
{
    public partial class Manager
    {
        public bool Cursor_Enabled = false;

        public bool Cursor_Shadow = false;

        public bool Cursor_Sonar = false;

        public int Cursor_Trails = 0;

        public Structures.Cursor Cursor_Arrow = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_AppLoading = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Circle,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Busy = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Circle,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Circle,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Help = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Move = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_NS = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_EW = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_NESW = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_NWSE = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Up = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Pen = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_None = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.FromArgb(255, 0, 0),
            SecondaryColor2 = Color.FromArgb(255, 0, 0),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Link = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Pin = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Person = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_IBeam = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };

        public Structures.Cursor Cursor_Cross = new()
        {
            PrimaryColor1 = Color.White,
            PrimaryColor2 = Color.White,
            PrimaryColorGradient = false,
            PrimaryColorGradientMode = Paths.GradientMode.Vertical,
            PrimaryColorNoise = false,
            PrimaryColorNoiseOpacity = 0.25f,
            SecondaryColor1 = Color.Black,
            SecondaryColor2 = Color.FromArgb(64, 65, 75),
            SecondaryColorGradient = true,
            SecondaryColorGradientMode = Paths.GradientMode.Vertical,
            SecondaryColorNoise = false,
            SecondaryColorNoiseOpacity = 0.25f,
            LoadingCircleBack1 = Color.FromArgb(42, 151, 243),
            LoadingCircleBack2 = Color.FromArgb(42, 151, 243),
            LoadingCircleBackGradient = false,
            LoadingCircleBackGradientMode = Paths.GradientMode.Circle,
            LoadingCircleBackNoise = false,
            LoadingCircleBackNoiseOpacity = 0.25f,
            LoadingCircleHot1 = Color.FromArgb(37, 204, 255),
            LoadingCircleHot2 = Color.FromArgb(37, 204, 255),
            LoadingCircleHotGradient = false,
            LoadingCircleHotGradientMode = Paths.GradientMode.Circle,
            LoadingCircleHotNoise = false,
            LoadingCircleHotNoiseOpacity = 0.25f,
            ArrowStyle = Paths.ArrowStyle.Aero,
            CircleStyle = Paths.CircleStyle.Aero,
            Shadow_Enabled = false,
            Shadow_Color = Color.Black,
            Shadow_Blur = 5,
            Shadow_Opacity = 0.3f,
            Shadow_OffsetX = 2,
            Shadow_OffsetY = 2
        };
    }
}
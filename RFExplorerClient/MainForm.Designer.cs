//============================================================================
//RF Explorer for Windows - A Handheld Spectrum Analyzer for everyone!
//Copyright © 2010-13 Ariel Rocholl, www.rf-explorer.com
//
//This application is free software; you can redistribute it and/or
//modify it under the terms of the GNU Lesser General Public
//License as published by the Free Software Foundation; either
//version 3.0 of the License, or (at your option) any later version.
//
//This software is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//General Public License for more details.
//
//You should have received a copy of the GNU General Public
//License along with this library; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//=============================================================================

namespace RFExplorerClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadRFE = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAsRFE = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContinuousLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveOnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menusSaveSimpleCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveRFS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadRFS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveRemoteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.menuReinitializeData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPortInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowControlArea = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRealtimeData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAveragedData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaxData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaxHoldData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMinData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowPeak = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCleanReport = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRFConnections = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEnableMainboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEnableExpansionBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAutoLCDOff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComboSavedOptions = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOnlineHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeviceManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuReleaseNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowsReleaseNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.m_timer_receive = new System.Windows.Forms.Timer(this.components);
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabSpectrumAnalyzer = new System.Windows.Forms.TabPage();
            this.btnCenterMark = new System.Windows.Forms.Button();
            this.btnSpanMin = new System.Windows.Forms.Button();
            this.btnSpanDefault = new System.Windows.Forms.Button();
            this.btnSpanMax = new System.Windows.Forms.Button();
            this.btnBottom5minus = new System.Windows.Forms.Button();
            this.btnBottom5plus = new System.Windows.Forms.Button();
            this.btnTop5minus = new System.Windows.Forms.Button();
            this.btnSpanDec = new System.Windows.Forms.Button();
            this.btnSpanInc = new System.Windows.Forms.Button();
            this.btnMoveFreqDecSmall = new System.Windows.Forms.Button();
            this.btnMoveFreqIncSmall = new System.Windows.Forms.Button();
            this.btnTop5plus = new System.Windows.Forms.Button();
            this.btnMoveFreqDecLarge = new System.Windows.Forms.Button();
            this.btnMoveFreqIncLarge = new System.Windows.Forms.Button();
            this.groupDataFeed = new System.Windows.Forms.GroupBox();
            this.chkCalcMin = new System.Windows.Forms.CheckBox();
            this.chkCalcMax = new System.Windows.Forms.CheckBox();
            this.chkCalcAverage = new System.Windows.Forms.CheckBox();
            this.chkCalcRealtime = new System.Windows.Forms.CheckBox();
            this.numericIterations = new System.Windows.Forms.NumericUpDown();
            this.numericSampleSA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRunMode = new System.Windows.Forms.CheckBox();
            this.chkHoldMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.toolCOMStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMemory = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSamples = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupCOM = new System.Windows.Forms.GroupBox();
            this.btnRescan = new System.Windows.Forms.Button();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.COMPortCombo = new System.Windows.Forms.ComboBox();
            this.zedSpectrumAnalyzer = new ZedGraph.ZedGraphControl();
            this.groupFreqSettings = new System.Windows.Forms.GroupBox();
            this.m_sBottomDBM = new System.Windows.Forms.TextBox();
            this.m_sTopDBM = new System.Windows.Forms.TextBox();
            this.m_sEndFreq = new System.Windows.Forms.TextBox();
            this.m_sFreqSpan = new System.Windows.Forms.TextBox();
            this.m_sStartFreq = new System.Windows.Forms.TextBox();
            this.m_sCenterFreq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabRemoteScreen = new System.Windows.Forms.TabPage();
            this.numVideoFPS = new System.Windows.Forms.NumericUpDown();
            this.groupRemoteScreen = new System.Windows.Forms.GroupBox();
            this.chkDumpHeader = new System.Windows.Forms.CheckBox();
            this.btnSaveRemoteBitmap = new System.Windows.Forms.Button();
            this.chkDumpColorScreen = new System.Windows.Forms.CheckBox();
            this.chkDumpLCDGrid = new System.Windows.Forms.CheckBox();
            this.numericZoom = new System.Windows.Forms.NumericUpDown();
            this.numScreenIndex = new System.Windows.Forms.NumericUpDown();
            this.labelDumpBitmapSize = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDumpScreen = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panelRemoteScreen = new System.Windows.Forms.Panel();
            this.controlRemoteScreen = new RFEClientControls.RemoteScreenControl();
            this.btnSaveRemoteVideo = new System.Windows.Forms.Button();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.panelRFConnections = new System.Windows.Forms.Panel();
            this.controlRFModuleSelectorConfig = new RFEClientControls.RFModuleSelector();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.comboCSVFieldSeparator = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.labelReportFile = new System.Windows.Forms.Label();
            this.edDefaultFilePath = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupCalibration = new System.Windows.Forms.GroupBox();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.m_edCalibrationFreq = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.groupCommands = new System.Windows.Forms.GroupBox();
            this.m_chkDebugTraces = new System.Windows.Forms.CheckBox();
            this.btnSendCustomCmd = new System.Windows.Forms.Button();
            this.comboStdCmd = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboCustomCommand = new System.Windows.Forms.ComboBox();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.tabRAWDecoder = new System.Windows.Forms.TabPage();
            this.groupDemodulator = new System.Windows.Forms.GroupBox();
            this.chkPSK = new System.Windows.Forms.RadioButton();
            this.chkOOK = new System.Windows.Forms.RadioButton();
            this.m_sBaudRate = new System.Windows.Forms.TextBox();
            this.m_sRefFrequency = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupRAWDecoder = new System.Windows.Forms.GroupBox();
            this.chkRunDecoder = new System.Windows.Forms.CheckBox();
            this.chkHoldDecoder = new System.Windows.Forms.CheckBox();
            this.btnSaveRAWDecoderCSV = new System.Windows.Forms.Button();
            this.numMultiGraph = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numSampleDecoder = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.zedRAWDecoder = new ZedGraph.ZedGraphControl();
            this.m_MainFormTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnDelSettings = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.printMainDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.menuPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.tabSpectrumAnalyzer.SuspendLayout();
            this.groupDataFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSampleSA)).BeginInit();
            this.MainStatusBar.SuspendLayout();
            this.groupCOM.SuspendLayout();
            this.groupFreqSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVideoFPS)).BeginInit();
            this.groupRemoteScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenIndex)).BeginInit();
            this.panelRemoteScreen.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.panelConfiguration.SuspendLayout();
            this.panelRFConnections.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.groupCalibration.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.groupCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleDecoder)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFileMenu,
            this.MainViewMenu,
            this.controlToolStripMenuItem,
            this.menuComboSavedOptions,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(940, 27);
            this.MainMenu.TabIndex = 46;
            this.MainMenu.Text = "menu";
            // 
            // MainFileMenu
            // 
            this.MainFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoadRFE,
            this.menuSaveAsRFE,
            this.menuContinuousLog,
            this.menuSaveOnClose,
            this.toolStripSeparator4,
            this.menusSaveSimpleCSV,
            this.menuSaveCSV,
            this.toolStripSeparator5,
            this.menuSaveRFS,
            this.menuLoadRFS,
            this.menuSaveRemoteImage,
            this.toolStripSeparator6,
            this.menuPageSetup,
            this.menuPrintPreview,
            this.menuPrint,
            this.toolStripSeparator12,
            this.menuReinitializeData,
            this.toolStripSeparator2,
            this.menuPortInfo,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.MainFileMenu.Name = "MainFileMenu";
            this.MainFileMenu.Size = new System.Drawing.Size(37, 23);
            this.MainFileMenu.Text = "&File";
            this.MainFileMenu.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // menuLoadRFE
            // 
            this.menuLoadRFE.Name = "menuLoadRFE";
            this.menuLoadRFE.Size = new System.Drawing.Size(237, 22);
            this.menuLoadRFE.Text = "&Load RFE data file...";
            this.menuLoadRFE.Click += new System.EventHandler(this.toolStripMenuItemLoad_Click);
            // 
            // menuSaveAsRFE
            // 
            this.menuSaveAsRFE.Name = "menuSaveAsRFE";
            this.menuSaveAsRFE.Size = new System.Drawing.Size(237, 22);
            this.menuSaveAsRFE.Text = "Sa&ve RFE data As...";
            this.menuSaveAsRFE.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // menuContinuousLog
            // 
            this.menuContinuousLog.CheckOnClick = true;
            this.menuContinuousLog.Name = "menuContinuousLog";
            this.menuContinuousLog.Size = new System.Drawing.Size(237, 22);
            this.menuContinuousLog.Text = "&Continuous log to RFE data file";
            // 
            // menuSaveOnClose
            // 
            this.menuSaveOnClose.CheckOnClick = true;
            this.menuSaveOnClose.Name = "menuSaveOnClose";
            this.menuSaveOnClose.Size = new System.Drawing.Size(237, 22);
            this.menuSaveOnClose.Text = "&Save RFE data on Close";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(234, 6);
            // 
            // menusSaveSimpleCSV
            // 
            this.menusSaveSimpleCSV.Name = "menusSaveSimpleCSV";
            this.menusSaveSimpleCSV.Size = new System.Drawing.Size(237, 22);
            this.menusSaveSimpleCSV.Text = "Export Single Signal CSV &as...";
            this.menusSaveSimpleCSV.Click += new System.EventHandler(this.menusSaveSimpleCSV_Click);
            // 
            // menuSaveCSV
            // 
            this.menuSaveCSV.Name = "menuSaveCSV";
            this.menuSaveCSV.Size = new System.Drawing.Size(237, 22);
            this.menuSaveCSV.Text = "Export Cumulative CS&V As...";
            this.menuSaveCSV.Click += new System.EventHandler(this.SaveCSVtoolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(234, 6);
            // 
            // menuSaveRFS
            // 
            this.menuSaveRFS.Name = "menuSaveRFS";
            this.menuSaveRFS.Size = new System.Drawing.Size(237, 22);
            this.menuSaveRFS.Text = "Sav&e RFS Screen file As... ";
            this.menuSaveRFS.Click += new System.EventHandler(this.menu_SaveRFS_Click);
            // 
            // menuLoadRFS
            // 
            this.menuLoadRFS.Name = "menuLoadRFS";
            this.menuLoadRFS.Size = new System.Drawing.Size(237, 22);
            this.menuLoadRFS.Text = "Load &RFS Screen file As...";
            this.menuLoadRFS.Click += new System.EventHandler(this.menu_LoadRFS_Click);
            // 
            // menuSaveRemoteImage
            // 
            this.menuSaveRemoteImage.Name = "menuSaveRemoteImage";
            this.menuSaveRemoteImage.Size = new System.Drawing.Size(237, 22);
            this.menuSaveRemoteImage.Text = "Save Remote Ima&ge As...";
            this.menuSaveRemoteImage.Click += new System.EventHandler(this.SaveImagetoolStrip_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(234, 6);
            // 
            // menuPrintPreview
            // 
            this.menuPrintPreview.Name = "menuPrintPreview";
            this.menuPrintPreview.Size = new System.Drawing.Size(237, 22);
            this.menuPrintPreview.Text = "Print Previe&w...";
            this.menuPrintPreview.Click += new System.EventHandler(this.menuPrintPreview_Click);
            // 
            // menuPrint
            // 
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(237, 22);
            this.menuPrint.Text = "&Print...";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(234, 6);
            // 
            // menuReinitializeData
            // 
            this.menuReinitializeData.Name = "menuReinitializeData";
            this.menuReinitializeData.Size = new System.Drawing.Size(237, 22);
            this.menuReinitializeData.Text = "Reinitialize &Data Buffer...";
            this.menuReinitializeData.Click += new System.EventHandler(this.menuReinitializeData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // menuPortInfo
            // 
            this.menuPortInfo.Name = "menuPortInfo";
            this.menuPortInfo.Size = new System.Drawing.Size(237, 22);
            this.menuPortInfo.Text = "Report COM port &info";
            this.menuPortInfo.Click += new System.EventHandler(this.toolStripMenuPortInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainViewMenu
            // 
            this.MainViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDarkMode,
            this.menuShowControlArea,
            this.toolStripSeparator7,
            this.menuRealtimeData,
            this.menuAveragedData,
            this.menuMaxData,
            this.menuMaxHoldData,
            this.menuMinData,
            this.menuShowPeak,
            this.toolStripSeparator3,
            this.menuCleanReport});
            this.MainViewMenu.Name = "MainViewMenu";
            this.MainViewMenu.Size = new System.Drawing.Size(44, 23);
            this.MainViewMenu.Text = "&View";
            this.MainViewMenu.DropDownOpening += new System.EventHandler(this.MainMenuView_DropDownOpening);
            // 
            // menuDarkMode
            // 
            this.menuDarkMode.CheckOnClick = true;
            this.menuDarkMode.Name = "menuDarkMode";
            this.menuDarkMode.Size = new System.Drawing.Size(182, 22);
            this.menuDarkMode.Text = "Dar&k Color mode";
            this.menuDarkMode.Click += new System.EventHandler(this.menuDarkMode_Click);
            // 
            // menuShowControlArea
            // 
            this.menuShowControlArea.CheckOnClick = true;
            this.menuShowControlArea.Name = "menuShowControlArea";
            this.menuShowControlArea.Size = new System.Drawing.Size(182, 22);
            this.menuShowControlArea.Text = "&Display Control Area";
            this.menuShowControlArea.Click += new System.EventHandler(this.menuShowControlArea_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(179, 6);
            // 
            // menuRealtimeData
            // 
            this.menuRealtimeData.CheckOnClick = true;
            this.menuRealtimeData.Name = "menuRealtimeData";
            this.menuRealtimeData.Size = new System.Drawing.Size(182, 22);
            this.menuRealtimeData.Text = "&Realtime data";
            this.menuRealtimeData.Click += new System.EventHandler(this.click_view_mode);
            // 
            // menuAveragedData
            // 
            this.menuAveragedData.CheckOnClick = true;
            this.menuAveragedData.Name = "menuAveragedData";
            this.menuAveragedData.Size = new System.Drawing.Size(182, 22);
            this.menuAveragedData.Text = "&Averaged data";
            this.menuAveragedData.Click += new System.EventHandler(this.click_view_mode);
            // 
            // menuMaxData
            // 
            this.menuMaxData.CheckOnClick = true;
            this.menuMaxData.Name = "menuMaxData";
            this.menuMaxData.Size = new System.Drawing.Size(182, 22);
            this.menuMaxData.Text = "Ma&x Peak data";
            this.menuMaxData.Click += new System.EventHandler(this.click_view_mode);
            // 
            // menuMaxHoldData
            // 
            this.menuMaxHoldData.CheckOnClick = true;
            this.menuMaxHoldData.Name = "menuMaxHoldData";
            this.menuMaxHoldData.Size = new System.Drawing.Size(182, 22);
            this.menuMaxHoldData.Text = "Max &Hold data";
            this.menuMaxHoldData.Click += new System.EventHandler(this.click_view_mode);
            // 
            // menuMinData
            // 
            this.menuMinData.CheckOnClick = true;
            this.menuMinData.Name = "menuMinData";
            this.menuMinData.Size = new System.Drawing.Size(182, 22);
            this.menuMinData.Text = "M&inimum data";
            this.menuMinData.Click += new System.EventHandler(this.click_view_mode);
            // 
            // menuShowPeak
            // 
            this.menuShowPeak.CheckOnClick = true;
            this.menuShowPeak.Name = "menuShowPeak";
            this.menuShowPeak.Size = new System.Drawing.Size(182, 22);
            this.menuShowPeak.Text = "Show Peak values";
            this.menuShowPeak.CheckedChanged += new System.EventHandler(this.mnuItem_ShowPeak_CheckedChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // menuCleanReport
            // 
            this.menuCleanReport.Name = "menuCleanReport";
            this.menuCleanReport.Size = new System.Drawing.Size(182, 22);
            this.menuCleanReport.Text = "C&lean Report";
            this.menuCleanReport.Click += new System.EventHandler(this.toolStripCleanReport_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRFConnections,
            this.toolStripSeparator11,
            this.menuEnableMainboard,
            this.menuEnableExpansionBoard,
            this.toolStripSeparator10,
            this.menuAutoLCDOff});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.controlToolStripMenuItem.Text = "&Device";
            this.controlToolStripMenuItem.DropDownOpening += new System.EventHandler(this.controlToolStripMenuItem_DropDownOpening);
            // 
            // menuRFConnections
            // 
            this.menuRFConnections.CheckOnClick = true;
            this.menuRFConnections.Name = "menuRFConnections";
            this.menuRFConnections.Size = new System.Drawing.Size(230, 22);
            this.menuRFConnections.Text = "Show Device & RF &Connections";
            this.menuRFConnections.Click += new System.EventHandler(this.menuRFConnections_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(227, 6);
            // 
            // menuEnableMainboard
            // 
            this.menuEnableMainboard.Enabled = false;
            this.menuEnableMainboard.Name = "menuEnableMainboard";
            this.menuEnableMainboard.Size = new System.Drawing.Size(230, 22);
            this.menuEnableMainboard.Text = "Enable &left SMA connector";
            this.menuEnableMainboard.Click += new System.EventHandler(this.menuEnableMainboard_Click);
            // 
            // menuEnableExpansionBoard
            // 
            this.menuEnableExpansionBoard.Enabled = false;
            this.menuEnableExpansionBoard.Name = "menuEnableExpansionBoard";
            this.menuEnableExpansionBoard.Size = new System.Drawing.Size(230, 22);
            this.menuEnableExpansionBoard.Text = "Enable &right SMA connector";
            this.menuEnableExpansionBoard.Click += new System.EventHandler(this.menuEnableExpansionBoard_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(227, 6);
            // 
            // menuAutoLCDOff
            // 
            this.menuAutoLCDOff.CheckOnClick = true;
            this.menuAutoLCDOff.Name = "menuAutoLCDOff";
            this.menuAutoLCDOff.Size = new System.Drawing.Size(230, 22);
            this.menuAutoLCDOff.Text = "Automatic LCD O&FF";
            this.menuAutoLCDOff.Click += new System.EventHandler(this.menuAutoLCDOff_Click);
            // 
            // menuComboSavedOptions
            // 
            this.menuComboSavedOptions.AutoSize = false;
            this.menuComboSavedOptions.AutoToolTip = true;
            this.menuComboSavedOptions.MaxLength = 30;
            this.menuComboSavedOptions.Name = "menuComboSavedOptions";
            this.menuComboSavedOptions.Size = new System.Drawing.Size(180, 23);
            this.menuComboSavedOptions.Sorted = true;
            this.menuComboSavedOptions.ToolTipText = "Saved preconfigured options";
            this.menuComboSavedOptions.SelectedIndexChanged += new System.EventHandler(this.menuComboSavedOptions_SelectedIndexChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOnlineHelp,
            this.menuDeviceManual,
            this.toolStripSeparator8,
            this.menuReleaseNotes,
            this.menuWindowsReleaseNotes,
            this.toolStripSeparator9,
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuOnlineHelp
            // 
            this.menuOnlineHelp.Name = "menuOnlineHelp";
            this.menuOnlineHelp.Size = new System.Drawing.Size(272, 22);
            this.menuOnlineHelp.Text = "RF Explorer for Windows Online &Help";
            this.menuOnlineHelp.Click += new System.EventHandler(this.menuOnlineHelp_Click);
            // 
            // menuDeviceManual
            // 
            this.menuDeviceManual.Name = "menuDeviceManual";
            this.menuDeviceManual.Size = new System.Drawing.Size(272, 22);
            this.menuDeviceManual.Text = "RF Explorer device User Manual";
            this.menuDeviceManual.Click += new System.EventHandler(this.menuDeviceManual_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(269, 6);
            // 
            // menuReleaseNotes
            // 
            this.menuReleaseNotes.Name = "menuReleaseNotes";
            this.menuReleaseNotes.Size = new System.Drawing.Size(272, 22);
            this.menuReleaseNotes.Text = "RF Explorer Firmware Release Notes";
            this.menuReleaseNotes.Click += new System.EventHandler(this.menuFirmware_Click);
            // 
            // menuWindowsReleaseNotes
            // 
            this.menuWindowsReleaseNotes.Name = "menuWindowsReleaseNotes";
            this.menuWindowsReleaseNotes.Size = new System.Drawing.Size(272, 22);
            this.menuWindowsReleaseNotes.Text = "RF Explorer for Windows Relese Notes";
            this.menuWindowsReleaseNotes.Click += new System.EventHandler(this.menuWindowsReleaseNotes_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(269, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(272, 22);
            this.menuAbout.Text = "A&bout RF Explorer For Windows...";
            this.menuAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // m_timer_receive
            // 
            this.m_timer_receive.Interval = 50;
            this.m_timer_receive.Tick += new System.EventHandler(this.timer_receive_Tick);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabSpectrumAnalyzer);
            this.MainTab.Controls.Add(this.tabRemoteScreen);
            this.MainTab.Controls.Add(this.tabConfiguration);
            this.MainTab.Controls.Add(this.tabReport);
            this.MainTab.Location = new System.Drawing.Point(0, 27);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Drawing.Point(16, 5);
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(940, 540);
            this.MainTab.TabIndex = 49;
            // 
            // tabSpectrumAnalyzer
            // 
            this.tabSpectrumAnalyzer.Controls.Add(this.btnCenterMark);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnSpanMin);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnSpanDefault);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnSpanMax);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnBottom5minus);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnBottom5plus);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnTop5minus);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnSpanDec);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnSpanInc);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnMoveFreqDecSmall);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnMoveFreqIncSmall);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnTop5plus);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnMoveFreqDecLarge);
            this.tabSpectrumAnalyzer.Controls.Add(this.btnMoveFreqIncLarge);
            this.tabSpectrumAnalyzer.Controls.Add(this.groupDataFeed);
            this.tabSpectrumAnalyzer.Controls.Add(this.MainStatusBar);
            this.tabSpectrumAnalyzer.Controls.Add(this.groupCOM);
            this.tabSpectrumAnalyzer.Controls.Add(this.zedSpectrumAnalyzer);
            this.tabSpectrumAnalyzer.Controls.Add(this.groupFreqSettings);
            this.tabSpectrumAnalyzer.Location = new System.Drawing.Point(4, 26);
            this.tabSpectrumAnalyzer.Name = "tabSpectrumAnalyzer";
            this.tabSpectrumAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpectrumAnalyzer.Size = new System.Drawing.Size(932, 510);
            this.tabSpectrumAnalyzer.TabIndex = 0;
            this.tabSpectrumAnalyzer.Text = "Spectrum Analyzer";
            this.tabSpectrumAnalyzer.UseVisualStyleBackColor = true;
            this.tabSpectrumAnalyzer.Enter += new System.EventHandler(this.tabSpectrumAnalyzer_Enter);
            // 
            // btnCenterMark
            // 
            this.btnCenterMark.Location = new System.Drawing.Point(756, 459);
            this.btnCenterMark.Name = "btnCenterMark";
            this.btnCenterMark.Size = new System.Drawing.Size(80, 23);
            this.btnCenterMark.TabIndex = 60;
            this.btnCenterMark.Text = "Center Mark";
            this.m_MainFormTooltip.SetToolTip(this.btnCenterMark, "Useful command that will use the current peak frequency and will center it on scr" +
        "een, moving the start/end frequency accordingly");
            this.btnCenterMark.UseVisualStyleBackColor = true;
            this.btnCenterMark.Visible = false;
            this.btnCenterMark.Click += new System.EventHandler(this.btnCenterMark_Click);
            // 
            // btnSpanMin
            // 
            this.btnSpanMin.Location = new System.Drawing.Point(849, 316);
            this.btnSpanMin.Name = "btnSpanMin";
            this.btnSpanMin.Size = new System.Drawing.Size(80, 23);
            this.btnSpanMin.TabIndex = 59;
            this.btnSpanMin.Text = "Span Min";
            this.m_MainFormTooltip.SetToolTip(this.btnSpanMin, "Decrease the frequency span to the minimum available for the active module");
            this.btnSpanMin.UseVisualStyleBackColor = true;
            this.btnSpanMin.Visible = false;
            this.btnSpanMin.Click += new System.EventHandler(this.btnSpanMin_Click);
            // 
            // btnSpanDefault
            // 
            this.btnSpanDefault.Location = new System.Drawing.Point(849, 288);
            this.btnSpanDefault.Name = "btnSpanDefault";
            this.btnSpanDefault.Size = new System.Drawing.Size(80, 23);
            this.btnSpanDefault.TabIndex = 58;
            this.btnSpanDefault.Text = "Span 10MHz";
            this.m_MainFormTooltip.SetToolTip(this.btnSpanDefault, "Set the frequency span to a common use 10MHz");
            this.btnSpanDefault.UseVisualStyleBackColor = true;
            this.btnSpanDefault.Visible = false;
            this.btnSpanDefault.Click += new System.EventHandler(this.btnSpanDefault_Click);
            // 
            // btnSpanMax
            // 
            this.btnSpanMax.Location = new System.Drawing.Point(849, 260);
            this.btnSpanMax.Name = "btnSpanMax";
            this.btnSpanMax.Size = new System.Drawing.Size(80, 23);
            this.btnSpanMax.TabIndex = 57;
            this.btnSpanMax.Text = "Span Max";
            this.m_MainFormTooltip.SetToolTip(this.btnSpanMax, "Increase the frequency span to the maximum available for the active module");
            this.btnSpanMax.UseVisualStyleBackColor = true;
            this.btnSpanMax.Visible = false;
            this.btnSpanMax.Click += new System.EventHandler(this.btnSpanMax_Click);
            // 
            // btnBottom5minus
            // 
            this.btnBottom5minus.Location = new System.Drawing.Point(849, 456);
            this.btnBottom5minus.Name = "btnBottom5minus";
            this.btnBottom5minus.Size = new System.Drawing.Size(80, 23);
            this.btnBottom5minus.TabIndex = 56;
            this.btnBottom5minus.Text = "Bottom -5dB";
            this.m_MainFormTooltip.SetToolTip(this.btnBottom5minus, "Decrease the visual amplitude in 5dB at the bottom");
            this.btnBottom5minus.UseVisualStyleBackColor = true;
            this.btnBottom5minus.Visible = false;
            this.btnBottom5minus.Click += new System.EventHandler(this.btnBottom5minus_Click);
            // 
            // btnBottom5plus
            // 
            this.btnBottom5plus.Location = new System.Drawing.Point(849, 428);
            this.btnBottom5plus.Name = "btnBottom5plus";
            this.btnBottom5plus.Size = new System.Drawing.Size(80, 23);
            this.btnBottom5plus.TabIndex = 55;
            this.btnBottom5plus.Text = "Bottom +5dB";
            this.m_MainFormTooltip.SetToolTip(this.btnBottom5plus, "Increase the visual amplitude in 5dB at the bottom");
            this.btnBottom5plus.UseVisualStyleBackColor = true;
            this.btnBottom5plus.Visible = false;
            this.btnBottom5plus.Click += new System.EventHandler(this.btnBottom5plus_Click);
            // 
            // btnTop5minus
            // 
            this.btnTop5minus.Location = new System.Drawing.Point(849, 148);
            this.btnTop5minus.Name = "btnTop5minus";
            this.btnTop5minus.Size = new System.Drawing.Size(80, 23);
            this.btnTop5minus.TabIndex = 54;
            this.btnTop5minus.Text = "Top -5dB";
            this.m_MainFormTooltip.SetToolTip(this.btnTop5minus, "Decrease the visual amplitude in 5dB at the top");
            this.btnTop5minus.UseVisualStyleBackColor = true;
            this.btnTop5minus.Visible = false;
            this.btnTop5minus.Click += new System.EventHandler(this.btnTop5minus_Click);
            // 
            // btnSpanDec
            // 
            this.btnSpanDec.Location = new System.Drawing.Point(849, 345);
            this.btnSpanDec.Name = "btnSpanDec";
            this.btnSpanDec.Size = new System.Drawing.Size(80, 23);
            this.btnSpanDec.TabIndex = 53;
            this.btnSpanDec.Text = "Span -25%";
            this.btnSpanDec.UseVisualStyleBackColor = true;
            this.btnSpanDec.Visible = false;
            this.btnSpanDec.Click += new System.EventHandler(this.btnSpanDec_Click);
            // 
            // btnSpanInc
            // 
            this.btnSpanInc.Location = new System.Drawing.Point(849, 233);
            this.btnSpanInc.Name = "btnSpanInc";
            this.btnSpanInc.Size = new System.Drawing.Size(80, 23);
            this.btnSpanInc.TabIndex = 53;
            this.btnSpanInc.Text = "Span +25%";
            this.m_MainFormTooltip.SetToolTip(this.btnSpanInc, "Increase the frequency span by a 25%");
            this.btnSpanInc.UseVisualStyleBackColor = true;
            this.btnSpanInc.Visible = false;
            this.btnSpanInc.Click += new System.EventHandler(this.btnSpanInc_Click);
            // 
            // btnMoveFreqDecSmall
            // 
            this.btnMoveFreqDecSmall.Location = new System.Drawing.Point(849, 204);
            this.btnMoveFreqDecSmall.Name = "btnMoveFreqDecSmall";
            this.btnMoveFreqDecSmall.Size = new System.Drawing.Size(80, 23);
            this.btnMoveFreqDecSmall.TabIndex = 53;
            this.btnMoveFreqDecSmall.Text = "Start < 10%";
            this.m_MainFormTooltip.SetToolTip(this.btnMoveFreqDecSmall, "Offset to a lower frequency by 10% of the span");
            this.btnMoveFreqDecSmall.UseVisualStyleBackColor = true;
            this.btnMoveFreqDecSmall.Visible = false;
            this.btnMoveFreqDecSmall.Click += new System.EventHandler(this.btnMoveFreqDecSmall_Click);
            // 
            // btnMoveFreqIncSmall
            // 
            this.btnMoveFreqIncSmall.Location = new System.Drawing.Point(849, 372);
            this.btnMoveFreqIncSmall.Name = "btnMoveFreqIncSmall";
            this.btnMoveFreqIncSmall.Size = new System.Drawing.Size(80, 23);
            this.btnMoveFreqIncSmall.TabIndex = 53;
            this.btnMoveFreqIncSmall.Text = "End > 10%";
            this.m_MainFormTooltip.SetToolTip(this.btnMoveFreqIncSmall, "Offset to a higher frequency by 10% of the span");
            this.btnMoveFreqIncSmall.UseVisualStyleBackColor = true;
            this.btnMoveFreqIncSmall.Visible = false;
            this.btnMoveFreqIncSmall.Click += new System.EventHandler(this.btnMoveFreqIncSmall_Click);
            // 
            // btnTop5plus
            // 
            this.btnTop5plus.Location = new System.Drawing.Point(849, 120);
            this.btnTop5plus.Name = "btnTop5plus";
            this.btnTop5plus.Size = new System.Drawing.Size(80, 23);
            this.btnTop5plus.TabIndex = 53;
            this.btnTop5plus.Text = "Top +5dB";
            this.m_MainFormTooltip.SetToolTip(this.btnTop5plus, "Increase the visual amplitude in 5dB at the top");
            this.btnTop5plus.UseVisualStyleBackColor = true;
            this.btnTop5plus.Visible = false;
            this.btnTop5plus.Click += new System.EventHandler(this.btnTop5plus_Click);
            // 
            // btnMoveFreqDecLarge
            // 
            this.btnMoveFreqDecLarge.Location = new System.Drawing.Point(849, 176);
            this.btnMoveFreqDecLarge.Name = "btnMoveFreqDecLarge";
            this.btnMoveFreqDecLarge.Size = new System.Drawing.Size(80, 23);
            this.btnMoveFreqDecLarge.TabIndex = 53;
            this.btnMoveFreqDecLarge.Text = "Start < 50%";
            this.m_MainFormTooltip.SetToolTip(this.btnMoveFreqDecLarge, "Offset to a lower frequency by 50% of the span");
            this.btnMoveFreqDecLarge.UseVisualStyleBackColor = true;
            this.btnMoveFreqDecLarge.Visible = false;
            this.btnMoveFreqDecLarge.Click += new System.EventHandler(this.btnMoveFreqDecLarge_Click);
            // 
            // btnMoveFreqIncLarge
            // 
            this.btnMoveFreqIncLarge.Location = new System.Drawing.Point(849, 400);
            this.btnMoveFreqIncLarge.Name = "btnMoveFreqIncLarge";
            this.btnMoveFreqIncLarge.Size = new System.Drawing.Size(80, 23);
            this.btnMoveFreqIncLarge.TabIndex = 53;
            this.btnMoveFreqIncLarge.Text = "End > 50%";
            this.m_MainFormTooltip.SetToolTip(this.btnMoveFreqIncLarge, "Offset to a higher frequency by 50% of the span");
            this.btnMoveFreqIncLarge.UseVisualStyleBackColor = true;
            this.btnMoveFreqIncLarge.Visible = false;
            this.btnMoveFreqIncLarge.Click += new System.EventHandler(this.btnMoveFreqIncLarge_Click);
            // 
            // groupDataFeed
            // 
            this.groupDataFeed.Controls.Add(this.chkCalcMin);
            this.groupDataFeed.Controls.Add(this.chkCalcMax);
            this.groupDataFeed.Controls.Add(this.chkCalcAverage);
            this.groupDataFeed.Controls.Add(this.chkCalcRealtime);
            this.groupDataFeed.Controls.Add(this.numericIterations);
            this.groupDataFeed.Controls.Add(this.numericSampleSA);
            this.groupDataFeed.Controls.Add(this.label1);
            this.groupDataFeed.Controls.Add(this.chkRunMode);
            this.groupDataFeed.Controls.Add(this.chkHoldMode);
            this.groupDataFeed.Controls.Add(this.label2);
            this.groupDataFeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupDataFeed.Location = new System.Drawing.Point(272, 6);
            this.groupDataFeed.Name = "groupDataFeed";
            this.groupDataFeed.Size = new System.Drawing.Size(236, 108);
            this.groupDataFeed.TabIndex = 52;
            this.groupDataFeed.TabStop = false;
            this.groupDataFeed.Text = "Mode";
            // 
            // chkCalcMin
            // 
            this.chkCalcMin.AutoSize = true;
            this.chkCalcMin.Location = new System.Drawing.Point(160, 79);
            this.chkCalcMin.Name = "chkCalcMin";
            this.chkCalcMin.Size = new System.Drawing.Size(66, 17);
            this.chkCalcMin.TabIndex = 51;
            this.chkCalcMin.Text = "Minimum";
            this.m_MainFormTooltip.SetToolTip(this.chkCalcMin, "Display Min calculated data based on latest n Iterations");
            this.chkCalcMin.UseVisualStyleBackColor = true;
            this.chkCalcMin.CheckedChanged += new System.EventHandler(this.chkCalcMin_CheckedChanged);
            // 
            // chkCalcMax
            // 
            this.chkCalcMax.AutoSize = true;
            this.chkCalcMax.Location = new System.Drawing.Point(160, 59);
            this.chkCalcMax.Name = "chkCalcMax";
            this.chkCalcMax.Size = new System.Drawing.Size(72, 17);
            this.chkCalcMax.TabIndex = 51;
            this.chkCalcMax.Text = "Max Peak";
            this.m_MainFormTooltip.SetToolTip(this.chkCalcMax, "Display Max calculated data based on latest n Iterations");
            this.chkCalcMax.UseVisualStyleBackColor = true;
            this.chkCalcMax.CheckedChanged += new System.EventHandler(this.chkCalcMax_CheckedChanged);
            // 
            // chkCalcAverage
            // 
            this.chkCalcAverage.AutoSize = true;
            this.chkCalcAverage.Location = new System.Drawing.Point(160, 39);
            this.chkCalcAverage.Name = "chkCalcAverage";
            this.chkCalcAverage.Size = new System.Drawing.Size(67, 17);
            this.chkCalcAverage.TabIndex = 51;
            this.chkCalcAverage.Text = "Average";
            this.m_MainFormTooltip.SetToolTip(this.chkCalcAverage, "Display Average calculated data based on latest n Iterations");
            this.chkCalcAverage.UseVisualStyleBackColor = true;
            this.chkCalcAverage.CheckedChanged += new System.EventHandler(this.chkCalcAverage_CheckedChanged);
            // 
            // chkCalcRealtime
            // 
            this.chkCalcRealtime.AutoSize = true;
            this.chkCalcRealtime.Location = new System.Drawing.Point(160, 19);
            this.chkCalcRealtime.Name = "chkCalcRealtime";
            this.chkCalcRealtime.Size = new System.Drawing.Size(67, 17);
            this.chkCalcRealtime.TabIndex = 51;
            this.chkCalcRealtime.Text = "Realtime";
            this.m_MainFormTooltip.SetToolTip(this.chkCalcRealtime, "Display Realtime data");
            this.chkCalcRealtime.UseVisualStyleBackColor = true;
            this.chkCalcRealtime.CheckedChanged += new System.EventHandler(this.chkCalcRealtime_CheckedChanged);
            // 
            // numericIterations
            // 
            this.numericIterations.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericIterations.Location = new System.Drawing.Point(80, 73);
            this.numericIterations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericIterations.Name = "numericIterations";
            this.numericIterations.Size = new System.Drawing.Size(60, 23);
            this.numericIterations.TabIndex = 17;
            this.numericIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.numericIterations, "Total number of iterations to perform calculations for (Max, Min and Avg)");
            this.numericIterations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericIterations.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericSampleSA
            // 
            this.numericSampleSA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSampleSA.Location = new System.Drawing.Point(80, 46);
            this.numericSampleSA.Name = "numericSampleSA";
            this.numericSampleSA.Size = new System.Drawing.Size(60, 23);
            this.numericSampleSA.TabIndex = 16;
            this.numericSampleSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.numericSampleSA, "Current sample being displayed on Screen");
            this.numericSampleSA.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sample:";
            // 
            // chkRunMode
            // 
            this.chkRunMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRunMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkRunMode.Location = new System.Drawing.Point(14, 20);
            this.chkRunMode.MinimumSize = new System.Drawing.Size(60, 0);
            this.chkRunMode.Name = "chkRunMode";
            this.chkRunMode.Size = new System.Drawing.Size(60, 23);
            this.chkRunMode.TabIndex = 14;
            this.chkRunMode.Text = "RUN";
            this.chkRunMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_MainFormTooltip.SetToolTip(this.chkRunMode, "Restore data receive with RF Explorer");
            this.chkRunMode.UseVisualStyleBackColor = true;
            this.chkRunMode.CheckedChanged += new System.EventHandler(this.chkRunMode_CheckedChanged);
            // 
            // chkHoldMode
            // 
            this.chkHoldMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHoldMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkHoldMode.Location = new System.Drawing.Point(80, 20);
            this.chkHoldMode.MinimumSize = new System.Drawing.Size(60, 0);
            this.chkHoldMode.Name = "chkHoldMode";
            this.chkHoldMode.Size = new System.Drawing.Size(60, 23);
            this.chkHoldMode.TabIndex = 15;
            this.chkHoldMode.Text = "HOLD";
            this.chkHoldMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_MainFormTooltip.SetToolTip(this.chkHoldMode, "Stops receiving data from RF Explorer");
            this.chkHoldMode.UseVisualStyleBackColor = true;
            this.chkHoldMode.CheckedChanged += new System.EventHandler(this.chkHoldMode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Iterations:";
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCOMStatus,
            this.toolStripMemory,
            this.toolStripSamples,
            this.toolFile});
            this.MainStatusBar.Location = new System.Drawing.Point(3, 485);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(926, 22);
            this.MainStatusBar.TabIndex = 51;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // toolCOMStatus
            // 
            this.toolCOMStatus.Name = "toolCOMStatus";
            this.toolCOMStatus.Size = new System.Drawing.Size(79, 17);
            this.toolCOMStatus.Text = "Disconnected";
            // 
            // toolStripMemory
            // 
            this.toolStripMemory.Name = "toolStripMemory";
            this.toolStripMemory.Size = new System.Drawing.Size(100, 16);
            this.toolStripMemory.ToolTipText = "Buffer memory used";
            // 
            // toolStripSamples
            // 
            this.toolStripSamples.Name = "toolStripSamples";
            this.toolStripSamples.Size = new System.Drawing.Size(101, 17);
            this.toolStripSamples.Text = "Samples: 0/0 - 0%";
            // 
            // toolFile
            // 
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(58, 17);
            this.toolFile.Text = "File: none";
            // 
            // groupCOM
            // 
            this.groupCOM.Controls.Add(this.btnRescan);
            this.groupCOM.Controls.Add(this.comboBaudRate);
            this.groupCOM.Controls.Add(this.btnConnect);
            this.groupCOM.Controls.Add(this.btnDisconnect);
            this.groupCOM.Controls.Add(this.COMPortCombo);
            this.groupCOM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupCOM.Location = new System.Drawing.Point(6, 6);
            this.groupCOM.Name = "groupCOM";
            this.groupCOM.Size = new System.Drawing.Size(260, 108);
            this.groupCOM.TabIndex = 50;
            this.groupCOM.TabStop = false;
            this.groupCOM.Text = "COM Port";
            // 
            // btnRescan
            // 
            this.btnRescan.AutoSize = true;
            this.btnRescan.Location = new System.Drawing.Point(110, 19);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(34, 23);
            this.btnRescan.TabIndex = 11;
            this.btnRescan.Text = "*";
            this.m_MainFormTooltip.SetToolTip(this.btnRescan, "Click to rescan available ports");
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudRate.Items.AddRange(new object[] {
            "2400",
            "500000"});
            this.comboBaudRate.Location = new System.Drawing.Point(150, 20);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(92, 21);
            this.comboBaudRate.TabIndex = 12;
            this.m_MainFormTooltip.SetToolTip(this.comboBaudRate, "Baudrate connection speed - it must match the value selected on RF Explorer");
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(22, 50);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 38);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.m_MainFormTooltip.SetToolTip(this.btnConnect, "Click to connect to the selected USB COM port");
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisconnect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(135, 50);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(107, 38);
            this.btnDisconnect.TabIndex = 41;
            this.btnDisconnect.Text = "Disconnect";
            this.m_MainFormTooltip.SetToolTip(this.btnDisconnect, "Click to disconnect from the USB COM port");
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // COMPortCombo
            // 
            this.COMPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortCombo.Location = new System.Drawing.Point(22, 20);
            this.COMPortCombo.Name = "COMPortCombo";
            this.COMPortCombo.Size = new System.Drawing.Size(82, 21);
            this.COMPortCombo.TabIndex = 10;
            this.m_MainFormTooltip.SetToolTip(this.COMPortCombo, "Available COM port where a potential RF Explorer device is connected");
            // 
            // zedSpectrumAnalyzer
            // 
            this.zedSpectrumAnalyzer.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zedSpectrumAnalyzer.IsAntiAlias = true;
            this.zedSpectrumAnalyzer.IsEnableSelection = true;
            this.zedSpectrumAnalyzer.Location = new System.Drawing.Point(6, 120);
            this.zedSpectrumAnalyzer.Name = "zedSpectrumAnalyzer";
            this.zedSpectrumAnalyzer.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zedSpectrumAnalyzer.ScrollGrace = 0D;
            this.zedSpectrumAnalyzer.ScrollMaxX = 0D;
            this.zedSpectrumAnalyzer.ScrollMaxY = 0D;
            this.zedSpectrumAnalyzer.ScrollMaxY2 = 0D;
            this.zedSpectrumAnalyzer.ScrollMinX = 0D;
            this.zedSpectrumAnalyzer.ScrollMinY = 0D;
            this.zedSpectrumAnalyzer.ScrollMinY2 = 0D;
            this.zedSpectrumAnalyzer.Size = new System.Drawing.Size(655, 362);
            this.zedSpectrumAnalyzer.TabIndex = 49;
            this.zedSpectrumAnalyzer.TabStop = false;
            this.zedSpectrumAnalyzer.Visible = false;
            this.zedSpectrumAnalyzer.ContextMenuBuilder += new ZedGraph.ZedGraphControl.ContextMenuBuilderEventHandler(this.objGraph_ContextMenuBuilder);
            this.zedSpectrumAnalyzer.ZoomEvent += new ZedGraph.ZedGraphControl.ZoomEventHandler(this.zedSpectrumAnalyzer_ZoomEvent);
            // 
            // groupFreqSettings
            // 
            this.groupFreqSettings.Controls.Add(this.m_sBottomDBM);
            this.groupFreqSettings.Controls.Add(this.m_sTopDBM);
            this.groupFreqSettings.Controls.Add(this.m_sEndFreq);
            this.groupFreqSettings.Controls.Add(this.m_sFreqSpan);
            this.groupFreqSettings.Controls.Add(this.m_sStartFreq);
            this.groupFreqSettings.Controls.Add(this.m_sCenterFreq);
            this.groupFreqSettings.Controls.Add(this.label8);
            this.groupFreqSettings.Controls.Add(this.label7);
            this.groupFreqSettings.Controls.Add(this.label6);
            this.groupFreqSettings.Controls.Add(this.label5);
            this.groupFreqSettings.Controls.Add(this.label4);
            this.groupFreqSettings.Controls.Add(this.label3);
            this.groupFreqSettings.Controls.Add(this.btnReset);
            this.groupFreqSettings.Controls.Add(this.btnSend);
            this.groupFreqSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupFreqSettings.Location = new System.Drawing.Point(514, 7);
            this.groupFreqSettings.Name = "groupFreqSettings";
            this.groupFreqSettings.Size = new System.Drawing.Size(410, 107);
            this.groupFreqSettings.TabIndex = 48;
            this.groupFreqSettings.TabStop = false;
            this.groupFreqSettings.Text = "Remote Frequency and Power control";
            // 
            // m_sBottomDBM
            // 
            this.m_sBottomDBM.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_sBottomDBM.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sBottomDBM.ForeColor = System.Drawing.Color.White;
            this.m_sBottomDBM.Location = new System.Drawing.Point(77, 78);
            this.m_sBottomDBM.Name = "m_sBottomDBM";
            this.m_sBottomDBM.Size = new System.Drawing.Size(98, 26);
            this.m_sBottomDBM.TabIndex = 6;
            this.m_sBottomDBM.Text = "-120";
            this.m_sBottomDBM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.m_sBottomDBM, "Visual amplitude at the bottom in dBm");
            this.m_sBottomDBM.Leave += new System.EventHandler(this.m_sBottomDBM_Leave);
            // 
            // m_sTopDBM
            // 
            this.m_sTopDBM.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_sTopDBM.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sTopDBM.ForeColor = System.Drawing.Color.White;
            this.m_sTopDBM.Location = new System.Drawing.Point(242, 78);
            this.m_sTopDBM.Name = "m_sTopDBM";
            this.m_sTopDBM.Size = new System.Drawing.Size(98, 26);
            this.m_sTopDBM.TabIndex = 5;
            this.m_sTopDBM.Text = "-20";
            this.m_sTopDBM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.m_sTopDBM, "Visual amplitude at the top in dBm");
            // 
            // m_sEndFreq
            // 
            this.m_sEndFreq.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_sEndFreq.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sEndFreq.ForeColor = System.Drawing.Color.White;
            this.m_sEndFreq.Location = new System.Drawing.Point(242, 49);
            this.m_sEndFreq.Name = "m_sEndFreq";
            this.m_sEndFreq.Size = new System.Drawing.Size(98, 26);
            this.m_sEndFreq.TabIndex = 4;
            this.m_sEndFreq.Text = "437.000";
            this.m_sEndFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.m_sEndFreq, "Stop frequency in MHZ - Center/Start will be recalculated");
            this.m_sEndFreq.Leave += new System.EventHandler(this.m_sEndFreq_Leave);
            // 
            // m_sFreqSpan
            // 
            this.m_sFreqSpan.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_sFreqSpan.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sFreqSpan.ForeColor = System.Drawing.Color.White;
            this.m_sFreqSpan.Location = new System.Drawing.Point(242, 20);
            this.m_sFreqSpan.Name = "m_sFreqSpan";
            this.m_sFreqSpan.Size = new System.Drawing.Size(98, 26);
            this.m_sFreqSpan.TabIndex = 2;
            this.m_sFreqSpan.Text = "4.000";
            this.m_sFreqSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.m_sFreqSpan, "Frequency span in MHZ");
            this.m_sFreqSpan.Leave += new System.EventHandler(this.m_sFreqSpan_Leave);
            // 
            // m_sStartFreq
            // 
            this.m_sStartFreq.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_sStartFreq.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sStartFreq.ForeColor = System.Drawing.Color.White;
            this.m_sStartFreq.Location = new System.Drawing.Point(77, 49);
            this.m_sStartFreq.Name = "m_sStartFreq";
            this.m_sStartFreq.Size = new System.Drawing.Size(98, 26);
            this.m_sStartFreq.TabIndex = 3;
            this.m_sStartFreq.Text = "433.000";
            this.m_sStartFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.m_sStartFreq, "Start frequency in MHZ - Center will be recalculated");
            this.m_sStartFreq.Leave += new System.EventHandler(this.m_sStartFreq_Leave);
            // 
            // m_sCenterFreq
            // 
            this.m_sCenterFreq.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_sCenterFreq.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sCenterFreq.ForeColor = System.Drawing.Color.White;
            this.m_sCenterFreq.Location = new System.Drawing.Point(77, 21);
            this.m_sCenterFreq.Name = "m_sCenterFreq";
            this.m_sCenterFreq.Size = new System.Drawing.Size(98, 26);
            this.m_sCenterFreq.TabIndex = 1;
            this.m_sCenterFreq.Text = "435.000";
            this.m_sCenterFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_MainFormTooltip.SetToolTip(this.m_sCenterFreq, "Center frequency in MHZ - Start/Stop will be recalculated");
            this.m_sCenterFreq.Leave += new System.EventHandler(this.m_sCenterFreq_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(10, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "BOTTOM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(204, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "TOP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(194, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "STOP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(194, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "SPAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(20, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "START";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "CENTER";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(348, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.m_MainFormTooltip.SetToolTip(this.btnReset, "Ignores all changes and restore last values received from the RF Explorer device");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(348, 61);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 34);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.m_MainFormTooltip.SetToolTip(this.btnSend, "Send the updated values to the RF Explorer device");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // tabRemoteScreen
            // 
            this.tabRemoteScreen.Controls.Add(this.numVideoFPS);
            this.tabRemoteScreen.Controls.Add(this.groupRemoteScreen);
            this.tabRemoteScreen.Controls.Add(this.label13);
            this.tabRemoteScreen.Controls.Add(this.panelRemoteScreen);
            this.tabRemoteScreen.Controls.Add(this.btnSaveRemoteVideo);
            this.tabRemoteScreen.Location = new System.Drawing.Point(4, 26);
            this.tabRemoteScreen.Name = "tabRemoteScreen";
            this.tabRemoteScreen.Size = new System.Drawing.Size(932, 510);
            this.tabRemoteScreen.TabIndex = 2;
            this.tabRemoteScreen.Text = "Remote Screen";
            this.tabRemoteScreen.UseVisualStyleBackColor = true;
            this.tabRemoteScreen.Enter += new System.EventHandler(this.tabRemoteScreen_Enter);
            // 
            // numVideoFPS
            // 
            this.numVideoFPS.DecimalPlaces = 1;
            this.numVideoFPS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVideoFPS.Location = new System.Drawing.Point(778, 88);
            this.numVideoFPS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numVideoFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numVideoFPS.Name = "numVideoFPS";
            this.numVideoFPS.Size = new System.Drawing.Size(49, 23);
            this.numVideoFPS.TabIndex = 54;
            this.numVideoFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVideoFPS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVideoFPS.Visible = false;
            // 
            // groupRemoteScreen
            // 
            this.groupRemoteScreen.Controls.Add(this.chkDumpHeader);
            this.groupRemoteScreen.Controls.Add(this.btnSaveRemoteBitmap);
            this.groupRemoteScreen.Controls.Add(this.chkDumpColorScreen);
            this.groupRemoteScreen.Controls.Add(this.chkDumpLCDGrid);
            this.groupRemoteScreen.Controls.Add(this.numericZoom);
            this.groupRemoteScreen.Controls.Add(this.numScreenIndex);
            this.groupRemoteScreen.Controls.Add(this.labelDumpBitmapSize);
            this.groupRemoteScreen.Controls.Add(this.label10);
            this.groupRemoteScreen.Controls.Add(this.label9);
            this.groupRemoteScreen.Controls.Add(this.chkDumpScreen);
            this.groupRemoteScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupRemoteScreen.Location = new System.Drawing.Point(272, 6);
            this.groupRemoteScreen.Name = "groupRemoteScreen";
            this.groupRemoteScreen.Size = new System.Drawing.Size(350, 108);
            this.groupRemoteScreen.TabIndex = 53;
            this.groupRemoteScreen.TabStop = false;
            this.groupRemoteScreen.Text = "Dump Remote Screen";
            // 
            // chkDumpHeader
            // 
            this.chkDumpHeader.AutoSize = true;
            this.chkDumpHeader.Location = new System.Drawing.Point(248, 38);
            this.chkDumpHeader.Name = "chkDumpHeader";
            this.chkDumpHeader.Size = new System.Drawing.Size(86, 17);
            this.chkDumpHeader.TabIndex = 54;
            this.chkDumpHeader.Text = "Header Text";
            this.chkDumpHeader.UseVisualStyleBackColor = true;
            this.chkDumpHeader.CheckedChanged += new System.EventHandler(this.chkDumpHeader_CheckedChanged);
            // 
            // btnSaveRemoteBitmap
            // 
            this.btnSaveRemoteBitmap.Location = new System.Drawing.Point(139, 40);
            this.btnSaveRemoteBitmap.Name = "btnSaveRemoteBitmap";
            this.btnSaveRemoteBitmap.Size = new System.Drawing.Size(98, 35);
            this.btnSaveRemoteBitmap.TabIndex = 53;
            this.btnSaveRemoteBitmap.Text = "Save Bitmap...";
            this.btnSaveRemoteBitmap.UseVisualStyleBackColor = true;
            this.btnSaveRemoteBitmap.Click += new System.EventHandler(this.SaveImagetoolStrip_Click);
            // 
            // chkDumpColorScreen
            // 
            this.chkDumpColorScreen.AutoSize = true;
            this.chkDumpColorScreen.Location = new System.Drawing.Point(248, 61);
            this.chkDumpColorScreen.Name = "chkDumpColorScreen";
            this.chkDumpColorScreen.Size = new System.Drawing.Size(87, 17);
            this.chkDumpColorScreen.TabIndex = 54;
            this.chkDumpColorScreen.Text = "Color Screen";
            this.chkDumpColorScreen.UseVisualStyleBackColor = true;
            this.chkDumpColorScreen.CheckedChanged += new System.EventHandler(this.chkDumpColorScreen_CheckedChanged);
            // 
            // chkDumpLCDGrid
            // 
            this.chkDumpLCDGrid.AutoSize = true;
            this.chkDumpLCDGrid.Location = new System.Drawing.Point(248, 84);
            this.chkDumpLCDGrid.Name = "chkDumpLCDGrid";
            this.chkDumpLCDGrid.Size = new System.Drawing.Size(92, 17);
            this.chkDumpLCDGrid.TabIndex = 54;
            this.chkDumpLCDGrid.Text = "View LCD Grid";
            this.chkDumpLCDGrid.UseVisualStyleBackColor = true;
            this.chkDumpLCDGrid.CheckedChanged += new System.EventHandler(this.chkDumpLCDGrid_CheckedChanged);
            // 
            // numericZoom
            // 
            this.numericZoom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericZoom.Location = new System.Drawing.Point(63, 76);
            this.numericZoom.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericZoom.Name = "numericZoom";
            this.numericZoom.Size = new System.Drawing.Size(70, 23);
            this.numericZoom.TabIndex = 17;
            this.numericZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericZoom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericZoom.ValueChanged += new System.EventHandler(this.numericZoom_ValueChanged);
            // 
            // numScreenIndex
            // 
            this.numScreenIndex.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScreenIndex.Location = new System.Drawing.Point(63, 52);
            this.numScreenIndex.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numScreenIndex.Name = "numScreenIndex";
            this.numScreenIndex.Size = new System.Drawing.Size(70, 23);
            this.numScreenIndex.TabIndex = 51;
            this.numScreenIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numScreenIndex.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numScreenIndex.ValueChanged += new System.EventHandler(this.numScreenIndex_ValueChanged);
            // 
            // labelDumpBitmapSize
            // 
            this.labelDumpBitmapSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDumpBitmapSize.Location = new System.Drawing.Point(139, 78);
            this.labelDumpBitmapSize.Name = "labelDumpBitmapSize";
            this.labelDumpBitmapSize.Size = new System.Drawing.Size(98, 21);
            this.labelDumpBitmapSize.TabIndex = 50;
            this.labelDumpBitmapSize.Text = "Size:128x64";
            this.labelDumpBitmapSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Zoom";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 52;
            this.label9.Text = "Sample";
            // 
            // chkDumpScreen
            // 
            this.chkDumpScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDumpScreen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDumpScreen.Location = new System.Drawing.Point(6, 13);
            this.chkDumpScreen.MinimumSize = new System.Drawing.Size(60, 0);
            this.chkDumpScreen.Name = "chkDumpScreen";
            this.chkDumpScreen.Size = new System.Drawing.Size(168, 29);
            this.chkDumpScreen.TabIndex = 14;
            this.chkDumpScreen.Text = "Enable Screen Capture";
            this.chkDumpScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDumpScreen.UseVisualStyleBackColor = true;
            this.chkDumpScreen.CheckedChanged += new System.EventHandler(this.chkDumpScreen_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(708, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 55;
            this.label13.Text = "Video FPS";
            this.label13.Visible = false;
            // 
            // panelRemoteScreen
            // 
            this.panelRemoteScreen.Controls.Add(this.controlRemoteScreen);
            this.panelRemoteScreen.Location = new System.Drawing.Point(12, 140);
            this.panelRemoteScreen.Name = "panelRemoteScreen";
            this.panelRemoteScreen.Size = new System.Drawing.Size(912, 363);
            this.panelRemoteScreen.TabIndex = 55;
            // 
            // controlRemoteScreen
            // 
            this.controlRemoteScreen.HeaderText = true;
            this.controlRemoteScreen.LCDColor = true;
            this.controlRemoteScreen.LCDGrid = true;
            this.controlRemoteScreen.Location = new System.Drawing.Point(0, 0);
            this.controlRemoteScreen.Name = "controlRemoteScreen";
            this.controlRemoteScreen.Size = new System.Drawing.Size(292, 174);
            this.controlRemoteScreen.TabIndex = 54;
            // 
            // btnSaveRemoteVideo
            // 
            this.btnSaveRemoteVideo.Location = new System.Drawing.Point(833, 74);
            this.btnSaveRemoteVideo.Name = "btnSaveRemoteVideo";
            this.btnSaveRemoteVideo.Size = new System.Drawing.Size(91, 37);
            this.btnSaveRemoteVideo.TabIndex = 53;
            this.btnSaveRemoteVideo.Text = "Save Video...";
            this.btnSaveRemoteVideo.UseVisualStyleBackColor = true;
            this.btnSaveRemoteVideo.Visible = false;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.panelConfiguration);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 26);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(932, 510);
            this.tabConfiguration.TabIndex = 3;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            this.tabConfiguration.Enter += new System.EventHandler(this.tabConfiguration_Enter);
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Controls.Add(this.panelRFConnections);
            this.panelConfiguration.Controls.Add(this.groupBoxFiles);
            this.panelConfiguration.Controls.Add(this.groupCalibration);
            this.panelConfiguration.Location = new System.Drawing.Point(12, 140);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(912, 336);
            this.panelConfiguration.TabIndex = 56;
            // 
            // panelRFConnections
            // 
            this.panelRFConnections.BackColor = System.Drawing.Color.Transparent;
            this.panelRFConnections.Controls.Add(this.controlRFModuleSelectorConfig);
            this.panelRFConnections.Location = new System.Drawing.Point(708, 3);
            this.panelRFConnections.Name = "panelRFConnections";
            this.panelRFConnections.Size = new System.Drawing.Size(201, 332);
            this.panelRFConnections.TabIndex = 8;
            // 
            // controlRFModuleSelectorConfig
            // 
            this.controlRFModuleSelectorConfig.ActualPictureHeight = 332;
            this.controlRFModuleSelectorConfig.ActualPictureWidth = 157;
            this.controlRFModuleSelectorConfig.AutoSize = true;
            this.controlRFModuleSelectorConfig.BackColor = System.Drawing.Color.Transparent;
            this.controlRFModuleSelectorConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlRFModuleSelectorConfig.Location = new System.Drawing.Point(0, 0);
            this.controlRFModuleSelectorConfig.Name = "controlRFModuleSelectorConfig";
            this.controlRFModuleSelectorConfig.Size = new System.Drawing.Size(201, 332);
            this.controlRFModuleSelectorConfig.TabIndex = 0;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.comboCSVFieldSeparator);
            this.groupBoxFiles.Controls.Add(this.label21);
            this.groupBoxFiles.Controls.Add(this.btnOpenLog);
            this.groupBoxFiles.Controls.Add(this.labelReportFile);
            this.groupBoxFiles.Controls.Add(this.edDefaultFilePath);
            this.groupBoxFiles.Controls.Add(this.label20);
            this.groupBoxFiles.Location = new System.Drawing.Point(3, 109);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(653, 118);
            this.groupBoxFiles.TabIndex = 7;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Configuration files and folders";
            // 
            // comboCSVFieldSeparator
            // 
            this.comboCSVFieldSeparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCSVFieldSeparator.FormattingEnabled = true;
            this.comboCSVFieldSeparator.Items.AddRange(new object[] {
            "Comma (,)",
            "Division (|)",
            "Semicolon (;)",
            "Space ( )",
            "Tabulator (\\t)"});
            this.comboCSVFieldSeparator.Location = new System.Drawing.Point(119, 84);
            this.comboCSVFieldSeparator.Name = "comboCSVFieldSeparator";
            this.comboCSVFieldSeparator.Size = new System.Drawing.Size(94, 21);
            this.comboCSVFieldSeparator.Sorted = true;
            this.comboCSVFieldSeparator.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "CSV field separator";
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.Location = new System.Drawing.Point(572, 58);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLog.TabIndex = 8;
            this.btnOpenLog.Text = "Open Log";
            this.btnOpenLog.UseVisualStyleBackColor = true;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // labelReportFile
            // 
            this.labelReportFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReportFile.Location = new System.Drawing.Point(14, 58);
            this.labelReportFile.Name = "labelReportFile";
            this.labelReportFile.Size = new System.Drawing.Size(552, 23);
            this.labelReportFile.TabIndex = 7;
            this.labelReportFile.Text = "Report log file:";
            this.labelReportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_MainFormTooltip.SetToolTip(this.labelReportFile, "Full path of the report log file, you may need this upon Support request");
            // 
            // edDefaultFilePath
            // 
            this.edDefaultFilePath.Location = new System.Drawing.Point(170, 31);
            this.edDefaultFilePath.Name = "edDefaultFilePath";
            this.edDefaultFilePath.Size = new System.Drawing.Size(477, 21);
            this.edDefaultFilePath.TabIndex = 6;
            this.edDefaultFilePath.Leave += new System.EventHandler(this.edDefaultFilePath_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Default Output data file path:";


            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.groupCommands);
            this.tabReport.Controls.Add(this.textBox_message);
            this.tabReport.Location = new System.Drawing.Point(4, 26);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(932, 510);
            this.tabReport.TabIndex = 1;
            this.tabReport.Text = "Report";
            this.tabReport.UseVisualStyleBackColor = true;
            this.tabReport.Enter += new System.EventHandler(this.tabReport_Enter);
            // 
            // groupCommands
            // 
            this.groupCommands.Controls.Add(this.m_chkDebugTraces);
            this.groupCommands.Controls.Add(this.btnSendCustomCmd);
            this.groupCommands.Controls.Add(this.comboStdCmd);
            this.groupCommands.Controls.Add(this.label12);
            this.groupCommands.Controls.Add(this.label11);
            this.groupCommands.Controls.Add(this.comboCustomCommand);
            this.groupCommands.Controls.Add(this.btnSendCmd);
            this.groupCommands.Location = new System.Drawing.Point(274, 6);
            this.groupCommands.Name = "groupCommands";
            this.groupCommands.Size = new System.Drawing.Size(652, 108);
            this.groupCommands.TabIndex = 50;
            this.groupCommands.TabStop = false;
            this.groupCommands.Text = "Advanced Remote Command (developer only)";
            // 
            // m_chkDebugTraces
            // 
            this.m_chkDebugTraces.AutoSize = true;
            this.m_chkDebugTraces.Location = new System.Drawing.Point(353, 15);
            this.m_chkDebugTraces.Name = "m_chkDebugTraces";
            this.m_chkDebugTraces.Size = new System.Drawing.Size(293, 17);
            this.m_chkDebugTraces.TabIndex = 19;
            this.m_chkDebugTraces.Text = "Detailed debug info (only if required to diagnose issues)";
            this.m_chkDebugTraces.UseVisualStyleBackColor = true;
            // 
            // btnSendCustomCmd
            // 
            this.btnSendCustomCmd.Location = new System.Drawing.Point(590, 66);
            this.btnSendCustomCmd.Name = "btnSendCustomCmd";
            this.btnSendCustomCmd.Size = new System.Drawing.Size(56, 23);
            this.btnSendCustomCmd.TabIndex = 18;
            this.btnSendCustomCmd.Text = "Send";
            this.btnSendCustomCmd.UseVisualStyleBackColor = true;
            this.btnSendCustomCmd.Click += new System.EventHandler(this.btnSendCustomCmd_Click);
            // 
            // comboStdCmd
            // 
            this.comboStdCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStdCmd.FormattingEnabled = true;
            this.comboStdCmd.Items.AddRange(new object[] {
            "Baudrate 115200 : c8",
            "Baudrate 19200 : c5",
            "Baudrate 2400 : c2",
            "Baudrate 500K : c0",
            "Dump screen OFF : D0",
            "Dump screen ON : D1",
            "LCD OFF : L0",
            "LCD ON : L1",
            "Request Configuration : C0",
            "Restart RFE: r",
            "RFE on hold : CH",
            "Shutdown RFE : S"});
            this.comboStdCmd.Location = new System.Drawing.Point(123, 38);
            this.comboStdCmd.Name = "comboStdCmd";
            this.comboStdCmd.Size = new System.Drawing.Size(461, 21);
            this.comboStdCmd.Sorted = true;
            this.comboStdCmd.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Standard Command";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Custom Command";
            // 
            // comboCustomCommand
            // 
            this.comboCustomCommand.FormattingEnabled = true;
            this.comboCustomCommand.Location = new System.Drawing.Point(123, 68);
            this.comboCustomCommand.Name = "comboCustomCommand";
            this.comboCustomCommand.Size = new System.Drawing.Size(461, 21);
            this.comboCustomCommand.TabIndex = 14;
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(590, 38);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(56, 22);
            this.btnSendCmd.TabIndex = 13;
            this.btnSendCmd.Text = "Send";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_message.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_message.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox_message.Location = new System.Drawing.Point(6, 120);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.ReadOnly = true;
            this.textBox_message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_message.Size = new System.Drawing.Size(920, 383);
            this.textBox_message.TabIndex = 49;
            this.textBox_message.WordWrap = false;
            // 
            // tabRAWDecoder
            // 
            this.tabRAWDecoder.Location = new System.Drawing.Point(0, 0);
            this.tabRAWDecoder.Name = "tabRAWDecoder";
            this.tabRAWDecoder.Size = new System.Drawing.Size(200, 100);
            this.tabRAWDecoder.TabIndex = 0;
            // 
            // groupDemodulator
            // 
            this.groupDemodulator.Location = new System.Drawing.Point(0, 0);
            this.groupDemodulator.Name = "groupDemodulator";
            this.groupDemodulator.Size = new System.Drawing.Size(200, 100);
            this.groupDemodulator.TabIndex = 0;
            this.groupDemodulator.TabStop = false;
            // 
            // chkPSK
            // 
            this.chkPSK.Location = new System.Drawing.Point(0, 0);
            this.chkPSK.Name = "chkPSK";
            this.chkPSK.Size = new System.Drawing.Size(104, 24);
            this.chkPSK.TabIndex = 0;
            // 
            // chkOOK
            // 
            this.chkOOK.Location = new System.Drawing.Point(0, 0);
            this.chkOOK.Name = "chkOOK";
            this.chkOOK.Size = new System.Drawing.Size(104, 24);
            this.chkOOK.TabIndex = 0;
            // 
            // m_sBaudRate
            // 
            this.m_sBaudRate.Location = new System.Drawing.Point(0, 0);
            this.m_sBaudRate.Name = "m_sBaudRate";
            this.m_sBaudRate.Size = new System.Drawing.Size(100, 20);
            this.m_sBaudRate.TabIndex = 0;
            // 
            // m_sRefFrequency
            // 
            this.m_sRefFrequency.Location = new System.Drawing.Point(0, 0);
            this.m_sRefFrequency.Name = "m_sRefFrequency";
            this.m_sRefFrequency.Size = new System.Drawing.Size(100, 20);
            this.m_sRefFrequency.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // groupRAWDecoder
            // 
            this.groupRAWDecoder.Location = new System.Drawing.Point(0, 0);
            this.groupRAWDecoder.Name = "groupRAWDecoder";
            this.groupRAWDecoder.Size = new System.Drawing.Size(200, 100);
            this.groupRAWDecoder.TabIndex = 0;
            this.groupRAWDecoder.TabStop = false;
            // 
            // chkRunDecoder
            // 
            this.chkRunDecoder.Location = new System.Drawing.Point(0, 0);
            this.chkRunDecoder.Name = "chkRunDecoder";
            this.chkRunDecoder.Size = new System.Drawing.Size(104, 24);
            this.chkRunDecoder.TabIndex = 0;
            // 
            // chkHoldDecoder
            // 
            this.chkHoldDecoder.Location = new System.Drawing.Point(0, 0);
            this.chkHoldDecoder.Name = "chkHoldDecoder";
            this.chkHoldDecoder.Size = new System.Drawing.Size(104, 24);
            this.chkHoldDecoder.TabIndex = 0;
            // 
            // btnSaveRAWDecoderCSV
            // 
            this.btnSaveRAWDecoderCSV.Location = new System.Drawing.Point(0, 0);
            this.btnSaveRAWDecoderCSV.Name = "btnSaveRAWDecoderCSV";
            this.btnSaveRAWDecoderCSV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRAWDecoderCSV.TabIndex = 0;
            // 
            // numMultiGraph
            // 
            this.numMultiGraph.Location = new System.Drawing.Point(0, 0);
            this.numMultiGraph.Name = "numMultiGraph";
            this.numMultiGraph.Size = new System.Drawing.Size(120, 20);
            this.numMultiGraph.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // numSampleDecoder
            // 
            this.numSampleDecoder.Location = new System.Drawing.Point(0, 0);
            this.numSampleDecoder.Name = "numSampleDecoder";
            this.numSampleDecoder.Size = new System.Drawing.Size(120, 20);
            this.numSampleDecoder.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // zedRAWDecoder
            // 
            this.zedRAWDecoder.Location = new System.Drawing.Point(0, 0);
            this.zedRAWDecoder.Name = "zedRAWDecoder";
            this.zedRAWDecoder.ScrollGrace = 0D;
            this.zedRAWDecoder.ScrollMaxX = 0D;
            this.zedRAWDecoder.ScrollMaxY = 0D;
            this.zedRAWDecoder.ScrollMaxY2 = 0D;
            this.zedRAWDecoder.ScrollMinX = 0D;
            this.zedRAWDecoder.ScrollMinY = 0D;
            this.zedRAWDecoder.ScrollMinY2 = 0D;
            this.zedRAWDecoder.Size = new System.Drawing.Size(150, 150);
            this.zedRAWDecoder.TabIndex = 0;
            // 
            // m_MainFormTooltip
            // 
            this.m_MainFormTooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_MainFormTooltip.ForeColor = System.Drawing.Color.Blue;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(383, 4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(46, 23);
            this.btnSaveSettings.TabIndex = 50;
            this.btnSaveSettings.Text = "Save";
            this.m_MainFormTooltip.SetToolTip(this.btnSaveSettings, "Save current settings to the selected name");
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnDelSettings
            // 
            this.btnDelSettings.Location = new System.Drawing.Point(435, 4);
            this.btnDelSettings.Name = "btnDelSettings";
            this.btnDelSettings.Size = new System.Drawing.Size(46, 23);
            this.btnDelSettings.TabIndex = 50;
            this.btnDelSettings.Text = "Del";
            this.m_MainFormTooltip.SetToolTip(this.btnDelSettings, "Delete the selected named settings");
            this.btnDelSettings.UseVisualStyleBackColor = true;
            this.btnDelSettings.Click += new System.EventHandler(this.btnDelSettings_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(331, 4);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(46, 23);
            this.btnLoadSettings.TabIndex = 51;
            this.btnLoadSettings.Text = "Load";
            this.m_MainFormTooltip.SetToolTip(this.btnLoadSettings, "Load and apply the selected settings");
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printMainDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // menuPageSetup
            // 
            this.menuPageSetup.Name = "menuPageSetup";
            this.menuPageSetup.Size = new System.Drawing.Size(237, 22);
            this.menuPageSetup.Text = "Pa&ge Setup...";
            this.menuPageSetup.Click += new System.EventHandler(this.menuPageSetup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(940, 568);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.btnDelSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.Text = "  RF Explorer for Windows";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.tabSpectrumAnalyzer.ResumeLayout(false);
            this.tabSpectrumAnalyzer.PerformLayout();
            this.groupDataFeed.ResumeLayout(false);
            this.groupDataFeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSampleSA)).EndInit();
            this.MainStatusBar.ResumeLayout(false);
            this.MainStatusBar.PerformLayout();
            this.groupCOM.ResumeLayout(false);
            this.groupCOM.PerformLayout();
            this.groupFreqSettings.ResumeLayout(false);
            this.groupFreqSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVideoFPS)).EndInit();
            this.groupRemoteScreen.ResumeLayout(false);
            this.groupRemoteScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScreenIndex)).EndInit();
            this.panelRemoteScreen.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.panelConfiguration.ResumeLayout(false);
            this.panelRFConnections.ResumeLayout(false);
            this.panelRFConnections.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.groupCalibration.ResumeLayout(false);
            this.groupCalibration.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.tabReport.PerformLayout();
            this.groupCommands.ResumeLayout(false);
            this.groupCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMultiGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleDecoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainFileMenu;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsRFE;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer m_timer_receive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MainViewMenu;
        private System.Windows.Forms.ToolStripMenuItem menuRealtimeData;
        private System.Windows.Forms.ToolStripMenuItem menuAveragedData;
        private System.Windows.Forms.ToolStripMenuItem menuMaxData;
        private System.Windows.Forms.ToolStripMenuItem menuMinData;
        private System.Windows.Forms.ToolStripMenuItem menuLoadRFE;
        private System.Windows.Forms.ToolStripMenuItem menuSaveOnClose;
        private System.Windows.Forms.ToolStripMenuItem menuPortInfo;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabSpectrumAnalyzer;
        private System.Windows.Forms.GroupBox groupDataFeed;
        private System.Windows.Forms.NumericUpDown numericIterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRunMode;
        private System.Windows.Forms.CheckBox chkHoldMode;
        private System.Windows.Forms.NumericUpDown numericSampleSA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolCOMStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripMemory;
        private System.Windows.Forms.ToolStripStatusLabel toolFile;
        private System.Windows.Forms.GroupBox groupCOM;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ComboBox COMPortCombo;
        private ZedGraph.ZedGraphControl zedSpectrumAnalyzer;
        private System.Windows.Forms.GroupBox groupFreqSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_sBottomDBM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_sTopDBM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_sEndFreq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_sFreqSpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_sStartFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_sCenterFreq;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuCleanReport;
        private System.Windows.Forms.CheckBox chkCalcMin;
        private System.Windows.Forms.CheckBox chkCalcMax;
        private System.Windows.Forms.CheckBox chkCalcAverage;
        private System.Windows.Forms.CheckBox chkCalcRealtime;
        private System.Windows.Forms.ToolStripMenuItem menuReinitializeData;
        private System.Windows.Forms.ToolStripMenuItem menuSaveCSV;
        private System.Windows.Forms.TabPage tabRemoteScreen;
        private System.Windows.Forms.GroupBox groupRemoteScreen;
        private System.Windows.Forms.NumericUpDown numericZoom;
        private System.Windows.Forms.CheckBox chkDumpScreen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numScreenIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem menuSaveRemoteImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuSaveRFS;
        private System.Windows.Forms.ToolStripMenuItem menuLoadRFS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolStripMenuItem menuShowPeak;
        private System.Windows.Forms.Panel panelRemoteScreen;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.ToolStripMenuItem menuShowControlArea;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.GroupBox groupCommands;
        private System.Windows.Forms.ComboBox comboStdCmd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboCustomCommand;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.ToolStripMenuItem menuDarkMode;
        private System.Windows.Forms.Button btnSaveRemoteVideo;
        private System.Windows.Forms.Button btnSaveRemoteBitmap;
        private System.Windows.Forms.Button btnSendCustomCmd;
        private System.Windows.Forms.TabPage tabRAWDecoder;
        private ZedGraph.ZedGraphControl zedRAWDecoder;
        private System.Windows.Forms.NumericUpDown numVideoFPS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupRAWDecoder;
        private System.Windows.Forms.NumericUpDown numMultiGraph;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numSampleDecoder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox m_sBaudRate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox m_sRefFrequency;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSaveRAWDecoderCSV;
        private System.Windows.Forms.RadioButton chkPSK;
        private System.Windows.Forms.RadioButton chkOOK;
        private System.Windows.Forms.GroupBox groupDemodulator;
        private System.Windows.Forms.CheckBox chkRunDecoder;
        private System.Windows.Forms.CheckBox chkHoldDecoder;
        private System.Windows.Forms.Button btnSpanDec;
        private System.Windows.Forms.Button btnSpanInc;
        private System.Windows.Forms.Button btnMoveFreqDecSmall;
        private System.Windows.Forms.Button btnMoveFreqIncSmall;
        private System.Windows.Forms.Button btnMoveFreqDecLarge;
        private System.Windows.Forms.Button btnMoveFreqIncLarge;
        private System.Windows.Forms.Button btnTop5plus;
        private System.Windows.Forms.Button btnTop5minus;
        private System.Windows.Forms.Button btnBottom5minus;
        private System.Windows.Forms.Button btnBottom5plus;
        private System.Windows.Forms.Button btnSpanMin;
        private System.Windows.Forms.Button btnSpanDefault;
        private System.Windows.Forms.Button btnSpanMax;
        private System.Windows.Forms.Button btnCenterMark;
        private System.Windows.Forms.Panel panelConfiguration;
        private System.Windows.Forms.GroupBox groupCalibration;
        private System.Windows.Forms.TextBox m_edCalibrationFreq;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.TextBox edDefaultFilePath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Button btnOpenLog;
        private System.Windows.Forms.Label labelReportFile;
        private System.Windows.Forms.ToolStripComboBox menuComboSavedOptions;
        private System.Windows.Forms.ToolTip m_MainFormTooltip;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnDelSettings;
        private System.Windows.Forms.ToolStripMenuItem menusSaveSimpleCSV;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboCSVFieldSeparator;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.ToolStripMenuItem menuContinuousLog;
        private System.Windows.Forms.CheckBox m_chkDebugTraces;
        private System.Windows.Forms.CheckBox chkDumpLCDGrid;
        private System.Windows.Forms.CheckBox chkDumpColorScreen;
        private RFEClientControls.RemoteScreenControl controlRemoteScreen;
        private System.Windows.Forms.Panel panelRFConnections;
        private RFEClientControls.RFModuleSelector controlRFModuleSelectorConfig;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEnableMainboard;
        private System.Windows.Forms.ToolStripMenuItem menuEnableExpansionBoard;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOnlineHelp;
        private System.Windows.Forms.ToolStripMenuItem menuDeviceManual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem menuReleaseNotes;
        private System.Windows.Forms.ToolStripMenuItem menuWindowsReleaseNotes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.CheckBox chkDumpHeader;
        private System.Windows.Forms.Label labelDumpBitmapSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSamples;
        private System.Windows.Forms.ToolStripMenuItem menuMaxHoldData;
        private System.Windows.Forms.ToolStripMenuItem menuRFConnections;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem menuAutoLCDOff;
        private System.Windows.Forms.ToolStripMenuItem menuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Drawing.Printing.PrintDocument printMainDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStripMenuItem menuPageSetup;
    }
}


using System;
using System.Collections.Generic;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Bimser.CSP.FormControls.Base;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.RuleManager;
using Bimser.CSP.FormControls.Enums;
using Bimser.Framework.Monitoring;
using Newtonsoft.Json;
using stj1_gorev_atama_sureci.Entities;

namespace stj1_gorev_atama_sureci.Forms {

    public partial class Form1 : Form<E_stj1_gorev_atama_sureci_Form1Entity> {

        // properties
        RadioList gorDerece { get; set; }
Tab Collapse_atanYeniPer { get; set; }
Rate gorevYuzde { get; set; }
Header Header2 { get; set; }
ComboBox gorAtananPer { get; set; }
DateTimePicker endDate { get; set; }
TextArea gorevTanim { get; set; }
NumberBox kalanSuresi { get; set; }
DateTimePicker startDate { get; set; }
Tab Collapse_yapilacakAksiyon { get; set; }
RelatedDocuments gorevDosya { get; set; }
DataGrid asamaTablo { get; set; }
DocumentMetadata gorevStartDate { get; set; }
Divider Divider1 { get; set; }
UserMetadata amirAd { get; set; }
NumberBox NumberOran { get; set; }
ListBox gorevList { get; set; }
DocumentMetadata gorevNo { get; set; }
TextBox gorevAd { get; set; }
Collapse atanacakPerCollapse { get; set; }
Tab Collapse_gorevBilgi { get; set; }


        // constructor
        public Form1(FormHttpParameters httpParameters, ITelemetryCollectorHolder telemetryCollectorHolder = null)
 : base(httpParameters, telemetryCollectorHolder)
        {

        }

        // initialize members
        public override void InitMembers ()
        {
            
gorDerece = new RadioList {
ControlId = "8dd52dd1-0d96-c7b3-b0da-f261e895b2ab",
Name = "gorDerece",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Önem Derecesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.gorDerece",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
Direction = Direction.Horizontal,
ButtonType = RadioListButtonType.Radio,
ShowSearch = false,
};

Controls.Add(gorDerece);
gorDerece.Items = new ListItemCollection();

gorDerece.Items.Add(new ListItem {
Value = "low",
Key = "low",
Icon = @"",
Selected = true,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Düşük" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorDerece.Items.Add(new ListItem {
Value = "middle",
Key = "middle",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Orta" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorDerece.Items.Add(new ListItem {
Value = "high",
Key = "high",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yüksek" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorDerece.Items.Add(new ListItem {
Value = "critical",
Key = "critical",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kritik" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_gordereceComponent = new BaseComponent {
Id = "gorDerece",
Type = "RadioList",
ParentId = "Column8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorDerece,
ViewProperties = "",
};

AddToViewItems("default", default_gordereceComponent);

BaseComponent default_column6Component = new BaseComponent {
Id = "Column6",
Type = "Column",
ParentId = "Section5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "0px 10px 0px 10px",
},
},
Items = new List<string> {
"gorAtananPer",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column6Component);

BaseComponent default_column7Component = new BaseComponent {
Id = "Column7",
Type = "Column",
ParentId = "Section6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"startDate",
"endDate",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column7Component);

BaseComponent default_column8Component = new BaseComponent {
Id = "Column8",
Type = "Column",
ParentId = "Section7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"gorDerece",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column8Component);

BaseComponent default_column9Component = new BaseComponent {
Id = "Column9",
Type = "Column",
ParentId = "Section8",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Header2",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column9Component);

Collapse_atanYeniPer = new Tab {
ControlId = "8b167127-c0c8-219f-156a-a8bdcfddd234",
Name = "Collapse_atanYeniPer",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Atanacak Personel Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = true,
Icon = "general",
OrderNo = 0
};

Controls.Add(Collapse_atanYeniPer);

BaseComponent default_collapse_atanyeniperComponent = new BaseComponent {
Id = "Collapse_atanYeniPer",
Type = "Tab",
ParentId = "atanacakPerCollapse",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section5",
"Section6",
"Section7",
},
Properties = Collapse_atanYeniPer,
ViewProperties = "",
};

AddToViewItems("default", default_collapse_atanyeniperComponent);

BaseComponent default_section10Component = new BaseComponent {
Id = "Section10",
Type = "Section",
ParentId = "Collapse_gorevBilgi",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column11",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section10Component);

gorevYuzde = new Rate {
ControlId = "956ef28c-faa2-2d15-265c-8493849864b0",
Name = "gorevYuzde",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Tamamlama Yüzdesi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "gorevYuzde",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = 0M,
AllowClear = false,
AllowHalf = false,
Count = 20,
Tooltips = new List<MultiLanguageText> {
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "5" },{ "en-US", "5" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "10" },{ "en-US", "10" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "15" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "20" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "25" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "30" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "35" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "40" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "45" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "50" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "55" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "60" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "65" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "70" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "75" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "80" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "85" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "90" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "95" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "100" },})
{
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
}
};

Controls.Add(gorevYuzde);

BaseComponent default_gorevyuzdeComponent = new BaseComponent {
Id = "gorevYuzde",
Type = "Rate",
ParentId = "Column13",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorevYuzde,
ViewProperties = "",
};

AddToViewItems("default", default_gorevyuzdeComponent);

Header2 = new Header {
ControlId = "ca9da68d-78f4-a78f-489d-87f51c928059",
Name = "Header2",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Header2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "",
Color = "#555",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görevlendilecek Personel;" },{ "en-US", "Header2" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
HeadingType = "h3"
};

Controls.Add(Header2);

BaseComponent default_header2Component = new BaseComponent {
Id = "Header2",
Type = "Header",
ParentId = "Column9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Header2,
ViewProperties = "",
};

AddToViewItems("default", default_header2Component);

BaseComponent default_section11Component = new BaseComponent {
Id = "Section11",
Type = "Section",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column12",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section11Component);

gorAtananPer = new ComboBox {
ControlId = "d4cade74-62a7-1175-f2b0-7a8999f6693e",
Name = "gorAtananPer",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görevlendirilecek Personel" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.gorAtananPer",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "astKisiler",
ValueMember = "ID",
DisplayMember = new List<string>{
"Ad Soyad",
},
DisplayFormat = "{{ Ad Soyad }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.MSSQL,
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
};

Controls.Add(gorAtananPer);
gorAtananPer.Items = new ListItemCollection();

BaseComponent default_goratananperComponent = new BaseComponent {
Id = "gorAtananPer",
Type = "ComboBox",
ParentId = "Column6",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorAtananPer,
ViewProperties = "",
};

AddToViewItems("default", default_goratananperComponent);

BaseComponent default_section12Component = new BaseComponent {
Id = "Section12",
Type = "Section",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column13",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section12Component);

BaseComponent default_section13Component = new BaseComponent {
Id = "Section13",
Type = "Section",
ParentId = "Collapse_yapilacakAksiyon",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section13Component);

BaseComponent default_section14Component = new BaseComponent {
Id = "Section14",
Type = "Section",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column14",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section14Component);

endDate = new DateTimePicker {
ControlId = "4ea2723f-e7d8-c57d-9c4f-a46a224500b3",
Name = "endDate",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "endDate_OnValueChanged",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Bitiş Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "endDate",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "",
SetTodayAsDefault = false,
ShowTime = false,
ShowToday = false,
AllowClear = true,
DisableBefore = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
DisableAfter = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
SizeType = null,
};

Controls.Add(endDate);

BaseComponent default_enddateComponent = new BaseComponent {
Id = "endDate",
Type = "DateTimePicker",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = endDate,
ViewProperties = "",
};

AddToViewItems("default", default_enddateComponent);

gorevTanim = new TextArea {
ControlId = "d19d3ffe-0022-79c8-1c5f-0b9bc7a157b7",
Name = "gorevTanim",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Tanımı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.gorevTanim",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(gorevTanim);

BaseComponent default_gorevtanimComponent = new BaseComponent {
Id = "gorevTanim",
Type = "TextArea",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorevTanim,
ViewProperties = "",
};

AddToViewItems("default", default_gorevtanimComponent);

ClientVisible = true;
ProjectName = "stj1_gorev_atama_sureci";
ProjectId = "72a1bf10-62d3-4ea3-adb3-e8e9858da515";
EntityPath = "";
ActiveView = "default";
Version = 10;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "Form1" },
{ "en-US", "Form1" },
};
Name = "Form1";
FormId = "40c930c8-4607-4024-ad43-b9d2720bf6cb";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnBeforeSave",
MethodName = "Form1_OnBeforeSave",
Async = null
},
new EventItem {
Name = "OnLoad",
MethodName = "Form1_OnLoad",
Async = null
},
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "Gorev_Atama";
IdentityFormatId = 136;
PrintingEnabled = false;
PrintView = "default";
CopyPasteEnabled = false;
VersioningEnabled = false;
CanSaveAsDraft = false;
PanelSize = 2;
Style = new Style {
Padding = "10px 20px 10px 20px",
BackgroundColor = "rgba(255, 255, 255, 0)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
};
PublicFields = new List<FormPublicField> {
};
ToolbarButtons = new List<ToolbarButton> {
new ToolbarButton {
Key = "toolbarSaveButton",
Name = "Kaydet",
Icon = "save",
Enabled = true,
DefaultEnabled = true,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Kaydet" },
{ "en-US", "Save" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_Statement_default_gorevListorAtananPer",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessagorevListe_default_gorAtananPer",
Name = "gorAtananPer_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Görevlendirilecek Personel: Gerekli alan"
},
{
"en-US",
"Görevlendirilecek Personel: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"gorAtananPer",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_gorAtananPer",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_gorevListorAtananPer_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "gorAtananPer",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_gorevListorAtananPer",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_startDate",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessagorevListe_default_startDate",
Name = "startDate_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Göreve Başlama Tarihi: Gerekli alan"
},
{
"en-US",
"Göreve Başlama Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"startDate",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_startDate",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_startDate_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "startDate",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_startDate",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_endDate",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessagorevListe_default_endDate",
Name = "endDate_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Görev Bitiş Tarihi: Gerekli alan"
},
{
"en-US",
"Görev Bitiş Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"endDate",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_endDate",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_endDate_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "endDate",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_endDate",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessagorevListe_default_gorAtananPer",
Name = "gorAtananPer_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Görevlendirilecek Personel: Gerekli alan"
},
{
"en-US",
"Görevlendirilecek Personel: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"gorAtananPer",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessagorevListe_default_startDate",
Name = "startDate_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Göreve Başlama Tarihi: Gerekli alan"
},
{
"en-US",
"Göreve Başlama Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"startDate",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessagorevListe_default_endDate",
Name = "endDate_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Görev Bitiş Tarihi: Gerekli alan"
},
{
"en-US",
"Görev Bitiş Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"endDate",
},
},
},
TriggerEvents = new List<string> {
"Form1.client.OnBeforeSave",
"Form1.server.OnBeforeSave",
"Form1.client.OnToolbarButtonClicked",
"Form1.server.OnToolbarButtonClicked",
}
}
},
{
"7d6731f3-d19d-4269-a322-6c1f8a1a25f1",
new Rule {
Id = "7d6731f3-d19d-4269-a322-6c1f8a1a25f1",
Name = "Atanan kullanıcı için tamamlanma yüzdesi ve aşama tablosu visible",
Enabled = true,
OrderNo = 1,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "dd8a806c-9d30-a797-9875-5fb115bfa021",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "eb4d0367-4cf6-a73d-60b6-958e8b0b4d4e",
Name = "yüzde visible true",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevYuzde",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "fcf54466-bdc0-696f-36e4-38efdd0876ac",
Name = "asama tablo visible true",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "asamaTablo",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "f989e38e-dc0f-a08c-3e50-4a37a1e9da87",
Name = "Atanan Personel Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorAtananPer",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "c5d3a39f-e068-2548-0f0c-6855ddc18065",
Name = "Başlangıç Tarihi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "startDate",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "01cdafa6-60e1-1179-577a-c66cdecf3fd2",
Name = "Bitiş Tarihi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "endDate",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "bcdbf99c-3099-ea8c-2de9-794338a1324b",
Name = "Görev Listesi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevList",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "d771f649-4f73-a109-4ac4-33a567064ac5",
Name = "Görev Derecesi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorDerece",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "9409f581-6918-db2f-490b-b3681a4d5074",
Name = "Görev Adı Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevAd",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "99284594-f2c7-a6e3-1ec0-30ea2fe7f187",
Name = "Görev Tanımı Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevTanim",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "8cc06d7b-cba6-f6d1-d913-233c0c87b83c",
Name = "Görev Dosyası Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevDosya",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "3ab17c7f-6750-8b50-41c6-1e38120ed069",
Name = "Kalan Süre Görünürlüğü",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "kalanSuresi",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
},
ConditionGroup = new OrConditionGroup {
Id = "654953d1-cd40-757b-257a-8f1a2658419c",
TypeName = ConjunctionType.OrConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "78e172f7-5baf-8a0a-4612-60ca3819f44b",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "responseParameters.workflowInfo.currentStep.name",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "secilenKullanici"
},
new ValueEntryCondition {
Id = "f2ccd240-f1ec-c530-403e-3286d34396c5",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Form1",
PropertyName = "responseParameters.workflowInfo.currentStep.name",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "amir"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValueAssignActionWithEntry {
Id = "eb4d0367-4cf6-a73d-60b6-958e8b0b4d4e",
Name = "yüzde visible true",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevYuzde",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "fcf54466-bdc0-696f-36e4-38efdd0876ac",
Name = "asama tablo visible true",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "asamaTablo",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "f989e38e-dc0f-a08c-3e50-4a37a1e9da87",
Name = "Atanan Personel Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorAtananPer",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "c5d3a39f-e068-2548-0f0c-6855ddc18065",
Name = "Başlangıç Tarihi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "startDate",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "01cdafa6-60e1-1179-577a-c66cdecf3fd2",
Name = "Bitiş Tarihi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "endDate",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "bcdbf99c-3099-ea8c-2de9-794338a1324b",
Name = "Görev Listesi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevList",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "d771f649-4f73-a109-4ac4-33a567064ac5",
Name = "Görev Derecesi Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorDerece",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "9409f581-6918-db2f-490b-b3681a4d5074",
Name = "Görev Adı Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevAd",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "99284594-f2c7-a6e3-1ec0-30ea2fe7f187",
Name = "Görev Tanımı Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevTanim",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "8cc06d7b-cba6-f6d1-d913-233c0c87b83c",
Name = "Görev Dosyası Read Only",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "gorevDosya",
PropertyName = "readOnly",
Type = FieldValueType.Boolean,
},
Value = true
},
new ValueAssignActionWithEntry {
Id = "3ab17c7f-6750-8b50-41c6-1e38120ed069",
Name = "Kalan Süre Görünürlüğü",
Enabled = true,
TypeName = ActionType.ValueAssignActionWithEntry,
Field = new ValueAssignActionField {
Name = "kalanSuresi",
PropertyName = "clientVisible",
Type = FieldValueType.Boolean,
},
Value = true
},
},
TriggerEvents = new List<string> {
"Form1.client.OnLoad",
}
}
},
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
SizeType = SizeType.Middle;
PaddingType = SizeType.Middle;
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yazılım Geliştirici Formu" },{ "en-US", "Form1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
};

Controls.Add(this);

BaseComponent default_form1Component = new BaseComponent {
Id = "Form1",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section3",
"Section4",
"Section11",
"Section12",
"Section14",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_form1Component);

BaseComponent default_section3Component = new BaseComponent {
Id = "Section3",
Type = "Section",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column3",
"Column5",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section3Component);

kalanSuresi = new NumberBox {
ControlId = "097ca41f-5a6a-f45d-4b71-fc3067cc06ed",
Name = "kalanSuresi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev İçin Kalan Süre" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "kalanSuresi",
ReadOnly = true,
DefaultReadOnly = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Min = null,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(kalanSuresi);

BaseComponent default_kalansuresiComponent = new BaseComponent {
Id = "kalanSuresi",
Type = "NumberBox",
ParentId = "Column13",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = kalanSuresi,
ViewProperties = "",
};

AddToViewItems("default", default_kalansuresiComponent);

BaseComponent default_section4Component = new BaseComponent {
Id = "Section4",
Type = "Section",
ParentId = "Form1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column4",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section4Component);

BaseComponent default_section5Component = new BaseComponent {
Id = "Section5",
Type = "Section",
ParentId = "Collapse_atanYeniPer",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column6",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section5Component);

startDate = new DateTimePicker {
ControlId = "5f6e7649-f2f0-3512-fbd7-94ac82efb517",
Name = "startDate",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnValueChanged",
MethodName = "startDate_OnValueChanged",
Async = null
},
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Göreve Başlama Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "startDate",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "",
SetTodayAsDefault = false,
ShowTime = false,
ShowToday = false,
AllowClear = true,
DisableBefore = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
DisableAfter = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
SizeType = null,
};

Controls.Add(startDate);

BaseComponent default_startdateComponent = new BaseComponent {
Id = "startDate",
Type = "DateTimePicker",
ParentId = "Column7",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = startDate,
ViewProperties = "",
};

AddToViewItems("default", default_startdateComponent);

BaseComponent default_section6Component = new BaseComponent {
Id = "Section6",
Type = "Section",
ParentId = "Collapse_atanYeniPer",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column7",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section6Component);

BaseComponent default_section7Component = new BaseComponent {
Id = "Section7",
Type = "Section",
ParentId = "Collapse_atanYeniPer",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column8",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section7Component);

BaseComponent default_section8Component = new BaseComponent {
Id = "Section8",
Type = "Section",
ParentId = "Collapse_yapilacakAksiyon",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column9",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section8Component);

Collapse_yapilacakAksiyon = new Tab {
ControlId = "4ea443fa-4c22-f42e-fc81-79fce41778a9",
Name = "Collapse_yapilacakAksiyon",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yapılacak Aksiyonlar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "general",
OrderNo = 1
};

Controls.Add(Collapse_yapilacakAksiyon);

BaseComponent default_collapse_yapilacakaksiyonComponent = new BaseComponent {
Id = "Collapse_yapilacakAksiyon",
Type = "Tab",
ParentId = "atanacakPerCollapse",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section8",
"Section9",
"Section13",
},
Properties = Collapse_yapilacakAksiyon,
ViewProperties = "",
};

AddToViewItems("default", default_collapse_yapilacakaksiyonComponent);

BaseComponent default_section9Component = new BaseComponent {
Id = "Section9",
Type = "Section",
ParentId = "Collapse_yapilacakAksiyon",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column10",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_section9Component);

BaseComponent default_column10Component = new BaseComponent {
Id = "Column10",
Type = "Column",
ParentId = "Section9",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"gorevList",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column10Component);

gorevDosya = new RelatedDocuments {
ControlId = "3440697f-8d02-b7a9-95ab-0c598c9eab28",
Name = "gorevDosya",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev ile ilgili Dosyalar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "RD.gorevDosya",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
Categories = new List<RelatedDocumentCategory> {
new RelatedDocumentCategory {
Id = 0,
CategoryId = "14425e1a-5197-cd92-73ea-546c78dae4b5",
Name = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
Description = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
MinFilesCount = 0,
MaxFilesCount = null,
MaxFileSize = null,
AllowedFileExtensions = new List<string> {
},
Enabled = true,
Path = "",
TargetId = ""
},
},
Files = new List<RelatedDocumentFile> {
},
AddingMode = RelatedDocumentsAddingMode.All,
ViewType = RelatedDocumentsViewType.Card,
AddNewEnabled = true,
DeleteEnabled = true,
Viewable = true,
CreateEnabled = false,
Path = "",
ShowCategoryDescription = false,
ShowFileDescription = false,
FileDescriptionIsRequired = false,
ShowContentForImageFiles = false,
ShowCreateDate = true,
ShowCreator = false,
ShowFileExtension = true,
ShowPath = true,
TargetId = "",
};

Controls.Add(gorevDosya);

BaseComponent default_gorevdosyaComponent = new BaseComponent {
Id = "gorevDosya",
Type = "RelatedDocuments",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorevDosya,
ViewProperties = "",
};

AddToViewItems("default", default_gorevdosyaComponent);

asamaTablo = new DataGrid {
ControlId = "eb616101-c0e4-380b-db0a-39e1a7166979",
Name = "asamaTablo",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnRowInserting",
MethodName = "asamaTablo_OnRowInserting",
Async = null
},
},
Visible = true,
ClientVisible = false,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "DataGrid1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "E_stj1_gorev_atama_sureci_Form1_asamaTablo",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
DisplayType = DataGridDisplayType.AutoGrow,
Columns = new DataGridColumnCollection {
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "IdAsama"
},
DbType = new ColumnDbType() {
ColumnName = "IdAsama",
Type = "decimal"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "ID" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.NumberBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "IdAsama",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = true,
IsGeneratedColumn = false,
Visible = false,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = true,
},
new GridColumn() {
EditControl = 
new DateTimePicker {
Visible = true,
EntityPath = "tarihAsama2",
Format = "",
},
DbType = new ColumnDbType() {
ColumnName = "tarihAsama2",
Type = "date"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Tarih" },
},
AllowHiding = false,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.DatePicker,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "tarihAsama",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = false,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new NumberBox {
Visible = true,
EntityPath = "ML.yuzdeAsama2"
},
DbType = new ColumnDbType() {
ColumnName = "yuzdeAsama2",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Aşama (%)" },
},
AllowHiding = true,
AllowNull = true,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.NumberBox,
EditingEnabled = false,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "yuzdeAsama",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = false,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
new GridColumn() {
EditControl = 
new TextBox {
Value = "",
Text = "",
EntityPath = "ML.yorumAsama",
MaxLength = 50
},
DbType = new ColumnDbType() {
ColumnName = "yorumAsama",
Type = "string"
},
FormatType = new ColumnFormatType {
Type = "label",
Format = ""
},
DisableToExport = false,
Precision = 0,
UseThousandSeparator = false,
Align = HorizontalAlign.Left,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Aşama Yorumu" },
},
AllowHiding = true,
AllowNull = false,
HeaderFilterEnabled = false,
Style = new Dictionary<string, object> {
},
EditType = ColumnEditType.TextBox,
EditingEnabled = true,
ShowEditorAlways = false,
Filtering = new DataGridColumnFilteringOptions {
Enabled = false,
Operation = DataGridFilteringOperation.Contains,
Value = "",
},
Index = 0,
Name = "yorumAsama",
Sorting = new DataGridColumnSortingOptions {
Enabled = true,
Index = 0,
Order = DataGridSortingDirection.Asc,
},
SummaryTypes = new List<DataGridSummaryType> {
},
SummaryTypePrefixes = new List<DataGridColumnSummary> {
},
Width = "100",
WordWrapEnabled = false,
IsPrimaryKey = false,
IsGeneratedColumn = false,
Visible = true,
HidingPriority = null,
SourceType = GridColumnSourceType.Base64,
EnlargeOnClick = false,
ImageWidth = 100,
SizeUnit = GridColumnSizeUnit.Pixels,
ImageType = GridColumnImageType.SmallImage,
IconMatchers = new List<IconMatchers>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
AutoIncrement = false,
},
},
Rows = new DataGridRowCollection {

},
DataSource = new DataSource {
Name = "",
ValueMember = "",
DisplayMember = new List<string>{
},
DisplayFormat = "",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = null,
},
ColumnSettings = new DataGridColumnOptions {
Orderable = false,
Resizeable = false,
ShowColumnChooser = false,
},
DetailRow = new DataGridDetailRowOptions {
Enabled = false,
},
Editing = new DataGridEditingOptions {
Enabled = false,
ShowAddCommand = true,
ShowEditCommand = true,
ShowDeleteCommand = true,
Mode = DataGridEditingModeType.Cell,
},
Filtering = new DataGridFilteringOptions {
Enabled = false,
ShowOperationChooser = false,
HeaderFilterEnabled = false,
},
Grouping = new DataGridGroupingOptions {
Enabled = false,
},
Paging = new DataGridPagingOptions {
Enabled = true,
CurrentPage = 1,
PageSize = 10,
PagingSizes = new List<int> {
10,
20,
30,
40,
},
},
Searching = new DataGridSearchingOptions {
Enabled = false,
},
Selection = new DataGridSelectionOptions {
Enabled = false,
Mode = DataGridSelectionMode.Single,
SelectAllMode = DataGridSelectAllMode.Page,
ShowCheckBoxesMode = DataGridShowCheckBoxMode.OnClick,
ShowSelectAll = false,
Type = DataGridSelectionType.Rowselect,
DisabledValueColumnName = "",
DisabledValueMatchers = new List<object>{
},},
Sorting = new DataGridSortingOptions {
Enabled = false,
AllSortingColumns = true,
Mode = DataGridSortingMode.None,
},
TreeView = new DataGridTreeViewOptions {
Enabled = false,
Id = "",
ParentId = "",
},
AlternateColor = new DataGridAlternateColorOptions {
Enabled = true,
Color = "rgba(33, 150, 243, 0.05)",
},
RowDragging = new DataGridRowDraggingOptions {
Enabled = false,
ShowDragIcons = false,
},
ToolbarActionButtons = new List<ExecuteActionButton> {
},
FillForm = null,
Height = null,
ExportToExcel = false,
GridBorder = true,
ColumnVerticalBorder = true,
VirtualScrolling = false,
HoverStateEnabled = false,
ShowClearAllButton = false,
ColumnAutoWidth = true,
SaveAction = false,
WordWrapEnabled = false,
ColumnHidingEnabled = false,
ColumnFixingEnabled = false,
GridLines = DataGridLineType.Horizontal,
DataSourceType = DataSourceType.Dynamic,
HiddenRowColumnName = null,
HiddenRowValueMatchers = new DataGridHiddenRowValueOptions {
},
};

Controls.Add(asamaTablo);

BaseComponent default_asamatabloComponent = new BaseComponent {
Id = "asamaTablo",
Type = "DataGrid",
ParentId = "Column13",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = asamaTablo,
ViewProperties = "",
};

AddToViewItems("default", default_asamatabloComponent);

gorevStartDate = new DocumentMetadata {
ControlId = "4201dc50-28ee-b89d-081b-38c5f854e1b1",
Name = "gorevStartDate",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Göreve Başlangıç Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "CREATEDAT",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = DocumentMetadataType.CreateDate,
DateFormat = "DD.MM.YYYY",
PullNumberOnStart = false,
PullNewNumber = false,
SizeType = null,
};

Controls.Add(gorevStartDate);

BaseComponent default_gorevstartdateComponent = new BaseComponent {
Id = "gorevStartDate",
Type = "DocumentMetadata",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorevStartDate,
ViewProperties = "",
};

AddToViewItems("default", default_gorevstartdateComponent);

BaseComponent default_column11Component = new BaseComponent {
Id = "Column11",
Type = "Column",
ParentId = "Section10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"gorevAd",
"gorevTanim",
"gorevDosya",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column11Component);

BaseComponent default_column12Component = new BaseComponent {
Id = "Column12",
Type = "Column",
ParentId = "Section11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Divider1",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column12Component);

BaseComponent default_column13Component = new BaseComponent {
Id = "Column13",
Type = "Column",
ParentId = "Section12",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"kalanSuresi",
"gorevYuzde",
"asamaTablo",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column13Component);

Divider1 = new Divider {
ControlId = "71ee345d-6b96-46b0-f151-51d6674e53fb",
Name = "Divider1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Divider1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
};

Controls.Add(Divider1);

BaseComponent default_divider1Component = new BaseComponent {
Id = "Divider1",
Type = "Divider",
ParentId = "Column12",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Divider1,
ViewProperties = "",
};

AddToViewItems("default", default_divider1Component);

amirAd = new UserMetadata {
ControlId = "6f64c6f5-82e9-1e94-f5c2-9a30c9ba977d",
Name = "amirAd",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "hizalaSola",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Amir Adı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "amirAd",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = UserMetadataType.NameAndSurname,
CustomMetadataName = "",
SizeType = Bimser.CSP.FormControls.Enums.SizeType.Middle,
PropertyType = UserMetadataOptionTypes.Text,
LocationDataType = LocationDataType.Coordinates,
};

Controls.Add(amirAd);

BaseComponent default_amiradComponent = new BaseComponent {
Id = "amirAd",
Type = "UserMetadata",
ParentId = "Column3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = amirAd,
ViewProperties = "",
};

AddToViewItems("default", default_amiradComponent);

BaseComponent default_column14Component = new BaseComponent {
Id = "Column14",
Type = "Column",
ParentId = "Section14",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"NumberOran",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column14Component);

NumberOran = new NumberBox {
ControlId = "9361cd16-4974-77a1-f11b-5256b72b9c1e",
Name = "NumberOran",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = false,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Oran Sayısı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "NumberOran",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = null,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(NumberOran);

BaseComponent default_numberoranComponent = new BaseComponent {
Id = "NumberOran",
Type = "NumberBox",
ParentId = "Column14",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = NumberOran,
ViewProperties = "",
};

AddToViewItems("default", default_numberoranComponent);

gorevList = new ListBox {
ControlId = "9371a262-874b-777a-090f-b03ada5d3ca8",
Name = "gorevList",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "ListBox1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "SL.gorevList",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
},
DataSourceType = DataSourceType.Static,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
TextSeparator = ",",
ValueSeparator = ",",
ShowSearch = false,
Direction = Direction.Vertical,
AllowSelectAll = false
};

Controls.Add(gorevList);
gorevList.Items = new ListItemCollection();

gorevList.Items.Add(new ListItem {
Value = "list1",
Key = "list1",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yapılan görev ile ilgili dökuman hazırlanacak mı ?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorevList.Items.Add(new ListItem {
Value = "list2",
Key = "list2",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Eğitim süreci olacak mı ?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorevList.Items.Add(new ListItem {
Value = "list3",
Key = "list3",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kod örneği hazırlanacak mı ?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorevList.Items.Add(new ListItem {
Value = "list4",
Key = "list4",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Müşteri ortamlarına bağlantı yapılması gerekiyor mu ?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorevList.Items.Add(new ListItem {
Value = "list5",
Key = "list5",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Geliştirme esnasında müşteriyle paralel mi ilerlenecek ?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorevList.Items.Add(new ListItem {
Value = "list6",
Key = "list6",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Destek birimleri için talepler oluşturulması gerekli mi ?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

gorevList.Items.Add(new ListItem {
Value = "list7",
Key = "list7",
Icon = @"",
Selected = false,
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Bilgilendirme maillerinde müşteriler bulunacak mı ?" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
});

BaseComponent default_gorevlistComponent = new BaseComponent {
Id = "gorevList",
Type = "ListBox",
ParentId = "Column10",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorevList,
ViewProperties = "",
};

AddToViewItems("default", default_gorevlistComponent);

gorevNo = new DocumentMetadata {
ControlId = "d34f2d32-6e92-afee-fb5a-368d7b1335dd",
Name = "gorevNo",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev NO" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "UNIQUEID",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
MetadataType = DocumentMetadataType.Id,
DateFormat = "",
PullNumberOnStart = true,
PullNewNumber = false,
SizeType = null,
};

Controls.Add(gorevNo);

BaseComponent default_gorevnoComponent = new BaseComponent {
Id = "gorevNo",
Type = "DocumentMetadata",
ParentId = "Column5",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorevNo,
ViewProperties = "",
};

AddToViewItems("default", default_gorevnoComponent);

BaseComponent default_column3Component = new BaseComponent {
Id = "Column3",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"amirAd",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column3Component);

gorevAd = new TextBox {
ControlId = "2d5dcb95-f743-18f4-5a9a-dd01e95e5689",
Name = "gorevAd",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Adı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "ML.gorevAd",
ReadOnly = false,
DefaultReadOnly = false,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 50,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = false,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
SizeType = null,
};

Controls.Add(gorevAd);

BaseComponent default_gorevadComponent = new BaseComponent {
Id = "gorevAd",
Type = "TextBox",
ParentId = "Column11",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = gorevAd,
ViewProperties = "",
};

AddToViewItems("default", default_gorevadComponent);

atanacakPerCollapse = new Collapse {
ControlId = "916ee91a-9ca1-f782-5ff8-18a4c7b8f209",
Name = "atanacakPerCollapse",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "",
BackgroundColor = "rgb(255, 255, 255)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = 300
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Collapse1" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
Items = new List<TabItem> {
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Atanacak Personel Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Collapse_atanYeniPer",
Enabled = true,
Icon = "general",
OrderNo = 0,
Selected = true
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Yapılacak Aksiyonlar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Collapse_yapilacakAksiyon",
Enabled = true,
Icon = "general",
OrderNo = 1,
Selected = false
},
new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Collapse_gorevBilgi",
Enabled = true,
Icon = "general",
OrderNo = 2,
Selected = false
},
},
SelectedIndex = 0,
SelectedItem = new TabItem {
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Atanacak Personel Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Key = "Collapse_atanYeniPer",
Enabled = true,
Icon = "general",
OrderNo = 0,
Selected = true
},
TabPosition = Position.Top,
HasScrollbar = true,
Accordion = false,
ToolboxItems = new List<ToolboxItem> {
},
};

Controls.Add(atanacakPerCollapse);

BaseComponent default_atanacakpercollapseComponent = new BaseComponent {
Id = "atanacakPerCollapse",
Type = "Collapse",
ParentId = "Column4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Collapse_gorevBilgi",
"Collapse_yapilacakAksiyon",
"Collapse_atanYeniPer",
},
Properties = atanacakPerCollapse,
ViewProperties = "",
};

AddToViewItems("default", default_atanacakpercollapseComponent);

Collapse_gorevBilgi = new Tab {
ControlId = "f0047d8d-8a65-57e2-d8e0-3f451a1f1691",
Name = "Collapse_gorevBilgi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.Container,
Style = new Style {
Padding = "10px 15px 10px 15px",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Görev Bilgileri" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = false,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
ReadOnly = false,
DefaultReadOnly = false,
HeaderMode = HeaderMode.Titled,
CollapsedDefault = false,
TitleFont = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "12",
Color = "",
Bold = true,
Italic = false,
Underline = false,
Strikethrough = false
},
Key = "",
Selected = false,
Icon = "general",
OrderNo = 2
};

Controls.Add(Collapse_gorevBilgi);

BaseComponent default_collapse_gorevbilgiComponent = new BaseComponent {
Id = "Collapse_gorevBilgi",
Type = "Tab",
ParentId = "atanacakPerCollapse",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section10",
},
Properties = Collapse_gorevBilgi,
ViewProperties = "",
};

AddToViewItems("default", default_collapse_gorevbilgiComponent);

BaseComponent default_column4Component = new BaseComponent {
Id = "Column4",
Type = "Column",
ParentId = "Section4",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"atanacakPerCollapse",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column4Component);

BaseComponent default_column5Component = new BaseComponent {
Id = "Column5",
Type = "Column",
ParentId = "Section3",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"gorevNo",
"gorevStartDate",
},
Properties = null,
ViewProperties = "",
};

AddToViewItems("default", default_column5Component);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            






















        }
    }
}
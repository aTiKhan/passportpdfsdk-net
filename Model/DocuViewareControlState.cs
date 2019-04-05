/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PassportPDF.Client.OpenAPIDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Specifies configuration and appearance state of a DocuVieware control.
    /// </summary>
    [DataContract]
    public partial class DocuViewareControlState :  IEquatable<DocuViewareControlState>, IValidatableObject
    {
        /// <summary>
        /// Specifies the document alignment set within the control.
        /// </summary>
        /// <value>Specifies the document alignment set within the control.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentAlignmentEnum
        {
            /// <summary>
            /// Enum MiddleLeft for value: MiddleLeft
            /// </summary>
            [EnumMember(Value = "MiddleLeft")]
            MiddleLeft = 1,

            /// <summary>
            /// Enum MiddleRight for value: MiddleRight
            /// </summary>
            [EnumMember(Value = "MiddleRight")]
            MiddleRight = 2,

            /// <summary>
            /// Enum MiddleCenter for value: MiddleCenter
            /// </summary>
            [EnumMember(Value = "MiddleCenter")]
            MiddleCenter = 3,

            /// <summary>
            /// Enum TopLeft for value: TopLeft
            /// </summary>
            [EnumMember(Value = "TopLeft")]
            TopLeft = 4,

            /// <summary>
            /// Enum TopRight for value: TopRight
            /// </summary>
            [EnumMember(Value = "TopRight")]
            TopRight = 5,

            /// <summary>
            /// Enum TopCenter for value: TopCenter
            /// </summary>
            [EnumMember(Value = "TopCenter")]
            TopCenter = 6,

            /// <summary>
            /// Enum BottomLeft for value: BottomLeft
            /// </summary>
            [EnumMember(Value = "BottomLeft")]
            BottomLeft = 7,

            /// <summary>
            /// Enum BottomRight for value: BottomRight
            /// </summary>
            [EnumMember(Value = "BottomRight")]
            BottomRight = 8,

            /// <summary>
            /// Enum BottomCenter for value: BottomCenter
            /// </summary>
            [EnumMember(Value = "BottomCenter")]
            BottomCenter = 9

        }

        /// <summary>
        /// Specifies the document alignment set within the control.
        /// </summary>
        /// <value>Specifies the document alignment set within the control.</value>
        [DataMember(Name="DocumentAlignment", EmitDefaultValue=false)]
        public DocumentAlignmentEnum? DocumentAlignment { get; set; }
        /// <summary>
        /// Specifies the document position set within the control.
        /// </summary>
        /// <value>Specifies the document position set within the control.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentPositionEnum
        {
            /// <summary>
            /// Enum MiddleLeft for value: MiddleLeft
            /// </summary>
            [EnumMember(Value = "MiddleLeft")]
            MiddleLeft = 1,

            /// <summary>
            /// Enum MiddleRight for value: MiddleRight
            /// </summary>
            [EnumMember(Value = "MiddleRight")]
            MiddleRight = 2,

            /// <summary>
            /// Enum MiddleCenter for value: MiddleCenter
            /// </summary>
            [EnumMember(Value = "MiddleCenter")]
            MiddleCenter = 3,

            /// <summary>
            /// Enum TopLeft for value: TopLeft
            /// </summary>
            [EnumMember(Value = "TopLeft")]
            TopLeft = 4,

            /// <summary>
            /// Enum TopRight for value: TopRight
            /// </summary>
            [EnumMember(Value = "TopRight")]
            TopRight = 5,

            /// <summary>
            /// Enum TopCenter for value: TopCenter
            /// </summary>
            [EnumMember(Value = "TopCenter")]
            TopCenter = 6,

            /// <summary>
            /// Enum BottomLeft for value: BottomLeft
            /// </summary>
            [EnumMember(Value = "BottomLeft")]
            BottomLeft = 7,

            /// <summary>
            /// Enum BottomRight for value: BottomRight
            /// </summary>
            [EnumMember(Value = "BottomRight")]
            BottomRight = 8,

            /// <summary>
            /// Enum BottomCenter for value: BottomCenter
            /// </summary>
            [EnumMember(Value = "BottomCenter")]
            BottomCenter = 9

        }

        /// <summary>
        /// Specifies the document position set within the control.
        /// </summary>
        /// <value>Specifies the document position set within the control.</value>
        [DataMember(Name="DocumentPosition", EmitDefaultValue=false)]
        public DocumentPositionEnum? DocumentPosition { get; set; }
        /// <summary>
        /// Specifies the zoom mode used by the viewer.
        /// </summary>
        /// <value>Specifies the zoom mode used by the viewer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ZoomModeEnum
        {
            /// <summary>
            /// Enum ZoomMode100 for value: ZoomMode100
            /// </summary>
            [EnumMember(Value = "ZoomMode100")]
            ZoomMode100 = 1,

            /// <summary>
            /// Enum ZoomModeFitToViewer for value: ZoomModeFitToViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeFitToViewer")]
            ZoomModeFitToViewer = 2,

            /// <summary>
            /// Enum ZoomModeWidthViewer for value: ZoomModeWidthViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeWidthViewer")]
            ZoomModeWidthViewer = 3,

            /// <summary>
            /// Enum ZoomModeCustom for value: ZoomModeCustom
            /// </summary>
            [EnumMember(Value = "ZoomModeCustom")]
            ZoomModeCustom = 4,

            /// <summary>
            /// Enum ZoomModeHeightViewer for value: ZoomModeHeightViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeHeightViewer")]
            ZoomModeHeightViewer = 5,

            /// <summary>
            /// Enum ZoomModeToViewer for value: ZoomModeToViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeToViewer")]
            ZoomModeToViewer = 6,

            /// <summary>
            /// Enum ZoomModeShrinkToViewerWidth for value: ZoomModeShrinkToViewerWidth
            /// </summary>
            [EnumMember(Value = "ZoomModeShrinkToViewerWidth")]
            ZoomModeShrinkToViewerWidth = 7

        }

        /// <summary>
        /// Specifies the zoom mode used by the viewer.
        /// </summary>
        /// <value>Specifies the zoom mode used by the viewer.</value>
        [DataMember(Name="ZoomMode", EmitDefaultValue=false)]
        public ZoomModeEnum? ZoomMode { get; set; }
        /// <summary>
        /// Specifies the zoom mode to set when a new document is loaded.
        /// </summary>
        /// <value>Specifies the zoom mode to set when a new document is loaded.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpenZoomModeEnum
        {
            /// <summary>
            /// Enum ZoomMode100 for value: ZoomMode100
            /// </summary>
            [EnumMember(Value = "ZoomMode100")]
            ZoomMode100 = 1,

            /// <summary>
            /// Enum ZoomModeFitToViewer for value: ZoomModeFitToViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeFitToViewer")]
            ZoomModeFitToViewer = 2,

            /// <summary>
            /// Enum ZoomModeWidthViewer for value: ZoomModeWidthViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeWidthViewer")]
            ZoomModeWidthViewer = 3,

            /// <summary>
            /// Enum ZoomModeCustom for value: ZoomModeCustom
            /// </summary>
            [EnumMember(Value = "ZoomModeCustom")]
            ZoomModeCustom = 4,

            /// <summary>
            /// Enum ZoomModeHeightViewer for value: ZoomModeHeightViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeHeightViewer")]
            ZoomModeHeightViewer = 5,

            /// <summary>
            /// Enum ZoomModeToViewer for value: ZoomModeToViewer
            /// </summary>
            [EnumMember(Value = "ZoomModeToViewer")]
            ZoomModeToViewer = 6,

            /// <summary>
            /// Enum ZoomModeShrinkToViewerWidth for value: ZoomModeShrinkToViewerWidth
            /// </summary>
            [EnumMember(Value = "ZoomModeShrinkToViewerWidth")]
            ZoomModeShrinkToViewerWidth = 7

        }

        /// <summary>
        /// Specifies the zoom mode to set when a new document is loaded.
        /// </summary>
        /// <value>Specifies the zoom mode to set when a new document is loaded.</value>
        [DataMember(Name="OpenZoomMode", EmitDefaultValue=false)]
        public OpenZoomModeEnum? OpenZoomMode { get; set; }
        /// <summary>
        /// Specifies the current rotation of the control.
        /// </summary>
        /// <value>Specifies the current rotation of the control.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewRotationEnum
        {
            /// <summary>
            /// Enum RotateNoneFlipNone for value: RotateNoneFlipNone
            /// </summary>
            [EnumMember(Value = "RotateNoneFlipNone")]
            RotateNoneFlipNone = 1,

            /// <summary>
            /// Enum Rotate90FlipNone for value: Rotate90FlipNone
            /// </summary>
            [EnumMember(Value = "Rotate90FlipNone")]
            Rotate90FlipNone = 2,

            /// <summary>
            /// Enum Rotate180FlipNone for value: Rotate180FlipNone
            /// </summary>
            [EnumMember(Value = "Rotate180FlipNone")]
            Rotate180FlipNone = 3,

            /// <summary>
            /// Enum Rotate270FlipNone for value: Rotate270FlipNone
            /// </summary>
            [EnumMember(Value = "Rotate270FlipNone")]
            Rotate270FlipNone = 4,

            /// <summary>
            /// Enum RotateNoneFlipX for value: RotateNoneFlipX
            /// </summary>
            [EnumMember(Value = "RotateNoneFlipX")]
            RotateNoneFlipX = 5,

            /// <summary>
            /// Enum Rotate90FlipX for value: Rotate90FlipX
            /// </summary>
            [EnumMember(Value = "Rotate90FlipX")]
            Rotate90FlipX = 6,

            /// <summary>
            /// Enum Rotate180FlipX for value: Rotate180FlipX
            /// </summary>
            [EnumMember(Value = "Rotate180FlipX")]
            Rotate180FlipX = 7,

            /// <summary>
            /// Enum Rotate270FlipX for value: Rotate270FlipX
            /// </summary>
            [EnumMember(Value = "Rotate270FlipX")]
            Rotate270FlipX = 8

        }

        /// <summary>
        /// Specifies the current rotation of the control.
        /// </summary>
        /// <value>Specifies the current rotation of the control.</value>
        [DataMember(Name="ViewRotation", EmitDefaultValue=false)]
        public ViewRotationEnum? ViewRotation { get; set; }
        /// <summary>
        /// Specifies the current page rotation of the displayed document.
        /// </summary>
        /// <value>Specifies the current page rotation of the displayed document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageRotationEnum
        {
            /// <summary>
            /// Enum RotateNoneFlipNone for value: RotateNoneFlipNone
            /// </summary>
            [EnumMember(Value = "RotateNoneFlipNone")]
            RotateNoneFlipNone = 1,

            /// <summary>
            /// Enum Rotate90FlipNone for value: Rotate90FlipNone
            /// </summary>
            [EnumMember(Value = "Rotate90FlipNone")]
            Rotate90FlipNone = 2,

            /// <summary>
            /// Enum Rotate180FlipNone for value: Rotate180FlipNone
            /// </summary>
            [EnumMember(Value = "Rotate180FlipNone")]
            Rotate180FlipNone = 3,

            /// <summary>
            /// Enum Rotate270FlipNone for value: Rotate270FlipNone
            /// </summary>
            [EnumMember(Value = "Rotate270FlipNone")]
            Rotate270FlipNone = 4,

            /// <summary>
            /// Enum RotateNoneFlipX for value: RotateNoneFlipX
            /// </summary>
            [EnumMember(Value = "RotateNoneFlipX")]
            RotateNoneFlipX = 5,

            /// <summary>
            /// Enum Rotate90FlipX for value: Rotate90FlipX
            /// </summary>
            [EnumMember(Value = "Rotate90FlipX")]
            Rotate90FlipX = 6,

            /// <summary>
            /// Enum Rotate180FlipX for value: Rotate180FlipX
            /// </summary>
            [EnumMember(Value = "Rotate180FlipX")]
            Rotate180FlipX = 7,

            /// <summary>
            /// Enum Rotate270FlipX for value: Rotate270FlipX
            /// </summary>
            [EnumMember(Value = "Rotate270FlipX")]
            Rotate270FlipX = 8

        }

        /// <summary>
        /// Specifies the current page rotation of the displayed document.
        /// </summary>
        /// <value>Specifies the current page rotation of the displayed document.</value>
        [DataMember(Name="PageRotation", EmitDefaultValue=false)]
        public PageRotationEnum? PageRotation { get; set; }
        /// <summary>
        /// Specifies the view mode used by the viewer.
        /// </summary>
        /// <value>Specifies the view mode used by the viewer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageViewModeEnum
        {
            /// <summary>
            /// Enum SinglePageView for value: SinglePageView
            /// </summary>
            [EnumMember(Value = "SinglePageView")]
            SinglePageView = 1,

            /// <summary>
            /// Enum MultiplePagesView for value: MultiplePagesView
            /// </summary>
            [EnumMember(Value = "MultiplePagesView")]
            MultiplePagesView = 2

        }

        /// <summary>
        /// Specifies the view mode used by the viewer.
        /// </summary>
        /// <value>Specifies the view mode used by the viewer.</value>
        [DataMember(Name="PageViewMode", EmitDefaultValue=false)]
        public PageViewModeEnum? PageViewMode { get; set; }
        /// <summary>
        /// Specifies the user preference information related to the user&#39;s language.
        /// </summary>
        /// <value>Specifies the user preference information related to the user&#39;s language.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocaleEnum
        {
            /// <summary>
            /// Enum Auto for value: Auto
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 1,

            /// <summary>
            /// Enum Fr for value: Fr
            /// </summary>
            [EnumMember(Value = "Fr")]
            Fr = 2,

            /// <summary>
            /// Enum En for value: En
            /// </summary>
            [EnumMember(Value = "En")]
            En = 3,

            /// <summary>
            /// Enum Ro for value: Ro
            /// </summary>
            [EnumMember(Value = "Ro")]
            Ro = 4,

            /// <summary>
            /// Enum Ar for value: Ar
            /// </summary>
            [EnumMember(Value = "Ar")]
            Ar = 5,

            /// <summary>
            /// Enum De for value: De
            /// </summary>
            [EnumMember(Value = "De")]
            De = 6,

            /// <summary>
            /// Enum It for value: It
            /// </summary>
            [EnumMember(Value = "It")]
            It = 7,

            /// <summary>
            /// Enum Tr for value: Tr
            /// </summary>
            [EnumMember(Value = "Tr")]
            Tr = 8,

            /// <summary>
            /// Enum Sk for value: Sk
            /// </summary>
            [EnumMember(Value = "Sk")]
            Sk = 9,

            /// <summary>
            /// Enum Cs for value: Cs
            /// </summary>
            [EnumMember(Value = "Cs")]
            Cs = 10,

            /// <summary>
            /// Enum Es for value: Es
            /// </summary>
            [EnumMember(Value = "Es")]
            Es = 11,

            /// <summary>
            /// Enum Da for value: Da
            /// </summary>
            [EnumMember(Value = "Da")]
            Da = 12,

            /// <summary>
            /// Enum Ru for value: Ru
            /// </summary>
            [EnumMember(Value = "Ru")]
            Ru = 13,

            /// <summary>
            /// Enum Pt for value: Pt
            /// </summary>
            [EnumMember(Value = "Pt")]
            Pt = 14,

            /// <summary>
            /// Enum Nl for value: Nl
            /// </summary>
            [EnumMember(Value = "Nl")]
            Nl = 15,

            /// <summary>
            /// Enum Pl for value: Pl
            /// </summary>
            [EnumMember(Value = "Pl")]
            Pl = 16,

            /// <summary>
            /// Enum Hu for value: Hu
            /// </summary>
            [EnumMember(Value = "Hu")]
            Hu = 17,

            /// <summary>
            /// Enum Bg for value: Bg
            /// </summary>
            [EnumMember(Value = "Bg")]
            Bg = 18,

            /// <summary>
            /// Enum El for value: El
            /// </summary>
            [EnumMember(Value = "El")]
            El = 19,

            /// <summary>
            /// Enum Zh for value: Zh
            /// </summary>
            [EnumMember(Value = "Zh")]
            Zh = 20,

            /// <summary>
            /// Enum Ja for value: Ja
            /// </summary>
            [EnumMember(Value = "Ja")]
            Ja = 21,

            /// <summary>
            /// Enum Sv for value: Sv
            /// </summary>
            [EnumMember(Value = "Sv")]
            Sv = 22,

            /// <summary>
            /// Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")]
            No = 23,

            /// <summary>
            /// Enum Ko for value: Ko
            /// </summary>
            [EnumMember(Value = "Ko")]
            Ko = 24,

            /// <summary>
            /// Enum He for value: He
            /// </summary>
            [EnumMember(Value = "He")]
            He = 25,

            /// <summary>
            /// Enum Fi for value: Fi
            /// </summary>
            [EnumMember(Value = "Fi")]
            Fi = 26,

            /// <summary>
            /// Enum Sl for value: Sl
            /// </summary>
            [EnumMember(Value = "Sl")]
            Sl = 27

        }

        /// <summary>
        /// Specifies the user preference information related to the user&#39;s language.
        /// </summary>
        /// <value>Specifies the user preference information related to the user&#39;s language.</value>
        [DataMember(Name="Locale", EmitDefaultValue=false)]
        public LocaleEnum? Locale { get; set; }
        /// <summary>
        /// Specifies the rotation mode associated with the rotation button group.
        /// </summary>
        /// <value>Specifies the rotation mode associated with the rotation button group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RotateButtonsModeEnum
        {
            /// <summary>
            /// Enum View for value: View
            /// </summary>
            [EnumMember(Value = "View")]
            View = 1,

            /// <summary>
            /// Enum CurrentPage for value: CurrentPage
            /// </summary>
            [EnumMember(Value = "CurrentPage")]
            CurrentPage = 2

        }

        /// <summary>
        /// Specifies the rotation mode associated with the rotation button group.
        /// </summary>
        /// <value>Specifies the rotation mode associated with the rotation button group.</value>
        [DataMember(Name="RotateButtonsMode", EmitDefaultValue=false)]
        public RotateButtonsModeEnum? RotateButtonsMode { get; set; }
        /// <summary>
        /// Specifies the Toolbar style, Desktop, Mobile or Auto.
        /// </summary>
        /// <value>Specifies the Toolbar style, Desktop, Mobile or Auto.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ToolbarStyleEnum
        {
            /// <summary>
            /// Enum Auto for value: Auto
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto = 1,

            /// <summary>
            /// Enum Desktop for value: Desktop
            /// </summary>
            [EnumMember(Value = "Desktop")]
            Desktop = 2,

            /// <summary>
            /// Enum Mobile for value: Mobile
            /// </summary>
            [EnumMember(Value = "Mobile")]
            Mobile = 3

        }

        /// <summary>
        /// Specifies the Toolbar style, Desktop, Mobile or Auto.
        /// </summary>
        /// <value>Specifies the Toolbar style, Desktop, Mobile or Auto.</value>
        [DataMember(Name="ToolbarStyle", EmitDefaultValue=false)]
        public ToolbarStyleEnum? ToolbarStyle { get; set; }
        /// <summary>
        /// Specifies the quality level to be used to print documents.
        /// </summary>
        /// <value>Specifies the quality level to be used to print documents.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrintQualityEnum
        {
            /// <summary>
            /// Enum Low for value: Low
            /// </summary>
            [EnumMember(Value = "Low")]
            Low = 1,

            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,

            /// <summary>
            /// Enum High for value: High
            /// </summary>
            [EnumMember(Value = "High")]
            High = 3,

            /// <summary>
            /// Enum VeryHigh for value: VeryHigh
            /// </summary>
            [EnumMember(Value = "VeryHigh")]
            VeryHigh = 4

        }

        /// <summary>
        /// Specifies the quality level to be used to print documents.
        /// </summary>
        /// <value>Specifies the quality level to be used to print documents.</value>
        [DataMember(Name="PrintQuality", EmitDefaultValue=false)]
        public PrintQualityEnum? PrintQuality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocuViewareControlState" /> class.
        /// </summary>
        /// <param name="textSearchMaxResults">Specifies the maximum number of results provided by a text search request..</param>
        /// <param name="timeout">Specifies the amount of time, in minutes, allowed between requests before the DocuVieware session-state provider terminates the session.&lt;br /&gt;.</param>
        /// <param name="controlId">Specifies the identifier associated with the control..</param>
        /// <param name="showLogo">Specifies if the DocuVieware logo is displayed in the toolbar..</param>
        /// <param name="remoteIP">Specifies the remote IP. This property can be leaved empty if user requests don&#39;t need to be traced..</param>
        /// <param name="documentAlignment">Specifies the document alignment set within the control..</param>
        /// <param name="documentPosition">Specifies the document position set within the control..</param>
        /// <param name="enableGdPictureAnnotations">Specifies if GdPicture/XMP annotations support is activated..</param>
        /// <param name="enableFormFieldsEdition">Specifies whether form fields can be edited into the client browser or not..</param>
        /// <param name="annotationEditorMode">Specifies the editor mode for the GdPicture/XMP annotation support.&lt;br /&gt;.</param>
        /// <param name="zoom">Specifies the current factor of zoom applied during page rendering operations: 1 for 100%, 1.5 for 150%, 2 for 200%....</param>
        /// <param name="zoomMode">Specifies the zoom mode used by the viewer..</param>
        /// <param name="openZoomMode">Specifies the zoom mode to set when a new document is loaded..</param>
        /// <param name="viewRotation">Specifies the current rotation of the control..</param>
        /// <param name="pageRotation">Specifies the current page rotation of the displayed document..</param>
        /// <param name="zoomStep">Defines the percentage of increasing or decreasing level of zoom for &#39;Zoom In&#39; and &#39;Zoom Out&#39; operations..</param>
        /// <param name="scrollBars">Specifies whether scrollbars can be displayed or not within the viewer.&lt;br /&gt;.</param>
        /// <param name="forceScrollBars">Specifies whether the viewer shall always show scrollbars..</param>
        /// <param name="pageViewMode">Specifies the view mode used by the viewer..</param>
        /// <param name="enableTextSelection">Specifies if text selection is permitted..</param>
        /// <param name="enableTextSelectionAnnotation">Specifies whether the selected text context menu options should contain annotations entries..</param>
        /// <param name="locale">Specifies the user preference information related to the user&#39;s language..</param>
        /// <param name="userLanguages">Specifies the different languages used by the user&#39;s browser..</param>
        /// <param name="controlWidth">Specifies the width of the control within its container..</param>
        /// <param name="controlHeight">Specifies, the height of the control within its container..</param>
        /// <param name="annotationDropShadow">Specifies whether GdPicture/XMP annotations are rendered with a drop shadow effect..</param>
        /// <param name="allowPrint">Specifies whether printing is allowed..</param>
        /// <param name="allowUpload">Specifies whether file upload is allowed..</param>
        /// <param name="enableMultipleThumbnailSelection">Specifies whether multiple thumbnails selection is allowed..</param>
        /// <param name="enableThumbnailDragDrop">Specifies whether the thumbnails can be moved by drag and drop..</param>
        /// <param name="enableFileUploadButton">Specifies whether the open button shall be enabled..</param>
        /// <param name="enableLoadFromUriButton">Specifies whether the &#39;open from uri&#39; button shall be enabled..</param>
        /// <param name="enableSaveButton">Specifies whether the save button shall be enabled..</param>
        /// <param name="enablePagesNavigationButtons">Specifies whether the save button shall be enabled..</param>
        /// <param name="enablePrintButton">Specifies whether the print button shall be enabled..</param>
        /// <param name="enableFitWidthButton">Specifies whether the fit width button shall be enabled..</param>
        /// <param name="enableZoom100Button">Specifies whether the fit original size button shall be enabled..</param>
        /// <param name="enableMouseModeButtons">Specifies whether the mouse mode button group shall be enabled..</param>
        /// <param name="enablePanModeButton">Specifies whether the pan mode button shall be enabled..</param>
        /// <param name="enableSelectModeButton">Specifies whether the select mode button shall be enabled..</param>
        /// <param name="enableMarqueeZoomModeButton">Specifies whether the marquee zoom mode button shall be enabled..</param>
        /// <param name="enableFullScreenButton">Specifies whether the fullscreen button shall be enabled..</param>
        /// <param name="enableFitPageButton">Specifies whether the &#39;Fit Page&#39; button shall be enabled..</param>
        /// <param name="enableZoomButtons">Specifies whether the zoom button group shall be enabled..</param>
        /// <param name="enablePageViewButtons">Specifies whether the page view mode button shall be enabled..</param>
        /// <param name="rotateButtonsMode">Specifies the rotation mode associated with the rotation button group..</param>
        /// <param name="enableRotateButtons">Specifies whether the rotation button group shall be enabled..</param>
        /// <param name="enableAnnotationActionButtons">Specifies whether the action buttons shall be enabled when an annotation is selected.  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableSelectedTextAnnotationEdition">Specifies whether the selected text annotations shall be editable..</param>
        /// <param name="enableRectangleHighlighterAnnotationButton">Specifies whether the rectangle highlighter annotation button shall be enabled. &lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableFreehandHighlighterAnnotationButton">Specifies whether the freehand highlighter annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableRubberStampAnnotationButton">Specifies whether the rubber stamp annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableRectangleAnnotationButton">Specifies whether the rectangle annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableEllipseAnnotationButton">Specifies whether the ellipse annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableLineAnnotationButton">Specifies whether the line annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableConnectedLineAnnotationButton">Specifies whether the connected line annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableFreehandAnnotationButton">Specifies whether the freehand annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableLineArrowAnnotationButton">Specifies whether the line arrow annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableLinkAnnotationButton">Specifies whether the link annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableRulerAnnotationButton">Specifies whether the ruler annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enablePolyRulerAnnotationButton">enablePolyRulerAnnotationButton.</param>
        /// <param name="enableTextAnnotationButton">Specifies whether the text annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableStickyNoteAnnotationButton">Specifies whether the sticky note annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="enableTwainAcquisitionButton">Specifies whether the TWAIN acquisition button shall be enabled..</param>
        /// <param name="twainSourceEnableCustomConfiguration">Enables the custom configuration support for the TWAIN source..</param>
        /// <param name="twainSourceSelectFeeder">Specifies whether the TWAIN acquisition source shall acquire from the document feeder or the flatbed.  This property is only effective if TwainSourceSetCustomConfiguration is set to true..</param>
        /// <param name="twainSourceBitDepth">Specifies the bit depth the TWAIN acquisition source should acquire at. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true..</param>
        /// <param name="twainSourceResolution">Specifies the resolution the TWAIN acquisition source should acquire at. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true..</param>
        /// <param name="twainSourceEnableDuplex">Specifies whether the TWAIN acquisition source shall enable duplex acquisition. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true..</param>
        /// <param name="twainSourceHideUI">Specifies whether the TWAIN acquisition source shall hide or show the device driver user interface before acquisition. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true..</param>
        /// <param name="freeHandContinuousDrawingMode">Specifies whether the drawing mode for freehand annotation is multi line or not.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="showTextSearchSnapIn">Specifies whether the text search SnapIn is enabled..</param>
        /// <param name="showThumbnailsSnapIn">Specifies whether the Thumbnails SnapIn is enabled..</param>
        /// <param name="showBookmarksSnapIn">Specifies whether the Bookmarks SnapIn is enabled..</param>
        /// <param name="showAnnotationsSnapIn">Specifies whether the annotations SnapIn is enabled..</param>
        /// <param name="showAnnotationsCommentsSnapIn">Specifies whether the Annotations Comments SnapIn is enabled..</param>
        /// <param name="thumbnailWidth">The width, in pixels, of each thumbnail..</param>
        /// <param name="thumbnailHeight">The height, in pixels, of each thumbnail..</param>
        /// <param name="snapInPanelDefaultWidth">Specifies the Snap-in panel default width..</param>
        /// <param name="collapsedSnapIn">Specifies whether the Snap-in panel is collapsed or not..</param>
        /// <param name="collapseSnapinOnDocumentClosed">Specifies whether the Snap-in panel should be automatically collapsed when the displayed document is closed..</param>
        /// <param name="showSnapInCollapseButton">Specifies whether the button that collapses the Snap-in panel is displayed or not..</param>
        /// <param name="showSnapInPanelHeader">Specifies whether the header of the Snap-in panel is displayed or not..</param>
        /// <param name="showSnapInButtonStrip">Specifies whether the Snap-in button strip is displayed or not..</param>
        /// <param name="showToolbar">Specifies whether the Toolbars are visible or not..</param>
        /// <param name="toolbarStyle">Specifies the Toolbar style, Desktop, Mobile or Auto..</param>
        /// <param name="toolbarButtonsSpacing">The space, in pixels, between each button of the toolbar..</param>
        /// <param name="toolbarHeight">The height, in pixels, of the toolbar..</param>
        /// <param name="strokeColor">Specifies the color used to stroke viewer elements such borders, toolbar icons and thumbnail text..</param>
        /// <param name="miscBorderColor">Specifies the color used to define dropdowns borders, buttons separators, line separators..</param>
        /// <param name="headerColor">Specifies the color used in both dialogs and snap-ins headers..</param>
        /// <param name="panelBackColor">Specifies the color used in both dialogs and snap-ins body background..</param>
        /// <param name="viewerBackColor">Specifies the viewer area background color..</param>
        /// <param name="activeSelectedColor">Specifies the selected and active elements stroke color..</param>
        /// <param name="toolbarBackColor">Viewer Toolbar Background Color..</param>
        /// <param name="customNotificationIconError">Custom error notification icon.&lt;br /&gt;  Used to specify a custom icon within errors notification boxes..</param>
        /// <param name="customNotificationIconQuestion">Custom question notification icon.&lt;br /&gt;  Used to specify a custom icon within questions notification boxes..</param>
        /// <param name="customNotificationIconWarning">Custom warning notification icon.&lt;br /&gt;  Used to specify a custom icon within warnings notification boxes..</param>
        /// <param name="customNotificationIconInfo">Custom info notification icon.&lt;br /&gt;  Used to specify a custom icon within information notification boxes..</param>
        /// <param name="customNotificationIconOk">Custom success notification icon.&lt;br /&gt;  Used to specify a custom icon within success notification boxes..</param>
        /// <param name="maxUploadSize">Specifies, in bytes, the upload size limit..</param>
        /// <param name="maxDownloadSize">Specifies, in bytes, the download size limit..</param>
        /// <param name="maxPages">Specifies the maximum of pages per loaded document..</param>
        /// <param name="allowedExportFormats">Specifies extensions of the allowed formats for export. Each extension must be separated by a coma.&lt;br /&gt;  Wildcard character &#39;*&#39; can be used to specify any supported format.&lt;br /&gt;  The following extensions are currently supported: \&quot;PDF\&quot;, \&quot;TIFF\&quot;.&lt;br /&gt;  For example use \&quot;*\&quot; to allow all supported format for export, \&quot;PDF\&quot; to allow only PDF export and \&quot;PDF,TIFF\&quot; to allow PDF and TIFF export..</param>
        /// <param name="disableAnnotationDrawingModePanel">Specifies whether the drawing mode panel shall be enabled while user is drawing a free hand annotation.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true..</param>
        /// <param name="printQuality">Specifies the quality level to be used to print documents..</param>
        /// <param name="fileHostingURI">fileHostingURI.</param>
        /// <param name="documentURI">Specifies the URI of a document to load into the control.  This can be an empty string if a document is already loaded..</param>
        /// <param name="documentFileName">Specifies the file name of the input document. The file name can help to determine the input document format.  Default value is an empty string..</param>
        /// <param name="disableDownloadProgress">A flag specifying if the control should display a loading progress status bar to the end user while a document is being loaded..</param>
        /// <param name="enableDocumentsDrop">enableDocumentsDrop.</param>
        /// <param name="customHeaders">Specifies custom headers for the generated ajax requests.</param>
        public DocuViewareControlState(int? textSearchMaxResults = default(int?), int? timeout = default(int?), string controlId = default(string), bool? showLogo = default(bool?), string remoteIP = default(string), DocumentAlignmentEnum? documentAlignment = default(DocumentAlignmentEnum?), DocumentPositionEnum? documentPosition = default(DocumentPositionEnum?), bool? enableGdPictureAnnotations = default(bool?), bool? enableFormFieldsEdition = default(bool?), bool? annotationEditorMode = default(bool?), double? zoom = default(double?), ZoomModeEnum? zoomMode = default(ZoomModeEnum?), OpenZoomModeEnum? openZoomMode = default(OpenZoomModeEnum?), ViewRotationEnum? viewRotation = default(ViewRotationEnum?), PageRotationEnum? pageRotation = default(PageRotationEnum?), int? zoomStep = default(int?), bool? scrollBars = default(bool?), bool? forceScrollBars = default(bool?), PageViewModeEnum? pageViewMode = default(PageViewModeEnum?), bool? enableTextSelection = default(bool?), bool? enableTextSelectionAnnotation = default(bool?), LocaleEnum? locale = default(LocaleEnum?), List<string> userLanguages = default(List<string>), string controlWidth = default(string), string controlHeight = default(string), bool? annotationDropShadow = default(bool?), bool? allowPrint = default(bool?), bool? allowUpload = default(bool?), bool? enableMultipleThumbnailSelection = default(bool?), bool? enableThumbnailDragDrop = default(bool?), bool? enableFileUploadButton = default(bool?), bool? enableLoadFromUriButton = default(bool?), bool? enableSaveButton = default(bool?), bool? enablePagesNavigationButtons = default(bool?), bool? enablePrintButton = default(bool?), bool? enableFitWidthButton = default(bool?), bool? enableZoom100Button = default(bool?), bool? enableMouseModeButtons = default(bool?), bool? enablePanModeButton = default(bool?), bool? enableSelectModeButton = default(bool?), bool? enableMarqueeZoomModeButton = default(bool?), bool? enableFullScreenButton = default(bool?), bool? enableFitPageButton = default(bool?), bool? enableZoomButtons = default(bool?), bool? enablePageViewButtons = default(bool?), RotateButtonsModeEnum? rotateButtonsMode = default(RotateButtonsModeEnum?), bool? enableRotateButtons = default(bool?), bool? enableAnnotationActionButtons = default(bool?), bool? enableSelectedTextAnnotationEdition = default(bool?), bool? enableRectangleHighlighterAnnotationButton = default(bool?), bool? enableFreehandHighlighterAnnotationButton = default(bool?), bool? enableRubberStampAnnotationButton = default(bool?), bool? enableRectangleAnnotationButton = default(bool?), bool? enableEllipseAnnotationButton = default(bool?), bool? enableLineAnnotationButton = default(bool?), bool? enableConnectedLineAnnotationButton = default(bool?), bool? enableFreehandAnnotationButton = default(bool?), bool? enableLineArrowAnnotationButton = default(bool?), bool? enableLinkAnnotationButton = default(bool?), bool? enableRulerAnnotationButton = default(bool?), bool? enablePolyRulerAnnotationButton = default(bool?), bool? enableTextAnnotationButton = default(bool?), bool? enableStickyNoteAnnotationButton = default(bool?), bool? enableTwainAcquisitionButton = default(bool?), bool? twainSourceEnableCustomConfiguration = default(bool?), bool? twainSourceSelectFeeder = default(bool?), int? twainSourceBitDepth = default(int?), int? twainSourceResolution = default(int?), bool? twainSourceEnableDuplex = default(bool?), bool? twainSourceHideUI = default(bool?), bool? freeHandContinuousDrawingMode = default(bool?), bool? showTextSearchSnapIn = default(bool?), bool? showThumbnailsSnapIn = default(bool?), bool? showBookmarksSnapIn = default(bool?), bool? showAnnotationsSnapIn = default(bool?), bool? showAnnotationsCommentsSnapIn = default(bool?), int? thumbnailWidth = default(int?), int? thumbnailHeight = default(int?), string snapInPanelDefaultWidth = default(string), bool? collapsedSnapIn = default(bool?), bool? collapseSnapinOnDocumentClosed = default(bool?), bool? showSnapInCollapseButton = default(bool?), bool? showSnapInPanelHeader = default(bool?), bool? showSnapInButtonStrip = default(bool?), bool? showToolbar = default(bool?), ToolbarStyleEnum? toolbarStyle = default(ToolbarStyleEnum?), int? toolbarButtonsSpacing = default(int?), int? toolbarHeight = default(int?), string strokeColor = default(string), string miscBorderColor = default(string), string headerColor = default(string), string panelBackColor = default(string), string viewerBackColor = default(string), string activeSelectedColor = default(string), string toolbarBackColor = default(string), string customNotificationIconError = default(string), string customNotificationIconQuestion = default(string), string customNotificationIconWarning = default(string), string customNotificationIconInfo = default(string), string customNotificationIconOk = default(string), int? maxUploadSize = default(int?), int? maxDownloadSize = default(int?), int? maxPages = default(int?), string allowedExportFormats = default(string), bool? disableAnnotationDrawingModePanel = default(bool?), PrintQualityEnum? printQuality = default(PrintQualityEnum?), string fileHostingURI = default(string), string documentURI = default(string), string documentFileName = default(string), bool? disableDownloadProgress = default(bool?), bool? enableDocumentsDrop = default(bool?), string customHeaders = default(string))
        {
            this.TextSearchMaxResults = textSearchMaxResults;
            this.Timeout = timeout;
            this.ControlId = controlId;
            this.ShowLogo = showLogo;
            this.RemoteIP = remoteIP;
            this.DocumentAlignment = documentAlignment;
            this.DocumentPosition = documentPosition;
            this.EnableGdPictureAnnotations = enableGdPictureAnnotations;
            this.EnableFormFieldsEdition = enableFormFieldsEdition;
            this.AnnotationEditorMode = annotationEditorMode;
            this.Zoom = zoom;
            this.ZoomMode = zoomMode;
            this.OpenZoomMode = openZoomMode;
            this.ViewRotation = viewRotation;
            this.PageRotation = pageRotation;
            this.ZoomStep = zoomStep;
            this.ScrollBars = scrollBars;
            this.ForceScrollBars = forceScrollBars;
            this.PageViewMode = pageViewMode;
            this.EnableTextSelection = enableTextSelection;
            this.EnableTextSelectionAnnotation = enableTextSelectionAnnotation;
            this.Locale = locale;
            this.UserLanguages = userLanguages;
            this.ControlWidth = controlWidth;
            this.ControlHeight = controlHeight;
            this.AnnotationDropShadow = annotationDropShadow;
            this.AllowPrint = allowPrint;
            this.AllowUpload = allowUpload;
            this.EnableMultipleThumbnailSelection = enableMultipleThumbnailSelection;
            this.EnableThumbnailDragDrop = enableThumbnailDragDrop;
            this.EnableFileUploadButton = enableFileUploadButton;
            this.EnableLoadFromUriButton = enableLoadFromUriButton;
            this.EnableSaveButton = enableSaveButton;
            this.EnablePagesNavigationButtons = enablePagesNavigationButtons;
            this.EnablePrintButton = enablePrintButton;
            this.EnableFitWidthButton = enableFitWidthButton;
            this.EnableZoom100Button = enableZoom100Button;
            this.EnableMouseModeButtons = enableMouseModeButtons;
            this.EnablePanModeButton = enablePanModeButton;
            this.EnableSelectModeButton = enableSelectModeButton;
            this.EnableMarqueeZoomModeButton = enableMarqueeZoomModeButton;
            this.EnableFullScreenButton = enableFullScreenButton;
            this.EnableFitPageButton = enableFitPageButton;
            this.EnableZoomButtons = enableZoomButtons;
            this.EnablePageViewButtons = enablePageViewButtons;
            this.RotateButtonsMode = rotateButtonsMode;
            this.EnableRotateButtons = enableRotateButtons;
            this.EnableAnnotationActionButtons = enableAnnotationActionButtons;
            this.EnableSelectedTextAnnotationEdition = enableSelectedTextAnnotationEdition;
            this.EnableRectangleHighlighterAnnotationButton = enableRectangleHighlighterAnnotationButton;
            this.EnableFreehandHighlighterAnnotationButton = enableFreehandHighlighterAnnotationButton;
            this.EnableRubberStampAnnotationButton = enableRubberStampAnnotationButton;
            this.EnableRectangleAnnotationButton = enableRectangleAnnotationButton;
            this.EnableEllipseAnnotationButton = enableEllipseAnnotationButton;
            this.EnableLineAnnotationButton = enableLineAnnotationButton;
            this.EnableConnectedLineAnnotationButton = enableConnectedLineAnnotationButton;
            this.EnableFreehandAnnotationButton = enableFreehandAnnotationButton;
            this.EnableLineArrowAnnotationButton = enableLineArrowAnnotationButton;
            this.EnableLinkAnnotationButton = enableLinkAnnotationButton;
            this.EnableRulerAnnotationButton = enableRulerAnnotationButton;
            this.EnablePolyRulerAnnotationButton = enablePolyRulerAnnotationButton;
            this.EnableTextAnnotationButton = enableTextAnnotationButton;
            this.EnableStickyNoteAnnotationButton = enableStickyNoteAnnotationButton;
            this.EnableTwainAcquisitionButton = enableTwainAcquisitionButton;
            this.TwainSourceEnableCustomConfiguration = twainSourceEnableCustomConfiguration;
            this.TwainSourceSelectFeeder = twainSourceSelectFeeder;
            this.TwainSourceBitDepth = twainSourceBitDepth;
            this.TwainSourceResolution = twainSourceResolution;
            this.TwainSourceEnableDuplex = twainSourceEnableDuplex;
            this.TwainSourceHideUI = twainSourceHideUI;
            this.FreeHandContinuousDrawingMode = freeHandContinuousDrawingMode;
            this.ShowTextSearchSnapIn = showTextSearchSnapIn;
            this.ShowThumbnailsSnapIn = showThumbnailsSnapIn;
            this.ShowBookmarksSnapIn = showBookmarksSnapIn;
            this.ShowAnnotationsSnapIn = showAnnotationsSnapIn;
            this.ShowAnnotationsCommentsSnapIn = showAnnotationsCommentsSnapIn;
            this.ThumbnailWidth = thumbnailWidth;
            this.ThumbnailHeight = thumbnailHeight;
            this.SnapInPanelDefaultWidth = snapInPanelDefaultWidth;
            this.CollapsedSnapIn = collapsedSnapIn;
            this.CollapseSnapinOnDocumentClosed = collapseSnapinOnDocumentClosed;
            this.ShowSnapInCollapseButton = showSnapInCollapseButton;
            this.ShowSnapInPanelHeader = showSnapInPanelHeader;
            this.ShowSnapInButtonStrip = showSnapInButtonStrip;
            this.ShowToolbar = showToolbar;
            this.ToolbarStyle = toolbarStyle;
            this.ToolbarButtonsSpacing = toolbarButtonsSpacing;
            this.ToolbarHeight = toolbarHeight;
            this.StrokeColor = strokeColor;
            this.MiscBorderColor = miscBorderColor;
            this.HeaderColor = headerColor;
            this.PanelBackColor = panelBackColor;
            this.ViewerBackColor = viewerBackColor;
            this.ActiveSelectedColor = activeSelectedColor;
            this.ToolbarBackColor = toolbarBackColor;
            this.CustomNotificationIconError = customNotificationIconError;
            this.CustomNotificationIconQuestion = customNotificationIconQuestion;
            this.CustomNotificationIconWarning = customNotificationIconWarning;
            this.CustomNotificationIconInfo = customNotificationIconInfo;
            this.CustomNotificationIconOk = customNotificationIconOk;
            this.MaxUploadSize = maxUploadSize;
            this.MaxDownloadSize = maxDownloadSize;
            this.MaxPages = maxPages;
            this.AllowedExportFormats = allowedExportFormats;
            this.DisableAnnotationDrawingModePanel = disableAnnotationDrawingModePanel;
            this.PrintQuality = printQuality;
            this.FileHostingURI = fileHostingURI;
            this.DocumentURI = documentURI;
            this.DocumentFileName = documentFileName;
            this.DisableDownloadProgress = disableDownloadProgress;
            this.EnableDocumentsDrop = enableDocumentsDrop;
            this.CustomHeaders = customHeaders;
        }
        
        /// <summary>
        /// Specifies the maximum number of results provided by a text search request.
        /// </summary>
        /// <value>Specifies the maximum number of results provided by a text search request.</value>
        [DataMember(Name="TextSearchMaxResults", EmitDefaultValue=false)]
        public int? TextSearchMaxResults { get; set; }

        /// <summary>
        /// Specifies the amount of time, in minutes, allowed between requests before the DocuVieware session-state provider terminates the session.&lt;br /&gt;
        /// </summary>
        /// <value>Specifies the amount of time, in minutes, allowed between requests before the DocuVieware session-state provider terminates the session.&lt;br /&gt;</value>
        [DataMember(Name="Timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Specifies the identifier associated with the control.
        /// </summary>
        /// <value>Specifies the identifier associated with the control.</value>
        [DataMember(Name="ControlId", EmitDefaultValue=false)]
        public string ControlId { get; set; }

        /// <summary>
        /// Specifies if the DocuVieware logo is displayed in the toolbar.
        /// </summary>
        /// <value>Specifies if the DocuVieware logo is displayed in the toolbar.</value>
        [DataMember(Name="ShowLogo", EmitDefaultValue=false)]
        public bool? ShowLogo { get; set; }

        /// <summary>
        /// Specifies the remote IP. This property can be leaved empty if user requests don&#39;t need to be traced.
        /// </summary>
        /// <value>Specifies the remote IP. This property can be leaved empty if user requests don&#39;t need to be traced.</value>
        [DataMember(Name="RemoteIP", EmitDefaultValue=false)]
        public string RemoteIP { get; set; }



        /// <summary>
        /// Specifies if GdPicture/XMP annotations support is activated.
        /// </summary>
        /// <value>Specifies if GdPicture/XMP annotations support is activated.</value>
        [DataMember(Name="EnableGdPictureAnnotations", EmitDefaultValue=false)]
        public bool? EnableGdPictureAnnotations { get; set; }

        /// <summary>
        /// Specifies whether form fields can be edited into the client browser or not.
        /// </summary>
        /// <value>Specifies whether form fields can be edited into the client browser or not.</value>
        [DataMember(Name="EnableFormFieldsEdition", EmitDefaultValue=false)]
        public bool? EnableFormFieldsEdition { get; set; }

        /// <summary>
        /// Specifies the editor mode for the GdPicture/XMP annotation support.&lt;br /&gt;
        /// </summary>
        /// <value>Specifies the editor mode for the GdPicture/XMP annotation support.&lt;br /&gt;</value>
        [DataMember(Name="AnnotationEditorMode", EmitDefaultValue=false)]
        public bool? AnnotationEditorMode { get; set; }

        /// <summary>
        /// Specifies the current factor of zoom applied during page rendering operations: 1 for 100%, 1.5 for 150%, 2 for 200%...
        /// </summary>
        /// <value>Specifies the current factor of zoom applied during page rendering operations: 1 for 100%, 1.5 for 150%, 2 for 200%...</value>
        [DataMember(Name="Zoom", EmitDefaultValue=false)]
        public double? Zoom { get; set; }





        /// <summary>
        /// Defines the percentage of increasing or decreasing level of zoom for &#39;Zoom In&#39; and &#39;Zoom Out&#39; operations.
        /// </summary>
        /// <value>Defines the percentage of increasing or decreasing level of zoom for &#39;Zoom In&#39; and &#39;Zoom Out&#39; operations.</value>
        [DataMember(Name="ZoomStep", EmitDefaultValue=false)]
        public int? ZoomStep { get; set; }

        /// <summary>
        /// Specifies whether scrollbars can be displayed or not within the viewer.&lt;br /&gt;
        /// </summary>
        /// <value>Specifies whether scrollbars can be displayed or not within the viewer.&lt;br /&gt;</value>
        [DataMember(Name="ScrollBars", EmitDefaultValue=false)]
        public bool? ScrollBars { get; set; }

        /// <summary>
        /// Specifies whether the viewer shall always show scrollbars.
        /// </summary>
        /// <value>Specifies whether the viewer shall always show scrollbars.</value>
        [DataMember(Name="ForceScrollBars", EmitDefaultValue=false)]
        public bool? ForceScrollBars { get; set; }


        /// <summary>
        /// Specifies if text selection is permitted.
        /// </summary>
        /// <value>Specifies if text selection is permitted.</value>
        [DataMember(Name="EnableTextSelection", EmitDefaultValue=false)]
        public bool? EnableTextSelection { get; set; }

        /// <summary>
        /// Specifies whether the selected text context menu options should contain annotations entries.
        /// </summary>
        /// <value>Specifies whether the selected text context menu options should contain annotations entries.</value>
        [DataMember(Name="EnableTextSelectionAnnotation", EmitDefaultValue=false)]
        public bool? EnableTextSelectionAnnotation { get; set; }


        /// <summary>
        /// Specifies the different languages used by the user&#39;s browser.
        /// </summary>
        /// <value>Specifies the different languages used by the user&#39;s browser.</value>
        [DataMember(Name="UserLanguages", EmitDefaultValue=false)]
        public List<string> UserLanguages { get; set; }

        /// <summary>
        /// Specifies the width of the control within its container.
        /// </summary>
        /// <value>Specifies the width of the control within its container.</value>
        [DataMember(Name="ControlWidth", EmitDefaultValue=false)]
        public string ControlWidth { get; set; }

        /// <summary>
        /// Specifies, the height of the control within its container.
        /// </summary>
        /// <value>Specifies, the height of the control within its container.</value>
        [DataMember(Name="ControlHeight", EmitDefaultValue=false)]
        public string ControlHeight { get; set; }

        /// <summary>
        /// Specifies whether GdPicture/XMP annotations are rendered with a drop shadow effect.
        /// </summary>
        /// <value>Specifies whether GdPicture/XMP annotations are rendered with a drop shadow effect.</value>
        [DataMember(Name="AnnotationDropShadow", EmitDefaultValue=false)]
        public bool? AnnotationDropShadow { get; set; }

        /// <summary>
        /// Specifies whether printing is allowed.
        /// </summary>
        /// <value>Specifies whether printing is allowed.</value>
        [DataMember(Name="AllowPrint", EmitDefaultValue=false)]
        public bool? AllowPrint { get; set; }

        /// <summary>
        /// Specifies whether file upload is allowed.
        /// </summary>
        /// <value>Specifies whether file upload is allowed.</value>
        [DataMember(Name="AllowUpload", EmitDefaultValue=false)]
        public bool? AllowUpload { get; set; }

        /// <summary>
        /// Specifies whether multiple thumbnails selection is allowed.
        /// </summary>
        /// <value>Specifies whether multiple thumbnails selection is allowed.</value>
        [DataMember(Name="EnableMultipleThumbnailSelection", EmitDefaultValue=false)]
        public bool? EnableMultipleThumbnailSelection { get; set; }

        /// <summary>
        /// Specifies whether the thumbnails can be moved by drag and drop.
        /// </summary>
        /// <value>Specifies whether the thumbnails can be moved by drag and drop.</value>
        [DataMember(Name="EnableThumbnailDragDrop", EmitDefaultValue=false)]
        public bool? EnableThumbnailDragDrop { get; set; }

        /// <summary>
        /// Specifies whether the open button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the open button shall be enabled.</value>
        [DataMember(Name="EnableFileUploadButton", EmitDefaultValue=false)]
        public bool? EnableFileUploadButton { get; set; }

        /// <summary>
        /// Specifies whether the &#39;open from uri&#39; button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the &#39;open from uri&#39; button shall be enabled.</value>
        [DataMember(Name="EnableLoadFromUriButton", EmitDefaultValue=false)]
        public bool? EnableLoadFromUriButton { get; set; }

        /// <summary>
        /// Specifies whether the save button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the save button shall be enabled.</value>
        [DataMember(Name="EnableSaveButton", EmitDefaultValue=false)]
        public bool? EnableSaveButton { get; set; }

        /// <summary>
        /// Specifies whether the save button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the save button shall be enabled.</value>
        [DataMember(Name="EnablePagesNavigationButtons", EmitDefaultValue=false)]
        public bool? EnablePagesNavigationButtons { get; set; }

        /// <summary>
        /// Specifies whether the print button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the print button shall be enabled.</value>
        [DataMember(Name="EnablePrintButton", EmitDefaultValue=false)]
        public bool? EnablePrintButton { get; set; }

        /// <summary>
        /// Specifies whether the fit width button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the fit width button shall be enabled.</value>
        [DataMember(Name="EnableFitWidthButton", EmitDefaultValue=false)]
        public bool? EnableFitWidthButton { get; set; }

        /// <summary>
        /// Specifies whether the fit original size button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the fit original size button shall be enabled.</value>
        [DataMember(Name="EnableZoom100Button", EmitDefaultValue=false)]
        public bool? EnableZoom100Button { get; set; }

        /// <summary>
        /// Specifies whether the mouse mode button group shall be enabled.
        /// </summary>
        /// <value>Specifies whether the mouse mode button group shall be enabled.</value>
        [DataMember(Name="EnableMouseModeButtons", EmitDefaultValue=false)]
        public bool? EnableMouseModeButtons { get; set; }

        /// <summary>
        /// Specifies whether the pan mode button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the pan mode button shall be enabled.</value>
        [DataMember(Name="EnablePanModeButton", EmitDefaultValue=false)]
        public bool? EnablePanModeButton { get; set; }

        /// <summary>
        /// Specifies whether the select mode button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the select mode button shall be enabled.</value>
        [DataMember(Name="EnableSelectModeButton", EmitDefaultValue=false)]
        public bool? EnableSelectModeButton { get; set; }

        /// <summary>
        /// Specifies whether the marquee zoom mode button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the marquee zoom mode button shall be enabled.</value>
        [DataMember(Name="EnableMarqueeZoomModeButton", EmitDefaultValue=false)]
        public bool? EnableMarqueeZoomModeButton { get; set; }

        /// <summary>
        /// Specifies whether the fullscreen button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the fullscreen button shall be enabled.</value>
        [DataMember(Name="EnableFullScreenButton", EmitDefaultValue=false)]
        public bool? EnableFullScreenButton { get; set; }

        /// <summary>
        /// Specifies whether the &#39;Fit Page&#39; button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the &#39;Fit Page&#39; button shall be enabled.</value>
        [DataMember(Name="EnableFitPageButton", EmitDefaultValue=false)]
        public bool? EnableFitPageButton { get; set; }

        /// <summary>
        /// Specifies whether the zoom button group shall be enabled.
        /// </summary>
        /// <value>Specifies whether the zoom button group shall be enabled.</value>
        [DataMember(Name="EnableZoomButtons", EmitDefaultValue=false)]
        public bool? EnableZoomButtons { get; set; }

        /// <summary>
        /// Specifies whether the page view mode button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the page view mode button shall be enabled.</value>
        [DataMember(Name="EnablePageViewButtons", EmitDefaultValue=false)]
        public bool? EnablePageViewButtons { get; set; }


        /// <summary>
        /// Specifies whether the rotation button group shall be enabled.
        /// </summary>
        /// <value>Specifies whether the rotation button group shall be enabled.</value>
        [DataMember(Name="EnableRotateButtons", EmitDefaultValue=false)]
        public bool? EnableRotateButtons { get; set; }

        /// <summary>
        /// Specifies whether the action buttons shall be enabled when an annotation is selected.  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the action buttons shall be enabled when an annotation is selected.  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableAnnotationActionButtons", EmitDefaultValue=false)]
        public bool? EnableAnnotationActionButtons { get; set; }

        /// <summary>
        /// Specifies whether the selected text annotations shall be editable.
        /// </summary>
        /// <value>Specifies whether the selected text annotations shall be editable.</value>
        [DataMember(Name="EnableSelectedTextAnnotationEdition", EmitDefaultValue=false)]
        public bool? EnableSelectedTextAnnotationEdition { get; set; }

        /// <summary>
        /// Specifies whether the rectangle highlighter annotation button shall be enabled. &lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the rectangle highlighter annotation button shall be enabled. &lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableRectangleHighlighterAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableRectangleHighlighterAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the freehand highlighter annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the freehand highlighter annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableFreehandHighlighterAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableFreehandHighlighterAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the rubber stamp annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the rubber stamp annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableRubberStampAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableRubberStampAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the rectangle annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the rectangle annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableRectangleAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableRectangleAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the ellipse annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the ellipse annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableEllipseAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableEllipseAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the line annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the line annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableLineAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableLineAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the connected line annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the connected line annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableConnectedLineAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableConnectedLineAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the freehand annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the freehand annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableFreehandAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableFreehandAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the line arrow annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the line arrow annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableLineArrowAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableLineArrowAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the link annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the link annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableLinkAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableLinkAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the ruler annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the ruler annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableRulerAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableRulerAnnotationButton { get; set; }

        /// <summary>
        /// Gets or Sets EnablePolyRulerAnnotationButton
        /// </summary>
        [DataMember(Name="EnablePolyRulerAnnotationButton", EmitDefaultValue=false)]
        public bool? EnablePolyRulerAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the text annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the text annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableTextAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableTextAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the sticky note annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the sticky note annotation button shall be enabled.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="EnableStickyNoteAnnotationButton", EmitDefaultValue=false)]
        public bool? EnableStickyNoteAnnotationButton { get; set; }

        /// <summary>
        /// Specifies whether the TWAIN acquisition button shall be enabled.
        /// </summary>
        /// <value>Specifies whether the TWAIN acquisition button shall be enabled.</value>
        [DataMember(Name="EnableTwainAcquisitionButton", EmitDefaultValue=false)]
        public bool? EnableTwainAcquisitionButton { get; set; }

        /// <summary>
        /// Enables the custom configuration support for the TWAIN source.
        /// </summary>
        /// <value>Enables the custom configuration support for the TWAIN source.</value>
        [DataMember(Name="TwainSourceEnableCustomConfiguration", EmitDefaultValue=false)]
        public bool? TwainSourceEnableCustomConfiguration { get; set; }

        /// <summary>
        /// Specifies whether the TWAIN acquisition source shall acquire from the document feeder or the flatbed.  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        /// <value>Specifies whether the TWAIN acquisition source shall acquire from the document feeder or the flatbed.  This property is only effective if TwainSourceSetCustomConfiguration is set to true.</value>
        [DataMember(Name="TwainSourceSelectFeeder", EmitDefaultValue=false)]
        public bool? TwainSourceSelectFeeder { get; set; }

        /// <summary>
        /// Specifies the bit depth the TWAIN acquisition source should acquire at. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        /// <value>Specifies the bit depth the TWAIN acquisition source should acquire at. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.</value>
        [DataMember(Name="TwainSourceBitDepth", EmitDefaultValue=false)]
        public int? TwainSourceBitDepth { get; set; }

        /// <summary>
        /// Specifies the resolution the TWAIN acquisition source should acquire at. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        /// <value>Specifies the resolution the TWAIN acquisition source should acquire at. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.</value>
        [DataMember(Name="TwainSourceResolution", EmitDefaultValue=false)]
        public int? TwainSourceResolution { get; set; }

        /// <summary>
        /// Specifies whether the TWAIN acquisition source shall enable duplex acquisition. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        /// <value>Specifies whether the TWAIN acquisition source shall enable duplex acquisition. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.</value>
        [DataMember(Name="TwainSourceEnableDuplex", EmitDefaultValue=false)]
        public bool? TwainSourceEnableDuplex { get; set; }

        /// <summary>
        /// Specifies whether the TWAIN acquisition source shall hide or show the device driver user interface before acquisition. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.
        /// </summary>
        /// <value>Specifies whether the TWAIN acquisition source shall hide or show the device driver user interface before acquisition. &lt;br /&gt;  This property is only effective if TwainSourceSetCustomConfiguration is set to true.</value>
        [DataMember(Name="TwainSourceHideUI", EmitDefaultValue=false)]
        public bool? TwainSourceHideUI { get; set; }

        /// <summary>
        /// Specifies whether the drawing mode for freehand annotation is multi line or not.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the drawing mode for freehand annotation is multi line or not.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="FreeHandContinuousDrawingMode", EmitDefaultValue=false)]
        public bool? FreeHandContinuousDrawingMode { get; set; }

        /// <summary>
        /// Specifies whether the text search SnapIn is enabled.
        /// </summary>
        /// <value>Specifies whether the text search SnapIn is enabled.</value>
        [DataMember(Name="ShowTextSearchSnapIn", EmitDefaultValue=false)]
        public bool? ShowTextSearchSnapIn { get; set; }

        /// <summary>
        /// Specifies whether the Thumbnails SnapIn is enabled.
        /// </summary>
        /// <value>Specifies whether the Thumbnails SnapIn is enabled.</value>
        [DataMember(Name="ShowThumbnailsSnapIn", EmitDefaultValue=false)]
        public bool? ShowThumbnailsSnapIn { get; set; }

        /// <summary>
        /// Specifies whether the Bookmarks SnapIn is enabled.
        /// </summary>
        /// <value>Specifies whether the Bookmarks SnapIn is enabled.</value>
        [DataMember(Name="ShowBookmarksSnapIn", EmitDefaultValue=false)]
        public bool? ShowBookmarksSnapIn { get; set; }

        /// <summary>
        /// Specifies whether the annotations SnapIn is enabled.
        /// </summary>
        /// <value>Specifies whether the annotations SnapIn is enabled.</value>
        [DataMember(Name="ShowAnnotationsSnapIn", EmitDefaultValue=false)]
        public bool? ShowAnnotationsSnapIn { get; set; }

        /// <summary>
        /// Specifies whether the Annotations Comments SnapIn is enabled.
        /// </summary>
        /// <value>Specifies whether the Annotations Comments SnapIn is enabled.</value>
        [DataMember(Name="ShowAnnotationsCommentsSnapIn", EmitDefaultValue=false)]
        public bool? ShowAnnotationsCommentsSnapIn { get; set; }

        /// <summary>
        /// The width, in pixels, of each thumbnail.
        /// </summary>
        /// <value>The width, in pixels, of each thumbnail.</value>
        [DataMember(Name="ThumbnailWidth", EmitDefaultValue=false)]
        public int? ThumbnailWidth { get; set; }

        /// <summary>
        /// The height, in pixels, of each thumbnail.
        /// </summary>
        /// <value>The height, in pixels, of each thumbnail.</value>
        [DataMember(Name="ThumbnailHeight", EmitDefaultValue=false)]
        public int? ThumbnailHeight { get; set; }

        /// <summary>
        /// Specifies the Snap-in panel default width.
        /// </summary>
        /// <value>Specifies the Snap-in panel default width.</value>
        [DataMember(Name="SnapInPanelDefaultWidth", EmitDefaultValue=false)]
        public string SnapInPanelDefaultWidth { get; set; }

        /// <summary>
        /// Specifies whether the Snap-in panel is collapsed or not.
        /// </summary>
        /// <value>Specifies whether the Snap-in panel is collapsed or not.</value>
        [DataMember(Name="CollapsedSnapIn", EmitDefaultValue=false)]
        public bool? CollapsedSnapIn { get; set; }

        /// <summary>
        /// Specifies whether the Snap-in panel should be automatically collapsed when the displayed document is closed.
        /// </summary>
        /// <value>Specifies whether the Snap-in panel should be automatically collapsed when the displayed document is closed.</value>
        [DataMember(Name="CollapseSnapinOnDocumentClosed", EmitDefaultValue=false)]
        public bool? CollapseSnapinOnDocumentClosed { get; set; }

        /// <summary>
        /// Specifies whether the button that collapses the Snap-in panel is displayed or not.
        /// </summary>
        /// <value>Specifies whether the button that collapses the Snap-in panel is displayed or not.</value>
        [DataMember(Name="ShowSnapInCollapseButton", EmitDefaultValue=false)]
        public bool? ShowSnapInCollapseButton { get; set; }

        /// <summary>
        /// Specifies whether the header of the Snap-in panel is displayed or not.
        /// </summary>
        /// <value>Specifies whether the header of the Snap-in panel is displayed or not.</value>
        [DataMember(Name="ShowSnapInPanelHeader", EmitDefaultValue=false)]
        public bool? ShowSnapInPanelHeader { get; set; }

        /// <summary>
        /// Specifies whether the Snap-in button strip is displayed or not.
        /// </summary>
        /// <value>Specifies whether the Snap-in button strip is displayed or not.</value>
        [DataMember(Name="ShowSnapInButtonStrip", EmitDefaultValue=false)]
        public bool? ShowSnapInButtonStrip { get; set; }

        /// <summary>
        /// Specifies whether the Toolbars are visible or not.
        /// </summary>
        /// <value>Specifies whether the Toolbars are visible or not.</value>
        [DataMember(Name="ShowToolbar", EmitDefaultValue=false)]
        public bool? ShowToolbar { get; set; }


        /// <summary>
        /// The space, in pixels, between each button of the toolbar.
        /// </summary>
        /// <value>The space, in pixels, between each button of the toolbar.</value>
        [DataMember(Name="ToolbarButtonsSpacing", EmitDefaultValue=false)]
        public int? ToolbarButtonsSpacing { get; set; }

        /// <summary>
        /// The height, in pixels, of the toolbar.
        /// </summary>
        /// <value>The height, in pixels, of the toolbar.</value>
        [DataMember(Name="ToolbarHeight", EmitDefaultValue=false)]
        public int? ToolbarHeight { get; set; }

        /// <summary>
        /// Specifies the color used to stroke viewer elements such borders, toolbar icons and thumbnail text.
        /// </summary>
        /// <value>Specifies the color used to stroke viewer elements such borders, toolbar icons and thumbnail text.</value>
        [DataMember(Name="StrokeColor", EmitDefaultValue=false)]
        public string StrokeColor { get; set; }

        /// <summary>
        /// Specifies the color used to define dropdowns borders, buttons separators, line separators.
        /// </summary>
        /// <value>Specifies the color used to define dropdowns borders, buttons separators, line separators.</value>
        [DataMember(Name="MiscBorderColor", EmitDefaultValue=false)]
        public string MiscBorderColor { get; set; }

        /// <summary>
        /// Specifies the color used in both dialogs and snap-ins headers.
        /// </summary>
        /// <value>Specifies the color used in both dialogs and snap-ins headers.</value>
        [DataMember(Name="HeaderColor", EmitDefaultValue=false)]
        public string HeaderColor { get; set; }

        /// <summary>
        /// Specifies the color used in both dialogs and snap-ins body background.
        /// </summary>
        /// <value>Specifies the color used in both dialogs and snap-ins body background.</value>
        [DataMember(Name="PanelBackColor", EmitDefaultValue=false)]
        public string PanelBackColor { get; set; }

        /// <summary>
        /// Specifies the viewer area background color.
        /// </summary>
        /// <value>Specifies the viewer area background color.</value>
        [DataMember(Name="ViewerBackColor", EmitDefaultValue=false)]
        public string ViewerBackColor { get; set; }

        /// <summary>
        /// Specifies the selected and active elements stroke color.
        /// </summary>
        /// <value>Specifies the selected and active elements stroke color.</value>
        [DataMember(Name="ActiveSelectedColor", EmitDefaultValue=false)]
        public string ActiveSelectedColor { get; set; }

        /// <summary>
        /// Viewer Toolbar Background Color.
        /// </summary>
        /// <value>Viewer Toolbar Background Color.</value>
        [DataMember(Name="ToolbarBackColor", EmitDefaultValue=false)]
        public string ToolbarBackColor { get; set; }

        /// <summary>
        /// Custom error notification icon.&lt;br /&gt;  Used to specify a custom icon within errors notification boxes.
        /// </summary>
        /// <value>Custom error notification icon.&lt;br /&gt;  Used to specify a custom icon within errors notification boxes.</value>
        [DataMember(Name="CustomNotificationIconError", EmitDefaultValue=false)]
        public string CustomNotificationIconError { get; set; }

        /// <summary>
        /// Custom question notification icon.&lt;br /&gt;  Used to specify a custom icon within questions notification boxes.
        /// </summary>
        /// <value>Custom question notification icon.&lt;br /&gt;  Used to specify a custom icon within questions notification boxes.</value>
        [DataMember(Name="CustomNotificationIconQuestion", EmitDefaultValue=false)]
        public string CustomNotificationIconQuestion { get; set; }

        /// <summary>
        /// Custom warning notification icon.&lt;br /&gt;  Used to specify a custom icon within warnings notification boxes.
        /// </summary>
        /// <value>Custom warning notification icon.&lt;br /&gt;  Used to specify a custom icon within warnings notification boxes.</value>
        [DataMember(Name="CustomNotificationIconWarning", EmitDefaultValue=false)]
        public string CustomNotificationIconWarning { get; set; }

        /// <summary>
        /// Custom info notification icon.&lt;br /&gt;  Used to specify a custom icon within information notification boxes.
        /// </summary>
        /// <value>Custom info notification icon.&lt;br /&gt;  Used to specify a custom icon within information notification boxes.</value>
        [DataMember(Name="CustomNotificationIconInfo", EmitDefaultValue=false)]
        public string CustomNotificationIconInfo { get; set; }

        /// <summary>
        /// Custom success notification icon.&lt;br /&gt;  Used to specify a custom icon within success notification boxes.
        /// </summary>
        /// <value>Custom success notification icon.&lt;br /&gt;  Used to specify a custom icon within success notification boxes.</value>
        [DataMember(Name="CustomNotificationIconOk", EmitDefaultValue=false)]
        public string CustomNotificationIconOk { get; set; }

        /// <summary>
        /// Specifies, in bytes, the upload size limit.
        /// </summary>
        /// <value>Specifies, in bytes, the upload size limit.</value>
        [DataMember(Name="MaxUploadSize", EmitDefaultValue=false)]
        public int? MaxUploadSize { get; set; }

        /// <summary>
        /// Specifies, in bytes, the download size limit.
        /// </summary>
        /// <value>Specifies, in bytes, the download size limit.</value>
        [DataMember(Name="MaxDownloadSize", EmitDefaultValue=false)]
        public int? MaxDownloadSize { get; set; }

        /// <summary>
        /// Specifies the maximum of pages per loaded document.
        /// </summary>
        /// <value>Specifies the maximum of pages per loaded document.</value>
        [DataMember(Name="MaxPages", EmitDefaultValue=false)]
        public int? MaxPages { get; set; }

        /// <summary>
        /// Specifies extensions of the allowed formats for export. Each extension must be separated by a coma.&lt;br /&gt;  Wildcard character &#39;*&#39; can be used to specify any supported format.&lt;br /&gt;  The following extensions are currently supported: \&quot;PDF\&quot;, \&quot;TIFF\&quot;.&lt;br /&gt;  For example use \&quot;*\&quot; to allow all supported format for export, \&quot;PDF\&quot; to allow only PDF export and \&quot;PDF,TIFF\&quot; to allow PDF and TIFF export.
        /// </summary>
        /// <value>Specifies extensions of the allowed formats for export. Each extension must be separated by a coma.&lt;br /&gt;  Wildcard character &#39;*&#39; can be used to specify any supported format.&lt;br /&gt;  The following extensions are currently supported: \&quot;PDF\&quot;, \&quot;TIFF\&quot;.&lt;br /&gt;  For example use \&quot;*\&quot; to allow all supported format for export, \&quot;PDF\&quot; to allow only PDF export and \&quot;PDF,TIFF\&quot; to allow PDF and TIFF export.</value>
        [DataMember(Name="AllowedExportFormats", EmitDefaultValue=false)]
        public string AllowedExportFormats { get; set; }

        /// <summary>
        /// Specifies whether the drawing mode panel shall be enabled while user is drawing a free hand annotation.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.
        /// </summary>
        /// <value>Specifies whether the drawing mode panel shall be enabled while user is drawing a free hand annotation.&lt;br /&gt;  This property is only effective if EnableGdPictureAnnotations is set to true.</value>
        [DataMember(Name="DisableAnnotationDrawingModePanel", EmitDefaultValue=false)]
        public bool? DisableAnnotationDrawingModePanel { get; set; }


        /// <summary>
        /// Gets or Sets FileHostingURI
        /// </summary>
        [DataMember(Name="FileHostingURI", EmitDefaultValue=false)]
        public string FileHostingURI { get; set; }

        /// <summary>
        /// Specifies the URI of a document to load into the control.  This can be an empty string if a document is already loaded.
        /// </summary>
        /// <value>Specifies the URI of a document to load into the control.  This can be an empty string if a document is already loaded.</value>
        [DataMember(Name="DocumentURI", EmitDefaultValue=false)]
        public string DocumentURI { get; set; }

        /// <summary>
        /// Specifies the file name of the input document. The file name can help to determine the input document format.  Default value is an empty string.
        /// </summary>
        /// <value>Specifies the file name of the input document. The file name can help to determine the input document format.  Default value is an empty string.</value>
        [DataMember(Name="DocumentFileName", EmitDefaultValue=false)]
        public string DocumentFileName { get; set; }

        /// <summary>
        /// A flag specifying if the control should display a loading progress status bar to the end user while a document is being loaded.
        /// </summary>
        /// <value>A flag specifying if the control should display a loading progress status bar to the end user while a document is being loaded.</value>
        [DataMember(Name="DisableDownloadProgress", EmitDefaultValue=false)]
        public bool? DisableDownloadProgress { get; set; }

        /// <summary>
        /// Gets or Sets EnableDocumentsDrop
        /// </summary>
        [DataMember(Name="EnableDocumentsDrop", EmitDefaultValue=false)]
        public bool? EnableDocumentsDrop { get; set; }

        /// <summary>
        /// Specifies custom headers for the generated ajax requests
        /// </summary>
        /// <value>Specifies custom headers for the generated ajax requests</value>
        [DataMember(Name="CustomHeaders", EmitDefaultValue=false)]
        public string CustomHeaders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocuViewareControlState {\n");
            sb.Append("  TextSearchMaxResults: ").Append(TextSearchMaxResults).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  ControlId: ").Append(ControlId).Append("\n");
            sb.Append("  ShowLogo: ").Append(ShowLogo).Append("\n");
            sb.Append("  RemoteIP: ").Append(RemoteIP).Append("\n");
            sb.Append("  DocumentAlignment: ").Append(DocumentAlignment).Append("\n");
            sb.Append("  DocumentPosition: ").Append(DocumentPosition).Append("\n");
            sb.Append("  EnableGdPictureAnnotations: ").Append(EnableGdPictureAnnotations).Append("\n");
            sb.Append("  EnableFormFieldsEdition: ").Append(EnableFormFieldsEdition).Append("\n");
            sb.Append("  AnnotationEditorMode: ").Append(AnnotationEditorMode).Append("\n");
            sb.Append("  Zoom: ").Append(Zoom).Append("\n");
            sb.Append("  ZoomMode: ").Append(ZoomMode).Append("\n");
            sb.Append("  OpenZoomMode: ").Append(OpenZoomMode).Append("\n");
            sb.Append("  ViewRotation: ").Append(ViewRotation).Append("\n");
            sb.Append("  PageRotation: ").Append(PageRotation).Append("\n");
            sb.Append("  ZoomStep: ").Append(ZoomStep).Append("\n");
            sb.Append("  ScrollBars: ").Append(ScrollBars).Append("\n");
            sb.Append("  ForceScrollBars: ").Append(ForceScrollBars).Append("\n");
            sb.Append("  PageViewMode: ").Append(PageViewMode).Append("\n");
            sb.Append("  EnableTextSelection: ").Append(EnableTextSelection).Append("\n");
            sb.Append("  EnableTextSelectionAnnotation: ").Append(EnableTextSelectionAnnotation).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  UserLanguages: ").Append(UserLanguages).Append("\n");
            sb.Append("  ControlWidth: ").Append(ControlWidth).Append("\n");
            sb.Append("  ControlHeight: ").Append(ControlHeight).Append("\n");
            sb.Append("  AnnotationDropShadow: ").Append(AnnotationDropShadow).Append("\n");
            sb.Append("  AllowPrint: ").Append(AllowPrint).Append("\n");
            sb.Append("  AllowUpload: ").Append(AllowUpload).Append("\n");
            sb.Append("  EnableMultipleThumbnailSelection: ").Append(EnableMultipleThumbnailSelection).Append("\n");
            sb.Append("  EnableThumbnailDragDrop: ").Append(EnableThumbnailDragDrop).Append("\n");
            sb.Append("  EnableFileUploadButton: ").Append(EnableFileUploadButton).Append("\n");
            sb.Append("  EnableLoadFromUriButton: ").Append(EnableLoadFromUriButton).Append("\n");
            sb.Append("  EnableSaveButton: ").Append(EnableSaveButton).Append("\n");
            sb.Append("  EnablePagesNavigationButtons: ").Append(EnablePagesNavigationButtons).Append("\n");
            sb.Append("  EnablePrintButton: ").Append(EnablePrintButton).Append("\n");
            sb.Append("  EnableFitWidthButton: ").Append(EnableFitWidthButton).Append("\n");
            sb.Append("  EnableZoom100Button: ").Append(EnableZoom100Button).Append("\n");
            sb.Append("  EnableMouseModeButtons: ").Append(EnableMouseModeButtons).Append("\n");
            sb.Append("  EnablePanModeButton: ").Append(EnablePanModeButton).Append("\n");
            sb.Append("  EnableSelectModeButton: ").Append(EnableSelectModeButton).Append("\n");
            sb.Append("  EnableMarqueeZoomModeButton: ").Append(EnableMarqueeZoomModeButton).Append("\n");
            sb.Append("  EnableFullScreenButton: ").Append(EnableFullScreenButton).Append("\n");
            sb.Append("  EnableFitPageButton: ").Append(EnableFitPageButton).Append("\n");
            sb.Append("  EnableZoomButtons: ").Append(EnableZoomButtons).Append("\n");
            sb.Append("  EnablePageViewButtons: ").Append(EnablePageViewButtons).Append("\n");
            sb.Append("  RotateButtonsMode: ").Append(RotateButtonsMode).Append("\n");
            sb.Append("  EnableRotateButtons: ").Append(EnableRotateButtons).Append("\n");
            sb.Append("  EnableAnnotationActionButtons: ").Append(EnableAnnotationActionButtons).Append("\n");
            sb.Append("  EnableSelectedTextAnnotationEdition: ").Append(EnableSelectedTextAnnotationEdition).Append("\n");
            sb.Append("  EnableRectangleHighlighterAnnotationButton: ").Append(EnableRectangleHighlighterAnnotationButton).Append("\n");
            sb.Append("  EnableFreehandHighlighterAnnotationButton: ").Append(EnableFreehandHighlighterAnnotationButton).Append("\n");
            sb.Append("  EnableRubberStampAnnotationButton: ").Append(EnableRubberStampAnnotationButton).Append("\n");
            sb.Append("  EnableRectangleAnnotationButton: ").Append(EnableRectangleAnnotationButton).Append("\n");
            sb.Append("  EnableEllipseAnnotationButton: ").Append(EnableEllipseAnnotationButton).Append("\n");
            sb.Append("  EnableLineAnnotationButton: ").Append(EnableLineAnnotationButton).Append("\n");
            sb.Append("  EnableConnectedLineAnnotationButton: ").Append(EnableConnectedLineAnnotationButton).Append("\n");
            sb.Append("  EnableFreehandAnnotationButton: ").Append(EnableFreehandAnnotationButton).Append("\n");
            sb.Append("  EnableLineArrowAnnotationButton: ").Append(EnableLineArrowAnnotationButton).Append("\n");
            sb.Append("  EnableLinkAnnotationButton: ").Append(EnableLinkAnnotationButton).Append("\n");
            sb.Append("  EnableRulerAnnotationButton: ").Append(EnableRulerAnnotationButton).Append("\n");
            sb.Append("  EnablePolyRulerAnnotationButton: ").Append(EnablePolyRulerAnnotationButton).Append("\n");
            sb.Append("  EnableTextAnnotationButton: ").Append(EnableTextAnnotationButton).Append("\n");
            sb.Append("  EnableStickyNoteAnnotationButton: ").Append(EnableStickyNoteAnnotationButton).Append("\n");
            sb.Append("  EnableTwainAcquisitionButton: ").Append(EnableTwainAcquisitionButton).Append("\n");
            sb.Append("  TwainSourceEnableCustomConfiguration: ").Append(TwainSourceEnableCustomConfiguration).Append("\n");
            sb.Append("  TwainSourceSelectFeeder: ").Append(TwainSourceSelectFeeder).Append("\n");
            sb.Append("  TwainSourceBitDepth: ").Append(TwainSourceBitDepth).Append("\n");
            sb.Append("  TwainSourceResolution: ").Append(TwainSourceResolution).Append("\n");
            sb.Append("  TwainSourceEnableDuplex: ").Append(TwainSourceEnableDuplex).Append("\n");
            sb.Append("  TwainSourceHideUI: ").Append(TwainSourceHideUI).Append("\n");
            sb.Append("  FreeHandContinuousDrawingMode: ").Append(FreeHandContinuousDrawingMode).Append("\n");
            sb.Append("  ShowTextSearchSnapIn: ").Append(ShowTextSearchSnapIn).Append("\n");
            sb.Append("  ShowThumbnailsSnapIn: ").Append(ShowThumbnailsSnapIn).Append("\n");
            sb.Append("  ShowBookmarksSnapIn: ").Append(ShowBookmarksSnapIn).Append("\n");
            sb.Append("  ShowAnnotationsSnapIn: ").Append(ShowAnnotationsSnapIn).Append("\n");
            sb.Append("  ShowAnnotationsCommentsSnapIn: ").Append(ShowAnnotationsCommentsSnapIn).Append("\n");
            sb.Append("  ThumbnailWidth: ").Append(ThumbnailWidth).Append("\n");
            sb.Append("  ThumbnailHeight: ").Append(ThumbnailHeight).Append("\n");
            sb.Append("  SnapInPanelDefaultWidth: ").Append(SnapInPanelDefaultWidth).Append("\n");
            sb.Append("  CollapsedSnapIn: ").Append(CollapsedSnapIn).Append("\n");
            sb.Append("  CollapseSnapinOnDocumentClosed: ").Append(CollapseSnapinOnDocumentClosed).Append("\n");
            sb.Append("  ShowSnapInCollapseButton: ").Append(ShowSnapInCollapseButton).Append("\n");
            sb.Append("  ShowSnapInPanelHeader: ").Append(ShowSnapInPanelHeader).Append("\n");
            sb.Append("  ShowSnapInButtonStrip: ").Append(ShowSnapInButtonStrip).Append("\n");
            sb.Append("  ShowToolbar: ").Append(ShowToolbar).Append("\n");
            sb.Append("  ToolbarStyle: ").Append(ToolbarStyle).Append("\n");
            sb.Append("  ToolbarButtonsSpacing: ").Append(ToolbarButtonsSpacing).Append("\n");
            sb.Append("  ToolbarHeight: ").Append(ToolbarHeight).Append("\n");
            sb.Append("  StrokeColor: ").Append(StrokeColor).Append("\n");
            sb.Append("  MiscBorderColor: ").Append(MiscBorderColor).Append("\n");
            sb.Append("  HeaderColor: ").Append(HeaderColor).Append("\n");
            sb.Append("  PanelBackColor: ").Append(PanelBackColor).Append("\n");
            sb.Append("  ViewerBackColor: ").Append(ViewerBackColor).Append("\n");
            sb.Append("  ActiveSelectedColor: ").Append(ActiveSelectedColor).Append("\n");
            sb.Append("  ToolbarBackColor: ").Append(ToolbarBackColor).Append("\n");
            sb.Append("  CustomNotificationIconError: ").Append(CustomNotificationIconError).Append("\n");
            sb.Append("  CustomNotificationIconQuestion: ").Append(CustomNotificationIconQuestion).Append("\n");
            sb.Append("  CustomNotificationIconWarning: ").Append(CustomNotificationIconWarning).Append("\n");
            sb.Append("  CustomNotificationIconInfo: ").Append(CustomNotificationIconInfo).Append("\n");
            sb.Append("  CustomNotificationIconOk: ").Append(CustomNotificationIconOk).Append("\n");
            sb.Append("  MaxUploadSize: ").Append(MaxUploadSize).Append("\n");
            sb.Append("  MaxDownloadSize: ").Append(MaxDownloadSize).Append("\n");
            sb.Append("  MaxPages: ").Append(MaxPages).Append("\n");
            sb.Append("  AllowedExportFormats: ").Append(AllowedExportFormats).Append("\n");
            sb.Append("  DisableAnnotationDrawingModePanel: ").Append(DisableAnnotationDrawingModePanel).Append("\n");
            sb.Append("  PrintQuality: ").Append(PrintQuality).Append("\n");
            sb.Append("  FileHostingURI: ").Append(FileHostingURI).Append("\n");
            sb.Append("  DocumentURI: ").Append(DocumentURI).Append("\n");
            sb.Append("  DocumentFileName: ").Append(DocumentFileName).Append("\n");
            sb.Append("  DisableDownloadProgress: ").Append(DisableDownloadProgress).Append("\n");
            sb.Append("  EnableDocumentsDrop: ").Append(EnableDocumentsDrop).Append("\n");
            sb.Append("  CustomHeaders: ").Append(CustomHeaders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocuViewareControlState);
        }

        /// <summary>
        /// Returns true if DocuViewareControlState instances are equal
        /// </summary>
        /// <param name="input">Instance of DocuViewareControlState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocuViewareControlState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextSearchMaxResults == input.TextSearchMaxResults ||
                    (this.TextSearchMaxResults != null &&
                    this.TextSearchMaxResults.Equals(input.TextSearchMaxResults))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.ControlId == input.ControlId ||
                    (this.ControlId != null &&
                    this.ControlId.Equals(input.ControlId))
                ) && 
                (
                    this.ShowLogo == input.ShowLogo ||
                    (this.ShowLogo != null &&
                    this.ShowLogo.Equals(input.ShowLogo))
                ) && 
                (
                    this.RemoteIP == input.RemoteIP ||
                    (this.RemoteIP != null &&
                    this.RemoteIP.Equals(input.RemoteIP))
                ) && 
                (
                    this.DocumentAlignment == input.DocumentAlignment ||
                    (this.DocumentAlignment != null &&
                    this.DocumentAlignment.Equals(input.DocumentAlignment))
                ) && 
                (
                    this.DocumentPosition == input.DocumentPosition ||
                    (this.DocumentPosition != null &&
                    this.DocumentPosition.Equals(input.DocumentPosition))
                ) && 
                (
                    this.EnableGdPictureAnnotations == input.EnableGdPictureAnnotations ||
                    (this.EnableGdPictureAnnotations != null &&
                    this.EnableGdPictureAnnotations.Equals(input.EnableGdPictureAnnotations))
                ) && 
                (
                    this.EnableFormFieldsEdition == input.EnableFormFieldsEdition ||
                    (this.EnableFormFieldsEdition != null &&
                    this.EnableFormFieldsEdition.Equals(input.EnableFormFieldsEdition))
                ) && 
                (
                    this.AnnotationEditorMode == input.AnnotationEditorMode ||
                    (this.AnnotationEditorMode != null &&
                    this.AnnotationEditorMode.Equals(input.AnnotationEditorMode))
                ) && 
                (
                    this.Zoom == input.Zoom ||
                    (this.Zoom != null &&
                    this.Zoom.Equals(input.Zoom))
                ) && 
                (
                    this.ZoomMode == input.ZoomMode ||
                    (this.ZoomMode != null &&
                    this.ZoomMode.Equals(input.ZoomMode))
                ) && 
                (
                    this.OpenZoomMode == input.OpenZoomMode ||
                    (this.OpenZoomMode != null &&
                    this.OpenZoomMode.Equals(input.OpenZoomMode))
                ) && 
                (
                    this.ViewRotation == input.ViewRotation ||
                    (this.ViewRotation != null &&
                    this.ViewRotation.Equals(input.ViewRotation))
                ) && 
                (
                    this.PageRotation == input.PageRotation ||
                    (this.PageRotation != null &&
                    this.PageRotation.Equals(input.PageRotation))
                ) && 
                (
                    this.ZoomStep == input.ZoomStep ||
                    (this.ZoomStep != null &&
                    this.ZoomStep.Equals(input.ZoomStep))
                ) && 
                (
                    this.ScrollBars == input.ScrollBars ||
                    (this.ScrollBars != null &&
                    this.ScrollBars.Equals(input.ScrollBars))
                ) && 
                (
                    this.ForceScrollBars == input.ForceScrollBars ||
                    (this.ForceScrollBars != null &&
                    this.ForceScrollBars.Equals(input.ForceScrollBars))
                ) && 
                (
                    this.PageViewMode == input.PageViewMode ||
                    (this.PageViewMode != null &&
                    this.PageViewMode.Equals(input.PageViewMode))
                ) && 
                (
                    this.EnableTextSelection == input.EnableTextSelection ||
                    (this.EnableTextSelection != null &&
                    this.EnableTextSelection.Equals(input.EnableTextSelection))
                ) && 
                (
                    this.EnableTextSelectionAnnotation == input.EnableTextSelectionAnnotation ||
                    (this.EnableTextSelectionAnnotation != null &&
                    this.EnableTextSelectionAnnotation.Equals(input.EnableTextSelectionAnnotation))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.UserLanguages == input.UserLanguages ||
                    this.UserLanguages != null &&
                    this.UserLanguages.SequenceEqual(input.UserLanguages)
                ) && 
                (
                    this.ControlWidth == input.ControlWidth ||
                    (this.ControlWidth != null &&
                    this.ControlWidth.Equals(input.ControlWidth))
                ) && 
                (
                    this.ControlHeight == input.ControlHeight ||
                    (this.ControlHeight != null &&
                    this.ControlHeight.Equals(input.ControlHeight))
                ) && 
                (
                    this.AnnotationDropShadow == input.AnnotationDropShadow ||
                    (this.AnnotationDropShadow != null &&
                    this.AnnotationDropShadow.Equals(input.AnnotationDropShadow))
                ) && 
                (
                    this.AllowPrint == input.AllowPrint ||
                    (this.AllowPrint != null &&
                    this.AllowPrint.Equals(input.AllowPrint))
                ) && 
                (
                    this.AllowUpload == input.AllowUpload ||
                    (this.AllowUpload != null &&
                    this.AllowUpload.Equals(input.AllowUpload))
                ) && 
                (
                    this.EnableMultipleThumbnailSelection == input.EnableMultipleThumbnailSelection ||
                    (this.EnableMultipleThumbnailSelection != null &&
                    this.EnableMultipleThumbnailSelection.Equals(input.EnableMultipleThumbnailSelection))
                ) && 
                (
                    this.EnableThumbnailDragDrop == input.EnableThumbnailDragDrop ||
                    (this.EnableThumbnailDragDrop != null &&
                    this.EnableThumbnailDragDrop.Equals(input.EnableThumbnailDragDrop))
                ) && 
                (
                    this.EnableFileUploadButton == input.EnableFileUploadButton ||
                    (this.EnableFileUploadButton != null &&
                    this.EnableFileUploadButton.Equals(input.EnableFileUploadButton))
                ) && 
                (
                    this.EnableLoadFromUriButton == input.EnableLoadFromUriButton ||
                    (this.EnableLoadFromUriButton != null &&
                    this.EnableLoadFromUriButton.Equals(input.EnableLoadFromUriButton))
                ) && 
                (
                    this.EnableSaveButton == input.EnableSaveButton ||
                    (this.EnableSaveButton != null &&
                    this.EnableSaveButton.Equals(input.EnableSaveButton))
                ) && 
                (
                    this.EnablePagesNavigationButtons == input.EnablePagesNavigationButtons ||
                    (this.EnablePagesNavigationButtons != null &&
                    this.EnablePagesNavigationButtons.Equals(input.EnablePagesNavigationButtons))
                ) && 
                (
                    this.EnablePrintButton == input.EnablePrintButton ||
                    (this.EnablePrintButton != null &&
                    this.EnablePrintButton.Equals(input.EnablePrintButton))
                ) && 
                (
                    this.EnableFitWidthButton == input.EnableFitWidthButton ||
                    (this.EnableFitWidthButton != null &&
                    this.EnableFitWidthButton.Equals(input.EnableFitWidthButton))
                ) && 
                (
                    this.EnableZoom100Button == input.EnableZoom100Button ||
                    (this.EnableZoom100Button != null &&
                    this.EnableZoom100Button.Equals(input.EnableZoom100Button))
                ) && 
                (
                    this.EnableMouseModeButtons == input.EnableMouseModeButtons ||
                    (this.EnableMouseModeButtons != null &&
                    this.EnableMouseModeButtons.Equals(input.EnableMouseModeButtons))
                ) && 
                (
                    this.EnablePanModeButton == input.EnablePanModeButton ||
                    (this.EnablePanModeButton != null &&
                    this.EnablePanModeButton.Equals(input.EnablePanModeButton))
                ) && 
                (
                    this.EnableSelectModeButton == input.EnableSelectModeButton ||
                    (this.EnableSelectModeButton != null &&
                    this.EnableSelectModeButton.Equals(input.EnableSelectModeButton))
                ) && 
                (
                    this.EnableMarqueeZoomModeButton == input.EnableMarqueeZoomModeButton ||
                    (this.EnableMarqueeZoomModeButton != null &&
                    this.EnableMarqueeZoomModeButton.Equals(input.EnableMarqueeZoomModeButton))
                ) && 
                (
                    this.EnableFullScreenButton == input.EnableFullScreenButton ||
                    (this.EnableFullScreenButton != null &&
                    this.EnableFullScreenButton.Equals(input.EnableFullScreenButton))
                ) && 
                (
                    this.EnableFitPageButton == input.EnableFitPageButton ||
                    (this.EnableFitPageButton != null &&
                    this.EnableFitPageButton.Equals(input.EnableFitPageButton))
                ) && 
                (
                    this.EnableZoomButtons == input.EnableZoomButtons ||
                    (this.EnableZoomButtons != null &&
                    this.EnableZoomButtons.Equals(input.EnableZoomButtons))
                ) && 
                (
                    this.EnablePageViewButtons == input.EnablePageViewButtons ||
                    (this.EnablePageViewButtons != null &&
                    this.EnablePageViewButtons.Equals(input.EnablePageViewButtons))
                ) && 
                (
                    this.RotateButtonsMode == input.RotateButtonsMode ||
                    (this.RotateButtonsMode != null &&
                    this.RotateButtonsMode.Equals(input.RotateButtonsMode))
                ) && 
                (
                    this.EnableRotateButtons == input.EnableRotateButtons ||
                    (this.EnableRotateButtons != null &&
                    this.EnableRotateButtons.Equals(input.EnableRotateButtons))
                ) && 
                (
                    this.EnableAnnotationActionButtons == input.EnableAnnotationActionButtons ||
                    (this.EnableAnnotationActionButtons != null &&
                    this.EnableAnnotationActionButtons.Equals(input.EnableAnnotationActionButtons))
                ) && 
                (
                    this.EnableSelectedTextAnnotationEdition == input.EnableSelectedTextAnnotationEdition ||
                    (this.EnableSelectedTextAnnotationEdition != null &&
                    this.EnableSelectedTextAnnotationEdition.Equals(input.EnableSelectedTextAnnotationEdition))
                ) && 
                (
                    this.EnableRectangleHighlighterAnnotationButton == input.EnableRectangleHighlighterAnnotationButton ||
                    (this.EnableRectangleHighlighterAnnotationButton != null &&
                    this.EnableRectangleHighlighterAnnotationButton.Equals(input.EnableRectangleHighlighterAnnotationButton))
                ) && 
                (
                    this.EnableFreehandHighlighterAnnotationButton == input.EnableFreehandHighlighterAnnotationButton ||
                    (this.EnableFreehandHighlighterAnnotationButton != null &&
                    this.EnableFreehandHighlighterAnnotationButton.Equals(input.EnableFreehandHighlighterAnnotationButton))
                ) && 
                (
                    this.EnableRubberStampAnnotationButton == input.EnableRubberStampAnnotationButton ||
                    (this.EnableRubberStampAnnotationButton != null &&
                    this.EnableRubberStampAnnotationButton.Equals(input.EnableRubberStampAnnotationButton))
                ) && 
                (
                    this.EnableRectangleAnnotationButton == input.EnableRectangleAnnotationButton ||
                    (this.EnableRectangleAnnotationButton != null &&
                    this.EnableRectangleAnnotationButton.Equals(input.EnableRectangleAnnotationButton))
                ) && 
                (
                    this.EnableEllipseAnnotationButton == input.EnableEllipseAnnotationButton ||
                    (this.EnableEllipseAnnotationButton != null &&
                    this.EnableEllipseAnnotationButton.Equals(input.EnableEllipseAnnotationButton))
                ) && 
                (
                    this.EnableLineAnnotationButton == input.EnableLineAnnotationButton ||
                    (this.EnableLineAnnotationButton != null &&
                    this.EnableLineAnnotationButton.Equals(input.EnableLineAnnotationButton))
                ) && 
                (
                    this.EnableConnectedLineAnnotationButton == input.EnableConnectedLineAnnotationButton ||
                    (this.EnableConnectedLineAnnotationButton != null &&
                    this.EnableConnectedLineAnnotationButton.Equals(input.EnableConnectedLineAnnotationButton))
                ) && 
                (
                    this.EnableFreehandAnnotationButton == input.EnableFreehandAnnotationButton ||
                    (this.EnableFreehandAnnotationButton != null &&
                    this.EnableFreehandAnnotationButton.Equals(input.EnableFreehandAnnotationButton))
                ) && 
                (
                    this.EnableLineArrowAnnotationButton == input.EnableLineArrowAnnotationButton ||
                    (this.EnableLineArrowAnnotationButton != null &&
                    this.EnableLineArrowAnnotationButton.Equals(input.EnableLineArrowAnnotationButton))
                ) && 
                (
                    this.EnableLinkAnnotationButton == input.EnableLinkAnnotationButton ||
                    (this.EnableLinkAnnotationButton != null &&
                    this.EnableLinkAnnotationButton.Equals(input.EnableLinkAnnotationButton))
                ) && 
                (
                    this.EnableRulerAnnotationButton == input.EnableRulerAnnotationButton ||
                    (this.EnableRulerAnnotationButton != null &&
                    this.EnableRulerAnnotationButton.Equals(input.EnableRulerAnnotationButton))
                ) && 
                (
                    this.EnablePolyRulerAnnotationButton == input.EnablePolyRulerAnnotationButton ||
                    (this.EnablePolyRulerAnnotationButton != null &&
                    this.EnablePolyRulerAnnotationButton.Equals(input.EnablePolyRulerAnnotationButton))
                ) && 
                (
                    this.EnableTextAnnotationButton == input.EnableTextAnnotationButton ||
                    (this.EnableTextAnnotationButton != null &&
                    this.EnableTextAnnotationButton.Equals(input.EnableTextAnnotationButton))
                ) && 
                (
                    this.EnableStickyNoteAnnotationButton == input.EnableStickyNoteAnnotationButton ||
                    (this.EnableStickyNoteAnnotationButton != null &&
                    this.EnableStickyNoteAnnotationButton.Equals(input.EnableStickyNoteAnnotationButton))
                ) && 
                (
                    this.EnableTwainAcquisitionButton == input.EnableTwainAcquisitionButton ||
                    (this.EnableTwainAcquisitionButton != null &&
                    this.EnableTwainAcquisitionButton.Equals(input.EnableTwainAcquisitionButton))
                ) && 
                (
                    this.TwainSourceEnableCustomConfiguration == input.TwainSourceEnableCustomConfiguration ||
                    (this.TwainSourceEnableCustomConfiguration != null &&
                    this.TwainSourceEnableCustomConfiguration.Equals(input.TwainSourceEnableCustomConfiguration))
                ) && 
                (
                    this.TwainSourceSelectFeeder == input.TwainSourceSelectFeeder ||
                    (this.TwainSourceSelectFeeder != null &&
                    this.TwainSourceSelectFeeder.Equals(input.TwainSourceSelectFeeder))
                ) && 
                (
                    this.TwainSourceBitDepth == input.TwainSourceBitDepth ||
                    (this.TwainSourceBitDepth != null &&
                    this.TwainSourceBitDepth.Equals(input.TwainSourceBitDepth))
                ) && 
                (
                    this.TwainSourceResolution == input.TwainSourceResolution ||
                    (this.TwainSourceResolution != null &&
                    this.TwainSourceResolution.Equals(input.TwainSourceResolution))
                ) && 
                (
                    this.TwainSourceEnableDuplex == input.TwainSourceEnableDuplex ||
                    (this.TwainSourceEnableDuplex != null &&
                    this.TwainSourceEnableDuplex.Equals(input.TwainSourceEnableDuplex))
                ) && 
                (
                    this.TwainSourceHideUI == input.TwainSourceHideUI ||
                    (this.TwainSourceHideUI != null &&
                    this.TwainSourceHideUI.Equals(input.TwainSourceHideUI))
                ) && 
                (
                    this.FreeHandContinuousDrawingMode == input.FreeHandContinuousDrawingMode ||
                    (this.FreeHandContinuousDrawingMode != null &&
                    this.FreeHandContinuousDrawingMode.Equals(input.FreeHandContinuousDrawingMode))
                ) && 
                (
                    this.ShowTextSearchSnapIn == input.ShowTextSearchSnapIn ||
                    (this.ShowTextSearchSnapIn != null &&
                    this.ShowTextSearchSnapIn.Equals(input.ShowTextSearchSnapIn))
                ) && 
                (
                    this.ShowThumbnailsSnapIn == input.ShowThumbnailsSnapIn ||
                    (this.ShowThumbnailsSnapIn != null &&
                    this.ShowThumbnailsSnapIn.Equals(input.ShowThumbnailsSnapIn))
                ) && 
                (
                    this.ShowBookmarksSnapIn == input.ShowBookmarksSnapIn ||
                    (this.ShowBookmarksSnapIn != null &&
                    this.ShowBookmarksSnapIn.Equals(input.ShowBookmarksSnapIn))
                ) && 
                (
                    this.ShowAnnotationsSnapIn == input.ShowAnnotationsSnapIn ||
                    (this.ShowAnnotationsSnapIn != null &&
                    this.ShowAnnotationsSnapIn.Equals(input.ShowAnnotationsSnapIn))
                ) && 
                (
                    this.ShowAnnotationsCommentsSnapIn == input.ShowAnnotationsCommentsSnapIn ||
                    (this.ShowAnnotationsCommentsSnapIn != null &&
                    this.ShowAnnotationsCommentsSnapIn.Equals(input.ShowAnnotationsCommentsSnapIn))
                ) && 
                (
                    this.ThumbnailWidth == input.ThumbnailWidth ||
                    (this.ThumbnailWidth != null &&
                    this.ThumbnailWidth.Equals(input.ThumbnailWidth))
                ) && 
                (
                    this.ThumbnailHeight == input.ThumbnailHeight ||
                    (this.ThumbnailHeight != null &&
                    this.ThumbnailHeight.Equals(input.ThumbnailHeight))
                ) && 
                (
                    this.SnapInPanelDefaultWidth == input.SnapInPanelDefaultWidth ||
                    (this.SnapInPanelDefaultWidth != null &&
                    this.SnapInPanelDefaultWidth.Equals(input.SnapInPanelDefaultWidth))
                ) && 
                (
                    this.CollapsedSnapIn == input.CollapsedSnapIn ||
                    (this.CollapsedSnapIn != null &&
                    this.CollapsedSnapIn.Equals(input.CollapsedSnapIn))
                ) && 
                (
                    this.CollapseSnapinOnDocumentClosed == input.CollapseSnapinOnDocumentClosed ||
                    (this.CollapseSnapinOnDocumentClosed != null &&
                    this.CollapseSnapinOnDocumentClosed.Equals(input.CollapseSnapinOnDocumentClosed))
                ) && 
                (
                    this.ShowSnapInCollapseButton == input.ShowSnapInCollapseButton ||
                    (this.ShowSnapInCollapseButton != null &&
                    this.ShowSnapInCollapseButton.Equals(input.ShowSnapInCollapseButton))
                ) && 
                (
                    this.ShowSnapInPanelHeader == input.ShowSnapInPanelHeader ||
                    (this.ShowSnapInPanelHeader != null &&
                    this.ShowSnapInPanelHeader.Equals(input.ShowSnapInPanelHeader))
                ) && 
                (
                    this.ShowSnapInButtonStrip == input.ShowSnapInButtonStrip ||
                    (this.ShowSnapInButtonStrip != null &&
                    this.ShowSnapInButtonStrip.Equals(input.ShowSnapInButtonStrip))
                ) && 
                (
                    this.ShowToolbar == input.ShowToolbar ||
                    (this.ShowToolbar != null &&
                    this.ShowToolbar.Equals(input.ShowToolbar))
                ) && 
                (
                    this.ToolbarStyle == input.ToolbarStyle ||
                    (this.ToolbarStyle != null &&
                    this.ToolbarStyle.Equals(input.ToolbarStyle))
                ) && 
                (
                    this.ToolbarButtonsSpacing == input.ToolbarButtonsSpacing ||
                    (this.ToolbarButtonsSpacing != null &&
                    this.ToolbarButtonsSpacing.Equals(input.ToolbarButtonsSpacing))
                ) && 
                (
                    this.ToolbarHeight == input.ToolbarHeight ||
                    (this.ToolbarHeight != null &&
                    this.ToolbarHeight.Equals(input.ToolbarHeight))
                ) && 
                (
                    this.StrokeColor == input.StrokeColor ||
                    (this.StrokeColor != null &&
                    this.StrokeColor.Equals(input.StrokeColor))
                ) && 
                (
                    this.MiscBorderColor == input.MiscBorderColor ||
                    (this.MiscBorderColor != null &&
                    this.MiscBorderColor.Equals(input.MiscBorderColor))
                ) && 
                (
                    this.HeaderColor == input.HeaderColor ||
                    (this.HeaderColor != null &&
                    this.HeaderColor.Equals(input.HeaderColor))
                ) && 
                (
                    this.PanelBackColor == input.PanelBackColor ||
                    (this.PanelBackColor != null &&
                    this.PanelBackColor.Equals(input.PanelBackColor))
                ) && 
                (
                    this.ViewerBackColor == input.ViewerBackColor ||
                    (this.ViewerBackColor != null &&
                    this.ViewerBackColor.Equals(input.ViewerBackColor))
                ) && 
                (
                    this.ActiveSelectedColor == input.ActiveSelectedColor ||
                    (this.ActiveSelectedColor != null &&
                    this.ActiveSelectedColor.Equals(input.ActiveSelectedColor))
                ) && 
                (
                    this.ToolbarBackColor == input.ToolbarBackColor ||
                    (this.ToolbarBackColor != null &&
                    this.ToolbarBackColor.Equals(input.ToolbarBackColor))
                ) && 
                (
                    this.CustomNotificationIconError == input.CustomNotificationIconError ||
                    (this.CustomNotificationIconError != null &&
                    this.CustomNotificationIconError.Equals(input.CustomNotificationIconError))
                ) && 
                (
                    this.CustomNotificationIconQuestion == input.CustomNotificationIconQuestion ||
                    (this.CustomNotificationIconQuestion != null &&
                    this.CustomNotificationIconQuestion.Equals(input.CustomNotificationIconQuestion))
                ) && 
                (
                    this.CustomNotificationIconWarning == input.CustomNotificationIconWarning ||
                    (this.CustomNotificationIconWarning != null &&
                    this.CustomNotificationIconWarning.Equals(input.CustomNotificationIconWarning))
                ) && 
                (
                    this.CustomNotificationIconInfo == input.CustomNotificationIconInfo ||
                    (this.CustomNotificationIconInfo != null &&
                    this.CustomNotificationIconInfo.Equals(input.CustomNotificationIconInfo))
                ) && 
                (
                    this.CustomNotificationIconOk == input.CustomNotificationIconOk ||
                    (this.CustomNotificationIconOk != null &&
                    this.CustomNotificationIconOk.Equals(input.CustomNotificationIconOk))
                ) && 
                (
                    this.MaxUploadSize == input.MaxUploadSize ||
                    (this.MaxUploadSize != null &&
                    this.MaxUploadSize.Equals(input.MaxUploadSize))
                ) && 
                (
                    this.MaxDownloadSize == input.MaxDownloadSize ||
                    (this.MaxDownloadSize != null &&
                    this.MaxDownloadSize.Equals(input.MaxDownloadSize))
                ) && 
                (
                    this.MaxPages == input.MaxPages ||
                    (this.MaxPages != null &&
                    this.MaxPages.Equals(input.MaxPages))
                ) && 
                (
                    this.AllowedExportFormats == input.AllowedExportFormats ||
                    (this.AllowedExportFormats != null &&
                    this.AllowedExportFormats.Equals(input.AllowedExportFormats))
                ) && 
                (
                    this.DisableAnnotationDrawingModePanel == input.DisableAnnotationDrawingModePanel ||
                    (this.DisableAnnotationDrawingModePanel != null &&
                    this.DisableAnnotationDrawingModePanel.Equals(input.DisableAnnotationDrawingModePanel))
                ) && 
                (
                    this.PrintQuality == input.PrintQuality ||
                    (this.PrintQuality != null &&
                    this.PrintQuality.Equals(input.PrintQuality))
                ) && 
                (
                    this.FileHostingURI == input.FileHostingURI ||
                    (this.FileHostingURI != null &&
                    this.FileHostingURI.Equals(input.FileHostingURI))
                ) && 
                (
                    this.DocumentURI == input.DocumentURI ||
                    (this.DocumentURI != null &&
                    this.DocumentURI.Equals(input.DocumentURI))
                ) && 
                (
                    this.DocumentFileName == input.DocumentFileName ||
                    (this.DocumentFileName != null &&
                    this.DocumentFileName.Equals(input.DocumentFileName))
                ) && 
                (
                    this.DisableDownloadProgress == input.DisableDownloadProgress ||
                    (this.DisableDownloadProgress != null &&
                    this.DisableDownloadProgress.Equals(input.DisableDownloadProgress))
                ) && 
                (
                    this.EnableDocumentsDrop == input.EnableDocumentsDrop ||
                    (this.EnableDocumentsDrop != null &&
                    this.EnableDocumentsDrop.Equals(input.EnableDocumentsDrop))
                ) && 
                (
                    this.CustomHeaders == input.CustomHeaders ||
                    (this.CustomHeaders != null &&
                    this.CustomHeaders.Equals(input.CustomHeaders))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TextSearchMaxResults != null)
                    hashCode = hashCode * 59 + this.TextSearchMaxResults.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.ControlId != null)
                    hashCode = hashCode * 59 + this.ControlId.GetHashCode();
                if (this.ShowLogo != null)
                    hashCode = hashCode * 59 + this.ShowLogo.GetHashCode();
                if (this.RemoteIP != null)
                    hashCode = hashCode * 59 + this.RemoteIP.GetHashCode();
                if (this.DocumentAlignment != null)
                    hashCode = hashCode * 59 + this.DocumentAlignment.GetHashCode();
                if (this.DocumentPosition != null)
                    hashCode = hashCode * 59 + this.DocumentPosition.GetHashCode();
                if (this.EnableGdPictureAnnotations != null)
                    hashCode = hashCode * 59 + this.EnableGdPictureAnnotations.GetHashCode();
                if (this.EnableFormFieldsEdition != null)
                    hashCode = hashCode * 59 + this.EnableFormFieldsEdition.GetHashCode();
                if (this.AnnotationEditorMode != null)
                    hashCode = hashCode * 59 + this.AnnotationEditorMode.GetHashCode();
                if (this.Zoom != null)
                    hashCode = hashCode * 59 + this.Zoom.GetHashCode();
                if (this.ZoomMode != null)
                    hashCode = hashCode * 59 + this.ZoomMode.GetHashCode();
                if (this.OpenZoomMode != null)
                    hashCode = hashCode * 59 + this.OpenZoomMode.GetHashCode();
                if (this.ViewRotation != null)
                    hashCode = hashCode * 59 + this.ViewRotation.GetHashCode();
                if (this.PageRotation != null)
                    hashCode = hashCode * 59 + this.PageRotation.GetHashCode();
                if (this.ZoomStep != null)
                    hashCode = hashCode * 59 + this.ZoomStep.GetHashCode();
                if (this.ScrollBars != null)
                    hashCode = hashCode * 59 + this.ScrollBars.GetHashCode();
                if (this.ForceScrollBars != null)
                    hashCode = hashCode * 59 + this.ForceScrollBars.GetHashCode();
                if (this.PageViewMode != null)
                    hashCode = hashCode * 59 + this.PageViewMode.GetHashCode();
                if (this.EnableTextSelection != null)
                    hashCode = hashCode * 59 + this.EnableTextSelection.GetHashCode();
                if (this.EnableTextSelectionAnnotation != null)
                    hashCode = hashCode * 59 + this.EnableTextSelectionAnnotation.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.UserLanguages != null)
                    hashCode = hashCode * 59 + this.UserLanguages.GetHashCode();
                if (this.ControlWidth != null)
                    hashCode = hashCode * 59 + this.ControlWidth.GetHashCode();
                if (this.ControlHeight != null)
                    hashCode = hashCode * 59 + this.ControlHeight.GetHashCode();
                if (this.AnnotationDropShadow != null)
                    hashCode = hashCode * 59 + this.AnnotationDropShadow.GetHashCode();
                if (this.AllowPrint != null)
                    hashCode = hashCode * 59 + this.AllowPrint.GetHashCode();
                if (this.AllowUpload != null)
                    hashCode = hashCode * 59 + this.AllowUpload.GetHashCode();
                if (this.EnableMultipleThumbnailSelection != null)
                    hashCode = hashCode * 59 + this.EnableMultipleThumbnailSelection.GetHashCode();
                if (this.EnableThumbnailDragDrop != null)
                    hashCode = hashCode * 59 + this.EnableThumbnailDragDrop.GetHashCode();
                if (this.EnableFileUploadButton != null)
                    hashCode = hashCode * 59 + this.EnableFileUploadButton.GetHashCode();
                if (this.EnableLoadFromUriButton != null)
                    hashCode = hashCode * 59 + this.EnableLoadFromUriButton.GetHashCode();
                if (this.EnableSaveButton != null)
                    hashCode = hashCode * 59 + this.EnableSaveButton.GetHashCode();
                if (this.EnablePagesNavigationButtons != null)
                    hashCode = hashCode * 59 + this.EnablePagesNavigationButtons.GetHashCode();
                if (this.EnablePrintButton != null)
                    hashCode = hashCode * 59 + this.EnablePrintButton.GetHashCode();
                if (this.EnableFitWidthButton != null)
                    hashCode = hashCode * 59 + this.EnableFitWidthButton.GetHashCode();
                if (this.EnableZoom100Button != null)
                    hashCode = hashCode * 59 + this.EnableZoom100Button.GetHashCode();
                if (this.EnableMouseModeButtons != null)
                    hashCode = hashCode * 59 + this.EnableMouseModeButtons.GetHashCode();
                if (this.EnablePanModeButton != null)
                    hashCode = hashCode * 59 + this.EnablePanModeButton.GetHashCode();
                if (this.EnableSelectModeButton != null)
                    hashCode = hashCode * 59 + this.EnableSelectModeButton.GetHashCode();
                if (this.EnableMarqueeZoomModeButton != null)
                    hashCode = hashCode * 59 + this.EnableMarqueeZoomModeButton.GetHashCode();
                if (this.EnableFullScreenButton != null)
                    hashCode = hashCode * 59 + this.EnableFullScreenButton.GetHashCode();
                if (this.EnableFitPageButton != null)
                    hashCode = hashCode * 59 + this.EnableFitPageButton.GetHashCode();
                if (this.EnableZoomButtons != null)
                    hashCode = hashCode * 59 + this.EnableZoomButtons.GetHashCode();
                if (this.EnablePageViewButtons != null)
                    hashCode = hashCode * 59 + this.EnablePageViewButtons.GetHashCode();
                if (this.RotateButtonsMode != null)
                    hashCode = hashCode * 59 + this.RotateButtonsMode.GetHashCode();
                if (this.EnableRotateButtons != null)
                    hashCode = hashCode * 59 + this.EnableRotateButtons.GetHashCode();
                if (this.EnableAnnotationActionButtons != null)
                    hashCode = hashCode * 59 + this.EnableAnnotationActionButtons.GetHashCode();
                if (this.EnableSelectedTextAnnotationEdition != null)
                    hashCode = hashCode * 59 + this.EnableSelectedTextAnnotationEdition.GetHashCode();
                if (this.EnableRectangleHighlighterAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableRectangleHighlighterAnnotationButton.GetHashCode();
                if (this.EnableFreehandHighlighterAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableFreehandHighlighterAnnotationButton.GetHashCode();
                if (this.EnableRubberStampAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableRubberStampAnnotationButton.GetHashCode();
                if (this.EnableRectangleAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableRectangleAnnotationButton.GetHashCode();
                if (this.EnableEllipseAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableEllipseAnnotationButton.GetHashCode();
                if (this.EnableLineAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableLineAnnotationButton.GetHashCode();
                if (this.EnableConnectedLineAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableConnectedLineAnnotationButton.GetHashCode();
                if (this.EnableFreehandAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableFreehandAnnotationButton.GetHashCode();
                if (this.EnableLineArrowAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableLineArrowAnnotationButton.GetHashCode();
                if (this.EnableLinkAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableLinkAnnotationButton.GetHashCode();
                if (this.EnableRulerAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableRulerAnnotationButton.GetHashCode();
                if (this.EnablePolyRulerAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnablePolyRulerAnnotationButton.GetHashCode();
                if (this.EnableTextAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableTextAnnotationButton.GetHashCode();
                if (this.EnableStickyNoteAnnotationButton != null)
                    hashCode = hashCode * 59 + this.EnableStickyNoteAnnotationButton.GetHashCode();
                if (this.EnableTwainAcquisitionButton != null)
                    hashCode = hashCode * 59 + this.EnableTwainAcquisitionButton.GetHashCode();
                if (this.TwainSourceEnableCustomConfiguration != null)
                    hashCode = hashCode * 59 + this.TwainSourceEnableCustomConfiguration.GetHashCode();
                if (this.TwainSourceSelectFeeder != null)
                    hashCode = hashCode * 59 + this.TwainSourceSelectFeeder.GetHashCode();
                if (this.TwainSourceBitDepth != null)
                    hashCode = hashCode * 59 + this.TwainSourceBitDepth.GetHashCode();
                if (this.TwainSourceResolution != null)
                    hashCode = hashCode * 59 + this.TwainSourceResolution.GetHashCode();
                if (this.TwainSourceEnableDuplex != null)
                    hashCode = hashCode * 59 + this.TwainSourceEnableDuplex.GetHashCode();
                if (this.TwainSourceHideUI != null)
                    hashCode = hashCode * 59 + this.TwainSourceHideUI.GetHashCode();
                if (this.FreeHandContinuousDrawingMode != null)
                    hashCode = hashCode * 59 + this.FreeHandContinuousDrawingMode.GetHashCode();
                if (this.ShowTextSearchSnapIn != null)
                    hashCode = hashCode * 59 + this.ShowTextSearchSnapIn.GetHashCode();
                if (this.ShowThumbnailsSnapIn != null)
                    hashCode = hashCode * 59 + this.ShowThumbnailsSnapIn.GetHashCode();
                if (this.ShowBookmarksSnapIn != null)
                    hashCode = hashCode * 59 + this.ShowBookmarksSnapIn.GetHashCode();
                if (this.ShowAnnotationsSnapIn != null)
                    hashCode = hashCode * 59 + this.ShowAnnotationsSnapIn.GetHashCode();
                if (this.ShowAnnotationsCommentsSnapIn != null)
                    hashCode = hashCode * 59 + this.ShowAnnotationsCommentsSnapIn.GetHashCode();
                if (this.ThumbnailWidth != null)
                    hashCode = hashCode * 59 + this.ThumbnailWidth.GetHashCode();
                if (this.ThumbnailHeight != null)
                    hashCode = hashCode * 59 + this.ThumbnailHeight.GetHashCode();
                if (this.SnapInPanelDefaultWidth != null)
                    hashCode = hashCode * 59 + this.SnapInPanelDefaultWidth.GetHashCode();
                if (this.CollapsedSnapIn != null)
                    hashCode = hashCode * 59 + this.CollapsedSnapIn.GetHashCode();
                if (this.CollapseSnapinOnDocumentClosed != null)
                    hashCode = hashCode * 59 + this.CollapseSnapinOnDocumentClosed.GetHashCode();
                if (this.ShowSnapInCollapseButton != null)
                    hashCode = hashCode * 59 + this.ShowSnapInCollapseButton.GetHashCode();
                if (this.ShowSnapInPanelHeader != null)
                    hashCode = hashCode * 59 + this.ShowSnapInPanelHeader.GetHashCode();
                if (this.ShowSnapInButtonStrip != null)
                    hashCode = hashCode * 59 + this.ShowSnapInButtonStrip.GetHashCode();
                if (this.ShowToolbar != null)
                    hashCode = hashCode * 59 + this.ShowToolbar.GetHashCode();
                if (this.ToolbarStyle != null)
                    hashCode = hashCode * 59 + this.ToolbarStyle.GetHashCode();
                if (this.ToolbarButtonsSpacing != null)
                    hashCode = hashCode * 59 + this.ToolbarButtonsSpacing.GetHashCode();
                if (this.ToolbarHeight != null)
                    hashCode = hashCode * 59 + this.ToolbarHeight.GetHashCode();
                if (this.StrokeColor != null)
                    hashCode = hashCode * 59 + this.StrokeColor.GetHashCode();
                if (this.MiscBorderColor != null)
                    hashCode = hashCode * 59 + this.MiscBorderColor.GetHashCode();
                if (this.HeaderColor != null)
                    hashCode = hashCode * 59 + this.HeaderColor.GetHashCode();
                if (this.PanelBackColor != null)
                    hashCode = hashCode * 59 + this.PanelBackColor.GetHashCode();
                if (this.ViewerBackColor != null)
                    hashCode = hashCode * 59 + this.ViewerBackColor.GetHashCode();
                if (this.ActiveSelectedColor != null)
                    hashCode = hashCode * 59 + this.ActiveSelectedColor.GetHashCode();
                if (this.ToolbarBackColor != null)
                    hashCode = hashCode * 59 + this.ToolbarBackColor.GetHashCode();
                if (this.CustomNotificationIconError != null)
                    hashCode = hashCode * 59 + this.CustomNotificationIconError.GetHashCode();
                if (this.CustomNotificationIconQuestion != null)
                    hashCode = hashCode * 59 + this.CustomNotificationIconQuestion.GetHashCode();
                if (this.CustomNotificationIconWarning != null)
                    hashCode = hashCode * 59 + this.CustomNotificationIconWarning.GetHashCode();
                if (this.CustomNotificationIconInfo != null)
                    hashCode = hashCode * 59 + this.CustomNotificationIconInfo.GetHashCode();
                if (this.CustomNotificationIconOk != null)
                    hashCode = hashCode * 59 + this.CustomNotificationIconOk.GetHashCode();
                if (this.MaxUploadSize != null)
                    hashCode = hashCode * 59 + this.MaxUploadSize.GetHashCode();
                if (this.MaxDownloadSize != null)
                    hashCode = hashCode * 59 + this.MaxDownloadSize.GetHashCode();
                if (this.MaxPages != null)
                    hashCode = hashCode * 59 + this.MaxPages.GetHashCode();
                if (this.AllowedExportFormats != null)
                    hashCode = hashCode * 59 + this.AllowedExportFormats.GetHashCode();
                if (this.DisableAnnotationDrawingModePanel != null)
                    hashCode = hashCode * 59 + this.DisableAnnotationDrawingModePanel.GetHashCode();
                if (this.PrintQuality != null)
                    hashCode = hashCode * 59 + this.PrintQuality.GetHashCode();
                if (this.FileHostingURI != null)
                    hashCode = hashCode * 59 + this.FileHostingURI.GetHashCode();
                if (this.DocumentURI != null)
                    hashCode = hashCode * 59 + this.DocumentURI.GetHashCode();
                if (this.DocumentFileName != null)
                    hashCode = hashCode * 59 + this.DocumentFileName.GetHashCode();
                if (this.DisableDownloadProgress != null)
                    hashCode = hashCode * 59 + this.DisableDownloadProgress.GetHashCode();
                if (this.EnableDocumentsDrop != null)
                    hashCode = hashCode * 59 + this.EnableDocumentsDrop.GetHashCode();
                if (this.CustomHeaders != null)
                    hashCode = hashCode * 59 + this.CustomHeaders.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

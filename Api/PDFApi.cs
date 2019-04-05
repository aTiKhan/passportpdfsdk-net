/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PassportPDF.Client;
using PassportPDF.Model;

namespace PassportPDF.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPDFApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Annotates a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>PDFAnnotateResponse</returns>
        PDFAnnotateResponse Annotate (PDFAnnotateParameters annotateParameters);

        /// <summary>
        /// Annotates a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFAnnotateResponse</returns>
        ApiResponse<PDFAnnotateResponse> AnnotateWithHttpInfo (PDFAnnotateParameters annotateParameters);
        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>PDFAutoDeskewResponse</returns>
        PDFAutoDeskewResponse AutoDeskew (PDFAutoDeskewParameters autoDeskewParameters);

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFAutoDeskewResponse</returns>
        ApiResponse<PDFAutoDeskewResponse> AutoDeskewWithHttpInfo (PDFAutoDeskewParameters autoDeskewParameters);
        /// <summary>
        /// Clears a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFClearPageResponse</returns>
        PDFClearPageResponse ClearPage (PDFClearPageParameters clearPageParameters);

        /// <summary>
        /// Clears a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFClearPageResponse</returns>
        ApiResponse<PDFClearPageResponse> ClearPageWithHttpInfo (PDFClearPageParameters clearPageParameters);
        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFClonePageResponse</returns>
        PDFClonePageResponse ClonePage (PDFClonePageParameters clonePageParameters = null);

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFClonePageResponse</returns>
        ApiResponse<PDFClonePageResponse> ClonePageWithHttpInfo (PDFClonePageParameters clonePageParameters = null);
        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PDFCloseDocumentResponse</returns>
        PDFCloseDocumentResponse ClosePDF (PDFCloseDocumentParameters closeDocumentParameters);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFCloseDocumentResponse</returns>
        ApiResponse<PDFCloseDocumentResponse> ClosePDFWithHttpInfo (PDFCloseDocumentParameters closeDocumentParameters);
        /// <summary>
        /// Deletes a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDeletePageResponse</returns>
        PDFDeletePageResponse DeletePage (PDFDeletePageParameters deletePageParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDeletePageResponse</returns>
        ApiResponse<PDFDeletePageResponse> DeletePageWithHttpInfo (PDFDeletePageParameters deletePageParameters);
        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDetectPageOrientationResponse</returns>
        PDFDetectPageOrientationResponse DetectPageOrientation (PDFDetectPageOrientationParameters detectPageOrientationParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDetectPageOrientationResponse</returns>
        ApiResponse<PDFDetectPageOrientationResponse> DetectPageOrientationWithHttpInfo (PDFDetectPageOrientationParameters detectPageOrientationParameters);
        /// <summary>
        /// Signs a previously uploaded document digitally.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDigiSignResponse</returns>
        PDFDigiSignResponse DigiSign (PDFDigiSignParameters digiSignParameters);

        /// <summary>
        /// Signs a previously uploaded document digitally.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDigiSignResponse</returns>
        ApiResponse<PDFDigiSignResponse> DigiSignWithHttpInfo (PDFDigiSignParameters digiSignParameters);
        /// <summary>
        /// Draws an image on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDrawImageResponse</returns>
        PDFDrawImageResponse DrawImage (PDFDrawImageParameters drawImageParameters);

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDrawImageResponse</returns>
        ApiResponse<PDFDrawImageResponse> DrawImageWithHttpInfo (PDFDrawImageParameters drawImageParameters);
        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFExtractPageResponse</returns>
        PDFExtractPageResponse ExtractPage (PDFExtractPageParameters extractPageParameters);

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFExtractPageResponse</returns>
        ApiResponse<PDFExtractPageResponse> ExtractPageWithHttpInfo (PDFExtractPageParameters extractPageParameters);
        /// <summary>
        /// Extracts text from the document pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFExtractTextResponse</returns>
        PDFExtractTextResponse ExtractText (PDFExtractTextParameters extractTextParameters = null);

        /// <summary>
        /// Extracts text from the document pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFExtractTextResponse</returns>
        ApiResponse<PDFExtractTextResponse> ExtractTextWithHttpInfo (PDFExtractTextParameters extractTextParameters = null);
        /// <summary>
        /// Flattens the formfields of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>PDFFlattenFormFieldsResponse</returns>
        PDFFlattenFormFieldsResponse FlattenFormFields (PDFFlattenFormFieldsParameters flattenFormFieldsParameters);

        /// <summary>
        /// Flattens the formfields of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFFlattenFormFieldsResponse</returns>
        ApiResponse<PDFFlattenFormFieldsResponse> FlattenFormFieldsWithHttpInfo (PDFFlattenFormFieldsParameters flattenFormFieldsParameters);
        /// <summary>
        /// Gets information about a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>PDFGetInfoResponse</returns>
        PDFGetInfoResponse GetInfo (PDFGetInfoParameters getInfoParameters);

        /// <summary>
        /// Gets information about a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFGetInfoResponse</returns>
        ApiResponse<PDFGetInfoResponse> GetInfoWithHttpInfo (PDFGetInfoParameters getInfoParameters);
        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        StringArrayResponse GetPDFImportSupportedFileExtensions ();

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        ApiResponse<StringArrayResponse> GetPDFImportSupportedFileExtensionsWithHttpInfo ();
        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>PDFGetPageThumbnailResponse</returns>
        PDFGetPageThumbnailResponse GetPageThumbnail (PDFGetPageThumbnailParameters getPageThumbnailParameters);

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFGetPageThumbnailResponse</returns>
        ApiResponse<PDFGetPageThumbnailResponse> GetPageThumbnailWithHttpInfo (PDFGetPageThumbnailParameters getPageThumbnailParameters);
        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFInsertImageResponse</returns>
        PDFInsertImageResponse InsertImage (PDFInsertImageParameters insertImageParameters);

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFInsertImageResponse</returns>
        ApiResponse<PDFInsertImageResponse> InsertImageWithHttpInfo (PDFInsertImageParameters insertImageParameters);
        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFInsertNewPageResponse</returns>
        PDFInsertNewPageResponse InsertNewPage (PDFInsertNewPageParameters insertNewPageParameters);

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFInsertNewPageResponse</returns>
        ApiResponse<PDFInsertNewPageResponse> InsertNewPageWithHttpInfo (PDFInsertNewPageParameters insertNewPageParameters);
        /// <summary>
        /// Inserts page number(s) on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFInsertPageNumberResponse</returns>
        PDFInsertPageNumberResponse InsertPageNumber (PDFInsertPageNumberParameters insertPageNumberParameters = null);

        /// <summary>
        /// Inserts page number(s) on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFInsertPageNumberResponse</returns>
        ApiResponse<PDFInsertPageNumberResponse> InsertPageNumberWithHttpInfo (PDFInsertPageNumberParameters insertPageNumberParameters = null);
        /// <summary>
        /// Inserts text on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFInsertTextResponse</returns>
        PDFInsertTextResponse InsertText (PDFInsertTextParameters insertTextParameters = null);

        /// <summary>
        /// Inserts text on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFInsertTextResponse</returns>
        ApiResponse<PDFInsertTextResponse> InsertTextWithHttpInfo (PDFInsertTextParameters insertTextParameters = null);
        /// <summary>
        /// Linearizes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>PDFLinearizeResponse</returns>
        PDFLinearizeResponse Linearize (PDFLinearizeParameters linearizeParameters);

        /// <summary>
        /// Linearizes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFLinearizeResponse</returns>
        ApiResponse<PDFLinearizeResponse> LinearizeWithHttpInfo (PDFLinearizeParameters linearizeParameters);
        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>PDFLoadDocumentResponse</returns>
        PDFLoadDocumentResponse LoadDocumentAsPDF (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters);

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFLoadDocumentResponse</returns>
        ApiResponse<PDFLoadDocumentResponse> LoadDocumentAsPDFWithHttpInfo (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters);
        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>PDFLoadDocumentResponse</returns>
        PDFLoadDocumentResponse LoadDocumentAsPDFMultipart (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null);

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>ApiResponse of PDFLoadDocumentResponse</returns>
        ApiResponse<PDFLoadDocumentResponse> LoadDocumentAsPDFMultipartWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null);
        /// <summary>
        /// Merges several previously uploaded documents into a new PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>PDFMergeResponse</returns>
        PDFMergeResponse Merge (PDFMergeParameters mergeParameters);

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFMergeResponse</returns>
        ApiResponse<PDFMergeResponse> MergeWithHttpInfo (PDFMergeParameters mergeParameters);
        /// <summary>
        /// Moves a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFMovePageResponse</returns>
        PDFMovePageResponse MovePage (PDFMovePageParameters movePageParameters);

        /// <summary>
        /// Moves a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFMovePageResponse</returns>
        ApiResponse<PDFMovePageResponse> MovePageWithHttpInfo (PDFMovePageParameters movePageParameters);
        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>PDFOCRResponse</returns>
        PDFOCRResponse OCR (PDFOCRParameters oCRParameters);

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFOCRResponse</returns>
        ApiResponse<PDFOCRResponse> OCRWithHttpInfo (PDFOCRParameters oCRParameters);
        /// <summary>
        /// Protects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>PDFProtectResponse</returns>
        PDFProtectResponse Protect (PDFProtectParameters protectParameters);

        /// <summary>
        /// Protects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFProtectResponse</returns>
        ApiResponse<PDFProtectResponse> ProtectWithHttpInfo (PDFProtectParameters protectParameters);
        /// <summary>
        /// Reads barcodes from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ReadBarcodesResponse</returns>
        ReadBarcodesResponse ReadBarcodes (PDFReadBarcodesParameters readBarcodeParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ReadBarcodesResponse</returns>
        ApiResponse<ReadBarcodesResponse> ReadBarcodesWithHttpInfo (PDFReadBarcodesParameters readBarcodeParameters);
        /// <summary>
        /// Reduces the size of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>PDFReduceResponse</returns>
        PDFReduceResponse Reduce (PDFReduceParameters reduceParameters);

        /// <summary>
        /// Reduces the size of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFReduceResponse</returns>
        ApiResponse<PDFReduceResponse> ReduceWithHttpInfo (PDFReduceParameters reduceParameters);
        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFRemovePageFormFieldsResponse</returns>
        PDFRemovePageFormFieldsResponse RemovePageFormFields (PDFRemovePageFormFieldsParameters removePageFormFields = null);

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFRemovePageFormFieldsResponse</returns>
        ApiResponse<PDFRemovePageFormFieldsResponse> RemovePageFormFieldsWithHttpInfo (PDFRemovePageFormFieldsParameters removePageFormFields = null);
        /// <summary>
        /// Repairs a previously uploaded PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PDFRepairDocumentResponse</returns>
        PDFRepairDocumentResponse RepairDocument (PDFRepairDocumentParameters repairDocumentParameters);

        /// <summary>
        /// Repairs a previously uploaded PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFRepairDocumentResponse</returns>
        ApiResponse<PDFRepairDocumentResponse> RepairDocumentWithHttpInfo (PDFRepairDocumentParameters repairDocumentParameters);
        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>PDFRotatePageStandardResponse</returns>
        PDFRotatePageStandardResponse RotatePageStandard (PDFRotatePageStandardParameters rotatePageStandardParameters);

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFRotatePageStandardResponse</returns>
        ApiResponse<PDFRotatePageStandardResponse> RotatePageStandardWithHttpInfo (PDFRotatePageStandardParameters rotatePageStandardParameters);
        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsJPEGResponse</returns>
        PDFSaveAsJPEGResponse SaveAsJPEG (PDFSaveAsJPEGParameters saveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsJPEGResponse</returns>
        ApiResponse<PDFSaveAsJPEGResponse> SaveAsJPEGWithHttpInfo (PDFSaveAsJPEGParameters saveAsJPEGParameters);
        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsPNGResponse</returns>
        PDFSaveAsPNGResponse SaveAsPNG (PDFSaveAsPNGParameters saveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsPNGResponse</returns>
        ApiResponse<PDFSaveAsPNGResponse> SaveAsPNGWithHttpInfo (PDFSaveAsPNGParameters saveAsPNGParameters);
        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsTIFFResponse</returns>
        PDFSaveAsTIFFResponse SaveAsTIFF (PDFSaveAsTIFFParameters saveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsTIFFResponse</returns>
        ApiResponse<PDFSaveAsTIFFResponse> SaveAsTIFFWithHttpInfo (PDFSaveAsTIFFParameters saveAsTIFFParameters);
        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsTIFFMultipageResponse</returns>
        PDFSaveAsTIFFMultipageResponse SaveAsTIFFMultipage (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsTIFFMultipageResponse</returns>
        ApiResponse<PDFSaveAsTIFFMultipageResponse> SaveAsTIFFMultipageWithHttpInfo (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);
        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveDocumentResponse</returns>
        PDFSaveDocumentResponse SaveDocument (PDFSaveDocumentParameters saveDocumentParameters);

        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveDocumentResponse</returns>
        ApiResponse<PDFSaveDocumentResponse> SaveDocumentWithHttpInfo (PDFSaveDocumentParameters saveDocumentParameters);
        /// <summary>
        /// Sets information to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSetInfoResponse</returns>
        PDFSetInfoResponse SetInfo (PDFSetInfoParameters setInfoParameters);

        /// <summary>
        /// Sets information to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSetInfoResponse</returns>
        ApiResponse<PDFSetInfoResponse> SetInfoWithHttpInfo (PDFSetInfoParameters setInfoParameters);
        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFSetInitialViewResponse</returns>
        PDFSetInitialViewResponse SetInitialView (PDFSetInitialViewParameters setInitialViewParameters = null);

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFSetInitialViewResponse</returns>
        ApiResponse<PDFSetInitialViewResponse> SetInitialViewWithHttpInfo (PDFSetInitialViewParameters setInitialViewParameters = null);
        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFSetPageBoxResponse</returns>
        PDFSetPageBoxResponse SetPageBox (PDFSetPageBoxParameters setPageBoxParameters = null);

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFSetPageBoxResponse</returns>
        ApiResponse<PDFSetPageBoxResponse> SetPageBoxWithHttpInfo (PDFSetPageBoxParameters setPageBoxParameters = null);
        /// <summary>
        /// Splits a previously uploaded document into new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSplitResponse</returns>
        PDFSplitResponse Split (PDFSplitParameters splitParameters);

        /// <summary>
        /// Splits a previously uploaded document into new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSplitResponse</returns>
        ApiResponse<PDFSplitResponse> SplitWithHttpInfo (PDFSplitParameters splitParameters);
        /// <summary>
        /// Swaps two pages from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSwapPagesResponse</returns>
        PDFSwapPagesResponse SwapPages (PDFSwapPagesParameters swapPagesParameters);

        /// <summary>
        /// Swaps two pages from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSwapPagesResponse</returns>
        ApiResponse<PDFSwapPagesResponse> SwapPagesWithHttpInfo (PDFSwapPagesParameters swapPagesParameters);
        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>PDFUnprotectResponse</returns>
        PDFUnprotectResponse Unprotect (PDFUnprotectParameters unprotectParameters);

        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFUnprotectResponse</returns>
        ApiResponse<PDFUnprotectResponse> UnprotectWithHttpInfo (PDFUnprotectParameters unprotectParameters);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Annotates a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFAnnotateResponse</returns>
        System.Threading.Tasks.Task<PDFAnnotateResponse> AnnotateAsync (PDFAnnotateParameters annotateParameters);

        /// <summary>
        /// Annotates a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFAnnotateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFAnnotateResponse>> AnnotateAsyncWithHttpInfo (PDFAnnotateParameters annotateParameters);
        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFAutoDeskewResponse</returns>
        System.Threading.Tasks.Task<PDFAutoDeskewResponse> AutoDeskewAsync (PDFAutoDeskewParameters autoDeskewParameters);

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFAutoDeskewResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFAutoDeskewResponse>> AutoDeskewAsyncWithHttpInfo (PDFAutoDeskewParameters autoDeskewParameters);
        /// <summary>
        /// Clears a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFClearPageResponse</returns>
        System.Threading.Tasks.Task<PDFClearPageResponse> ClearPageAsync (PDFClearPageParameters clearPageParameters);

        /// <summary>
        /// Clears a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFClearPageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFClearPageResponse>> ClearPageAsyncWithHttpInfo (PDFClearPageParameters clearPageParameters);
        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFClonePageResponse</returns>
        System.Threading.Tasks.Task<PDFClonePageResponse> ClonePageAsync (PDFClonePageParameters clonePageParameters = null);

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFClonePageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFClonePageResponse>> ClonePageAsyncWithHttpInfo (PDFClonePageParameters clonePageParameters = null);
        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFCloseDocumentResponse</returns>
        System.Threading.Tasks.Task<PDFCloseDocumentResponse> ClosePDFAsync (PDFCloseDocumentParameters closeDocumentParameters);

        /// <summary>
        /// Closes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFCloseDocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFCloseDocumentResponse>> ClosePDFAsyncWithHttpInfo (PDFCloseDocumentParameters closeDocumentParameters);
        /// <summary>
        /// Deletes a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDeletePageResponse</returns>
        System.Threading.Tasks.Task<PDFDeletePageResponse> DeletePageAsync (PDFDeletePageParameters deletePageParameters);

        /// <summary>
        /// Deletes a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDeletePageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFDeletePageResponse>> DeletePageAsyncWithHttpInfo (PDFDeletePageParameters deletePageParameters);
        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDetectPageOrientationResponse</returns>
        System.Threading.Tasks.Task<PDFDetectPageOrientationResponse> DetectPageOrientationAsync (PDFDetectPageOrientationParameters detectPageOrientationParameters);

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDetectPageOrientationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFDetectPageOrientationResponse>> DetectPageOrientationAsyncWithHttpInfo (PDFDetectPageOrientationParameters detectPageOrientationParameters);
        /// <summary>
        /// Signs a previously uploaded document digitally.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDigiSignResponse</returns>
        System.Threading.Tasks.Task<PDFDigiSignResponse> DigiSignAsync (PDFDigiSignParameters digiSignParameters);

        /// <summary>
        /// Signs a previously uploaded document digitally.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDigiSignResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFDigiSignResponse>> DigiSignAsyncWithHttpInfo (PDFDigiSignParameters digiSignParameters);
        /// <summary>
        /// Draws an image on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDrawImageResponse</returns>
        System.Threading.Tasks.Task<PDFDrawImageResponse> DrawImageAsync (PDFDrawImageParameters drawImageParameters);

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDrawImageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFDrawImageResponse>> DrawImageAsyncWithHttpInfo (PDFDrawImageParameters drawImageParameters);
        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFExtractPageResponse</returns>
        System.Threading.Tasks.Task<PDFExtractPageResponse> ExtractPageAsync (PDFExtractPageParameters extractPageParameters);

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFExtractPageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFExtractPageResponse>> ExtractPageAsyncWithHttpInfo (PDFExtractPageParameters extractPageParameters);
        /// <summary>
        /// Extracts text from the document pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFExtractTextResponse</returns>
        System.Threading.Tasks.Task<PDFExtractTextResponse> ExtractTextAsync (PDFExtractTextParameters extractTextParameters = null);

        /// <summary>
        /// Extracts text from the document pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFExtractTextResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFExtractTextResponse>> ExtractTextAsyncWithHttpInfo (PDFExtractTextParameters extractTextParameters = null);
        /// <summary>
        /// Flattens the formfields of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFFlattenFormFieldsResponse</returns>
        System.Threading.Tasks.Task<PDFFlattenFormFieldsResponse> FlattenFormFieldsAsync (PDFFlattenFormFieldsParameters flattenFormFieldsParameters);

        /// <summary>
        /// Flattens the formfields of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFFlattenFormFieldsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFFlattenFormFieldsResponse>> FlattenFormFieldsAsyncWithHttpInfo (PDFFlattenFormFieldsParameters flattenFormFieldsParameters);
        /// <summary>
        /// Gets information about a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFGetInfoResponse</returns>
        System.Threading.Tasks.Task<PDFGetInfoResponse> GetInfoAsync (PDFGetInfoParameters getInfoParameters);

        /// <summary>
        /// Gets information about a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFGetInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFGetInfoResponse>> GetInfoAsyncWithHttpInfo (PDFGetInfoParameters getInfoParameters);
        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        System.Threading.Tasks.Task<StringArrayResponse> GetPDFImportSupportedFileExtensionsAsync ();

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> GetPDFImportSupportedFileExtensionsAsyncWithHttpInfo ();
        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFGetPageThumbnailResponse</returns>
        System.Threading.Tasks.Task<PDFGetPageThumbnailResponse> GetPageThumbnailAsync (PDFGetPageThumbnailParameters getPageThumbnailParameters);

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFGetPageThumbnailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFGetPageThumbnailResponse>> GetPageThumbnailAsyncWithHttpInfo (PDFGetPageThumbnailParameters getPageThumbnailParameters);
        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFInsertImageResponse</returns>
        System.Threading.Tasks.Task<PDFInsertImageResponse> InsertImageAsync (PDFInsertImageParameters insertImageParameters);

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFInsertImageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFInsertImageResponse>> InsertImageAsyncWithHttpInfo (PDFInsertImageParameters insertImageParameters);
        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFInsertNewPageResponse</returns>
        System.Threading.Tasks.Task<PDFInsertNewPageResponse> InsertNewPageAsync (PDFInsertNewPageParameters insertNewPageParameters);

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFInsertNewPageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFInsertNewPageResponse>> InsertNewPageAsyncWithHttpInfo (PDFInsertNewPageParameters insertNewPageParameters);
        /// <summary>
        /// Inserts page number(s) on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFInsertPageNumberResponse</returns>
        System.Threading.Tasks.Task<PDFInsertPageNumberResponse> InsertPageNumberAsync (PDFInsertPageNumberParameters insertPageNumberParameters = null);

        /// <summary>
        /// Inserts page number(s) on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFInsertPageNumberResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFInsertPageNumberResponse>> InsertPageNumberAsyncWithHttpInfo (PDFInsertPageNumberParameters insertPageNumberParameters = null);
        /// <summary>
        /// Inserts text on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFInsertTextResponse</returns>
        System.Threading.Tasks.Task<PDFInsertTextResponse> InsertTextAsync (PDFInsertTextParameters insertTextParameters = null);

        /// <summary>
        /// Inserts text on a document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFInsertTextResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFInsertTextResponse>> InsertTextAsyncWithHttpInfo (PDFInsertTextParameters insertTextParameters = null);
        /// <summary>
        /// Linearizes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFLinearizeResponse</returns>
        System.Threading.Tasks.Task<PDFLinearizeResponse> LinearizeAsync (PDFLinearizeParameters linearizeParameters);

        /// <summary>
        /// Linearizes a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFLinearizeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFLinearizeResponse>> LinearizeAsyncWithHttpInfo (PDFLinearizeParameters linearizeParameters);
        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFLoadDocumentResponse</returns>
        System.Threading.Tasks.Task<PDFLoadDocumentResponse> LoadDocumentAsPDFAsync (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters);

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFLoadDocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFLoadDocumentResponse>> LoadDocumentAsPDFAsyncWithHttpInfo (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters);
        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>Task of PDFLoadDocumentResponse</returns>
        System.Threading.Tasks.Task<PDFLoadDocumentResponse> LoadDocumentAsPDFMultipartAsync (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null);

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>Task of ApiResponse (PDFLoadDocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFLoadDocumentResponse>> LoadDocumentAsPDFMultipartAsyncWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null);
        /// <summary>
        /// Merges several previously uploaded documents into a new PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFMergeResponse</returns>
        System.Threading.Tasks.Task<PDFMergeResponse> MergeAsync (PDFMergeParameters mergeParameters);

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFMergeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFMergeResponse>> MergeAsyncWithHttpInfo (PDFMergeParameters mergeParameters);
        /// <summary>
        /// Moves a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFMovePageResponse</returns>
        System.Threading.Tasks.Task<PDFMovePageResponse> MovePageAsync (PDFMovePageParameters movePageParameters);

        /// <summary>
        /// Moves a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFMovePageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFMovePageResponse>> MovePageAsyncWithHttpInfo (PDFMovePageParameters movePageParameters);
        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFOCRResponse</returns>
        System.Threading.Tasks.Task<PDFOCRResponse> OCRAsync (PDFOCRParameters oCRParameters);

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFOCRResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFOCRResponse>> OCRAsyncWithHttpInfo (PDFOCRParameters oCRParameters);
        /// <summary>
        /// Protects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFProtectResponse</returns>
        System.Threading.Tasks.Task<PDFProtectResponse> ProtectAsync (PDFProtectParameters protectParameters);

        /// <summary>
        /// Protects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFProtectResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFProtectResponse>> ProtectAsyncWithHttpInfo (PDFProtectParameters protectParameters);
        /// <summary>
        /// Reads barcodes from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ReadBarcodesResponse</returns>
        System.Threading.Tasks.Task<ReadBarcodesResponse> ReadBarcodesAsync (PDFReadBarcodesParameters readBarcodeParameters);

        /// <summary>
        /// Reads barcodes from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ReadBarcodesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReadBarcodesResponse>> ReadBarcodesAsyncWithHttpInfo (PDFReadBarcodesParameters readBarcodeParameters);
        /// <summary>
        /// Reduces the size of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFReduceResponse</returns>
        System.Threading.Tasks.Task<PDFReduceResponse> ReduceAsync (PDFReduceParameters reduceParameters);

        /// <summary>
        /// Reduces the size of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFReduceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFReduceResponse>> ReduceAsyncWithHttpInfo (PDFReduceParameters reduceParameters);
        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFRemovePageFormFieldsResponse</returns>
        System.Threading.Tasks.Task<PDFRemovePageFormFieldsResponse> RemovePageFormFieldsAsync (PDFRemovePageFormFieldsParameters removePageFormFields = null);

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFRemovePageFormFieldsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFRemovePageFormFieldsResponse>> RemovePageFormFieldsAsyncWithHttpInfo (PDFRemovePageFormFieldsParameters removePageFormFields = null);
        /// <summary>
        /// Repairs a previously uploaded PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFRepairDocumentResponse</returns>
        System.Threading.Tasks.Task<PDFRepairDocumentResponse> RepairDocumentAsync (PDFRepairDocumentParameters repairDocumentParameters);

        /// <summary>
        /// Repairs a previously uploaded PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFRepairDocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFRepairDocumentResponse>> RepairDocumentAsyncWithHttpInfo (PDFRepairDocumentParameters repairDocumentParameters);
        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFRotatePageStandardResponse</returns>
        System.Threading.Tasks.Task<PDFRotatePageStandardResponse> RotatePageStandardAsync (PDFRotatePageStandardParameters rotatePageStandardParameters);

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFRotatePageStandardResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFRotatePageStandardResponse>> RotatePageStandardAsyncWithHttpInfo (PDFRotatePageStandardParameters rotatePageStandardParameters);
        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsJPEGResponse</returns>
        System.Threading.Tasks.Task<PDFSaveAsJPEGResponse> SaveAsJPEGAsync (PDFSaveAsJPEGParameters saveAsJPEGParameters);

        /// <summary>
        /// Saves a previously uploaded document as JPEG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsJPEGResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSaveAsJPEGResponse>> SaveAsJPEGAsyncWithHttpInfo (PDFSaveAsJPEGParameters saveAsJPEGParameters);
        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsPNGResponse</returns>
        System.Threading.Tasks.Task<PDFSaveAsPNGResponse> SaveAsPNGAsync (PDFSaveAsPNGParameters saveAsPNGParameters);

        /// <summary>
        /// Saves a previously uploaded document as PNG.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsPNGResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSaveAsPNGResponse>> SaveAsPNGAsyncWithHttpInfo (PDFSaveAsPNGParameters saveAsPNGParameters);
        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsTIFFResponse</returns>
        System.Threading.Tasks.Task<PDFSaveAsTIFFResponse> SaveAsTIFFAsync (PDFSaveAsTIFFParameters saveAsTIFFParameters);

        /// <summary>
        /// Saves a previously uploaded document as TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsTIFFResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSaveAsTIFFResponse>> SaveAsTIFFAsyncWithHttpInfo (PDFSaveAsTIFFParameters saveAsTIFFParameters);
        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsTIFFMultipageResponse</returns>
        System.Threading.Tasks.Task<PDFSaveAsTIFFMultipageResponse> SaveAsTIFFMultipageAsync (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsTIFFMultipageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSaveAsTIFFMultipageResponse>> SaveAsTIFFMultipageAsyncWithHttpInfo (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters);
        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveDocumentResponse</returns>
        System.Threading.Tasks.Task<PDFSaveDocumentResponse> SaveDocumentAsync (PDFSaveDocumentParameters saveDocumentParameters);

        /// <summary>
        /// Saves a previously uploaded document as PDF.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveDocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSaveDocumentResponse>> SaveDocumentAsyncWithHttpInfo (PDFSaveDocumentParameters saveDocumentParameters);
        /// <summary>
        /// Sets information to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSetInfoResponse</returns>
        System.Threading.Tasks.Task<PDFSetInfoResponse> SetInfoAsync (PDFSetInfoParameters setInfoParameters);

        /// <summary>
        /// Sets information to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSetInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSetInfoResponse>> SetInfoAsyncWithHttpInfo (PDFSetInfoParameters setInfoParameters);
        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFSetInitialViewResponse</returns>
        System.Threading.Tasks.Task<PDFSetInitialViewResponse> SetInitialViewAsync (PDFSetInitialViewParameters setInitialViewParameters = null);

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFSetInitialViewResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSetInitialViewResponse>> SetInitialViewAsyncWithHttpInfo (PDFSetInitialViewParameters setInitialViewParameters = null);
        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFSetPageBoxResponse</returns>
        System.Threading.Tasks.Task<PDFSetPageBoxResponse> SetPageBoxAsync (PDFSetPageBoxParameters setPageBoxParameters = null);

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFSetPageBoxResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSetPageBoxResponse>> SetPageBoxAsyncWithHttpInfo (PDFSetPageBoxParameters setPageBoxParameters = null);
        /// <summary>
        /// Splits a previously uploaded document into new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSplitResponse</returns>
        System.Threading.Tasks.Task<PDFSplitResponse> SplitAsync (PDFSplitParameters splitParameters);

        /// <summary>
        /// Splits a previously uploaded document into new ones.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSplitResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSplitResponse>> SplitAsyncWithHttpInfo (PDFSplitParameters splitParameters);
        /// <summary>
        /// Swaps two pages from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSwapPagesResponse</returns>
        System.Threading.Tasks.Task<PDFSwapPagesResponse> SwapPagesAsync (PDFSwapPagesParameters swapPagesParameters);

        /// <summary>
        /// Swaps two pages from a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSwapPagesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFSwapPagesResponse>> SwapPagesAsyncWithHttpInfo (PDFSwapPagesParameters swapPagesParameters);
        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFUnprotectResponse</returns>
        System.Threading.Tasks.Task<PDFUnprotectResponse> UnprotectAsync (PDFUnprotectParameters unprotectParameters);

        /// <summary>
        /// Unprotects a previously uploaded document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFUnprotectResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PDFUnprotectResponse>> UnprotectAsyncWithHttpInfo (PDFUnprotectParameters unprotectParameters);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PDFApi : IPDFApi
    {
        private PassportPDF.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PDFApi(String basePath)
        {
            this.Configuration = new PassportPDF.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFApi"/> class
        /// </summary>
        /// <returns></returns>
        public PDFApi()
        {
            this.Configuration = PassportPDF.Client.Configuration.Default;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PDFApi(PassportPDF.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PassportPDF.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PassportPDF.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PassportPDF.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PassportPDF.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Annotates a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>PDFAnnotateResponse</returns>
        public PDFAnnotateResponse Annotate (PDFAnnotateParameters annotateParameters)
        {
             ApiResponse<PDFAnnotateResponse> localVarResponse = AnnotateWithHttpInfo(annotateParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Annotates a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFAnnotateResponse</returns>
        public ApiResponse< PDFAnnotateResponse > AnnotateWithHttpInfo (PDFAnnotateParameters annotateParameters)
        {
            // verify the required parameter 'annotateParameters' is set
            if (annotateParameters == null)
                throw new ApiException(400, "Missing required parameter 'annotateParameters' when calling PDFApi->Annotate");

            var localVarPath = "/api/pdf/Annotate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (annotateParameters != null && annotateParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(annotateParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = annotateParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Annotate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFAnnotateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFAnnotateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFAnnotateResponse)));
        }

        /// <summary>
        /// Annotates a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFAnnotateResponse</returns>
        public async System.Threading.Tasks.Task<PDFAnnotateResponse> AnnotateAsync (PDFAnnotateParameters annotateParameters)
        {
             ApiResponse<PDFAnnotateResponse> localVarResponse = await AnnotateAsyncWithHttpInfo(annotateParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Annotates a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="annotateParameters">A PDFAnnotateParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFAnnotateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFAnnotateResponse>> AnnotateAsyncWithHttpInfo (PDFAnnotateParameters annotateParameters)
        {
            // verify the required parameter 'annotateParameters' is set
            if (annotateParameters == null)
                throw new ApiException(400, "Missing required parameter 'annotateParameters' when calling PDFApi->Annotate");

            var localVarPath = "/api/pdf/Annotate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (annotateParameters != null && annotateParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(annotateParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = annotateParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Annotate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFAnnotateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFAnnotateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFAnnotateResponse)));
        }

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>PDFAutoDeskewResponse</returns>
        public PDFAutoDeskewResponse AutoDeskew (PDFAutoDeskewParameters autoDeskewParameters)
        {
             ApiResponse<PDFAutoDeskewResponse> localVarResponse = AutoDeskewWithHttpInfo(autoDeskewParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFAutoDeskewResponse</returns>
        public ApiResponse< PDFAutoDeskewResponse > AutoDeskewWithHttpInfo (PDFAutoDeskewParameters autoDeskewParameters)
        {
            // verify the required parameter 'autoDeskewParameters' is set
            if (autoDeskewParameters == null)
                throw new ApiException(400, "Missing required parameter 'autoDeskewParameters' when calling PDFApi->AutoDeskew");

            var localVarPath = "/api/pdf/AutoDeskew";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (autoDeskewParameters != null && autoDeskewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(autoDeskewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autoDeskewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AutoDeskew", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFAutoDeskewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFAutoDeskewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFAutoDeskewResponse)));
        }

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFAutoDeskewResponse</returns>
        public async System.Threading.Tasks.Task<PDFAutoDeskewResponse> AutoDeskewAsync (PDFAutoDeskewParameters autoDeskewParameters)
        {
             ApiResponse<PDFAutoDeskewResponse> localVarResponse = await AutoDeskewAsyncWithHttpInfo(autoDeskewParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs auto deskew on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="autoDeskewParameters">A PDFAutoDeskewParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFAutoDeskewResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFAutoDeskewResponse>> AutoDeskewAsyncWithHttpInfo (PDFAutoDeskewParameters autoDeskewParameters)
        {
            // verify the required parameter 'autoDeskewParameters' is set
            if (autoDeskewParameters == null)
                throw new ApiException(400, "Missing required parameter 'autoDeskewParameters' when calling PDFApi->AutoDeskew");

            var localVarPath = "/api/pdf/AutoDeskew";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (autoDeskewParameters != null && autoDeskewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(autoDeskewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = autoDeskewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AutoDeskew", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFAutoDeskewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFAutoDeskewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFAutoDeskewResponse)));
        }

        /// <summary>
        /// Clears a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFClearPageResponse</returns>
        public PDFClearPageResponse ClearPage (PDFClearPageParameters clearPageParameters)
        {
             ApiResponse<PDFClearPageResponse> localVarResponse = ClearPageWithHttpInfo(clearPageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Clears a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFClearPageResponse</returns>
        public ApiResponse< PDFClearPageResponse > ClearPageWithHttpInfo (PDFClearPageParameters clearPageParameters)
        {
            // verify the required parameter 'clearPageParameters' is set
            if (clearPageParameters == null)
                throw new ApiException(400, "Missing required parameter 'clearPageParameters' when calling PDFApi->ClearPage");

            var localVarPath = "/api/pdf/ClearPage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clearPageParameters != null && clearPageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(clearPageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = clearPageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClearPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFClearPageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFClearPageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFClearPageResponse)));
        }

        /// <summary>
        /// Clears a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFClearPageResponse</returns>
        public async System.Threading.Tasks.Task<PDFClearPageResponse> ClearPageAsync (PDFClearPageParameters clearPageParameters)
        {
             ApiResponse<PDFClearPageResponse> localVarResponse = await ClearPageAsyncWithHttpInfo(clearPageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Clears a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clearPageParameters">A PDFClearPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFClearPageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFClearPageResponse>> ClearPageAsyncWithHttpInfo (PDFClearPageParameters clearPageParameters)
        {
            // verify the required parameter 'clearPageParameters' is set
            if (clearPageParameters == null)
                throw new ApiException(400, "Missing required parameter 'clearPageParameters' when calling PDFApi->ClearPage");

            var localVarPath = "/api/pdf/ClearPage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clearPageParameters != null && clearPageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(clearPageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = clearPageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClearPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFClearPageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFClearPageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFClearPageResponse)));
        }

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFClonePageResponse</returns>
        public PDFClonePageResponse ClonePage (PDFClonePageParameters clonePageParameters = null)
        {
             ApiResponse<PDFClonePageResponse> localVarResponse = ClonePageWithHttpInfo(clonePageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFClonePageResponse</returns>
        public ApiResponse< PDFClonePageResponse > ClonePageWithHttpInfo (PDFClonePageParameters clonePageParameters = null)
        {

            var localVarPath = "/api/pdf/ClonePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clonePageParameters != null && clonePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(clonePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = clonePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClonePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFClonePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFClonePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFClonePageResponse)));
        }

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFClonePageResponse</returns>
        public async System.Threading.Tasks.Task<PDFClonePageResponse> ClonePageAsync (PDFClonePageParameters clonePageParameters = null)
        {
             ApiResponse<PDFClonePageResponse> localVarResponse = await ClonePageAsyncWithHttpInfo(clonePageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Clones specific pages from a previously uploaded document to another previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clonePageParameters">A PDFClonePageParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFClonePageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFClonePageResponse>> ClonePageAsyncWithHttpInfo (PDFClonePageParameters clonePageParameters = null)
        {

            var localVarPath = "/api/pdf/ClonePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clonePageParameters != null && clonePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(clonePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = clonePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClonePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFClonePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFClonePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFClonePageResponse)));
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PDFCloseDocumentResponse</returns>
        public PDFCloseDocumentResponse ClosePDF (PDFCloseDocumentParameters closeDocumentParameters)
        {
             ApiResponse<PDFCloseDocumentResponse> localVarResponse = ClosePDFWithHttpInfo(closeDocumentParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFCloseDocumentResponse</returns>
        public ApiResponse< PDFCloseDocumentResponse > ClosePDFWithHttpInfo (PDFCloseDocumentParameters closeDocumentParameters)
        {
            // verify the required parameter 'closeDocumentParameters' is set
            if (closeDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'closeDocumentParameters' when calling PDFApi->ClosePDF");

            var localVarPath = "/api/pdf/ClosePDF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (closeDocumentParameters != null && closeDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(closeDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = closeDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClosePDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFCloseDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFCloseDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFCloseDocumentResponse)));
        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFCloseDocumentResponse</returns>
        public async System.Threading.Tasks.Task<PDFCloseDocumentResponse> ClosePDFAsync (PDFCloseDocumentParameters closeDocumentParameters)
        {
             ApiResponse<PDFCloseDocumentResponse> localVarResponse = await ClosePDFAsyncWithHttpInfo(closeDocumentParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Closes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="closeDocumentParameters">A PDFCloseDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFCloseDocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFCloseDocumentResponse>> ClosePDFAsyncWithHttpInfo (PDFCloseDocumentParameters closeDocumentParameters)
        {
            // verify the required parameter 'closeDocumentParameters' is set
            if (closeDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'closeDocumentParameters' when calling PDFApi->ClosePDF");

            var localVarPath = "/api/pdf/ClosePDF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (closeDocumentParameters != null && closeDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(closeDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = closeDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClosePDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFCloseDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFCloseDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFCloseDocumentResponse)));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDeletePageResponse</returns>
        public PDFDeletePageResponse DeletePage (PDFDeletePageParameters deletePageParameters)
        {
             ApiResponse<PDFDeletePageResponse> localVarResponse = DeletePageWithHttpInfo(deletePageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDeletePageResponse</returns>
        public ApiResponse< PDFDeletePageResponse > DeletePageWithHttpInfo (PDFDeletePageParameters deletePageParameters)
        {
            // verify the required parameter 'deletePageParameters' is set
            if (deletePageParameters == null)
                throw new ApiException(400, "Missing required parameter 'deletePageParameters' when calling PDFApi->DeletePage");

            var localVarPath = "/api/pdf/DeletePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (deletePageParameters != null && deletePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(deletePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deletePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDeletePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDeletePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDeletePageResponse)));
        }

        /// <summary>
        /// Deletes a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDeletePageResponse</returns>
        public async System.Threading.Tasks.Task<PDFDeletePageResponse> DeletePageAsync (PDFDeletePageParameters deletePageParameters)
        {
             ApiResponse<PDFDeletePageResponse> localVarResponse = await DeletePageAsyncWithHttpInfo(deletePageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletes a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deletePageParameters">A PDFDeletePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDeletePageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFDeletePageResponse>> DeletePageAsyncWithHttpInfo (PDFDeletePageParameters deletePageParameters)
        {
            // verify the required parameter 'deletePageParameters' is set
            if (deletePageParameters == null)
                throw new ApiException(400, "Missing required parameter 'deletePageParameters' when calling PDFApi->DeletePage");

            var localVarPath = "/api/pdf/DeletePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (deletePageParameters != null && deletePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(deletePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deletePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDeletePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDeletePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDeletePageResponse)));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDetectPageOrientationResponse</returns>
        public PDFDetectPageOrientationResponse DetectPageOrientation (PDFDetectPageOrientationParameters detectPageOrientationParameters)
        {
             ApiResponse<PDFDetectPageOrientationResponse> localVarResponse = DetectPageOrientationWithHttpInfo(detectPageOrientationParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDetectPageOrientationResponse</returns>
        public ApiResponse< PDFDetectPageOrientationResponse > DetectPageOrientationWithHttpInfo (PDFDetectPageOrientationParameters detectPageOrientationParameters)
        {
            // verify the required parameter 'detectPageOrientationParameters' is set
            if (detectPageOrientationParameters == null)
                throw new ApiException(400, "Missing required parameter 'detectPageOrientationParameters' when calling PDFApi->DetectPageOrientation");

            var localVarPath = "/api/pdf/DetectPageOrientation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (detectPageOrientationParameters != null && detectPageOrientationParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectPageOrientationParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectPageOrientationParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DetectPageOrientation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDetectPageOrientationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDetectPageOrientationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDetectPageOrientationResponse)));
        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDetectPageOrientationResponse</returns>
        public async System.Threading.Tasks.Task<PDFDetectPageOrientationResponse> DetectPageOrientationAsync (PDFDetectPageOrientationParameters detectPageOrientationParameters)
        {
             ApiResponse<PDFDetectPageOrientationResponse> localVarResponse = await DetectPageOrientationAsyncWithHttpInfo(detectPageOrientationParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detects the orientation of the page(s) of a previously uploaded document and offers to automatically rotate them. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="detectPageOrientationParameters">A PDFDetectPageOrientationParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDetectPageOrientationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFDetectPageOrientationResponse>> DetectPageOrientationAsyncWithHttpInfo (PDFDetectPageOrientationParameters detectPageOrientationParameters)
        {
            // verify the required parameter 'detectPageOrientationParameters' is set
            if (detectPageOrientationParameters == null)
                throw new ApiException(400, "Missing required parameter 'detectPageOrientationParameters' when calling PDFApi->DetectPageOrientation");

            var localVarPath = "/api/pdf/DetectPageOrientation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (detectPageOrientationParameters != null && detectPageOrientationParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detectPageOrientationParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detectPageOrientationParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DetectPageOrientation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDetectPageOrientationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDetectPageOrientationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDetectPageOrientationResponse)));
        }

        /// <summary>
        /// Signs a previously uploaded document digitally. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDigiSignResponse</returns>
        public PDFDigiSignResponse DigiSign (PDFDigiSignParameters digiSignParameters)
        {
             ApiResponse<PDFDigiSignResponse> localVarResponse = DigiSignWithHttpInfo(digiSignParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Signs a previously uploaded document digitally. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDigiSignResponse</returns>
        public ApiResponse< PDFDigiSignResponse > DigiSignWithHttpInfo (PDFDigiSignParameters digiSignParameters)
        {
            // verify the required parameter 'digiSignParameters' is set
            if (digiSignParameters == null)
                throw new ApiException(400, "Missing required parameter 'digiSignParameters' when calling PDFApi->DigiSign");

            var localVarPath = "/api/pdf/DigiSign";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (digiSignParameters != null && digiSignParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(digiSignParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = digiSignParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DigiSign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDigiSignResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDigiSignResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDigiSignResponse)));
        }

        /// <summary>
        /// Signs a previously uploaded document digitally. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDigiSignResponse</returns>
        public async System.Threading.Tasks.Task<PDFDigiSignResponse> DigiSignAsync (PDFDigiSignParameters digiSignParameters)
        {
             ApiResponse<PDFDigiSignResponse> localVarResponse = await DigiSignAsyncWithHttpInfo(digiSignParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Signs a previously uploaded document digitally. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digiSignParameters">A PDFDigiSignParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDigiSignResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFDigiSignResponse>> DigiSignAsyncWithHttpInfo (PDFDigiSignParameters digiSignParameters)
        {
            // verify the required parameter 'digiSignParameters' is set
            if (digiSignParameters == null)
                throw new ApiException(400, "Missing required parameter 'digiSignParameters' when calling PDFApi->DigiSign");

            var localVarPath = "/api/pdf/DigiSign";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (digiSignParameters != null && digiSignParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(digiSignParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = digiSignParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DigiSign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDigiSignResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDigiSignResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDigiSignResponse)));
        }

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFDrawImageResponse</returns>
        public PDFDrawImageResponse DrawImage (PDFDrawImageParameters drawImageParameters)
        {
             ApiResponse<PDFDrawImageResponse> localVarResponse = DrawImageWithHttpInfo(drawImageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFDrawImageResponse</returns>
        public ApiResponse< PDFDrawImageResponse > DrawImageWithHttpInfo (PDFDrawImageParameters drawImageParameters)
        {
            // verify the required parameter 'drawImageParameters' is set
            if (drawImageParameters == null)
                throw new ApiException(400, "Missing required parameter 'drawImageParameters' when calling PDFApi->DrawImage");

            var localVarPath = "/api/pdf/DrawImage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (drawImageParameters != null && drawImageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(drawImageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = drawImageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DrawImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDrawImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDrawImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDrawImageResponse)));
        }

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFDrawImageResponse</returns>
        public async System.Threading.Tasks.Task<PDFDrawImageResponse> DrawImageAsync (PDFDrawImageParameters drawImageParameters)
        {
             ApiResponse<PDFDrawImageResponse> localVarResponse = await DrawImageAsyncWithHttpInfo(drawImageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Draws an image on a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="drawImageParameters">A PDFDrawImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFDrawImageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFDrawImageResponse>> DrawImageAsyncWithHttpInfo (PDFDrawImageParameters drawImageParameters)
        {
            // verify the required parameter 'drawImageParameters' is set
            if (drawImageParameters == null)
                throw new ApiException(400, "Missing required parameter 'drawImageParameters' when calling PDFApi->DrawImage");

            var localVarPath = "/api/pdf/DrawImage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (drawImageParameters != null && drawImageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(drawImageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = drawImageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DrawImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFDrawImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFDrawImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFDrawImageResponse)));
        }

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFExtractPageResponse</returns>
        public PDFExtractPageResponse ExtractPage (PDFExtractPageParameters extractPageParameters)
        {
             ApiResponse<PDFExtractPageResponse> localVarResponse = ExtractPageWithHttpInfo(extractPageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFExtractPageResponse</returns>
        public ApiResponse< PDFExtractPageResponse > ExtractPageWithHttpInfo (PDFExtractPageParameters extractPageParameters)
        {
            // verify the required parameter 'extractPageParameters' is set
            if (extractPageParameters == null)
                throw new ApiException(400, "Missing required parameter 'extractPageParameters' when calling PDFApi->ExtractPage");

            var localVarPath = "/api/pdf/ExtractPage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (extractPageParameters != null && extractPageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(extractPageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = extractPageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExtractPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFExtractPageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFExtractPageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFExtractPageResponse)));
        }

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFExtractPageResponse</returns>
        public async System.Threading.Tasks.Task<PDFExtractPageResponse> ExtractPageAsync (PDFExtractPageParameters extractPageParameters)
        {
             ApiResponse<PDFExtractPageResponse> localVarResponse = await ExtractPageAsyncWithHttpInfo(extractPageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Extracts a page range from a previously uploaded document into one or several new documents. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractPageParameters">A PDFExtractPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFExtractPageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFExtractPageResponse>> ExtractPageAsyncWithHttpInfo (PDFExtractPageParameters extractPageParameters)
        {
            // verify the required parameter 'extractPageParameters' is set
            if (extractPageParameters == null)
                throw new ApiException(400, "Missing required parameter 'extractPageParameters' when calling PDFApi->ExtractPage");

            var localVarPath = "/api/pdf/ExtractPage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (extractPageParameters != null && extractPageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(extractPageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = extractPageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExtractPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFExtractPageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFExtractPageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFExtractPageResponse)));
        }

        /// <summary>
        /// Extracts text from the document pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFExtractTextResponse</returns>
        public PDFExtractTextResponse ExtractText (PDFExtractTextParameters extractTextParameters = null)
        {
             ApiResponse<PDFExtractTextResponse> localVarResponse = ExtractTextWithHttpInfo(extractTextParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Extracts text from the document pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFExtractTextResponse</returns>
        public ApiResponse< PDFExtractTextResponse > ExtractTextWithHttpInfo (PDFExtractTextParameters extractTextParameters = null)
        {

            var localVarPath = "/api/pdf/ExtractText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (extractTextParameters != null && extractTextParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(extractTextParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = extractTextParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExtractText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFExtractTextResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFExtractTextResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFExtractTextResponse)));
        }

        /// <summary>
        /// Extracts text from the document pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFExtractTextResponse</returns>
        public async System.Threading.Tasks.Task<PDFExtractTextResponse> ExtractTextAsync (PDFExtractTextParameters extractTextParameters = null)
        {
             ApiResponse<PDFExtractTextResponse> localVarResponse = await ExtractTextAsyncWithHttpInfo(extractTextParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Extracts text from the document pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extractTextParameters">A PDFExtractTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFExtractTextResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFExtractTextResponse>> ExtractTextAsyncWithHttpInfo (PDFExtractTextParameters extractTextParameters = null)
        {

            var localVarPath = "/api/pdf/ExtractText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (extractTextParameters != null && extractTextParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(extractTextParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = extractTextParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExtractText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFExtractTextResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFExtractTextResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFExtractTextResponse)));
        }

        /// <summary>
        /// Flattens the formfields of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>PDFFlattenFormFieldsResponse</returns>
        public PDFFlattenFormFieldsResponse FlattenFormFields (PDFFlattenFormFieldsParameters flattenFormFieldsParameters)
        {
             ApiResponse<PDFFlattenFormFieldsResponse> localVarResponse = FlattenFormFieldsWithHttpInfo(flattenFormFieldsParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Flattens the formfields of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFFlattenFormFieldsResponse</returns>
        public ApiResponse< PDFFlattenFormFieldsResponse > FlattenFormFieldsWithHttpInfo (PDFFlattenFormFieldsParameters flattenFormFieldsParameters)
        {
            // verify the required parameter 'flattenFormFieldsParameters' is set
            if (flattenFormFieldsParameters == null)
                throw new ApiException(400, "Missing required parameter 'flattenFormFieldsParameters' when calling PDFApi->FlattenFormFields");

            var localVarPath = "/api/pdf/FlattenFormFields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (flattenFormFieldsParameters != null && flattenFormFieldsParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(flattenFormFieldsParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = flattenFormFieldsParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FlattenFormFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFFlattenFormFieldsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFFlattenFormFieldsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFFlattenFormFieldsResponse)));
        }

        /// <summary>
        /// Flattens the formfields of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFFlattenFormFieldsResponse</returns>
        public async System.Threading.Tasks.Task<PDFFlattenFormFieldsResponse> FlattenFormFieldsAsync (PDFFlattenFormFieldsParameters flattenFormFieldsParameters)
        {
             ApiResponse<PDFFlattenFormFieldsResponse> localVarResponse = await FlattenFormFieldsAsyncWithHttpInfo(flattenFormFieldsParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Flattens the formfields of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="flattenFormFieldsParameters">A PDFflattenFormFieldsParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFFlattenFormFieldsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFFlattenFormFieldsResponse>> FlattenFormFieldsAsyncWithHttpInfo (PDFFlattenFormFieldsParameters flattenFormFieldsParameters)
        {
            // verify the required parameter 'flattenFormFieldsParameters' is set
            if (flattenFormFieldsParameters == null)
                throw new ApiException(400, "Missing required parameter 'flattenFormFieldsParameters' when calling PDFApi->FlattenFormFields");

            var localVarPath = "/api/pdf/FlattenFormFields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (flattenFormFieldsParameters != null && flattenFormFieldsParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(flattenFormFieldsParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = flattenFormFieldsParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FlattenFormFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFFlattenFormFieldsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFFlattenFormFieldsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFFlattenFormFieldsResponse)));
        }

        /// <summary>
        /// Gets information about a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>PDFGetInfoResponse</returns>
        public PDFGetInfoResponse GetInfo (PDFGetInfoParameters getInfoParameters)
        {
             ApiResponse<PDFGetInfoResponse> localVarResponse = GetInfoWithHttpInfo(getInfoParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets information about a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFGetInfoResponse</returns>
        public ApiResponse< PDFGetInfoResponse > GetInfoWithHttpInfo (PDFGetInfoParameters getInfoParameters)
        {
            // verify the required parameter 'getInfoParameters' is set
            if (getInfoParameters == null)
                throw new ApiException(400, "Missing required parameter 'getInfoParameters' when calling PDFApi->GetInfo");

            var localVarPath = "/api/pdf/GetInfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getInfoParameters != null && getInfoParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getInfoParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getInfoParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFGetInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFGetInfoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFGetInfoResponse)));
        }

        /// <summary>
        /// Gets information about a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFGetInfoResponse</returns>
        public async System.Threading.Tasks.Task<PDFGetInfoResponse> GetInfoAsync (PDFGetInfoParameters getInfoParameters)
        {
             ApiResponse<PDFGetInfoResponse> localVarResponse = await GetInfoAsyncWithHttpInfo(getInfoParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets information about a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getInfoParameters">A PDFGetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFGetInfoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFGetInfoResponse>> GetInfoAsyncWithHttpInfo (PDFGetInfoParameters getInfoParameters)
        {
            // verify the required parameter 'getInfoParameters' is set
            if (getInfoParameters == null)
                throw new ApiException(400, "Missing required parameter 'getInfoParameters' when calling PDFApi->GetInfo");

            var localVarPath = "/api/pdf/GetInfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getInfoParameters != null && getInfoParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getInfoParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getInfoParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFGetInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFGetInfoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFGetInfoResponse)));
        }

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StringArrayResponse</returns>
        public StringArrayResponse GetPDFImportSupportedFileExtensions ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = GetPDFImportSupportedFileExtensionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StringArrayResponse</returns>
        public ApiResponse< StringArrayResponse > GetPDFImportSupportedFileExtensionsWithHttpInfo ()
        {

            var localVarPath = "/api/pdf/GetPDFImportSupportedFileExtensions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPDFImportSupportedFileExtensions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringArrayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StringArrayResponse</returns>
        public async System.Threading.Tasks.Task<StringArrayResponse> GetPDFImportSupportedFileExtensionsAsync ()
        {
             ApiResponse<StringArrayResponse> localVarResponse = await GetPDFImportSupportedFileExtensionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the supported file extensions by the LoadDocumentAsPDF action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StringArrayResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringArrayResponse>> GetPDFImportSupportedFileExtensionsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/pdf/GetPDFImportSupportedFileExtensions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPDFImportSupportedFileExtensions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StringArrayResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StringArrayResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StringArrayResponse)));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>PDFGetPageThumbnailResponse</returns>
        public PDFGetPageThumbnailResponse GetPageThumbnail (PDFGetPageThumbnailParameters getPageThumbnailParameters)
        {
             ApiResponse<PDFGetPageThumbnailResponse> localVarResponse = GetPageThumbnailWithHttpInfo(getPageThumbnailParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFGetPageThumbnailResponse</returns>
        public ApiResponse< PDFGetPageThumbnailResponse > GetPageThumbnailWithHttpInfo (PDFGetPageThumbnailParameters getPageThumbnailParameters)
        {
            // verify the required parameter 'getPageThumbnailParameters' is set
            if (getPageThumbnailParameters == null)
                throw new ApiException(400, "Missing required parameter 'getPageThumbnailParameters' when calling PDFApi->GetPageThumbnail");

            var localVarPath = "/api/pdf/GetPageThumbnail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getPageThumbnailParameters != null && getPageThumbnailParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPageThumbnailParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPageThumbnailParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageThumbnail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFGetPageThumbnailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFGetPageThumbnailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFGetPageThumbnailResponse)));
        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFGetPageThumbnailResponse</returns>
        public async System.Threading.Tasks.Task<PDFGetPageThumbnailResponse> GetPageThumbnailAsync (PDFGetPageThumbnailParameters getPageThumbnailParameters)
        {
             ApiResponse<PDFGetPageThumbnailResponse> localVarResponse = await GetPageThumbnailAsyncWithHttpInfo(getPageThumbnailParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a thumbnail of each page within the provided page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getPageThumbnailParameters">A PDFGetPageThumbnailParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFGetPageThumbnailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFGetPageThumbnailResponse>> GetPageThumbnailAsyncWithHttpInfo (PDFGetPageThumbnailParameters getPageThumbnailParameters)
        {
            // verify the required parameter 'getPageThumbnailParameters' is set
            if (getPageThumbnailParameters == null)
                throw new ApiException(400, "Missing required parameter 'getPageThumbnailParameters' when calling PDFApi->GetPageThumbnail");

            var localVarPath = "/api/pdf/GetPageThumbnail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (getPageThumbnailParameters != null && getPageThumbnailParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(getPageThumbnailParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = getPageThumbnailParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageThumbnail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFGetPageThumbnailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFGetPageThumbnailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFGetPageThumbnailResponse)));
        }

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFInsertImageResponse</returns>
        public PDFInsertImageResponse InsertImage (PDFInsertImageParameters insertImageParameters)
        {
             ApiResponse<PDFInsertImageResponse> localVarResponse = InsertImageWithHttpInfo(insertImageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFInsertImageResponse</returns>
        public ApiResponse< PDFInsertImageResponse > InsertImageWithHttpInfo (PDFInsertImageParameters insertImageParameters)
        {
            // verify the required parameter 'insertImageParameters' is set
            if (insertImageParameters == null)
                throw new ApiException(400, "Missing required parameter 'insertImageParameters' when calling PDFApi->InsertImage");

            var localVarPath = "/api/pdf/InsertImage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertImageParameters != null && insertImageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertImageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertImageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertImageResponse)));
        }

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFInsertImageResponse</returns>
        public async System.Threading.Tasks.Task<PDFInsertImageResponse> InsertImageAsync (PDFInsertImageParameters insertImageParameters)
        {
             ApiResponse<PDFInsertImageResponse> localVarResponse = await InsertImageAsyncWithHttpInfo(insertImageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserts an image on a new page of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertImageParameters">A PDFInsertImageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFInsertImageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFInsertImageResponse>> InsertImageAsyncWithHttpInfo (PDFInsertImageParameters insertImageParameters)
        {
            // verify the required parameter 'insertImageParameters' is set
            if (insertImageParameters == null)
                throw new ApiException(400, "Missing required parameter 'insertImageParameters' when calling PDFApi->InsertImage");

            var localVarPath = "/api/pdf/InsertImage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertImageParameters != null && insertImageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertImageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertImageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertImageResponse)));
        }

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFInsertNewPageResponse</returns>
        public PDFInsertNewPageResponse InsertNewPage (PDFInsertNewPageParameters insertNewPageParameters)
        {
             ApiResponse<PDFInsertNewPageResponse> localVarResponse = InsertNewPageWithHttpInfo(insertNewPageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFInsertNewPageResponse</returns>
        public ApiResponse< PDFInsertNewPageResponse > InsertNewPageWithHttpInfo (PDFInsertNewPageParameters insertNewPageParameters)
        {
            // verify the required parameter 'insertNewPageParameters' is set
            if (insertNewPageParameters == null)
                throw new ApiException(400, "Missing required parameter 'insertNewPageParameters' when calling PDFApi->InsertNewPage");

            var localVarPath = "/api/pdf/InsertNewPage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertNewPageParameters != null && insertNewPageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertNewPageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertNewPageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertNewPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertNewPageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertNewPageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertNewPageResponse)));
        }

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFInsertNewPageResponse</returns>
        public async System.Threading.Tasks.Task<PDFInsertNewPageResponse> InsertNewPageAsync (PDFInsertNewPageParameters insertNewPageParameters)
        {
             ApiResponse<PDFInsertNewPageResponse> localVarResponse = await InsertNewPageAsyncWithHttpInfo(insertNewPageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserts one or more new blank pages to a specific position in a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertNewPageParameters">A PDFInsertNewPageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFInsertNewPageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFInsertNewPageResponse>> InsertNewPageAsyncWithHttpInfo (PDFInsertNewPageParameters insertNewPageParameters)
        {
            // verify the required parameter 'insertNewPageParameters' is set
            if (insertNewPageParameters == null)
                throw new ApiException(400, "Missing required parameter 'insertNewPageParameters' when calling PDFApi->InsertNewPage");

            var localVarPath = "/api/pdf/InsertNewPage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertNewPageParameters != null && insertNewPageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertNewPageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertNewPageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertNewPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertNewPageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertNewPageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertNewPageResponse)));
        }

        /// <summary>
        /// Inserts page number(s) on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFInsertPageNumberResponse</returns>
        public PDFInsertPageNumberResponse InsertPageNumber (PDFInsertPageNumberParameters insertPageNumberParameters = null)
        {
             ApiResponse<PDFInsertPageNumberResponse> localVarResponse = InsertPageNumberWithHttpInfo(insertPageNumberParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserts page number(s) on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFInsertPageNumberResponse</returns>
        public ApiResponse< PDFInsertPageNumberResponse > InsertPageNumberWithHttpInfo (PDFInsertPageNumberParameters insertPageNumberParameters = null)
        {

            var localVarPath = "/api/pdf/InsertPageNumber";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertPageNumberParameters != null && insertPageNumberParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertPageNumberParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertPageNumberParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertPageNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertPageNumberResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertPageNumberResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertPageNumberResponse)));
        }

        /// <summary>
        /// Inserts page number(s) on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFInsertPageNumberResponse</returns>
        public async System.Threading.Tasks.Task<PDFInsertPageNumberResponse> InsertPageNumberAsync (PDFInsertPageNumberParameters insertPageNumberParameters = null)
        {
             ApiResponse<PDFInsertPageNumberResponse> localVarResponse = await InsertPageNumberAsyncWithHttpInfo(insertPageNumberParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserts page number(s) on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertPageNumberParameters">A PDFInsertPageNumberParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFInsertPageNumberResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFInsertPageNumberResponse>> InsertPageNumberAsyncWithHttpInfo (PDFInsertPageNumberParameters insertPageNumberParameters = null)
        {

            var localVarPath = "/api/pdf/InsertPageNumber";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertPageNumberParameters != null && insertPageNumberParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertPageNumberParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertPageNumberParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertPageNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertPageNumberResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertPageNumberResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertPageNumberResponse)));
        }

        /// <summary>
        /// Inserts text on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFInsertTextResponse</returns>
        public PDFInsertTextResponse InsertText (PDFInsertTextParameters insertTextParameters = null)
        {
             ApiResponse<PDFInsertTextResponse> localVarResponse = InsertTextWithHttpInfo(insertTextParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inserts text on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFInsertTextResponse</returns>
        public ApiResponse< PDFInsertTextResponse > InsertTextWithHttpInfo (PDFInsertTextParameters insertTextParameters = null)
        {

            var localVarPath = "/api/pdf/InsertText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertTextParameters != null && insertTextParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertTextParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertTextParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertTextResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertTextResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertTextResponse)));
        }

        /// <summary>
        /// Inserts text on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFInsertTextResponse</returns>
        public async System.Threading.Tasks.Task<PDFInsertTextResponse> InsertTextAsync (PDFInsertTextParameters insertTextParameters = null)
        {
             ApiResponse<PDFInsertTextResponse> localVarResponse = await InsertTextAsyncWithHttpInfo(insertTextParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inserts text on a document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="insertTextParameters">A PDFInsertTextParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFInsertTextResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFInsertTextResponse>> InsertTextAsyncWithHttpInfo (PDFInsertTextParameters insertTextParameters = null)
        {

            var localVarPath = "/api/pdf/InsertText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (insertTextParameters != null && insertTextParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(insertTextParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = insertTextParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InsertText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFInsertTextResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFInsertTextResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFInsertTextResponse)));
        }

        /// <summary>
        /// Linearizes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>PDFLinearizeResponse</returns>
        public PDFLinearizeResponse Linearize (PDFLinearizeParameters linearizeParameters)
        {
             ApiResponse<PDFLinearizeResponse> localVarResponse = LinearizeWithHttpInfo(linearizeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Linearizes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFLinearizeResponse</returns>
        public ApiResponse< PDFLinearizeResponse > LinearizeWithHttpInfo (PDFLinearizeParameters linearizeParameters)
        {
            // verify the required parameter 'linearizeParameters' is set
            if (linearizeParameters == null)
                throw new ApiException(400, "Missing required parameter 'linearizeParameters' when calling PDFApi->Linearize");

            var localVarPath = "/api/pdf/Linearize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (linearizeParameters != null && linearizeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(linearizeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = linearizeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Linearize", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFLinearizeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFLinearizeResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFLinearizeResponse)));
        }

        /// <summary>
        /// Linearizes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFLinearizeResponse</returns>
        public async System.Threading.Tasks.Task<PDFLinearizeResponse> LinearizeAsync (PDFLinearizeParameters linearizeParameters)
        {
             ApiResponse<PDFLinearizeResponse> localVarResponse = await LinearizeAsyncWithHttpInfo(linearizeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Linearizes a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linearizeParameters">A PDFLinearizeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFLinearizeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFLinearizeResponse>> LinearizeAsyncWithHttpInfo (PDFLinearizeParameters linearizeParameters)
        {
            // verify the required parameter 'linearizeParameters' is set
            if (linearizeParameters == null)
                throw new ApiException(400, "Missing required parameter 'linearizeParameters' when calling PDFApi->Linearize");

            var localVarPath = "/api/pdf/Linearize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (linearizeParameters != null && linearizeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(linearizeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = linearizeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Linearize", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFLinearizeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFLinearizeResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFLinearizeResponse)));
        }

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>PDFLoadDocumentResponse</returns>
        public PDFLoadDocumentResponse LoadDocumentAsPDF (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters)
        {
             ApiResponse<PDFLoadDocumentResponse> localVarResponse = LoadDocumentAsPDFWithHttpInfo(loadDocumentParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFLoadDocumentResponse</returns>
        public ApiResponse< PDFLoadDocumentResponse > LoadDocumentAsPDFWithHttpInfo (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters)
        {
            // verify the required parameter 'loadDocumentParameters' is set
            if (loadDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'loadDocumentParameters' when calling PDFApi->LoadDocumentAsPDF");

            var localVarPath = "/api/pdf/LoadDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loadDocumentParameters != null && loadDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(loadDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loadDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoadDocumentAsPDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFLoadDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFLoadDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFLoadDocumentResponse)));
        }

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFLoadDocumentResponse</returns>
        public async System.Threading.Tasks.Task<PDFLoadDocumentResponse> LoadDocumentAsPDFAsync (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters)
        {
             ApiResponse<PDFLoadDocumentResponse> localVarResponse = await LoadDocumentAsPDFAsyncWithHttpInfo(loadDocumentParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Imports the provided document as PDF.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loadDocumentParameters">A PDFLoadDocumentFromByteArrayParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFLoadDocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFLoadDocumentResponse>> LoadDocumentAsPDFAsyncWithHttpInfo (PDFLoadDocumentFromByteArrayParameters loadDocumentParameters)
        {
            // verify the required parameter 'loadDocumentParameters' is set
            if (loadDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'loadDocumentParameters' when calling PDFApi->LoadDocumentAsPDF");

            var localVarPath = "/api/pdf/LoadDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loadDocumentParameters != null && loadDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(loadDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loadDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoadDocumentAsPDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFLoadDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFLoadDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFLoadDocumentResponse)));
        }

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>PDFLoadDocumentResponse</returns>
        public PDFLoadDocumentResponse LoadDocumentAsPDFMultipart (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null)
        {
             ApiResponse<PDFLoadDocumentResponse> localVarResponse = LoadDocumentAsPDFMultipartWithHttpInfo(fileData, contentEncoding, fileName, password, conformance);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>ApiResponse of PDFLoadDocumentResponse</returns>
        public ApiResponse< PDFLoadDocumentResponse > LoadDocumentAsPDFMultipartWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ApiException(400, "Missing required parameter 'fileData' when calling PDFApi->LoadDocumentAsPDFMultipart");

            var localVarPath = "/api/pdf/LoadDocumentAsPDFMultipart";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileData != null) localVarFileParams.Add("FileData", this.Configuration.ApiClient.ParameterToFile("FileData", fileData));
            if (contentEncoding != null) localVarFormParams.Add("ContentEncoding", this.Configuration.ApiClient.ParameterToString(contentEncoding)); // form parameter
            if (fileName != null) localVarFormParams.Add("FileName", this.Configuration.ApiClient.ParameterToString(fileName)); // form parameter
            if (password != null) localVarFormParams.Add("Password", this.Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (conformance != null) localVarFormParams.Add("Conformance", this.Configuration.ApiClient.ParameterToString(conformance)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoadDocumentAsPDFMultipart", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFLoadDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFLoadDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFLoadDocumentResponse)));
        }

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>Task of PDFLoadDocumentResponse</returns>
        public async System.Threading.Tasks.Task<PDFLoadDocumentResponse> LoadDocumentAsPDFMultipartAsync (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null)
        {
             ApiResponse<PDFLoadDocumentResponse> localVarResponse = await LoadDocumentAsPDFMultipartAsyncWithHttpInfo(fileData, contentEncoding, fileName, password, conformance);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Imports the provided document as PDF using Multipart Upload.  Supported document formats can be retrieved by the GetPDFImportSupportedFileExtensions action. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileData">Specifies the stream of data of the file to be uploaded.</param>
        /// <param name="contentEncoding">Specifies the encoding of the fileData content. (optional, default to &quot;Identity&quot;)</param>
        /// <param name="fileName">Specifies the name of the file to be uploaded. (optional)</param>
        /// <param name="password">Specifies the password for the file to be uploaded. (optional)</param>
        /// <param name="conformance">Specifies the level of PDF conformance to be used for loading the document. (optional, default to &quot;PDF&quot;)</param>
        /// <returns>Task of ApiResponse (PDFLoadDocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFLoadDocumentResponse>> LoadDocumentAsPDFMultipartAsyncWithHttpInfo (System.IO.Stream fileData, string contentEncoding = null, string fileName = null, string password = null, string conformance = null)
        {
            // verify the required parameter 'fileData' is set
            if (fileData == null)
                throw new ApiException(400, "Missing required parameter 'fileData' when calling PDFApi->LoadDocumentAsPDFMultipart");

            var localVarPath = "/api/pdf/LoadDocumentAsPDFMultipart";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fileData != null) localVarFileParams.Add("FileData", this.Configuration.ApiClient.ParameterToFile("FileData", fileData));
            if (contentEncoding != null) localVarFormParams.Add("ContentEncoding", this.Configuration.ApiClient.ParameterToString(contentEncoding)); // form parameter
            if (fileName != null) localVarFormParams.Add("FileName", this.Configuration.ApiClient.ParameterToString(fileName)); // form parameter
            if (password != null) localVarFormParams.Add("Password", this.Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (conformance != null) localVarFormParams.Add("Conformance", this.Configuration.ApiClient.ParameterToString(conformance)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LoadDocumentAsPDFMultipart", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFLoadDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFLoadDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFLoadDocumentResponse)));
        }

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>PDFMergeResponse</returns>
        public PDFMergeResponse Merge (PDFMergeParameters mergeParameters)
        {
             ApiResponse<PDFMergeResponse> localVarResponse = MergeWithHttpInfo(mergeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFMergeResponse</returns>
        public ApiResponse< PDFMergeResponse > MergeWithHttpInfo (PDFMergeParameters mergeParameters)
        {
            // verify the required parameter 'mergeParameters' is set
            if (mergeParameters == null)
                throw new ApiException(400, "Missing required parameter 'mergeParameters' when calling PDFApi->Merge");

            var localVarPath = "/api/pdf/Merge";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (mergeParameters != null && mergeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(mergeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mergeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Merge", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFMergeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFMergeResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFMergeResponse)));
        }

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFMergeResponse</returns>
        public async System.Threading.Tasks.Task<PDFMergeResponse> MergeAsync (PDFMergeParameters mergeParameters)
        {
             ApiResponse<PDFMergeResponse> localVarResponse = await MergeAsyncWithHttpInfo(mergeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Merges several previously uploaded documents into a new PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mergeParameters">A PDFMergeParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFMergeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFMergeResponse>> MergeAsyncWithHttpInfo (PDFMergeParameters mergeParameters)
        {
            // verify the required parameter 'mergeParameters' is set
            if (mergeParameters == null)
                throw new ApiException(400, "Missing required parameter 'mergeParameters' when calling PDFApi->Merge");

            var localVarPath = "/api/pdf/Merge";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (mergeParameters != null && mergeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(mergeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mergeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Merge", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFMergeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFMergeResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFMergeResponse)));
        }

        /// <summary>
        /// Moves a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFMovePageResponse</returns>
        public PDFMovePageResponse MovePage (PDFMovePageParameters movePageParameters)
        {
             ApiResponse<PDFMovePageResponse> localVarResponse = MovePageWithHttpInfo(movePageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Moves a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFMovePageResponse</returns>
        public ApiResponse< PDFMovePageResponse > MovePageWithHttpInfo (PDFMovePageParameters movePageParameters)
        {
            // verify the required parameter 'movePageParameters' is set
            if (movePageParameters == null)
                throw new ApiException(400, "Missing required parameter 'movePageParameters' when calling PDFApi->MovePage");

            var localVarPath = "/api/pdf/MovePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (movePageParameters != null && movePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(movePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = movePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MovePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFMovePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFMovePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFMovePageResponse)));
        }

        /// <summary>
        /// Moves a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFMovePageResponse</returns>
        public async System.Threading.Tasks.Task<PDFMovePageResponse> MovePageAsync (PDFMovePageParameters movePageParameters)
        {
             ApiResponse<PDFMovePageResponse> localVarResponse = await MovePageAsyncWithHttpInfo(movePageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Moves a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="movePageParameters">A PDFMovePageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFMovePageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFMovePageResponse>> MovePageAsyncWithHttpInfo (PDFMovePageParameters movePageParameters)
        {
            // verify the required parameter 'movePageParameters' is set
            if (movePageParameters == null)
                throw new ApiException(400, "Missing required parameter 'movePageParameters' when calling PDFApi->MovePage");

            var localVarPath = "/api/pdf/MovePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (movePageParameters != null && movePageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(movePageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = movePageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MovePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFMovePageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFMovePageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFMovePageResponse)));
        }

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>PDFOCRResponse</returns>
        public PDFOCRResponse OCR (PDFOCRParameters oCRParameters)
        {
             ApiResponse<PDFOCRResponse> localVarResponse = OCRWithHttpInfo(oCRParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFOCRResponse</returns>
        public ApiResponse< PDFOCRResponse > OCRWithHttpInfo (PDFOCRParameters oCRParameters)
        {
            // verify the required parameter 'oCRParameters' is set
            if (oCRParameters == null)
                throw new ApiException(400, "Missing required parameter 'oCRParameters' when calling PDFApi->OCR");

            var localVarPath = "/api/pdf/OCR";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (oCRParameters != null && oCRParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(oCRParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = oCRParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OCR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFOCRResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFOCRResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFOCRResponse)));
        }

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFOCRResponse</returns>
        public async System.Threading.Tasks.Task<PDFOCRResponse> OCRAsync (PDFOCRParameters oCRParameters)
        {
             ApiResponse<PDFOCRResponse> localVarResponse = await OCRAsyncWithHttpInfo(oCRParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs optical character recognition on a page range of a previously uploaded document.  The recognized text is added as invisible text on each processed page.  No token is charged for blank pages. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="oCRParameters">A PDFOCRParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFOCRResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFOCRResponse>> OCRAsyncWithHttpInfo (PDFOCRParameters oCRParameters)
        {
            // verify the required parameter 'oCRParameters' is set
            if (oCRParameters == null)
                throw new ApiException(400, "Missing required parameter 'oCRParameters' when calling PDFApi->OCR");

            var localVarPath = "/api/pdf/OCR";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (oCRParameters != null && oCRParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(oCRParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = oCRParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OCR", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFOCRResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFOCRResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFOCRResponse)));
        }

        /// <summary>
        /// Protects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>PDFProtectResponse</returns>
        public PDFProtectResponse Protect (PDFProtectParameters protectParameters)
        {
             ApiResponse<PDFProtectResponse> localVarResponse = ProtectWithHttpInfo(protectParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Protects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFProtectResponse</returns>
        public ApiResponse< PDFProtectResponse > ProtectWithHttpInfo (PDFProtectParameters protectParameters)
        {
            // verify the required parameter 'protectParameters' is set
            if (protectParameters == null)
                throw new ApiException(400, "Missing required parameter 'protectParameters' when calling PDFApi->Protect");

            var localVarPath = "/api/pdf/Protect";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (protectParameters != null && protectParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(protectParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = protectParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Protect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFProtectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFProtectResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFProtectResponse)));
        }

        /// <summary>
        /// Protects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFProtectResponse</returns>
        public async System.Threading.Tasks.Task<PDFProtectResponse> ProtectAsync (PDFProtectParameters protectParameters)
        {
             ApiResponse<PDFProtectResponse> localVarResponse = await ProtectAsyncWithHttpInfo(protectParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Protects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="protectParameters">A PDFProtectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFProtectResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFProtectResponse>> ProtectAsyncWithHttpInfo (PDFProtectParameters protectParameters)
        {
            // verify the required parameter 'protectParameters' is set
            if (protectParameters == null)
                throw new ApiException(400, "Missing required parameter 'protectParameters' when calling PDFApi->Protect");

            var localVarPath = "/api/pdf/Protect";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (protectParameters != null && protectParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(protectParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = protectParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Protect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFProtectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFProtectResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFProtectResponse)));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ReadBarcodesResponse</returns>
        public ReadBarcodesResponse ReadBarcodes (PDFReadBarcodesParameters readBarcodeParameters)
        {
             ApiResponse<ReadBarcodesResponse> localVarResponse = ReadBarcodesWithHttpInfo(readBarcodeParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of ReadBarcodesResponse</returns>
        public ApiResponse< ReadBarcodesResponse > ReadBarcodesWithHttpInfo (PDFReadBarcodesParameters readBarcodeParameters)
        {
            // verify the required parameter 'readBarcodeParameters' is set
            if (readBarcodeParameters == null)
                throw new ApiException(400, "Missing required parameter 'readBarcodeParameters' when calling PDFApi->ReadBarcodes");

            var localVarPath = "/api/pdf/ReadBarcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (readBarcodeParameters != null && readBarcodeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(readBarcodeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = readBarcodeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadBarcodes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReadBarcodesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReadBarcodesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadBarcodesResponse)));
        }

        /// <summary>
        /// Reads barcodes from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ReadBarcodesResponse</returns>
        public async System.Threading.Tasks.Task<ReadBarcodesResponse> ReadBarcodesAsync (PDFReadBarcodesParameters readBarcodeParameters)
        {
             ApiResponse<ReadBarcodesResponse> localVarResponse = await ReadBarcodesAsyncWithHttpInfo(readBarcodeParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reads barcodes from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="readBarcodeParameters">A PDFReadBarcodesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (ReadBarcodesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReadBarcodesResponse>> ReadBarcodesAsyncWithHttpInfo (PDFReadBarcodesParameters readBarcodeParameters)
        {
            // verify the required parameter 'readBarcodeParameters' is set
            if (readBarcodeParameters == null)
                throw new ApiException(400, "Missing required parameter 'readBarcodeParameters' when calling PDFApi->ReadBarcodes");

            var localVarPath = "/api/pdf/ReadBarcodes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (readBarcodeParameters != null && readBarcodeParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(readBarcodeParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = readBarcodeParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadBarcodes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReadBarcodesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ReadBarcodesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadBarcodesResponse)));
        }

        /// <summary>
        /// Reduces the size of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>PDFReduceResponse</returns>
        public PDFReduceResponse Reduce (PDFReduceParameters reduceParameters)
        {
             ApiResponse<PDFReduceResponse> localVarResponse = ReduceWithHttpInfo(reduceParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reduces the size of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFReduceResponse</returns>
        public ApiResponse< PDFReduceResponse > ReduceWithHttpInfo (PDFReduceParameters reduceParameters)
        {
            // verify the required parameter 'reduceParameters' is set
            if (reduceParameters == null)
                throw new ApiException(400, "Missing required parameter 'reduceParameters' when calling PDFApi->Reduce");

            var localVarPath = "/api/pdf/Reduce";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (reduceParameters != null && reduceParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(reduceParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = reduceParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Reduce", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFReduceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFReduceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFReduceResponse)));
        }

        /// <summary>
        /// Reduces the size of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFReduceResponse</returns>
        public async System.Threading.Tasks.Task<PDFReduceResponse> ReduceAsync (PDFReduceParameters reduceParameters)
        {
             ApiResponse<PDFReduceResponse> localVarResponse = await ReduceAsyncWithHttpInfo(reduceParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reduces the size of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reduceParameters">A PDFReduceParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFReduceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFReduceResponse>> ReduceAsyncWithHttpInfo (PDFReduceParameters reduceParameters)
        {
            // verify the required parameter 'reduceParameters' is set
            if (reduceParameters == null)
                throw new ApiException(400, "Missing required parameter 'reduceParameters' when calling PDFApi->Reduce");

            var localVarPath = "/api/pdf/Reduce";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (reduceParameters != null && reduceParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(reduceParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = reduceParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Reduce", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFReduceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFReduceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFReduceResponse)));
        }

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFRemovePageFormFieldsResponse</returns>
        public PDFRemovePageFormFieldsResponse RemovePageFormFields (PDFRemovePageFormFieldsParameters removePageFormFields = null)
        {
             ApiResponse<PDFRemovePageFormFieldsResponse> localVarResponse = RemovePageFormFieldsWithHttpInfo(removePageFormFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFRemovePageFormFieldsResponse</returns>
        public ApiResponse< PDFRemovePageFormFieldsResponse > RemovePageFormFieldsWithHttpInfo (PDFRemovePageFormFieldsParameters removePageFormFields = null)
        {

            var localVarPath = "/api/pdf/RemovePageFormFields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (removePageFormFields != null && removePageFormFields.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(removePageFormFields); // http body (model) parameter
            }
            else
            {
                localVarPostBody = removePageFormFields; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemovePageFormFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFRemovePageFormFieldsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFRemovePageFormFieldsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFRemovePageFormFieldsResponse)));
        }

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFRemovePageFormFieldsResponse</returns>
        public async System.Threading.Tasks.Task<PDFRemovePageFormFieldsResponse> RemovePageFormFieldsAsync (PDFRemovePageFormFieldsParameters removePageFormFields = null)
        {
             ApiResponse<PDFRemovePageFormFieldsResponse> localVarResponse = await RemovePageFormFieldsAsyncWithHttpInfo(removePageFormFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Removes the form fields from a page range of a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="removePageFormFields">A PDFRemovePageFormFieldsParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFRemovePageFormFieldsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFRemovePageFormFieldsResponse>> RemovePageFormFieldsAsyncWithHttpInfo (PDFRemovePageFormFieldsParameters removePageFormFields = null)
        {

            var localVarPath = "/api/pdf/RemovePageFormFields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (removePageFormFields != null && removePageFormFields.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(removePageFormFields); // http body (model) parameter
            }
            else
            {
                localVarPostBody = removePageFormFields; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemovePageFormFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFRemovePageFormFieldsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFRemovePageFormFieldsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFRemovePageFormFieldsResponse)));
        }

        /// <summary>
        /// Repairs a previously uploaded PDF document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PDFRepairDocumentResponse</returns>
        public PDFRepairDocumentResponse RepairDocument (PDFRepairDocumentParameters repairDocumentParameters)
        {
             ApiResponse<PDFRepairDocumentResponse> localVarResponse = RepairDocumentWithHttpInfo(repairDocumentParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Repairs a previously uploaded PDF document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFRepairDocumentResponse</returns>
        public ApiResponse< PDFRepairDocumentResponse > RepairDocumentWithHttpInfo (PDFRepairDocumentParameters repairDocumentParameters)
        {
            // verify the required parameter 'repairDocumentParameters' is set
            if (repairDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'repairDocumentParameters' when calling PDFApi->RepairDocument");

            var localVarPath = "/api/pdf/RepairDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (repairDocumentParameters != null && repairDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(repairDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = repairDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RepairDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFRepairDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFRepairDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFRepairDocumentResponse)));
        }

        /// <summary>
        /// Repairs a previously uploaded PDF document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFRepairDocumentResponse</returns>
        public async System.Threading.Tasks.Task<PDFRepairDocumentResponse> RepairDocumentAsync (PDFRepairDocumentParameters repairDocumentParameters)
        {
             ApiResponse<PDFRepairDocumentResponse> localVarResponse = await RepairDocumentAsyncWithHttpInfo(repairDocumentParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Repairs a previously uploaded PDF document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="repairDocumentParameters">A PDFRepairDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFRepairDocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFRepairDocumentResponse>> RepairDocumentAsyncWithHttpInfo (PDFRepairDocumentParameters repairDocumentParameters)
        {
            // verify the required parameter 'repairDocumentParameters' is set
            if (repairDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'repairDocumentParameters' when calling PDFApi->RepairDocument");

            var localVarPath = "/api/pdf/RepairDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (repairDocumentParameters != null && repairDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(repairDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = repairDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RepairDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFRepairDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFRepairDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFRepairDocumentResponse)));
        }

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>PDFRotatePageStandardResponse</returns>
        public PDFRotatePageStandardResponse RotatePageStandard (PDFRotatePageStandardParameters rotatePageStandardParameters)
        {
             ApiResponse<PDFRotatePageStandardResponse> localVarResponse = RotatePageStandardWithHttpInfo(rotatePageStandardParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFRotatePageStandardResponse</returns>
        public ApiResponse< PDFRotatePageStandardResponse > RotatePageStandardWithHttpInfo (PDFRotatePageStandardParameters rotatePageStandardParameters)
        {
            // verify the required parameter 'rotatePageStandardParameters' is set
            if (rotatePageStandardParameters == null)
                throw new ApiException(400, "Missing required parameter 'rotatePageStandardParameters' when calling PDFApi->RotatePageStandard");

            var localVarPath = "/api/pdf/RotatePageStandard";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (rotatePageStandardParameters != null && rotatePageStandardParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(rotatePageStandardParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = rotatePageStandardParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RotatePageStandard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFRotatePageStandardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFRotatePageStandardResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFRotatePageStandardResponse)));
        }

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFRotatePageStandardResponse</returns>
        public async System.Threading.Tasks.Task<PDFRotatePageStandardResponse> RotatePageStandardAsync (PDFRotatePageStandardParameters rotatePageStandardParameters)
        {
             ApiResponse<PDFRotatePageStandardResponse> localVarResponse = await RotatePageStandardAsyncWithHttpInfo(rotatePageStandardParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Rotates (standardly) a page range from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rotatePageStandardParameters">A PDFRotatePageStandardParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFRotatePageStandardResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFRotatePageStandardResponse>> RotatePageStandardAsyncWithHttpInfo (PDFRotatePageStandardParameters rotatePageStandardParameters)
        {
            // verify the required parameter 'rotatePageStandardParameters' is set
            if (rotatePageStandardParameters == null)
                throw new ApiException(400, "Missing required parameter 'rotatePageStandardParameters' when calling PDFApi->RotatePageStandard");

            var localVarPath = "/api/pdf/RotatePageStandard";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (rotatePageStandardParameters != null && rotatePageStandardParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(rotatePageStandardParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = rotatePageStandardParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RotatePageStandard", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFRotatePageStandardResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFRotatePageStandardResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFRotatePageStandardResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsJPEGResponse</returns>
        public PDFSaveAsJPEGResponse SaveAsJPEG (PDFSaveAsJPEGParameters saveAsJPEGParameters)
        {
             ApiResponse<PDFSaveAsJPEGResponse> localVarResponse = SaveAsJPEGWithHttpInfo(saveAsJPEGParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsJPEGResponse</returns>
        public ApiResponse< PDFSaveAsJPEGResponse > SaveAsJPEGWithHttpInfo (PDFSaveAsJPEGParameters saveAsJPEGParameters)
        {
            // verify the required parameter 'saveAsJPEGParameters' is set
            if (saveAsJPEGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsJPEGParameters' when calling PDFApi->SaveAsJPEG");

            var localVarPath = "/api/pdf/SaveAsJPEG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsJPEGParameters != null && saveAsJPEGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsJPEGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsJPEGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsJPEG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsJPEGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsJPEGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsJPEGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsJPEGResponse</returns>
        public async System.Threading.Tasks.Task<PDFSaveAsJPEGResponse> SaveAsJPEGAsync (PDFSaveAsJPEGParameters saveAsJPEGParameters)
        {
             ApiResponse<PDFSaveAsJPEGResponse> localVarResponse = await SaveAsJPEGAsyncWithHttpInfo(saveAsJPEGParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded document as JPEG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsJPEGParameters">A PDFSaveAsJPEGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsJPEGResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSaveAsJPEGResponse>> SaveAsJPEGAsyncWithHttpInfo (PDFSaveAsJPEGParameters saveAsJPEGParameters)
        {
            // verify the required parameter 'saveAsJPEGParameters' is set
            if (saveAsJPEGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsJPEGParameters' when calling PDFApi->SaveAsJPEG");

            var localVarPath = "/api/pdf/SaveAsJPEG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsJPEGParameters != null && saveAsJPEGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsJPEGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsJPEGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsJPEG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsJPEGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsJPEGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsJPEGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsPNGResponse</returns>
        public PDFSaveAsPNGResponse SaveAsPNG (PDFSaveAsPNGParameters saveAsPNGParameters)
        {
             ApiResponse<PDFSaveAsPNGResponse> localVarResponse = SaveAsPNGWithHttpInfo(saveAsPNGParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsPNGResponse</returns>
        public ApiResponse< PDFSaveAsPNGResponse > SaveAsPNGWithHttpInfo (PDFSaveAsPNGParameters saveAsPNGParameters)
        {
            // verify the required parameter 'saveAsPNGParameters' is set
            if (saveAsPNGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPNGParameters' when calling PDFApi->SaveAsPNG");

            var localVarPath = "/api/pdf/SaveAsPNG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPNGParameters != null && saveAsPNGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPNGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPNGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsPNG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsPNGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsPNGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsPNGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsPNGResponse</returns>
        public async System.Threading.Tasks.Task<PDFSaveAsPNGResponse> SaveAsPNGAsync (PDFSaveAsPNGParameters saveAsPNGParameters)
        {
             ApiResponse<PDFSaveAsPNGResponse> localVarResponse = await SaveAsPNGAsyncWithHttpInfo(saveAsPNGParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded document as PNG. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsPNGParameters">A PDFSaveAsPNGParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsPNGResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSaveAsPNGResponse>> SaveAsPNGAsyncWithHttpInfo (PDFSaveAsPNGParameters saveAsPNGParameters)
        {
            // verify the required parameter 'saveAsPNGParameters' is set
            if (saveAsPNGParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsPNGParameters' when calling PDFApi->SaveAsPNG");

            var localVarPath = "/api/pdf/SaveAsPNG";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsPNGParameters != null && saveAsPNGParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsPNGParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsPNGParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsPNG", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsPNGResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsPNGResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsPNGResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsTIFFResponse</returns>
        public PDFSaveAsTIFFResponse SaveAsTIFF (PDFSaveAsTIFFParameters saveAsTIFFParameters)
        {
             ApiResponse<PDFSaveAsTIFFResponse> localVarResponse = SaveAsTIFFWithHttpInfo(saveAsTIFFParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsTIFFResponse</returns>
        public ApiResponse< PDFSaveAsTIFFResponse > SaveAsTIFFWithHttpInfo (PDFSaveAsTIFFParameters saveAsTIFFParameters)
        {
            // verify the required parameter 'saveAsTIFFParameters' is set
            if (saveAsTIFFParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFParameters' when calling PDFApi->SaveAsTIFF");

            var localVarPath = "/api/pdf/SaveAsTIFF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFParameters != null && saveAsTIFFParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsTIFF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsTIFFResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsTIFFResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsTIFFResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsTIFFResponse</returns>
        public async System.Threading.Tasks.Task<PDFSaveAsTIFFResponse> SaveAsTIFFAsync (PDFSaveAsTIFFParameters saveAsTIFFParameters)
        {
             ApiResponse<PDFSaveAsTIFFResponse> localVarResponse = await SaveAsTIFFAsyncWithHttpInfo(saveAsTIFFParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded document as TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFParameters">A PDFSaveAsTIFFParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsTIFFResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSaveAsTIFFResponse>> SaveAsTIFFAsyncWithHttpInfo (PDFSaveAsTIFFParameters saveAsTIFFParameters)
        {
            // verify the required parameter 'saveAsTIFFParameters' is set
            if (saveAsTIFFParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFParameters' when calling PDFApi->SaveAsTIFF");

            var localVarPath = "/api/pdf/SaveAsTIFF";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFParameters != null && saveAsTIFFParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsTIFF", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsTIFFResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsTIFFResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsTIFFResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveAsTIFFMultipageResponse</returns>
        public PDFSaveAsTIFFMultipageResponse SaveAsTIFFMultipage (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
             ApiResponse<PDFSaveAsTIFFMultipageResponse> localVarResponse = SaveAsTIFFMultipageWithHttpInfo(saveAsTIFFMultipageParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveAsTIFFMultipageResponse</returns>
        public ApiResponse< PDFSaveAsTIFFMultipageResponse > SaveAsTIFFMultipageWithHttpInfo (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'saveAsTIFFMultipageParameters' is set
            if (saveAsTIFFMultipageParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFMultipageParameters' when calling PDFApi->SaveAsTIFFMultipage");

            var localVarPath = "/api/pdf/SaveAsTIFFMultipage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFMultipageParameters != null && saveAsTIFFMultipageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFMultipageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFMultipageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsTIFFMultipage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsTIFFMultipageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsTIFFMultipageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsTIFFMultipageResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveAsTIFFMultipageResponse</returns>
        public async System.Threading.Tasks.Task<PDFSaveAsTIFFMultipageResponse> SaveAsTIFFMultipageAsync (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
             ApiResponse<PDFSaveAsTIFFMultipageResponse> localVarResponse = await SaveAsTIFFMultipageAsyncWithHttpInfo(saveAsTIFFMultipageParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded document as multipage TIFF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveAsTIFFMultipageParameters">A PDFSaveAsTIFFMultipageParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveAsTIFFMultipageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSaveAsTIFFMultipageResponse>> SaveAsTIFFMultipageAsyncWithHttpInfo (PDFSaveAsTIFFMultipageParameters saveAsTIFFMultipageParameters)
        {
            // verify the required parameter 'saveAsTIFFMultipageParameters' is set
            if (saveAsTIFFMultipageParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveAsTIFFMultipageParameters' when calling PDFApi->SaveAsTIFFMultipage");

            var localVarPath = "/api/pdf/SaveAsTIFFMultipage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveAsTIFFMultipageParameters != null && saveAsTIFFMultipageParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveAsTIFFMultipageParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveAsTIFFMultipageParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveAsTIFFMultipage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveAsTIFFMultipageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveAsTIFFMultipageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveAsTIFFMultipageResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSaveDocumentResponse</returns>
        public PDFSaveDocumentResponse SaveDocument (PDFSaveDocumentParameters saveDocumentParameters)
        {
             ApiResponse<PDFSaveDocumentResponse> localVarResponse = SaveDocumentWithHttpInfo(saveDocumentParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSaveDocumentResponse</returns>
        public ApiResponse< PDFSaveDocumentResponse > SaveDocumentWithHttpInfo (PDFSaveDocumentParameters saveDocumentParameters)
        {
            // verify the required parameter 'saveDocumentParameters' is set
            if (saveDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveDocumentParameters' when calling PDFApi->SaveDocument");

            var localVarPath = "/api/pdf/SaveDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveDocumentParameters != null && saveDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveDocumentResponse)));
        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSaveDocumentResponse</returns>
        public async System.Threading.Tasks.Task<PDFSaveDocumentResponse> SaveDocumentAsync (PDFSaveDocumentParameters saveDocumentParameters)
        {
             ApiResponse<PDFSaveDocumentResponse> localVarResponse = await SaveDocumentAsyncWithHttpInfo(saveDocumentParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Saves a previously uploaded document as PDF. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="saveDocumentParameters">A PDFSaveDocumentParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSaveDocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSaveDocumentResponse>> SaveDocumentAsyncWithHttpInfo (PDFSaveDocumentParameters saveDocumentParameters)
        {
            // verify the required parameter 'saveDocumentParameters' is set
            if (saveDocumentParameters == null)
                throw new ApiException(400, "Missing required parameter 'saveDocumentParameters' when calling PDFApi->SaveDocument");

            var localVarPath = "/api/pdf/SaveDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (saveDocumentParameters != null && saveDocumentParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(saveDocumentParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = saveDocumentParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SaveDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSaveDocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSaveDocumentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSaveDocumentResponse)));
        }

        /// <summary>
        /// Sets information to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSetInfoResponse</returns>
        public PDFSetInfoResponse SetInfo (PDFSetInfoParameters setInfoParameters)
        {
             ApiResponse<PDFSetInfoResponse> localVarResponse = SetInfoWithHttpInfo(setInfoParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets information to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSetInfoResponse</returns>
        public ApiResponse< PDFSetInfoResponse > SetInfoWithHttpInfo (PDFSetInfoParameters setInfoParameters)
        {
            // verify the required parameter 'setInfoParameters' is set
            if (setInfoParameters == null)
                throw new ApiException(400, "Missing required parameter 'setInfoParameters' when calling PDFApi->SetInfo");

            var localVarPath = "/api/pdf/SetInfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (setInfoParameters != null && setInfoParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(setInfoParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = setInfoParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSetInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSetInfoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSetInfoResponse)));
        }

        /// <summary>
        /// Sets information to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSetInfoResponse</returns>
        public async System.Threading.Tasks.Task<PDFSetInfoResponse> SetInfoAsync (PDFSetInfoParameters setInfoParameters)
        {
             ApiResponse<PDFSetInfoResponse> localVarResponse = await SetInfoAsyncWithHttpInfo(setInfoParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets information to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInfoParameters">A PDFSetInfoParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSetInfoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSetInfoResponse>> SetInfoAsyncWithHttpInfo (PDFSetInfoParameters setInfoParameters)
        {
            // verify the required parameter 'setInfoParameters' is set
            if (setInfoParameters == null)
                throw new ApiException(400, "Missing required parameter 'setInfoParameters' when calling PDFApi->SetInfo");

            var localVarPath = "/api/pdf/SetInfo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (setInfoParameters != null && setInfoParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(setInfoParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = setInfoParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSetInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSetInfoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSetInfoResponse)));
        }

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFSetInitialViewResponse</returns>
        public PDFSetInitialViewResponse SetInitialView (PDFSetInitialViewParameters setInitialViewParameters = null)
        {
             ApiResponse<PDFSetInitialViewResponse> localVarResponse = SetInitialViewWithHttpInfo(setInitialViewParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFSetInitialViewResponse</returns>
        public ApiResponse< PDFSetInitialViewResponse > SetInitialViewWithHttpInfo (PDFSetInitialViewParameters setInitialViewParameters = null)
        {

            var localVarPath = "/api/pdf/SetInitialView";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (setInitialViewParameters != null && setInitialViewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(setInitialViewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = setInitialViewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetInitialView", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSetInitialViewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSetInitialViewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSetInitialViewResponse)));
        }

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFSetInitialViewResponse</returns>
        public async System.Threading.Tasks.Task<PDFSetInitialViewResponse> SetInitialViewAsync (PDFSetInitialViewParameters setInitialViewParameters = null)
        {
             ApiResponse<PDFSetInitialViewResponse> localVarResponse = await SetInitialViewAsyncWithHttpInfo(setInitialViewParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets various document level initial view options to a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setInitialViewParameters">A PDFsetInitialViewParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFSetInitialViewResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSetInitialViewResponse>> SetInitialViewAsyncWithHttpInfo (PDFSetInitialViewParameters setInitialViewParameters = null)
        {

            var localVarPath = "/api/pdf/SetInitialView";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (setInitialViewParameters != null && setInitialViewParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(setInitialViewParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = setInitialViewParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetInitialView", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSetInitialViewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSetInitialViewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSetInitialViewResponse)));
        }

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>PDFSetPageBoxResponse</returns>
        public PDFSetPageBoxResponse SetPageBox (PDFSetPageBoxParameters setPageBoxParameters = null)
        {
             ApiResponse<PDFSetPageBoxResponse> localVarResponse = SetPageBoxWithHttpInfo(setPageBoxParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>ApiResponse of PDFSetPageBoxResponse</returns>
        public ApiResponse< PDFSetPageBoxResponse > SetPageBoxWithHttpInfo (PDFSetPageBoxParameters setPageBoxParameters = null)
        {

            var localVarPath = "/api/pdf/SetPageBox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (setPageBoxParameters != null && setPageBoxParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(setPageBoxParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = setPageBoxParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetPageBox", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSetPageBoxResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSetPageBoxResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSetPageBoxResponse)));
        }

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of PDFSetPageBoxResponse</returns>
        public async System.Threading.Tasks.Task<PDFSetPageBoxResponse> SetPageBoxAsync (PDFSetPageBoxParameters setPageBoxParameters = null)
        {
             ApiResponse<PDFSetPageBoxResponse> localVarResponse = await SetPageBoxAsyncWithHttpInfo(setPageBoxParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sets pagebox to a page range from previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPageBoxParameters">A PDFSetPageBoxParameters object specifying the parameters of the action. (optional)</param>
        /// <returns>Task of ApiResponse (PDFSetPageBoxResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSetPageBoxResponse>> SetPageBoxAsyncWithHttpInfo (PDFSetPageBoxParameters setPageBoxParameters = null)
        {

            var localVarPath = "/api/pdf/SetPageBox";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (setPageBoxParameters != null && setPageBoxParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(setPageBoxParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = setPageBoxParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetPageBox", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSetPageBoxResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSetPageBoxResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSetPageBoxResponse)));
        }

        /// <summary>
        /// Splits a previously uploaded document into new ones. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSplitResponse</returns>
        public PDFSplitResponse Split (PDFSplitParameters splitParameters)
        {
             ApiResponse<PDFSplitResponse> localVarResponse = SplitWithHttpInfo(splitParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Splits a previously uploaded document into new ones. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSplitResponse</returns>
        public ApiResponse< PDFSplitResponse > SplitWithHttpInfo (PDFSplitParameters splitParameters)
        {
            // verify the required parameter 'splitParameters' is set
            if (splitParameters == null)
                throw new ApiException(400, "Missing required parameter 'splitParameters' when calling PDFApi->Split");

            var localVarPath = "/api/pdf/Split";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (splitParameters != null && splitParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(splitParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = splitParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Split", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSplitResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSplitResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSplitResponse)));
        }

        /// <summary>
        /// Splits a previously uploaded document into new ones. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSplitResponse</returns>
        public async System.Threading.Tasks.Task<PDFSplitResponse> SplitAsync (PDFSplitParameters splitParameters)
        {
             ApiResponse<PDFSplitResponse> localVarResponse = await SplitAsyncWithHttpInfo(splitParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Splits a previously uploaded document into new ones. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="splitParameters">A PDFSplitParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSplitResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSplitResponse>> SplitAsyncWithHttpInfo (PDFSplitParameters splitParameters)
        {
            // verify the required parameter 'splitParameters' is set
            if (splitParameters == null)
                throw new ApiException(400, "Missing required parameter 'splitParameters' when calling PDFApi->Split");

            var localVarPath = "/api/pdf/Split";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (splitParameters != null && splitParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(splitParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = splitParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Split", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSplitResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSplitResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSplitResponse)));
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>PDFSwapPagesResponse</returns>
        public PDFSwapPagesResponse SwapPages (PDFSwapPagesParameters swapPagesParameters)
        {
             ApiResponse<PDFSwapPagesResponse> localVarResponse = SwapPagesWithHttpInfo(swapPagesParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFSwapPagesResponse</returns>
        public ApiResponse< PDFSwapPagesResponse > SwapPagesWithHttpInfo (PDFSwapPagesParameters swapPagesParameters)
        {
            // verify the required parameter 'swapPagesParameters' is set
            if (swapPagesParameters == null)
                throw new ApiException(400, "Missing required parameter 'swapPagesParameters' when calling PDFApi->SwapPages");

            var localVarPath = "/api/pdf/SwapPages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (swapPagesParameters != null && swapPagesParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(swapPagesParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = swapPagesParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SwapPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSwapPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSwapPagesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSwapPagesResponse)));
        }

        /// <summary>
        /// Swaps two pages from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFSwapPagesResponse</returns>
        public async System.Threading.Tasks.Task<PDFSwapPagesResponse> SwapPagesAsync (PDFSwapPagesParameters swapPagesParameters)
        {
             ApiResponse<PDFSwapPagesResponse> localVarResponse = await SwapPagesAsyncWithHttpInfo(swapPagesParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Swaps two pages from a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="swapPagesParameters">A PDFSwapPagesParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFSwapPagesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFSwapPagesResponse>> SwapPagesAsyncWithHttpInfo (PDFSwapPagesParameters swapPagesParameters)
        {
            // verify the required parameter 'swapPagesParameters' is set
            if (swapPagesParameters == null)
                throw new ApiException(400, "Missing required parameter 'swapPagesParameters' when calling PDFApi->SwapPages");

            var localVarPath = "/api/pdf/SwapPages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (swapPagesParameters != null && swapPagesParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(swapPagesParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = swapPagesParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SwapPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFSwapPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFSwapPagesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFSwapPagesResponse)));
        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>PDFUnprotectResponse</returns>
        public PDFUnprotectResponse Unprotect (PDFUnprotectParameters unprotectParameters)
        {
             ApiResponse<PDFUnprotectResponse> localVarResponse = UnprotectWithHttpInfo(unprotectParameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>ApiResponse of PDFUnprotectResponse</returns>
        public ApiResponse< PDFUnprotectResponse > UnprotectWithHttpInfo (PDFUnprotectParameters unprotectParameters)
        {
            // verify the required parameter 'unprotectParameters' is set
            if (unprotectParameters == null)
                throw new ApiException(400, "Missing required parameter 'unprotectParameters' when calling PDFApi->Unprotect");

            var localVarPath = "/api/pdf/Unprotect";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (unprotectParameters != null && unprotectParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(unprotectParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = unprotectParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Unprotect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFUnprotectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFUnprotectResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFUnprotectResponse)));
        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of PDFUnprotectResponse</returns>
        public async System.Threading.Tasks.Task<PDFUnprotectResponse> UnprotectAsync (PDFUnprotectParameters unprotectParameters)
        {
             ApiResponse<PDFUnprotectResponse> localVarResponse = await UnprotectAsyncWithHttpInfo(unprotectParameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unprotects a previously uploaded document. 
        /// </summary>
        /// <exception cref="PassportPDF.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="unprotectParameters">A PDFUnprotectParameters object specifying the parameters of the action.</param>
        /// <returns>Task of ApiResponse (PDFUnprotectResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PDFUnprotectResponse>> UnprotectAsyncWithHttpInfo (PDFUnprotectParameters unprotectParameters)
        {
            // verify the required parameter 'unprotectParameters' is set
            if (unprotectParameters == null)
                throw new ApiException(400, "Missing required parameter 'unprotectParameters' when calling PDFApi->Unprotect");

            var localVarPath = "/api/pdf/Unprotect";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (unprotectParameters != null && unprotectParameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(unprotectParameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = unprotectParameters; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Unprotect", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PDFUnprotectResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PDFUnprotectResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PDFUnprotectResponse)));
        }

    }
}

using System;
using IronPdf;

namespace pdfGenerator_MoM
{
    public class PdfCreator
    {
        public string OutPutDir { get; set; }

        public PdfCreator()
        {
            OutPutDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        /// <summary>
        /// Takes a raw string from a message, manipulates it and prints out a pdf to the OutPutDir, if none is chosen it defaults to desktop
        /// </summary>
        /// <param name="rawInput">This is the raw string from the message, do not edit it</param>
        public void Create(string rawInput)
        {
            string[] splitString = rawInput.Split(' ');


            // good luck reading this.
            var html = GenerateHtml(splitString[0], splitString[1], splitString[2], splitString[3],
                splitString[4], splitString[5], splitString[6], splitString[7],
                splitString[8], splitString[9], splitString[10], splitString[11], splitString[12], splitString[13]);

            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            Renderer.PrintOptions.CreatePdfFormsFromHtml = true;
            Renderer.RenderHtmlAsPdf(html).SaveAs(OutPutDir);
        }

        private string GenerateHtml(string name, string lastName,  string license, string gender, string color, 
            string brand, string model, string doors, string fuel, string type, string price, string animals, 
            string pickupLocation, string dropOffLocation)
        {
            var formHtml = $@"<html>
                                 <body>
                                     <h1 align='center'>Faraday Contract</h1>
                                     <h2> Name </h2> <p>{name} { lastName} License nr: {license}, {gender}</p>

                                     <h2> car </h2> <p>{brand} {model} {type} { color} {doors} doors, allowed animals: {animals} fuel: {fuel} price: {price}</ p >
                                     <h2> Location </h2> <p> is to be picked up at {pickupLocation} and dropped off at {dropOffLocation}  </p>

                                </ body >
                            </html>";

            return formHtml;
        }
    }
}
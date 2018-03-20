﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Note.Examples.CSharp.Pages
{
    class PageClone
    {
        public static void Run()
        {
            //ExStart: PageClone
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Pages();

            // Load OneNote document
            Document document = new Document(dataDir + "Aspose.one", new LoadOptions { LoadHistory = true });

            //Clone into new document without history
            var cloned = new Document();
            cloned.AppendChild(document.FirstChild.Clone());

            //Clone into new document with history
            cloned = new Document();
            cloned.AppendChild(document.FirstChild.Clone(true));
            //ExEnd: PageClone
        }
    }
}

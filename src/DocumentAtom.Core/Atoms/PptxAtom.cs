﻿namespace DocumentAtom.Core.Atoms
{
    using System.Data;
    using System.Text;
    using DocumentAtom.Core;
    using DocumentAtom.Core.Enums;
    using DocumentAtom.Core.Helpers;
    using SerializableDataTables;

    /// <summary>
    /// A pptx atom is a self-contained unit of information from a Microsoft PowerPoint .pptx presentation.
    /// </summary>
    public class PptxAtom : AtomBase<MarkdownAtom>
    {
        #region Public-Members

        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; set; } = null;

        /// <summary>
        /// Subtitle.
        /// </summary>
        public string Subtitle { get; set; } = null;

        /// <summary>
        /// Text content.
        /// </summary>
        public string Text { get; set; } = null;

        /// <summary>
        /// Unordered list elements.
        /// </summary>
        public List<string> UnorderedList { get; set; } = null;

        /// <summary>
        /// Ordered list elements.
        /// </summary>
        public List<string> OrderedList { get; set; } = null;

        /// <summary>
        /// Data table.
        /// </summary>
        public SerializableDataTable Table { get; set; } = null;

        /// <summary>
        /// Binary data.
        /// </summary>
        public byte[] Binary { get; set; } = null;

        #endregion

        #region Private-Members

        #endregion

        #region Constructors-and-Factories

        /// <summary>
        /// A pptx atom is a self-contained unit of information from a Microsoft PowerPoint .pptx presentation.
        /// </summary>
        public PptxAtom()
        {

        }

        #endregion

        #region Public-Methods

        #endregion

        #region Private-Methods

        #endregion
    }
}

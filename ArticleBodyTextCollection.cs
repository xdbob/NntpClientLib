#region Usings

using System.Collections.Generic;

#endregion

namespace NntpClientLib
{
    public class ArticleBodyTextCollection : List<string>, IArticleBodyProcessor
    {
        #region IArticleBodyProcessor Members

        /// <summary>
        /// Adds the text.
        /// </summary>
        /// <param name="line">The line.</param>
        public void AddText(string line)
        {
            Add(line);
        }

        #endregion
    }
}


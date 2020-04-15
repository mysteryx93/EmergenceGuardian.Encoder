﻿using System;

namespace HanumanInstitute.Encoder
{
    /// <summary>
    /// Returns file information parsed from X264.
    /// </summary>
    public interface IFileInfoParserX264
    {
        /// <summary>
        /// Returns the frame count of input file.
        /// </summary>
        long FrameCount { get; }
    }
}
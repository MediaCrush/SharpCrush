﻿namespace SharpCrush4.Results
{
    /// <summary>
    /// Status codes from the <see cref="SharpCrush.GetFileStatus(string)"/> routine.
    /// </summary>
    public enum GetFileStatusResult
    {
        // -- 200 Status results -- //

        /// <summary>
        /// The file has been processed.
        /// </summary>
        Done = 200,

        /// <summary>
        /// The file is being processed or in the processing queue.
        /// </summary>
        Processing,

        /// <summary>
        /// The processing step finished early with an abnormal return code.
        /// </summary>
        Error,

        /// <summary>
        /// The file took too long to process.
        /// </summary>
        TimedOut,


        // -- 404 status results -- //

        /// <summary>
        /// There is no file with that hash.
        /// </summary>
        FileNotFound = 404
    }
}

using System;

public static class LogAnalysis
{
    /// <summary>
    /// Takes in some string delimiter and returns the substring after the delimiter.
    /// </summary>
    /// <param name="logLine">The information log line.</param>
    /// <param name="delimiter">The delimiter value.</param>
    /// <returns>The substring after the delimiter.</returns>
    public static string SubstringAfter(this string logLine, string delimiter)
    {
        return logLine.Split(delimiter)[1];
    }

    /// <summary>
    /// Takes in two string delimiters, and returns the substring that lies between the two delimiters. 
    /// </summary>
    /// <param name="logLine">The information log line.</param>
    /// <param name="prefix">The beginning delimiter.</param>
    /// <param name="suffix">The ending delimiter.</param>
    /// <returns>The value between the prefix and the suffix delimiters.</returns>
    public static string SubstringBetween(this string logLine, string prefix, string suffix)
    {
        return logLine.Split(prefix)[1].Split(suffix)[0];
    }

    /// <summary>
    /// Returns the message contained in a logLine.
    /// </summary>
    /// <param name="logLine">The information log line.</param>
    /// <returns>The message contained in a log line.</returns>
    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ");
    }

    /// <summary>
    /// Returns the logLine level of a logLine.
    /// </summary>
    /// <param name="logLine">The information log line.</param>
    /// <returns>The level of a log contained in a log line.</returns>
    public static string LogLevel(this string logLine)
    {
        return logLine.SubstringBetween("[", "]");
    }
}
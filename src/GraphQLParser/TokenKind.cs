namespace GraphQLParser;

/// <summary>
/// GraphQL token kind.
/// </summary>
public enum TokenKind
{
    /// <summary>
    /// End of file.
    /// </summary>
    EOF = 1,

    /// <summary>
    /// !
    /// </summary>
    BANG = 2,

    /// <summary>
    /// $
    /// </summary>
    DOLLAR = 3,

    /// <summary>
    /// (
    /// </summary>
    PAREN_L = 4,

    /// <summary>
    /// )
    /// </summary>
    PAREN_R = 5,

    /// <summary>
    /// ...
    /// </summary>
    SPREAD = 6,

    /// <summary>
    /// :
    /// </summary>
    COLON = 7,

    /// <summary>
    /// =
    /// </summary>
    EQUALS = 8,

    /// <summary>
    /// @
    /// </summary>
    AT = 9,

    /// <summary>
    /// [
    /// </summary>
    BRACKET_L = 10,

    /// <summary>
    /// ]
    /// </summary>
    BRACKET_R = 11,

    /// <summary>
    /// {
    /// </summary>
    BRACE_L = 12,

    /// <summary>
    /// |
    /// </summary>
    PIPE = 13,

    /// <summary>
    /// }
    /// </summary>
    BRACE_R = 14,

    /// <summary>
    /// Named thing inside GraphQL document: operations, fields, arguments, types, directives, fragments, and variables.
    /// <br/>
    /// All names must follow the same grammatical form: [_A-Za-z][_0-9A-Za-z]*
    /// </summary>
    NAME = 15,

#pragma warning disable CA1720 // Identifiers should not contain type names

    /// <summary>
    /// An integer number is specified without a decimal point or exponent (ex. 1).
    /// </summary>
    INT = 16,

    /// <summary>
    /// A Float number includes either a decimal point (ex. 1.0) or an exponent (ex. 1e50) or both (ex. 6.0221413e23).
    /// </summary>
    FLOAT = 17,

    /// <summary>
    /// A string value, encoded as either a 'string' or 'block string'
    /// <br/><br/>
    /// Strings are sequences of characters wrapped in double‐quotes ("). (ex. "Hello World").
    /// White space and other otherwise‐ignored characters are significant within a string value.
    /// <br/><br/>
    /// Block strings are sequences of characters wrapped in triple‐quotes ("""). White space, line terminators,
    /// quote, and backslash characters may all be used unescaped to enable verbatim text.
    /// Since block strings represent freeform text often used in indented positions, the string value semantics
    /// of a block string excludes uniform indentation and blank initial and trailing lines.
    /// Triple-quotes (""") may be escaped as \""" within the block string. No other escape sequences may be used
    /// within a block string.
    /// </summary>
    /// <remarks>
    /// Within a block string, line termination sequences (LF, CR, or CRLF) are always replaced with a line-feed (LF) character.
    /// </remarks>
    STRING = 18,

#pragma warning restore CA1720

    /// <summary>
    /// GraphQL source documents may contain single‐line comments, starting with the # marker.
    /// A comment can contain any Unicode code point except LineTerminator so a comment always
    /// consists of all code points starting with the # character up to but not including the line terminator.
    /// Comments behave like white space and may appear after any token, or before a line terminator,
    /// and have no significance to the semantic meaning of a GraphQL Document.
    /// </summary>
    COMMENT = 19,

    /// <summary>
    /// Unknown token. Something went wrong.
    /// </summary>
    UNKNOWN = 20,

    /// <summary>
    /// &amp;
    /// </summary>
    AMPERSAND = 21,
}

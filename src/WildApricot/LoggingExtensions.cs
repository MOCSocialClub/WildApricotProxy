/*
 * LoggingExtensions.cs
 *     Created: 2024-10-22T10:25:47-04:00
 *    Modified: 2024-10-22T10:25:47-04:00
 *      Author: Dr. David Gerard <david@mymoc.social>
 *   Copyright: © 2022 - 2024 © 2024 Dr. David Gerard, All Rights Reserved, All Rights Reserved
 *     License: MIT (https://opensource.org/licenses/MIT)
 */

namespace WildApricot;

using Microsoft.Extensions.Logging;

public static partial class LoggingExtensions
{
    [SuppressMessage(
        "Style",
        "IDE0060:Remove unused parameter",
        Justification = "Extension method"
    )]
    [SuppressMessage(
        "Style",
        "RCS1163:Remove unused parameter",
        Justification = "Extension method"
    )]
    [LoggerMessage(
        EventId = 1,
        Level = LogLevel.Information,
        Message = "Proxying request to Wild Apricot API {RequestPath}"
    )]
    public static partial void ProxyingRequest(this ILogger logger, string requestPath);
}

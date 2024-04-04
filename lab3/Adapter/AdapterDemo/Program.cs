
using AdapterClassLib;

ILogger logger = new Logger();
logger.Log("Hello, World!");
logger.Error("This is an error message.");
logger.Warn("This is a warning message.");

logger = new FileWriterToLoggerAdapter("log.txt");
logger.Log("Hello, World!");
logger.Error("This is an error message.");
logger.Warn("This is a warning message.");

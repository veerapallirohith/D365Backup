ECHO Starting MR Services
net start "Management Reporter 2012 Process Service"

ECHO Starting DynamicsAxBatch
net start "Microsoft Dynamics 365 Unified Operations: Batch Management Service"

ECHO Starting Microsoft.Dynamics.AX.Framework.Tools.DMF.SSISHelperService
net start "Microsoft Dynamics 365 Unified Operations: Data Import Export Framework Service"

ECHO Starting W3SVC
net start "World Wide Web Publishing Service"

ECHO All Services are Started
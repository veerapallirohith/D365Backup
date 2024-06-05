ECHO Stopping MR Services
net stop "Management Reporter 2012 Process Service"

ECHO Stopping DynamicsAxBatch
net stop "Microsoft Dynamics 365 Unified Operations: Batch Management Service"

ECHO Stopping Microsoft.Dynamics.AX.Framework.Tools.DMF.SSISHelperService
net stop "Microsoft Dynamics 365 Unified Operations: Data Import Export Framework Service"

ECHO Stopping W3SVC
net stop "World Wide Web Publishing Service"

ECHO All Services are stopped
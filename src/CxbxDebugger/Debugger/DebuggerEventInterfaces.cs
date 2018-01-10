﻿// Written by x1nixmzeng for the Cxbx-Reloaded project
//

using System;

namespace CxbxDebugger
{
    public interface IDebuggerGeneralEvents
    {
        void OnDebugStart();
        void OnDebugEnd();
    }

    public interface IDebuggerProcessEvents
    {
        void OnProcessCreate(DebuggerProcess Process);
        void OnProcessExit(DebuggerProcess Process, uint ExitCode);
    }

    public interface IDebuggerThreadEvents
    {
        void OnThreadCreate(DebuggerThread Thread);
        void OnThreadExit(DebuggerThread Thread, uint ExitCode);
    }

    public interface IDebuggerModuleEvents
    {
        void OnModuleLoaded(DebuggerModule Module);
        void OnModuleUnloaded(DebuggerModule Module);
    }

    public interface IDebuggerOutputEvents
    {
        void OnDebugOutput(string Message);
    }

    public interface IDebuggerExceptionEvents
    {
        bool OnAccessViolation(DebuggerThread Thread, uint Code, IntPtr Address);
    }

    public interface IDebuggerFileEvents
    {
        void OnFileOpened(DebuggerMessages.FileOpened Info);
        void OnFileRead(DebuggerMessages.FileRead Info);
        void OnFileClosed(DebuggerMessages.FileClosed Info);
    }
}

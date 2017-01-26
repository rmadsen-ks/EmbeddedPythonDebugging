# EmbeddedPythonDebugging
Project demonstrating issues related to Python.NET debugging.

To try it out:

1. Build the EmbeddedPythonDebugging project

2. Set a breakpoint inside testmodule.py

3. See that debugging can be done when starting the python Debug project
  - run the bootstrap.py file from the Debug project
  - notice that the breakpoint is hit
  
4. Show that debugging cannot be done when attaching to a running python project
  - run ```EmbeddedPythonDebugging.exe testmodule``` from the Debug folder
  - notice that the breakpoint is not hit

Possible solutions: 
- import ptvsd and use remote debugging. I had some but limited success with this.
- attach to process while time.sleep() is called. I had some but limited success with this. Also not able to reliably reproduce
- Use ptsvd + Visual Studio Code. Again some but limited success. I was able to attach ptvsd remote debugger, but not set break points.
- PyDev - no succes with my real project, did not try on this demo version.
- PyCharm - no succes with my real project, did not try on this demo version.

import clr
import sys
import System.IO
sys.path.append(System.IO.Directory.GetCurrentDirectory())
import EmbeddedPythonDebugging
EmbeddedPythonDebugging.Program.Main(["testmodule"])

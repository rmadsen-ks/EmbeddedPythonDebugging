# Add a breakpoint in the below while loop.
# For the bootstrap.py application it should break at the point
# In that case its Python calling C#, calling Python.
# When debugging from an embedded implementation, in my experience it does not break.
# in that case it C# calling into Python.

while True:
    print "Hello world.."
    print raw_input("click")
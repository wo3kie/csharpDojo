# export MONO_TRACE_LISTENER=Console.Error

CSC=mcs
SRCS=$(shell ls *.cs)
APPS=$(subst .cs,,$(SRCS))
EXES=$(subst .cs,.exe,$(SRCS))
CSCFLAGS=-d:DEBUG -debug

all: $(EXES)

%.exe: %.cs
	$(CSC) $(CSCFLAGS) $<

	@echo '#!/bin/bash\n\nmono ./$@ $$@\n' > $(subst .exe,,$@)
	@chmod 744 $(subst .exe,,$@)

clean:
	rm -rf $(EXES) $(APPS) *.mdb


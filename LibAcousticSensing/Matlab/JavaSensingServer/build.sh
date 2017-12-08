#!/bin/bash

# 2017/03/30: simple script to build the classes file of matSock
# NOTE: matlab needs to be restarted to use the new built classes
# NOTE2: need to use the version compatible to matlab, check "java -version" and matlab's "version -java"

javac -source 1.7 -target 1.7 -d bin $(find . -name '*.java')

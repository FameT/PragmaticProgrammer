@echo off
echo Setting CLASSPATH...
SET CLASSPATH=.;D:\Tools\ANTLR\antlr-4.7-complete.jar;%CLASSPATH%
echo Starting...
java org.antlr.v4.Tool .\Test\Test.g4 -o .\Test
pause
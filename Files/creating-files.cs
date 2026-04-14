#!/usr/bin/env dotnet
using System.IO;

string text = "Hello World";
File.WriteAllText("filename.txt", text);

string readText = File.ReadAllText("filename.txt");

Console.WriteLine(readText);
using System;
using System.Collections.Generic;
using System.IO;

public class DictionaryService
{

    private String basePassword = "Password";

	public DictionaryService()
	{

	}

    public void CreateDictionary()
    {
        List<String> DictionaryOutput = null;
        StreamWriter Stream;
        
        Stream = File.CreateText(@"E:\Andrew Projects\ApiHack\Dictionary\Dictionary.txt");
        Stream.WriteLine(basePassword);

        for (int i = 0; i < 20; i++)
        {
            DictionaryOutput.Add("Password");
        }

        Stream.WriteLine(DictionaryOutput);
        Stream.Close();
        Console.WriteLine("Created File!");

    }

    LetterOption P = new LetterOption('P', new List<char> {'','',''});



}

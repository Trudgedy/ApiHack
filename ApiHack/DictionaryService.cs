using System;
using System.IO;

public class DictionaryService
{

    private String basePassword;

	public DictionaryService()
	{

	}

    public void CreateDictionary()
    {
        StreamWriter Stream;
        
        Stream = File.CreateText(@"E:\Andrew Projects\ApiHack\Dictionary\Dictionary.txt");
        Stream.WriteLine(basePassword);


        Stream.Close();
        Console.WriteLine("Created File!");

    }

}

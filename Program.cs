using System;
using System.Collections.Generic;

namespace encrypt
{
  class Program
  {
    static void Main(string[] args)
    {
      // string alphabet = "abcdefghijklmnopqrstuvwxyz";
      // for (int i = 0; i < alphabet.Length; i++)
      // {
      //   char letter = alphabet[i];
      // }
      Dictionary<char, Code> codes = new Dictionary<char, Code>() {
       {'A', new Code('a', 097, 01100001)},
       {'B', new Code('b', 098, 01100010)},
       {'C', new Code('c', 099, 01100011)},
       {'D', new Code('d', 100, 01100100)},
       {'E', new Code('e', 101, 01100101)},
       {'F', new Code('f', 102, 01100110)},
       {'G', new Code('g', 103, 01100111)},
       {'H', new Code('h', 104, 01101000)},
       {'I', new Code('i', 105, 01101001)},
       {'J', new Code('j', 106, 01101010)},
       {'K', new Code('k', 107, 01101011)},
       {'L', new Code('l', 108, 01101100)},
       {'M', new Code('m', 109, 01101101)},
       {'N', new Code('n', 110, 01101110)},
       {'O', new Code('o', 111, 01101111)},
       {'P', new Code('p', 112, 01110000)},
       {'Q', new Code('q', 113, 01110001)},
       {'R', new Code('r', 114, 01110010)},
       {'S', new Code('s', 115, 01110011)},
       {'T', new Code('t', 116, 01110100)},
       {'U', new Code('u', 117, 01110101)},
       {'V', new Code('v', 118, 01110110)},
       {'W', new Code('w', 119, 01110111)},
       {'X', new Code('x', 120, 01111000)},
       {'Y', new Code('y', 121, 01111001)},
       {'Z', new Code('z', 122, 01111010)}
      };
      System.Console.WriteLine("What do you want to encrypt?");
      string input = Console.ReadLine();
      string caps = input.ToUpper();
      char[] encryptable = caps.ToCharArray();
      foreach (char letter in encryptable)
      {
        // System.Console.WriteLine(letter);
        // System.Console.WriteLine(codes.ContainsKey(letter));
        var value = codes[letter];
        System.Console.WriteLine(value.Binary.ToString());

      }
      // foreach (KeyValuePair<char, Code> code in codes)
      // {
      //   System.Console.WriteLine($"{code.Key} -  {code.Value.Letter}, {code.Value.ASCII}, {code.Value.Binary}");
      // }
    }
  }
  class Code
  {
    public int ASCII { get; set; }
    public int Binary { get; set; }
    public char Letter { get; set; }

    public Code(char letter, int ascii, int binary)
    {
      Letter = letter;
      ASCII = ascii;
      Binary = binary;
    }
  }
}

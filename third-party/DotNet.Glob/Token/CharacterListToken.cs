﻿// This file isn't generated, but this comment is necessary to exclude it from StyleCop analysis.
// <auto-generated/>

namespace DotNet.Globbing.Token
{
    internal class CharacterListToken : INegatableToken
    {
        public CharacterListToken(char[] characters, bool isNegated)
        {
            Characters = characters;              
            IsNegated = isNegated;
        }

        public bool IsNegated { get; set; }      

        public char[] Characters { get; }       

        public void Accept(IGlobTokenVisitor Visitor)
        {
            Visitor.Visit(this);
        }
    }
}